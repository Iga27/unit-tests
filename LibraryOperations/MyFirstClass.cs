using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOperations
{
    public class MyFirstClass
    {
        MySecondClass second;

        public MyFirstClass(MySecondClass second)
        {
            this.second = second;
        }

        public string FirstMethod(string text)
        {
            second.AnotherMethod(text);
            return second.SecondMethod(text)+"def";
        }
    }
}
