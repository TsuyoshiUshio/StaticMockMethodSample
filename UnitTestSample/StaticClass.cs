using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public static class StaticClass
    {
        public static void DoSomething()
        {
            // Do something we need mock this. 
            throw new Exception("You can't call it");
        }
    }
}
