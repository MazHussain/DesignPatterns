namespace Singleton
{
    // thread safe implementation of the singleton class.
    public class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _padlock = new object();

        // prevents class from being instantiated.
        private Singleton()
        {}

        public static Singleton Instance
        {
            get
            {
                //ensures thread safety
                lock (_padlock)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
                
            }
        }
    }
}
