using UnityEngine;

namespace LongMan.GameUtil
{
    public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static bool HasInstance => _instance != null;

        private static T _instance;
        private static bool _isDestroyed;
        private static bool _isApplicationQuitting;

        protected virtual void Awake()
        {
            _isDestroyed = false;
            _isApplicationQuitting = false;

            DontDestroyOnLoad(gameObject);
        }

        public static T Instance
        {
            get
            {
                if (_isApplicationQuitting)
                {
                    Debug.LogError($"Already singleton is Destroyed. :{typeof(T)} " +
                                   $"InstanceHave: {HasInstance}, Destroyed: {_isDestroyed}");
                    return null;
                }

                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();

                    if (_instance == null)
                        CreateNewSingletonObject();
                }

                return _instance;
            }
        }

        private static void CreateNewSingletonObject()
        {
            var fullName = typeof(T).FullName;
            _instance = new GameObject(fullName).AddComponent<T>();
        }

        protected virtual void OnDestroy()
        {
            _instance = null;
            _isDestroyed = true;
        }

        protected void OnApplicationQuit()
        {
            _instance = null;
            _isDestroyed = true;
            _isApplicationQuitting = true;
        }
    }
}