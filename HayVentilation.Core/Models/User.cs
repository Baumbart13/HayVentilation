namespace HayVentilation.Core.Models; 

public class User : IHayModel {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}