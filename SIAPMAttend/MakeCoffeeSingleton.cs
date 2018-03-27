using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAPMAttend
{
    public sealed class MakeCoffeeSingleton
    {
        private static MakeCoffee _instance;

        public MakeCoffeeSingleton(MakeCoffee instance)
        {
            _instance = instance;
        }

        public static MakeCoffee Instance()
        {
            return _instance;
        }
    }
}
