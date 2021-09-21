using System;
using UnityEngine;

namespace LongMan.GameUtil
{
    public static class MathUtil
    {
        /// <summary>
        /// 나눠진 간격에 첫번째 포지션을 구한다.
        /// </summary>
        /// <param name="targetSize">타겟 사이즈</param>
        /// <param name="targetMargin">타겟 마진</param>
        /// <param name="totalCount">총 갯수</param>
        /// <param name="isFirstMinus">minus부터 시작하는지</param>
        /// <returns></returns>
        public static float GetDivideStartPos(float targetSize, float targetMargin, float totalCount, bool isFirstMinus = true)
        {
            return (isFirstMinus ? -1 : 1) * ((targetSize / 2) + (targetMargin / 2)) * Mathf.Max(totalCount - 1, 0);
        }

        /// <summary>
        /// 나눠진 간격에 Idx 포지션을 구한다.
        /// </summary>
        /// <param name="targetSize"></param>
        /// <param name="targetMargin"></param>
        /// <param name="totalCnt"></param>
        /// <param name="curIdx"></param>
        /// <param name="isFirstMinus"></param>
        /// <returns></returns>
        public static float GetDividePos(float targetSize, float targetMargin, int totalCnt, int curIdx, bool isFirstMinus = true)
        {
            var retPos = (isFirstMinus ? -1 : 1) * ((targetSize / 2) + (targetMargin / 2)) * (totalCnt - 1);
            retPos += (targetSize + targetMargin) * curIdx * (isFirstMinus ? 1 : -1);
            return retPos;
        }

        /// <summary>
        /// 보드의 로컬 포지션을 구한다. ( target Size )
        /// </summary>
        /// <param name="cellIndexPos"></param>
        /// <param name="targetSize"></param>
        /// <param name="targetMargin"></param>
        /// <param name="boardSize"></param>
        /// <returns></returns>
        public static Vector2 GetBoardLocalPos(Vector2Int cellIndexPos, Vector2 targetSize,
            Vector2 targetMargin, Vector2Int boardSize)
        {
            var retX = GetDivideStartPos(targetSize.x, targetMargin.x, boardSize.x) +
                       (targetSize.x + targetMargin.x) * cellIndexPos.x;
            var retY = GetDivideStartPos(targetSize.y, targetMargin.y, boardSize.y, false) -
                       (targetSize.y + targetMargin.y) * cellIndexPos.y;

            return new Vector2(retX, retY);
        }

        /// <summary>
        /// 보드의 로컬 포지션을 구한다. ( 정사각형 사이즈 )
        /// </summary>
        /// <param name="cellIndexPos"></param>
        /// <param name="targetSize"></param>
        /// <param name="targetMargin"></param>
        /// <param name="boardSize"></param>
        /// <returns></returns>
        public static Vector2 GetBoardLocalPos(Vector2Int cellIndexPos, float targetSize,
            float targetMargin, Vector2Int boardSize)
        {
            return GetBoardLocalPos(cellIndexPos,
                new Vector2(targetSize, targetSize),
                new Vector2(targetMargin, targetMargin), boardSize);
        }

        /// <summary>
        /// 두 벡터의 거리룰 구해준다.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float GetVector2Distance(Vector2 a, Vector2 b)
        {
            return new Vector2(Mathf.Abs(a.x - b.x), Mathf.Abs(a.y - b.y)).sqrMagnitude;
        }
    }
}