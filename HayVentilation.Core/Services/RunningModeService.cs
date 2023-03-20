using HayVentilation.Core.Models;
using HayVentilation.Core.Models.DB;

namespace HayVentilation.Core.Services; 

public class RunningModeService : ServiceBaseDb{
    protected RunningModeService(HayContext ctx) : base(ctx) { }

    public async void ChangeToMode(RunningMode mode) {
        throw new NotImplementedException();
    }

    public async Task<RunningMode> GetCurrentMode() {
        throw new NotImplementedException();
    }
}