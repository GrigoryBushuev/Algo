using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    public class MyHeavyClass<T>
    {
        private MyHeavyClass() { }

        public MyHeavyClass<T> Instance{
            get {
                return LazyInitializer.EnsureInitialized<MyHeavyClass>();
            }
        }

    }
}
