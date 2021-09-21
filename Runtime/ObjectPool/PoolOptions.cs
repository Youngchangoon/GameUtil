using UnityEngine;

namespace LongMan.GameUtil
{
    public struct PoolOptions
    {
        public readonly Transform ObjectParent;
        public readonly string ObjectName;
        public readonly int InitialCount;

        public PoolOptions(Transform objectParent, string objectName, int initialCount)
        {
            ObjectParent = objectParent;
            ObjectName = objectName;
            InitialCount = initialCount;
        }
    }
}