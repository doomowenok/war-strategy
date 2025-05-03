using VContainer;

namespace Infrastructure.MVVM
{
    public abstract class BaseViewModel<TModel> : IViewModel
    {
        [Inject] protected readonly TModel Model;
        public abstract void Subscribe();
        public abstract void Unsubscribe();
    }
}