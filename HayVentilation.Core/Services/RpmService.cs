using HayVentilation.Core.Models;
using HayVentilation.Core.Models.DB;
using Microsoft.EntityFrameworkCore;

namespace HayVentilation.Core.Services; 

public class RpmService : ServiceBaseDb{
    public RpmService(HayContext ctx) : base(ctx) { }

    public async Task<Rpm> GetCurrentDatabaseValueAsync() {
        var select = await Ctx.RPMs.FirstOrDefaultAsync();
        if (select == null) {
            select = new Rpm { RPM = -1 };
        }
        return select;
    }
}