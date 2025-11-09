using BullCommander.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BullCommander.Services
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddSingleton<IMainService, MainService>();
            /*collection.AddTransient<BusinessService>();
            collection.AddTransient<MainWindowViewModel>();*/

            var derivedTypes = new List<Type>();
            foreach (var domainAssembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var assemblyTypes = domainAssembly.GetTypes()
                    .Where(type => type.IsSubclassOf(typeof(ViewModelBase)) && !type.IsAbstract);

                derivedTypes.AddRange(assemblyTypes);
            }

            foreach (var derivedType in derivedTypes)
            {
                collection.AddTransient(derivedType);
            }
        }
    }
}