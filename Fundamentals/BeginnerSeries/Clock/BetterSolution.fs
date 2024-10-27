module BeginnerSeriesClockKata

let past h m s = 
    System.TimeSpan(h, m, s).TotalMilliseconds
