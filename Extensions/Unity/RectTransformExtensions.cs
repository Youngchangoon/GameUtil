using UnityEngine;

namespace YoungPackage.GameUtil.Extensions
{
    public static class RectTransformExtensions
    {
        public static void SetAnchoredPositionX(this RectTransform rectTransform, float x)
        {
            rectTransform.anchoredPosition = new Vector2(x, rectTransform.anchoredPosition.y);
        }

        public static void SetAnchoredPositionY(this RectTransform rectTransform, float y)
        {
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, y);
        }
        
        public static void SetSizeDeltaX(this RectTransform rectTransform, float x)
        {
            rectTransform.sizeDelta = new Vector2(x, rectTransform.sizeDelta.y);
        }

        public static void SetSizeDeltaY(this RectTransform rectTransform, float y)
        {
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, y);
        }
        
        public static RectTransform ChangeToAllStretch(this RectTransform rt)
        {
            rt.anchorMin = new Vector2(0, 0);
            rt.anchorMax = new Vector2(1, 1);
            return rt;
        }

        public static RectTransform SetLeft(this RectTransform rt, float x)
        {
            rt.offsetMin = new Vector2(x, rt.offsetMin.y);
            return rt;
        }

        public static RectTransform SetRight(this RectTransform rt, float x)
        {
            rt.offsetMax = new Vector2(-x, rt.offsetMax.y);
            return rt;
        }

        public static RectTransform SetBottom(this RectTransform rt, float y)
        {
            rt.offsetMin = new Vector2(rt.offsetMin.x, y);
            return rt;
        }

        public static RectTransform SetTop(this RectTransform rt, float y)
        {
            rt.offsetMax = new Vector2(rt.offsetMax.x, -y);
            return rt;
        }
        
        public static RectTransform SetStretchAll(this RectTransform rt)
        {
            rt.localPosition = Vector3.zero;
            rt.anchorMin = Vector2.zero;
            rt.anchorMax = Vector2.one;
            rt.sizeDelta = Vector2.zero;

            return rt;
        }
        
        public static RectTransform SetStretchLeft(this RectTransform rt, float width)
        {
            rt.localPosition = Vector3.zero;
            rt.anchorMin = Vector2.zero;
            rt.anchorMax = new Vector2(0, 1f);
            rt.pivot = new Vector2(0, 0.5f);
            
            rt.SetSizeDeltaX(width);
            rt.SetTop(0f);
            rt.SetBottom(0f);

            return rt;
        }
    }
}