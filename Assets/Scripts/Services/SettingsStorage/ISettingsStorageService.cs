using System;
using UniRx;
using Utils;

namespace Services.SettingsStorage
{
    public interface ISettingsStorageService
    {
        SettingsData CurrentSettings { get; }
        SettingsData? UnsavedSettings { get; }
        IObservable<Unit> UnsavedSettingsForgotten { get; }

        void ApplySettings(SettingsData settingsData);
        void RememberUnsavedSettings(SettingsData settingsData);
        void ApplyUnsavedSettings();
        void ForgetUnsavedSettings();
    }
}