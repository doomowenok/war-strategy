using VContainer;
using VContainer.Unity;

namespace Gameplay.Services
{
    public class SystemInjectorInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<SystemInjector>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}