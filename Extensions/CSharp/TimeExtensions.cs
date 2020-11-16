using System;

namespace YoungPackage.GameUtil.Extensions
{
    public static class TimeExtensions
    {
        public static TimeSpan RoundSeconds(this TimeSpan timeSpan)
        {
            return timeSpan.Milliseconds >= 500 ? timeSpan.Add(TimeSpan.FromSeconds(1)) : timeSpan;
        }
    }
}