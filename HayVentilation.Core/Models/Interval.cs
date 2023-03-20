namespace HayVentilation.Core.Models;

public class Interval : IHayModel {
    public byte IntervalNo { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan Start { get; set; }
    public TimeSpan End { get; set; }

    public int Id => ((int)Localize(Day) << 4) | IntervalNo;

    private enum LocalDayOfWeek {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    private static LocalDayOfWeek Localize(DayOfWeek d) {
        return d switch {
            DayOfWeek.Sunday => LocalDayOfWeek.Sunday,
            DayOfWeek.Monday => LocalDayOfWeek.Monday,
            DayOfWeek.Tuesday => LocalDayOfWeek.Tuesday,
            DayOfWeek.Wednesday => LocalDayOfWeek.Wednesday,
            DayOfWeek.Thursday => LocalDayOfWeek.Thursday,
            DayOfWeek.Friday => LocalDayOfWeek.Friday,
            DayOfWeek.Saturday => LocalDayOfWeek.Saturday,
            _ => throw new ArgumentOutOfRangeException(nameof(d), d, "Unknown day of week")
        };
    }

    public static bool IsEnoughTimeDifference(Interval i1, Interval i2) {
        if (i1.Day != i2.Day) {
            throw new ArgumentException("Intervals of different days can not be checked");
        }

        if (i1.Id == i2.Id) {
            return true;
        }

        var diff = i1.Start.Subtract(i2.Start);
        diff = TimeSpan.FromTicks(Math.Abs(diff.Ticks));
        if (diff.CompareTo(TimeSpan.FromMinutes(10)) < 0) {
            return false;
        }

        diff = i1.End.Subtract(i2.End);
        diff = TimeSpan.FromTicks(Math.Abs(diff.Ticks));
        return diff.CompareTo(TimeSpan.FromMinutes(10)) >= 0;
    }
}