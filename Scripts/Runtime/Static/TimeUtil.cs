using System;

namespace YoungPackage.GameUtil
{
    public static class TimeUtil
    {
        // Time Util
        public static string UnixTimeNowToString()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return ((long) timeSpan.TotalSeconds).ToString();
        }
        public static long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long) timeSpan.TotalSeconds;
        }
    }
}