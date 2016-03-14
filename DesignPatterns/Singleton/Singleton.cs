using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // thread safe implementation of the singleton class.
    public class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _padlock = new object();

        public static Singleton Instance
        {
            get
            {
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
