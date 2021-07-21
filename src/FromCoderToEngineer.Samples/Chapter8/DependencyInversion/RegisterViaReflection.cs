namespace FromCoderToEngineer.Samples.Chapter8.DependencyInversion
{
    using System.Linq;
    using System.Reflection;
    using Microsoft.Extensions.DependencyInjection;

    public class RegisterViaReflection
    {
        public void Register(IServiceCollection collection)
        {
            var assembly = Assembly.GetExecutingAssembly();

            assembly
                .GetTypes().Where(type => type.Name.EndsWith("Factory"))
                .ToList().ForEach(type => collection.AddTransient(type));

            assembly
                .GetTypes().Where(type => type.Name.EndsWith("Repository") && !type.IsAbstract && !type.IsInterface)
                .ToList().ForEach(type => collection.AddTransient(type.GetInterfaces().First(), type));
        }
    }
}
