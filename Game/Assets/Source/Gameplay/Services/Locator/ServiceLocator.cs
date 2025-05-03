using System;
using System.Collections.Generic;

namespace Gameplay.Services
{
    public static class ServiceLocator
    {
        private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>(32);
        
        public static void Register<TService>(TService service)
        {
            Services.Add(typeof(TService), service);
        }
        
        public static TService Get<TService>()
        {
            return (TService) Services[typeof(TService)];
        }
    }
}