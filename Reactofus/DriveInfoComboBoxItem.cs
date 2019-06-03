using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Reactofus
{
    public class DriveInfoComboBoxItem
    {
        public DriveInfo DriveInfo;
        public string OverrideString;

        public DriveInfoComboBoxItem(DriveInfo info)
            => DriveInfo = info;

        public DriveInfoComboBoxItem(string overrideString = "Choose a drive")
            => OverrideString = overrideString;

        public override string ToString()
        {
            // Text used for ComboBox

            if (DriveInfo == null) return OverrideString;

            if (DriveInfo.IsReady)
                return $"{DriveInfo.Name} - {DriveInfo.VolumeLabel} - {DriveInfo.DriveFormat} - {DriveInfo.TotalSize / 1024 / 1024} MB";
            else
                return $"{DriveInfo.Name} - Not Ready";
        }
    }
}
