using KoboldUi.Windows;
using MainMenuScreen.Ui.LevelSelector.Selector;
using UnityEngine;

namespace MainMenuScreen.Ui.LevelSelector
{
    public class LevelSelectorWindow : AWindow
    {
        [SerializeField] private LevelSelectorView levelSelectorView;
        
        protected override void AddControllers()
        {
            AddController<LevelSelectorController, LevelSelectorView>(levelSelectorView);
        }
    }
}