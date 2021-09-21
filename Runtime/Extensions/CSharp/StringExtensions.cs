using System;
using UnityEngine;

namespace LongMan.GameUtil.Extensions
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
        
        public static string GetForefrontToLower(this string str)
        {
            str = char.ToLower(str[0]) + str.Substring(1);
            return str;
        }
        
        public static string GetForefrontToUpper(this string str)
        {
            str = char.ToUpper(str[0]) + str.Substring(1);
            return str;
        }
        
        public static string SetMarkUpColor(this string str, Color color)
        {
            return $"<color={color.ToHtmlString()}>{str}</color>";
        }
    }
}