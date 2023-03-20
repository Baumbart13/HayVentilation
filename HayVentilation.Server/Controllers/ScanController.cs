using HayVentilation.Core.Models;
using HayVentilation.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HayVentilation.Server.Controllers {
    [ApiController]
    [Route("/api/[controller]")]
    public class ScanController : ControllerBase {
        private readonly ScanService _dbScanService;

        public ScanController(ScanService dbScanService) {
            _dbScanService = dbScanService;
        }

        [HttpGet]
        public IEnumerable<Scan> GetCurrentValues() {
            var data = _dbScanService.GetCurrentDatabaseValues();
            return data;
        }
    }
}