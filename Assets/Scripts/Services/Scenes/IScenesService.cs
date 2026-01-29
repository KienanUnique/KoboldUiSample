using UniRx;

namespace Services.Scenes
{
    public interface IScenesService
    {
        IReactiveProperty<float> LoadingProgress { get; }
        IReactiveProperty<bool> IsLoadingCompleted { get; }
        
        void ReloadCurrentScene();
    }
}