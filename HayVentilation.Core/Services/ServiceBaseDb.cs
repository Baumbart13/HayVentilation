using HayVentilation.Core.Models;
using HayVentilation.Core.Models.DB;

namespace HayVentilation.Core.Services;

public class ServiceBaseDb {
    protected readonly HayContext Ctx;

    protected ServiceBaseDb(HayContext ctx) {
        Ctx = ctx;
    }
}