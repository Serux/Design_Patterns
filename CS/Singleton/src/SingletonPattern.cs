using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton.src
{
    public class SingletonPattern
    {
        private static SingletonPattern? instance;

        private SingletonPattern()
        {

        }
        public static SingletonPattern getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonPattern();
            }
            return instance;
        }

    }
}