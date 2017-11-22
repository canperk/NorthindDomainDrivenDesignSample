namespace Northwind.Framework.Helpers
{
    public class SingleObject<T> where T : new()
    {
        static SingleObject()
        {
            _instance = new T();
        }
        private static T _instance;
        public static T Instance { get { return _instance;  } }
    }
}
