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

            var dependencyTypes = referencedAssemblies.Concat(new[] { assembly })
                                                        .SelectMany(a => a.GetExportedTypes())
                                                        .Where(t => typeof(IDependency).IsAssignableFrom(t) && t != typeof(IDependency))
                                                        .ToList();

            var dependencyInterfaces = dependencyTypes.SelectMany(t => t.GetInterfaces())
                                                       .Where(t => t != typeof(IDependency))
                                                       .ToArray();

            // Note, System.Type.IsInterface is implemented int .NET Core
            // https://apisof.net/catalog/System.Type.IsInterface
            var dependencyImplementations = dependencyTypes.Except(dependencyInterfaces).ToArray();

            Console.WriteLine("IDependency implementations");

            foreach (var @interface in dependencyInterfaces)
            {
                var type = dependencyImplementations.SingleOrDefault(t => @interface.IsAssignableFrom(t));

                Console.WriteLine($"{type.Name} : {@interface.Name}");
            }

            Console.ReadKey();
        }
    }
}
