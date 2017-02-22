using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecutionOrder
{
    public class Derived : Base
    {

        private SomeClass derivedProperty = new SomeClass("Derived Property");
        private readonly SomeClass derivedReadonlyProperty;

        public Derived()
        {
            Console.WriteLine("Derived Constructor");

            this.derivedReadonlyProperty = new SomeClass("Derived Readonly Property");
        }

        public override void DisplayReadonlyProperty()
        {
            Console.WriteLine($"Displaying Derived Readonly Property: {this.derivedReadonlyProperty}");

        }
    }
}

