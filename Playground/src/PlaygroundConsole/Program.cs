using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.ExpressionTree;

namespace Playground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Specific Type Static Property: {ExpressionTree.Parser.GetPropertyName(() => Environment.TickCount)}");

            var genericType = new GenericTypeInference<DataTransferObject>();
            Console.WriteLine($"Generic Type Instance Property: {genericType.GetPropertyName(_ => _.Count)}");


            Console.ReadKey();
        }
    }
}
