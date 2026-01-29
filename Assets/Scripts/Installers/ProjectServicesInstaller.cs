using Services.LevelProgression.Impl;
using Services.Scenes.Impl;
using Services.SettingsStorage.Impl;
using Zenject;

namespace Installers
{
    public class ProjectServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ScenesService>().AsSingle();
            Container.BindInterfacesTo<SettingsStorageService>().AsSingle();
            Container.BindInterfacesTo<LevelProgressionService>().AsSingle();
        }
    }
}