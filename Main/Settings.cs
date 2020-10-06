// ##########################################
// Solution: MakeFoldersSolution
// Project: TimelineMaker
// File: Settings.cs
// 
// Last User: Chris Hildebran
// Last Edit: 2019-02-03 7:47 AM
// ##########################################

using System.ComponentModel;
using System.Configuration;

namespace Timeline
{
          // This class allows you to handle specific events on the settings class:
          //  The SettingChanging event is raised before a setting's value is changed.
          //  The PropertyChanged event is raised after a setting's value is changed.
          //  The SettingsLoaded event is raised after the setting values are loaded.
          //  The SettingsSaving event is raised before the setting values are saved.
          internal sealed class Settings
          {
                    #region Methods

                    private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
                    {
                              // Add code to handle the SettingChangingEvent event here.
                    }


                    private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
                    {
                              // Add code to handle the SettingsSaving event here.
                    }

                    #endregion
          }
}