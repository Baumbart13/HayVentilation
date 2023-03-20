using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Text.Json.Serialization;
using HayVentilation.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HayVentilation.Core;

public class Configuration {
    internal IList<Interval> _intervals;
    internal RunningMode _runningMode;
    internal IDictionary<string, float> _humidities;
    private const string ConfigFile = "./config.json";
    private static JsonSerializer Serializer = JsonSerializer.CreateDefault();

    public IList<Interval> Intervals => _intervals;
    public RunningMode RunningMode => _runningMode;
    public IDictionary<string, float> Humidities => _humidities;

    private static Configuration _config;

    public static Configuration Instance {
        get {
            if (_config == null) {
                _config = LoadConfig(ConfigFile);
            }

            if (!Serializer.Converters.Contains(new StringEnumConverter())) {
                Serializer.Converters.Add(new StringEnumConverter());
            }

            return _config;
        }
    }

    private Configuration() {
        _intervals = new List<Interval>();
        _runningMode = RunningMode.Off;
        _humidities = new Dictionary<string, float> {
            { "sehr feucht", .8f },
            { "viel feucht", .76f },
            { "feucht", .75f },
            { "erhöhte feuchte", .68f },
            { "mittel", .64f },
            { "geringe feuchte", .6f },
            { "fast trocken", .55f },
            { "sehr trocken", .50f },
            { "nachtrocknen", .44f }
        };
    }

    public void Save() {
        Save(ConfigFile);
    }

    public void Save(string file) {
        if (!Directory.Exists(file[..file.LastIndexOf('/')])) {
            Directory.CreateDirectory(file[..file.LastIndexOf('/')]);
        }

        StreamWriter writer;
        if (File.Exists(file)) {
            writer = new StreamWriter(File.OpenWrite(file));
        } else {
            writer = new StreamWriter(File.Create(file));
        }
        
        Serializer.Serialize(writer, this);
        writer.Flush();
        writer.Close();
        writer.Dispose();
    }

    public static Configuration LoadConfig() {
        return LoadConfig(ConfigFile);
    }

    public static Configuration LoadConfig(string file) {
        Configuration? config;
        if (!File.Exists(file)) {
            config = new Configuration();
            config.Save(file);
            return config;
        }

        using var reader = new StreamReader(File.OpenRead(file));
        config = JsonConvert.DeserializeObject<Configuration>(reader.ReadToEnd());
        if (config != null) return config;
        Console.Write("WARNING: Couldn't load Configuration. Continuing with default");
        return new Configuration();
    }
}