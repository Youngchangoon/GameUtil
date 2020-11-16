using System;

namespace YoungPackage.GameUtil.Extensions
{
    public static class ArrayExtensions
    {
        public static T GetLast<T>(this T[] array)
        {
            if(array.Length == 0)
                throw new ArgumentOutOfRangeException();
            
            return array[array.Length - 1];
        }

        public static T GetFirst<T>(this T[] array)
        {
            return array[0];
        }

        public static T[] SetALlValues<T>(this T[] array, T value)
        {
            for (var i = 0; i < array.Length; i++)
                array[i] = value;

            return array;
        }

        public static void ClearAll<T>(this T[] array)
        {
            Array.Clear(array, 0, array.Length);
        }
    }
}