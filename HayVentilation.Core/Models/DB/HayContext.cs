using Microsoft.EntityFrameworkCore;

namespace HayVentilation.Core.Models.DB;

public class HayContext : DbContext {
    public DbSet<Rpm> RPMs { get; set; }
    public DbSet<Scan> Scans { get; set; }
}