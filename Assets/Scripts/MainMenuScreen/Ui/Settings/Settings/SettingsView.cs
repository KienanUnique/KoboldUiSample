using KoboldUi.Element.View;
using UnityEngine;
using UnityEngine.UI;

namespace MainMenuScreen.Ui.Settings.Settings
{
    public class SettingsView : AUiAnimatedView
    {
        [Header("Sounds")]
        public Slider soundVolume;
        public Slider musicVolume;
        
        [Header("Difficulty")]
        public Toggle easyModeToggle;

        [Header("Buttons")] 
        public Button applyButton;
        public Button cancelButton;
        public Button closeButton;
    }
}