using System;
using System.Collections.Generic;
using System.Text;

namespace TanksConsoleApp.Models
{
    public class Tank
    {
        public const string[] tankTypes = { 
            "Main Battle Tank", 
            "Heavy Tank", 
            "Medium Tank", 
            "Light Tank", 
            "Tank Destroyer", 
            "Artillery Tank", 
            "Other" 
        };
        int typeIndex;
        public int TypeIndex
        {
            get { return typeIndex; }
            set
            {
                if (value >= 0 && value <= tankTypes.Length)
                {
                    typeIndex = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("TypeIndex must be within range of 0 to " + tankTypes.Length);
                }
            } 
        }
        public string Type { get { return tankTypes[typeIndex]; } }
        public string Designation { get; set; }
        public Country Country { get; set; }
        public string Designer { get; set; }
        public int Designed { get; set; }
        public string Manufacturer { get; set; }
        public double Mass { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Crew { get; set; }
        public Cannon MainArmament { get; set; }
        public int AmmoCapacity { get; set; }
    }
}
