using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180122_kerta5
{
    class Cat
    {
        private static int instances = 0;

        public Cat()
        {
            instances++;
        }

        public static int CatCount()
        {
            return instances;
        }

        ~Cat()
        {
            instances--;
        }
    }
}
