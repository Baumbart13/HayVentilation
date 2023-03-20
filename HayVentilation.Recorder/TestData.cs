using System.Collections;
using HayVentilation.Core.Models;

namespace HayVentilation.Recorder;

public class TestData {
    private static Random rng = new Random((int)DateTime.Now.ToFileTime());
    private TestData() { }

    public static IList<Rpm> RPMData => new[] {
        new Rpm { RPM = 916 }, new Rpm { RPM = 884 }, new Rpm { RPM = 1 }, new Rpm { RPM = 324 }, new Rpm { RPM = 157 },
        new Rpm { RPM = 554 }, new Rpm { RPM = 4 }, new Rpm { RPM = 562 }, new Rpm { RPM = 879 }, new Rpm { RPM = 290 },
        new Rpm { RPM = 904 }, new Rpm { RPM = 346 }, new Rpm { RPM = 536 }, new Rpm { RPM = 280 }, new Rpm { RPM = 223 },
        new Rpm { RPM = 201 }, new Rpm { RPM = 469 }, new Rpm { RPM = 403 }, new Rpm { RPM = 265 }, new Rpm { RPM = 221 },
        new Rpm { RPM = 352 }, new Rpm { RPM = 987 }, new Rpm { RPM = 190 }, new Rpm { RPM = 247 }, new Rpm { RPM = 759 },
        new Rpm { RPM = 433 }, new Rpm { RPM = 844 }, new Rpm { RPM = 592 }, new Rpm { RPM = 240 }, new Rpm { RPM = 37 },
        new Rpm { RPM = 251 }, new Rpm { RPM = 986 }, new Rpm { RPM = 577 }, new Rpm { RPM = 253 }, new Rpm { RPM = 916 },
        new Rpm { RPM = 525 }, new Rpm { RPM = 890 }, new Rpm { RPM = 368 }, new Rpm { RPM = 295 }, new Rpm { RPM = 280 },
        new Rpm { RPM = 297 }, new Rpm { RPM = 399 }, new Rpm { RPM = 658 }, new Rpm { RPM = 462 }, new Rpm { RPM = 909 },
        new Rpm { RPM = 975 }, new Rpm { RPM = 961 }, new Rpm { RPM = 116 }, new Rpm { RPM = 294 }, new Rpm { RPM = 987 },
        new Rpm { RPM = 398 }, new Rpm { RPM = 732 }, new Rpm { RPM = 988 }, new Rpm { RPM = 103 }, new Rpm { RPM = 657 },
        new Rpm { RPM = 337 }, new Rpm { RPM = 892 }, new Rpm { RPM = 730 }, new Rpm { RPM = 405 }, new Rpm { RPM = 812 },
        new Rpm { RPM = 518 }, new Rpm { RPM = 352 }, new Rpm { RPM = 570 }, new Rpm { RPM = 59 }, new Rpm { RPM = 470 },
        new Rpm { RPM = 784 }, new Rpm { RPM = 340 }, new Rpm { RPM = 716 }, new Rpm { RPM = 942 }, new Rpm { RPM = 775 },
        new Rpm { RPM = 114 }, new Rpm { RPM = 776 }, new Rpm { RPM = 973 }, new Rpm { RPM = 460 }, new Rpm { RPM = 476 },
        new Rpm { RPM = 811 }, new Rpm { RPM = 348 }, new Rpm { RPM = 539 }, new Rpm { RPM = 534 }, new Rpm { RPM = 985 },
        new Rpm { RPM = 572 }, new Rpm { RPM = 171 }, new Rpm { RPM = 622 }, new Rpm { RPM = 818 }, new Rpm { RPM = 493 },
        new Rpm { RPM = 285 }, new Rpm { RPM = 242 }, new Rpm { RPM = 652 }, new Rpm { RPM = 119 }, new Rpm { RPM = 892 },
        new Rpm { RPM = 455 }, new Rpm { RPM = 705 }, new Rpm { RPM = 186 }, new Rpm { RPM = 126 }, new Rpm { RPM = 966 },
        new Rpm { RPM = 741 }, new Rpm { RPM = 457 }, new Rpm { RPM = 409 }, new Rpm { RPM = 701 }, new Rpm { RPM = 119 },
        new Rpm { RPM = 141 }, new Rpm { RPM = 8 }, new Rpm { RPM = 265 }, new Rpm { RPM = 40 }, new Rpm { RPM = 897 },
        new Rpm { RPM = 461 }, new Rpm { RPM = 127 }, new Rpm { RPM = 518 }, new Rpm { RPM = 620 }, new Rpm { RPM = 286 },
        new Rpm { RPM = 680 }, new Rpm { RPM = 266 }, new Rpm { RPM = 944 }, new Rpm { RPM = 901 }, new Rpm { RPM = 157 },
        new Rpm { RPM = 535 }, new Rpm { RPM = 673 }, new Rpm { RPM = 447 }, new Rpm { RPM = 161 }, new Rpm { RPM = 131 },
        new Rpm { RPM = 382 }, new Rpm { RPM = 388 }, new Rpm { RPM = 191 }, new Rpm { RPM = 434 }, new Rpm { RPM = 827 },
        new Rpm { RPM = 470 }, new Rpm { RPM = 829 }, new Rpm { RPM = 669 }, new Rpm { RPM = 349 }, new Rpm { RPM = 484 },
        new Rpm { RPM = 61 }, new Rpm { RPM = 953 }, new Rpm { RPM = 117 }, new Rpm { RPM = 59 }, new Rpm { RPM = 339 },
        new Rpm { RPM = 8 }, new Rpm { RPM = 898 }, new Rpm { RPM = 464 }, new Rpm { RPM = 93 }, new Rpm { RPM = 42 },
        new Rpm { RPM = 545 }, new Rpm { RPM = 253 }, new Rpm { RPM = 926 }, new Rpm { RPM = 680 }, new Rpm { RPM = 997 },
        new Rpm { RPM = 440 }, new Rpm { RPM = 940 }, new Rpm { RPM = 121 }, new Rpm { RPM = 397 }, new Rpm { RPM = 665 },
        new Rpm { RPM = 989 }, new Rpm { RPM = 121 }, new Rpm { RPM = 764 }, new Rpm { RPM = 774 }, new Rpm { RPM = 843 },
        new Rpm { RPM = 524 }, new Rpm { RPM = 227 }, new Rpm { RPM = 850 }, new Rpm { RPM = 234 }, new Rpm { RPM = 900 },
        new Rpm { RPM = 583 }, new Rpm { RPM = 205 }, new Rpm { RPM = 717 }, new Rpm { RPM = 869 }, new Rpm { RPM = 221 },
        new Rpm { RPM = 721 }, new Rpm { RPM = 165 }, new Rpm { RPM = 533 }, new Rpm { RPM = 198 }, new Rpm { RPM = 304 },
        new Rpm { RPM = 132 }, new Rpm { RPM = 996 }, new Rpm { RPM = 707 }, new Rpm { RPM = 561 }, new Rpm { RPM = 709 },
        new Rpm { RPM = 389 }, new Rpm { RPM = 899 }, new Rpm { RPM = 15 }, new Rpm { RPM = 103 }, new Rpm { RPM = 839 },
        new Rpm { RPM = 3 }, new Rpm { RPM = 478 }, new Rpm { RPM = 54 }, new Rpm { RPM = 554 }, new Rpm { RPM = 117 },
        new Rpm { RPM = 820 }, new Rpm { RPM = 986 }, new Rpm { RPM = 576 }, new Rpm { RPM = 951 }, new Rpm { RPM = 495 },
        new Rpm { RPM = 173 }, new Rpm { RPM = 567 }, new Rpm { RPM = 662 }, new Rpm { RPM = 210 }, new Rpm { RPM = 864 },
        new Rpm { RPM = 538 }, new Rpm { RPM = 635 }, new Rpm { RPM = 802 }, new Rpm { RPM = 489 }, new Rpm { RPM = 681 },
        new Rpm { RPM = 764 }, new Rpm { RPM = 44 }, new Rpm { RPM = 140 }, new Rpm { RPM = 261 }, new Rpm { RPM = 218 },
        new Rpm { RPM = 686 }, new Rpm { RPM = 958 }, new Rpm { RPM = 416 }, new Rpm { RPM = 136 }, new Rpm { RPM = 999 },
        new Rpm { RPM = 757 }, new Rpm { RPM = 979 }, new Rpm { RPM = 432 }, new Rpm { RPM = 208 }, new Rpm { RPM = 818 },
        new Rpm { RPM = 173 }, new Rpm { RPM = 538 }, new Rpm { RPM = 896 }, new Rpm { RPM = 942 }, new Rpm { RPM = 666 },
        new Rpm { RPM = 991 }, new Rpm { RPM = 284 }, new Rpm { RPM = 647 }, new Rpm { RPM = 635 }, new Rpm { RPM = 219 },
        new Rpm { RPM = 329 }, new Rpm { RPM = 366 }, new Rpm { RPM = 932 }, new Rpm { RPM = 941 }, new Rpm { RPM = 83 },
        new Rpm { RPM = 31 }, new Rpm { RPM = 174 }, new Rpm { RPM = 483 }, new Rpm { RPM = 574 }, new Rpm { RPM = 489 },
        new Rpm { RPM = 181 }, new Rpm { RPM = 228 }, new Rpm { RPM = 282 }, new Rpm { RPM = 491 }, new Rpm { RPM = 696 },
        new Rpm { RPM = 61 }, new Rpm { RPM = 582 }, new Rpm { RPM = 688 }, new Rpm { RPM = 266 }, new Rpm { RPM = 912 },
        new Rpm { RPM = 403 }, new Rpm { RPM = 587 }, new Rpm { RPM = 668 }, new Rpm { RPM = 429 }, new Rpm { RPM = 19 },
        new Rpm { RPM = 179 }, new Rpm { RPM = 241 }, new Rpm { RPM = 94 }, new Rpm { RPM = 851 }, new Rpm { RPM = 761 },
        new Rpm { RPM = 853 }, new Rpm { RPM = 838 }, new Rpm { RPM = 593 }, new Rpm { RPM = 721 }, new Rpm { RPM = 804 },
        new Rpm { RPM = 665 }, new Rpm { RPM = 698 }, new Rpm { RPM = 226 }, new Rpm { RPM = 255 }, new Rpm { RPM = 832 },
        new Rpm { RPM = 990 }, new Rpm { RPM = 319 }, new Rpm { RPM = 434 }, new Rpm { RPM = 607 }, new Rpm { RPM = 152 },
        new Rpm { RPM = 309 }, new Rpm { RPM = 686 }, new Rpm { RPM = 606 }, new Rpm { RPM = 478 }, new Rpm { RPM = 482 },
        new Rpm { RPM = 159 }, new Rpm { RPM = 502 }, new Rpm { RPM = 289 }, new Rpm { RPM = 803 }, new Rpm { RPM = 427 },
        new Rpm { RPM = 31 }, new Rpm { RPM = 500 }, new Rpm { RPM = 372 }, new Rpm { RPM = 209 }, new Rpm { RPM = 445 },
        new Rpm { RPM = 548 }, new Rpm { RPM = 393 }, new Rpm { RPM = 916 }, new Rpm { RPM = 560 }, new Rpm { RPM = 676 },
        new Rpm { RPM = 757 }, new Rpm { RPM = 244 }, new Rpm { RPM = 414 }, new Rpm { RPM = 930 }, new Rpm { RPM = 883 },
        new Rpm { RPM = 68 }, new Rpm { RPM = 747 }, new Rpm { RPM = 930 }, new Rpm { RPM = 602 }, new Rpm { RPM = 137 }
    };

    public static IList<Scan> ScanData => throw new NotImplementedException();

    public static string RpmInsertString(string tableName = "rpm") {
        return $"INSERT INTO {tableName} VALUES ({RPMData[(int)rng.NextInt64(RPMData.Count)]});";
    }

    public static IEnumerable<string> RpmInsertStrings(string tableName = "rpm", int amount = 5) {
        if (amount < 1) amount = 5;
        amount = amount > RPMData.Count ? RPMData.Count : amount;
        for (var i = 0; i < amount; ++i) {
            yield return RpmInsertString(tableName);
        }
    }

    public static string ScanInsertString(string tableName = "scan") {
        return $"INSERT INTO {tableName} VALUES ({ScanData[(int)rng.NextInt64(ScanData.Count)]})";
    }

    public static IEnumerable<string> ScanInsertStrings(string tableName = "scan", int amount = 5) {
        if (amount < 1) amount = 5;
        amount = amount > ScanData.Count ? ScanData.Count : amount;
        for (var i = 0; i < amount; ++i) {
            yield return ScanInsertString(tableName);
        }
    }
}