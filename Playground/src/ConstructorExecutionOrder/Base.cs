using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExecutionOrder
{
    public class Base
    {

        private SomeClass property = new SomeClass("Base Property");
        private readonly SomeClass readonlyProperty;

        public Base()
        {
            Console.WriteLine("Base Constructor");
            this.readonlyProperty = new SomeClass("Base Readonly Property");

            // Now this is overriden in the Derived class and will cause the overriden method to be called (which is not initialized from constructor yet)
            this.DisplayReadonlyProperty();
        }

        public virtual void DisplayReadonlyProperty()
        {
            Console.WriteLine($"Displaying Base Readonly Property {this.readonlyProperty}");
        }
    }
}
