using System;
using TanksConsoleApp.Models;

namespace TanksConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank m1Abrams = new Tank() 
            { 
                Country = Country.USA, 
                TypeIndex = 0, 
                Designation = "M1 Abrams", 
                Designer = "Chrysler Defense (now General Dynamics Land Systems)", 
                Designed = 1972,
                Manufacturer = "Lima Army Tank Plant (since 1980)",
                Mass = 60,
                Length = 9.77,
                Width = 3.66,
                Height = 2.44,
                Crew = 4,
                AmmoCapacity = 40,
                MainArmament = new Cannon() { Designation = "Rheinmetall Rh-120", Caliber=120, MaxRange =8000, ShellVelocity=1750 }
            };
        }
    }
}
