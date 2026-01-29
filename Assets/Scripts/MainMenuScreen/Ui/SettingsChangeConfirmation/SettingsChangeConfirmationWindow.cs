using KoboldUi.Windows;
using MainMenuScreen.Ui.SettingsChangeConfirmation.SettingsChangeConfirmation;
using UnityEngine;

namespace MainMenuScreen.Ui.SettingsChangeConfirmation
{
    public class SettingsChangeConfirmationWindow : AWindow
    {
        [SerializeField] private SettingsChangeConfirmationView settingsChangeConfirmationView;
        
        protected override void AddControllers()
        {
            AddController<SettingsChangeConfirmationController, SettingsChangeConfirmationView>(settingsChangeConfirmationView);
        }
    }
}