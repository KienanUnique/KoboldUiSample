using KoboldUi.Composition;
using KoboldUi.Composition.Zenject;
using KoboldUi.Services.WindowsService;
using MainMenuScreen.Ui.LevelSelector;
using MainMenuScreen.Ui.MainMenu;
using MainMenuScreen.Ui.Settings;
using MainMenuScreen.Ui.SettingsChangeConfirmation;
using Services.Bootstrap;
using UnityEngine;
using Zenject;

namespace MainMenuScreen.Installers
{
    [CreateAssetMenu(fileName = nameof(MainMenuUiInstaller), menuName = "Simple Sample/" + nameof(MainMenuUiInstaller), order = 0)]
    public class MainMenuUiInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas canvas;
        
        [Header("Windows")]
        [SerializeField] private MainMenuWindow mainMenuWindow;
        [SerializeField] private SettingsWindow settingsWindow;
        [SerializeField] private SettingsChangeConfirmationWindow settingsChangeConfirmationWindow;
        [SerializeField] private LevelSelectorWindow levelSelectorWindow;

        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(canvas);
            
            Container.BindKoboldUi(canvasInstance, WindowScope.Local)
                .RegisterWindow(mainMenuWindow)
                .RegisterWindow(settingsWindow)
                .RegisterWindow(settingsChangeConfirmationWindow)
                .RegisterWindow(levelSelectorWindow)
                .Build();

            Container.BindInterfacesTo<Bootstrap>().AsSingle().NonLazy(); // TODO: move this logic to other place
        }
    }
}
