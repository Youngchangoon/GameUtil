namespace LongMan.GameUtil
{
    /// <summary>
    /// 배열 관련 유틸함수
    /// </summary>
    public static class ArrayUtil
    {
        /// <summary>
        /// 새로운 배열을 생성한 후 복사한다.
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <param name="copyArray"></param>
        /// <typeparam name="T"></typeparam>
        public static void NewArrayAndFullCopy<T>(T[] sourceArray, out T[] copyArray)
        {
            copyArray = new T[sourceArray.Length];
            sourceArray.CopyTo(copyArray, 0);
        }
    }
}