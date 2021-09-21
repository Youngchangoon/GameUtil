using System;

namespace LongMan.GameUtil.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Enum값을 int로 바꿔준다.
        /// </summary>
        /// <param name="argEnum"></param>
        /// <returns></returns>
        public static int IntValue(this Enum argEnum)
        {
            return (int) (object)argEnum;
        }
        
        /// <summary>
        /// Enum의 총 갯수를 반환한다.
        /// </summary>
        /// <param name="type"></param>
        /// <typeparam name="TEnum"></typeparam>
        /// <returns></returns>
        public static int GetCount<TEnum>(this TEnum type) where TEnum : Type
        {
            return Enum.GetValues(type).Length;
        }
    }
}