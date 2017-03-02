﻿namespace Playground.Reflection
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Assembly can be loaded dynamically
            var assembly = Assembly.Load(new AssemblyName(typeof(IDependency).AssemblyQualifiedName ?? "Playground.Reflection")) ?? Assembly.GetEntryAssembly();

            Console.WriteLine(assembly.FullName);

            var allTypes = assembly.GetTypes().ToList(); 
            var interfaces = allTypes.SelectMany(t => t.GetInterfaces()).ToList();
            var types = allTypes.Except(interfaces).ToList();

            Console.WriteLine("IDependency implementations");

            foreach (var @interface in interfaces.Where(i => typeof(IDependency).IsAssignableFrom(i) && i.Name != typeof(IDependency).Name))
            {
                var type = types.SingleOrDefault(t => @interface.IsAssignableFrom(t));

                Console.WriteLine($"{type.Name} : {@interface.Name}");
            }
            
            Console.ReadKey();
        }
    }
}
