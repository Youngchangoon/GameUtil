using System;

namespace LongMan.GameUtil
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// 마지막 요소를 가져온다. ( 길이가 0일시 예외 )
        /// </summary>
        /// <param name="array"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static T GetLast<T>(this T[] array)
        {
            if(array.Length == 0)
                throw new ArgumentOutOfRangeException();
            
            return array[array.Length - 1];
        }

        /// <summary>
        /// 첫번째 요소를 반환한다. ( 길이가 0일시 예외 )
        /// </summary>
        /// <param name="array"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetFirst<T>(this T[] array)
        {
            if(array.Length == 0)
                throw new ArgumentOutOfRangeException();
            
            return array[0];
        }

        /// <summary>
        /// 배열안에 똑같은 T value를 넣는다.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] SetAllValues<T>(this T[] array, T value)
        {
            for (var i = 0; i < array.Length; i++)
                array[i] = value;

            return array;
        }

        /// <summary>
        /// 배열을 전부 지운다.
        /// </summary>
        /// <param name="array"></param>
        /// <typeparam name="T"></typeparam>
        public static void ClearAll<T>(this T[] array)
        {
            Array.Clear(array, 0, array.Length);
        }
    }
}