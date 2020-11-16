using UnityEngine;

namespace YoungPackage.GameUtil.Extensions
{
    public static class ColorExtensions
    {
        public static Color Opaque(this Color color)
        {
            return new Color(color.r, color.g, color.b);
        }

        public static Color Invert(this Color color)
        {
            return new Color(1 - color.r, 1 - color.g, 1 - color.b, color.a);
        }

        public static Color SetAlpha(this Color color, float alpha)
        {
            return new Color(color.r, color.g, color.b, alpha);
        }

        public static Color ToColor(this string htmlColorCode)
        {
            ColorUtility.TryParseHtmlString(htmlColorCode, out var color);
            return color;
        }
        
        public static string ToHtmlCodeRGB(this Color color)
        {
            return ColorUtility.ToHtmlStringRGB(color);
        }

        public static string ToHtmlCodeRGBA(this Color color)
        {
            return ColorUtility.ToHtmlStringRGBA(color);
        }
    }
}