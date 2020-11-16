using System;

namespace YoungPackage.GameUtil.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceAt(this string str, int index, int length, string replace)
        {
            return str
                .Remove(index, Math.Min(length, str.Length - index))
                .Insert(index, replace);
        }

        public static string RemoveAllSpace(this string str)
        {
            return str.Replace(" ", "");
        }
    }
}