using VContainer;
using VContainer.Unity;

namespace Gameplay.Services.Installers
{
    public sealed class LocatorInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<ServiceLocatorRegistrator>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}