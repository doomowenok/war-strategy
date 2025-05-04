using VContainer;
using VContainer.Unity;

namespace Gameplay.Core
{
    public sealed class InputInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.Register<InputSystem>(Lifetime.Singleton).AsImplementedInterfaces();
        }
    }
}