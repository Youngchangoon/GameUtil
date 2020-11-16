using System;
using UnityEngine;

namespace YoungPackage.GameUtil
{
    public static class MathUtil
    {
        public static float GetDivideStartPos(float targetSize, float targetMargin, float totalCnt, bool isFirstMinus = true)
        {
            return (isFirstMinus ? -1 : 1) * ((targetSize / 2) + (targetMargin / 2)) * Mathf.Max(totalCnt - 1, 0);
        }

        public static float GetDividePos(float targetSize, float targetMargin, int totalCnt, int curIdx, bool isFirstMinus = true)
        {
            var retPos = (isFirstMinus ? -1 : 1) * ((targetSize / 2) + (targetMargin / 2)) * (totalCnt - 1);
            retPos += (targetSize + targetMargin) * curIdx * (isFirstMinus ? 1 : -1);
            return retPos;
        }
        
        public static Vector2 GetBoardLocalPos(Vector2Int cellIndexPos, Vector2 targetSize, Vector2 targetMargin,
            Vector2Int boardSize)
        {
            var retX = GetDivideStartPos(targetSize.x, targetMargin.x, boardSize.x) +
                       (targetSize.x + targetMargin.x) * cellIndexPos.x;
            var retY = GetDivideStartPos(targetSize.y, targetMargin.y, boardSize.y, false) -
                       (targetSize.y + targetMargin.y) * cellIndexPos.y;
            
            return new Vector2(retX, retY);
        }
        
        public static Vector2 GetBoardLocalPos(Vector2Int cellIndexPos, float targetSize, float targetMargin,
            Vector2Int boardSize)
        {
            var retX = GetDivideStartPos(targetSize, targetMargin, boardSize.x) +
                       (targetSize + targetMargin) * cellIndexPos.x;
            var retY = GetDivideStartPos(targetSize, targetMargin, boardSize.y, false) -
                       (targetSize + targetMargin) * cellIndexPos.y;
            
            return new Vector2(retX, retY);
        }

        public static float GetVector2Distance(Vector2 a, Vector2 b)
        {
            return (new Vector2(Mathf.Abs((a.x - b.x)), Mathf.Abs(a.y - b.y))).sqrMagnitude;
        }
    }
}