using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecutionOrder
{
    public class SomeClass
    {
        public SomeClass(string param)
        {
            Console.WriteLine($"{nameof(SomeClass)} {param}");
        }
    }
}
