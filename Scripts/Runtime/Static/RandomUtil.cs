using UnityEngine;

namespace YoungPackage.GameUtil
{
    public class RandomUtil
    {
        public static float GetRandomRangeEachSide(float min, float max)
        {
            if (min < 0 || max < 0)
            {
                Debug.LogError($"Min or max is not positive number, It's will be change to positive number.. min: {min}, max: {max}");
                min = Mathf.Abs(min);
                max = Mathf.Abs(max);
            }
            
            return UnityEngine.Random.Range(min, max) * (UnityEngine.Random.Range(0, 2) == 0 ? 1 : -1);
        }
    }
}