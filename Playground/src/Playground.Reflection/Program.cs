namespace Playground.Reflection
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Program
    {
        public static void Main(string[] args)
        {
            var allTypes = Assembly.GetEntryAssembly().GetTypes(); //.GetInterfaces();
            var interfaces = allTypes.SelectMany(t => t.GetInterfaces());
            var types = allTypes.Except(interfaces);

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
