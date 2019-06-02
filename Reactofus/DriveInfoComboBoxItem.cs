using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Reactofus
{
    public class DriveInfoComboBoxItem
    {
        public DriveInfo DriveInfo;

        public DriveInfoComboBoxItem(DriveInfo info)
            => DriveInfo = info;

        public override string ToString()
            => DriveInfo != null 
            ? $"{DriveInfo.VolumeLabel} - {DriveInfo.Name} - {DriveInfo.DriveFormat} - {DriveInfo.TotalSize / 1024 / 1024}MB"
            : "Choose a drive";
    }
}
