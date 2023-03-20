using System.Collections;
using HayVentilation.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace HayVentilation.Core.Services; 

public class ConfigService {
    public readonly Configuration Config;

    public ConfigService(Configuration config) {
        Config = config;
    }

    public IList<Interval> GetAllValues() {
        var select = (from i in Config._intervals
            orderby i.Day
            select i)
            .Take(14)
            .ToList();
        return select;
    }

    public IEnumerable<Interval> GetOfDay(DayOfWeek day) {
        var select = (from i in Config._intervals
            where i.Day == day
            select i);
        return select;
    }

    public IEnumerable<Interval> GetOfDay(params DayOfWeek[] day) {
        var intervals = new List<Interval>();
        foreach (var d in day) {
            intervals.AddRange(from i in Config._intervals
                where i.Day == d
                select i);
        }

        return intervals.ToArray();
    }

    public void CreateOrUpdateInterval(Interval interval) {
        for (var i = 0; i < Config._intervals.Count; ++i) {
            if (Config._intervals[i].Id == interval.Id) {
                Config._intervals[i] = interval;
                return;
            }
        }
    }
}