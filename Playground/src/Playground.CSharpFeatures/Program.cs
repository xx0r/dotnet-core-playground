using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.CSharpFeatures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;

            // variable needs to be initialized when passing by reference...
            // ModifyByReference(ref i);

            int.TryParse("5", out i);

            Console.WriteLine(i);

            ModifyByReference(ref i);

            Console.WriteLine(i);

            Modify(i);

            Console.WriteLine(i);


            Console.ReadKey();

        }

        private static void ModifyByReference(ref int input)
        {
            input *= 3;
        }

        private static void Modify(int input)
        {
            input += 1;
        }

    }
}
