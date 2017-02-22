using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructorExecutionOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var instance = new Derived();

            Console.ReadKey();
        }
    }
}

