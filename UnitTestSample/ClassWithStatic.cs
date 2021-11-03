using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public class ClassWithStatic
    {

        public void Original()
        {
            // Original code
            StaticClass.DoSomething();
        }

        public void Method01()
        {
            DoSomething();
        }

        public void Method02()
        {
            somethingToDo();
        }

        internal virtual void DoSomething()
        {
            StaticClass.DoSomething();
        }

        private Action somethingToDo = () => { throw new Exception("not avaiable"); };

        internal Action SomethingToDo
        {
            set
            {
                somethingToDo = value;
            }
        }
    }
}
