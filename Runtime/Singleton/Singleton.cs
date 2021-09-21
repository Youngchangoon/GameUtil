namespace LongMan.GameUtil
{
    public class Singleton<T> where T : Singleton<T>, new()
    {
        private static T _instance;

        public static T Instance => _instance ?? (_instance = new T());
    }
}