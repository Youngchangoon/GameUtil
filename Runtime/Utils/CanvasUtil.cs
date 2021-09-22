using UnityEngine;

namespace LongMan.GameUtil
{
    /// <summary>
    /// 캔버스 관련 유틸함수
    /// </summary>
    public class CanvasUtil
    {
        /// <summary>
        /// 캔버스의 가로/세로비에 맞춰 ScaleMatch를 가져온다.
        /// </summary>
        /// <param name="isLandScapeGame">가로게임 여부</param>
        /// <returns></returns>
        public static float GetScaleMatch(bool isLandScapeGame)
        {
            if (!isLandScapeGame)
                return (float)Screen.width / (float)Screen.height >= 0.55f ? 1f : 0f;

            return (float)Screen.height / (float)Screen.width >= 0.55f ? 0f : 1f;
        }

        /// <summary>
        /// 캔버스 스케일을 가져온다.
        /// </summary>
        /// <param name="targetResolutionSize">타겟 해상도</param>
        /// <param name="matchWidthOrHeight"> 0 or 1</param>
        /// <param name="isLandScapeGame">가로 게임 여부</param>
        /// <returns></returns>
        public static float GetCanvasScale(Vector2 targetResolutionSize,
            float matchWidthOrHeight = -1f, bool isLandScapeGame = false)
        {
            if (matchWidthOrHeight < 0f)
                matchWidthOrHeight = GetScaleMatch(isLandScapeGame);

            return Mathf.Pow(2f, Mathf.Lerp(
                Mathf.Log(Screen.width / targetResolutionSize.x, 2f),
                Mathf.Log(Screen.height / targetResolutionSize.y, 2f), matchWidthOrHeight));
        }

        /// <summary>
        /// 캔버스 
        /// </summary>
        /// <param name="targetResolutionSize"></param>
        /// <param name="matchWidthOrHeight"></param>
        /// <returns></returns>
        public static Vector2 GetResolutionCanvasSize(Vector2 targetResolutionSize, float matchWidthOrHeight = -1f)
        {
            var canvasScale = GetCanvasScale(targetResolutionSize, matchWidthOrHeight);
            return new Vector2(Screen.width / canvasScale, Screen.height / canvasScale);
        }

        /// <summary>
        /// 해상도에 맞춰 직교 카메라 사이즈를 가져온다.
        /// </summary>
        /// <param name="targetResolution"></param>
        /// <returns></returns>
        public static float GetOrthographicSize(Vector2 targetResolution)
        {
            return Screen.height * 0.01f / 2f / GetCanvasScale(targetResolution);
        }

        /// <summary>
        /// 노말라이즈된 가로 반환
        /// </summary>
        /// <returns></returns>
        public static int GetNormalizedWidth()
        {
            return (int)((float)Screen.width / (float)Screen.height * 1920f);
        }

        /// <summary>
        /// 노말라이즈된 세로 반환
        /// </summary>
        /// <returns></returns>
        public static int GetNormalizedHeight()
        {
            return (int)((float)Screen.height / (float)Screen.width * 1080f);
        }
    }
}