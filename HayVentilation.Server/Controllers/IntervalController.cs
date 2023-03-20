using HayVentilation.Core.Models;
using HayVentilation.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace HayVentilation.Server.Controllers {

    [ApiController]
    [Route("/api/[controller]")]
    public class IntervalController : ControllerBase {
        private readonly ConfigService _configService;

        public IntervalController(ConfigService configService) {
            _configService = configService;
        }

        [HttpGet("GetAll")]
        public IList<Interval> GetAll() {
            return _configService.GetAllValues();
        }

        [HttpGet("GetDay/{day}")]
        public IEnumerable<Interval> GetSingleDay(DayOfWeek day) {
            return _configService.GetOfDay(day);
        }

        [HttpGet("TestAll")]
        public IEnumerable<Interval> Test_GetAll() {
            return (from i in TEST
                    orderby i.Id
                    select i)
                .ToArray();
        }

        [HttpGet("TestDay/{day}")]
        public IEnumerable<Interval> Test_GetSingleDay(DayOfWeek day) {
            return (from i in TEST
                    orderby i.Id
                    where i.Day == day
                    select i)
                .ToArray();
        }

        [HttpGet("TestSingle")]
        public Interval Test_GetSingleInterval() {
            return new Interval {
                Day = DayOfWeek.Monday,
                IntervalNo = 0,
                Start = new TimeSpan(6, 0, 0),
                End = new TimeSpan(12, 0, 0)
            };
        }

        public static readonly List<Interval> TEST = new List<Interval> {
            new Interval
                { Day = DayOfWeek.Monday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0) },
            new Interval {
                Day = DayOfWeek.Monday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval {
                Day = DayOfWeek.Tuesday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0)
            },
            new Interval {
                Day = DayOfWeek.Tuesday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval {
                Day = DayOfWeek.Wednesday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0)
            },
            new Interval {
                Day = DayOfWeek.Wednesday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval {
                Day = DayOfWeek.Thursday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0)
            },
            new Interval {
                Day = DayOfWeek.Thursday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval
                { Day = DayOfWeek.Friday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0) },
            new Interval {
                Day = DayOfWeek.Friday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval {
                Day = DayOfWeek.Saturday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0)
            },
            new Interval {
                Day = DayOfWeek.Saturday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },

            new Interval
                { Day = DayOfWeek.Sunday, IntervalNo = 0, Start = new TimeSpan(6, 0, 0), End = new TimeSpan(12, 0, 0) },
            new Interval {
                Day = DayOfWeek.Sunday, IntervalNo = 1, Start = new TimeSpan(18, 0, 0), End = new TimeSpan(24, 0, 0)
            },
        };
    }
}