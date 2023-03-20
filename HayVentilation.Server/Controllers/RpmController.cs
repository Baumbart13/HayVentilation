using HayVentilation.Core.Models;
using HayVentilation.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HayVentilation.Server.Controllers {

    [ApiController]
    [Route("/api/[controller]")]
    public class RpmController : ControllerBase {
        private readonly RpmService _dbRpmService;

        public RpmController(RpmService dbRpmService) {
            _dbRpmService = dbRpmService;
        }

        [HttpGet]
        public async Task<Rpm> GetCurrentValueAsync() {
            var data = await _dbRpmService.GetCurrentDatabaseValueAsync();
            return data;
        }
    }
}