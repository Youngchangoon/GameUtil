using UnityEngine;

namespace YoungPackage.GameUtil
{
    public class DeviceUtil
    {
         /// <summary>
         /// Get Unity canvas Width/Height Match 
         /// </summary>
         /// <returns></returns>
         public static float GetScaleMatch(bool isLandScapeGame = false)
        {
            if (!isLandScapeGame)
                return (float) Screen.width / (float) Screen.height >= 0.55f ? 1f : 0f;

            return (float) Screen.height / (float) Screen.width >= 0.55f ? 0f : 1f;
        }

        /// <summary>
        /// 캔버스 스케일을 가져온다.
        /// </summary>
        /// <param name="targetResolutionSize">타겟 해상도</param>
        /// <param name="matchWidthOrHeight"> 0 or 1</param>
        /// <returns></returns>
        public static float GetCanvasScale(Vector2 targetResolutionSize, float matchWidthOrHeight = -1f)
        {
            if (matchWidthOrHeight < 0f)
                matchWidthOrHeight = GetScaleMatch();

            return Mathf.Pow(2f, Mathf.Lerp(
                Mathf.Log(Screen.width / targetResolutionSize.x, 2f),
                Mathf.Log(Screen.height / targetResolutionSize.y, 2f), matchWidthOrHeight));
        }

        public static Vector2 GetResolutionCanvasSize(Vector2 targetResolutionSize, float matchWidthOrHeight = -1f)
        {
            var canvasScale = GetCanvasScale(targetResolutionSize, matchWidthOrHeight);
            return new Vector2(Screen.width / canvasScale, Screen.height / canvasScale);
        }
        
        public static float GetOrthographicSize(Vector2 targetResolution)
        {
            return Screen.height * 0.01f / 2f / GetCanvasScale(targetResolution);
        }
        
        public static int GetNormalizedWidth()
        {
            return (int)((float)Screen.width / (float)Screen.height * 1920f);
        }

        public static int GetNormalizedHeight()
        {
            return (int)((float)Screen.height / (float)Screen.width * 1080f);
        }
    }
}