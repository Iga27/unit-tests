using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOperations
{
    public class MySecondClass
    {
        /*should be a virtual, because Moq creates a type which inherits from MySecondClass
        and overrides the behaviors that you have set up in the "SetUp" method. */
        public virtual string SecondMethod(string source) 
        {
            return source + "abc";
        }

        public virtual void AnotherMethod(string text) 
        {
            text = "hello"; ////
        }
    }
}
