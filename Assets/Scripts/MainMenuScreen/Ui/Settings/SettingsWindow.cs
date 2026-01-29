using KoboldUi.Windows;
using MainMenuScreen.Ui.Settings.Settings;
using UnityEngine;

namespace MainMenuScreen.Ui.Settings
{
    public class SettingsWindow : AWindow
    {
        [SerializeField] private SettingsView settingsView;

        protected override void AddControllers()
        {
            AddController<SettingsController, SettingsView>(settingsView);
        }
    }
}