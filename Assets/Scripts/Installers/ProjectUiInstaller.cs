using KoboldUi.Composition;
using KoboldUi.Composition.Zenject;
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
        
        [Header("Windows")]
        [SerializeField] private LoadingWindow loadingWindow;

        public override void InstallBindings()
        {
            var canvasInstance = Instantiate(canvas);
            DontDestroyOnLoad(canvasInstance);
            
            Container.BindKoboldUi(canvasInstance, WindowScope.Project)
                .RegisterWindow(loadingWindow)
                .Build();
        }
    }
}
