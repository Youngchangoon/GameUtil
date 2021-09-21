using UnityEngine;
using UnityEngine.UI;

namespace LongMan.GameUtil.Extensions
{
    public static class UIGraphicExtensions
    {
        public static void SetRgb(this Graphic graphic, Color rgb)
        {
            graphic.color = new Color(rgb.r, rgb.g, rgb.b, graphic.color.a);
        }

        public static void SetRgb(this Graphic graphic, float rgb)
        {
            graphic.color = new Color(rgb / 255f, rgb / 255f, rgb / 255f, graphic.color.a);
        }
        
        public static void SetAlpha(this Graphic graphic, float alpha)
        {
            var rgb = graphic.color;
            graphic.color = new Color(rgb.r, rgb.g, rgb.b, alpha);
        }

        public static void SetSpriteAndSetNative(this Image image, Sprite sprite)
        {
            image.sprite = sprite;
            image.SetNativeSize();
        }
        
        public static void SetTextWithSize(this Text text, string str, float maxWidth, int maxFontSize)
        {
            text.text = str;
            text.fontSize = maxFontSize;

            while (text.preferredWidth > maxWidth)
                --text.fontSize;
        }
    }
}