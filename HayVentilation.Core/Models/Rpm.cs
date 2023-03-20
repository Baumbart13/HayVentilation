namespace HayVentilation.Core.Models;

public class Rpm : IHayModel {
    public float RPM { get; set; }

    public float RPS {
        get => RPM / 60;
        set => RPM = value / 60;
    }
}