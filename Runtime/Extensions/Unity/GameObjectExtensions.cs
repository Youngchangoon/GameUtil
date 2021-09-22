using UnityEngine;

namespace LongMan.GameUtil
{
    public static class GameObjectExtensions
    {
        /// <summary>
        /// Component가 있다면 Get하고 없으면 Add한다.
        /// </summary>
        /// <param name="gameObject"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var component = gameObject.GetComponent<T>();

            if (component != null)
                return component;

            return gameObject.AddComponent<T>();
        }
    }
}