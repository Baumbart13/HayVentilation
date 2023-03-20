using System.Collections.Immutable;
using HayVentilation.Core.Models;
using HayVentilation.Core.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace HayVentilation.Core.Services;

public class ScanService : ServiceBaseDb {
    public ScanService(HayContext ctx) : base(ctx) { }

    public async Task<IEnumerable<Scan>> GetCurrentDatabaseValuesAsync() {
        var select = await Ctx.Scans.ToListAsync();
        return select;
    }
    
    public IEnumerable<Scan> GetCurrentDatabaseValues() {
        var select = (from scan
                in Ctx.Scans
                where scan.Timestamp == DateTime.Now
                select scan)
            .ToImmutableList() ?? ImmutableList<Scan>.Empty;
        return select;
    }
}