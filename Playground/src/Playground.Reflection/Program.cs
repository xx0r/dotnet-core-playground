namespace Playground.Reflection
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Assembly can be loaded dynamically
            var assembly = Assembly.Load(new AssemblyName("Playground.Reflection")) ?? Assembly.GetEntryAssembly(); // typeof(IDependency).FullName ?? 
            var referencedAssemblies = assembly.GetReferencedAssemblies().Select(Assembly.Load);

            Console.WriteLine(assembly.FullName);

            var allTypes = referencedAssemblies.Concat(new[] { assembly }).SelectMany(a => a.GetTypes()).ToList();
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
