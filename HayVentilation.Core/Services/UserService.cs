using HayVentilation.Core.Models.DB;

namespace HayVentilation.Core.Services; 

public class UserService : ServiceBaseDb{
    protected UserService(HayContext ctx) : base(ctx) { }
}