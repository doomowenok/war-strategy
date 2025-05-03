using Cysharp.Threading.Tasks;
using Gameplay.Services;
using Infrastructure.StateMachine;
using Infrastructure.StateMachine.States;

namespace Gameplay.Boot
{
    public sealed class BootState : IState
    {
        private readonly IApplicationStateMachine _stateMachine;
        private readonly IServiceLocatorRegistrator _serviceLocatorRegistrator;

        public BootState(
            IApplicationStateMachine stateMachine,
            IServiceLocatorRegistrator serviceLocatorRegistrator)
        {
            _stateMachine = stateMachine;
            _serviceLocatorRegistrator = serviceLocatorRegistrator;
        }

        public UniTask Enter()
        { 
            _serviceLocatorRegistrator.Register();
            return UniTask.CompletedTask;
        }

        public UniTask Exit()
        {
            return UniTask.CompletedTask;
        }
    }
}