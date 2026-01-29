using KoboldUi.Windows;
using MainMenuScreen.Ui.MainMenu.Menu;
using MainMenuScreen.Ui.MainMenu.Title;
using UnityEngine;

namespace MainMenuScreen.Ui.MainMenu
{
    public class MainMenuWindow : AWindow
    {
        [SerializeField] private MainMenuView mainMenuView;
        [SerializeField] private TitleView titleView;
        
        protected override void AddControllers()
        {
            AddController<MainMenuController, MainMenuView>(mainMenuView);
            AddController<TitleController, TitleView>(titleView);
        }
    }
}