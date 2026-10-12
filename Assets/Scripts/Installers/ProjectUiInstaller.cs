using KoboldUi.Composition;
using KoboldUi.Composition.Zenject;
using KoboldUi.Element.Animations;
using KoboldUi.Services.WindowsService;
using Ui.LoadingWindow;
using UnityEngine;
using Zenject;

namespace Installers
{
    [CreateAssetMenu(fileName = nameof(ProjectUiInstaller), menuName = "Simple Sample/" + nameof(ProjectUiInstaller), order = 0)]
    public class ProjectUiInstaller : ScriptableObjectInstaller
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private UiAnimationDefaults animationDefaults;
        
        [Header("Windows")]
        [SerializeField] private LoadingWindow loadingWindow;

        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(canvas);
            DontDestroyOnLoad(canvasInstance);
            
            var ui = Container.BindKoboldUi(canvasInstance, WindowScope.Project,
                animationDefaults: animationDefaults);
            ui.RegisterWindow(loadingWindow, WindowScope.Project);
        }
    }
}
