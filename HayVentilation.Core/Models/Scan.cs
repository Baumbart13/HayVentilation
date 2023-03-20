namespace HayVentilation.Core.Models; 

public class Scan : IHayModel {
    public DateTime Timestamp { get; set; }
    public float Temperature { get; set; }
    public float Humidity { get; set; }
}