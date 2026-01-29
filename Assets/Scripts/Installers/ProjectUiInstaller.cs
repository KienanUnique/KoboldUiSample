using KoboldUi.Utils;
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
            
            Container.BindWindowFromPrefab(canvasInstance, loadingWindow);
        }
    }
}