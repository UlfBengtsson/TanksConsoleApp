using System;
using System.Collections.Generic;
using System.Text;

namespace TanksConsoleApp.Models
{
    public class Cannon
    {
        public string Designation { get; set; }
        public double Caliber { get; set; }
        public double ShellVelocity { get; set; }
        public int MaxRange { get; set; }
        public int ClipSize { get; set; }
        public double IntraClipReload { get; set; }
        public double ReloadSpeed { get; set; }

    }
}
