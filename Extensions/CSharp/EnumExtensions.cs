using System;

namespace YoungPackage.GameUtil.Extensions
{
    public static class EnumExtensions
    {
        public static int IntValue(this Enum argEnum)
        {
            return (int) (object)argEnum;
        }
    }
}