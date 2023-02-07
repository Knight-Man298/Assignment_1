using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Vacumm : Appliance
    {
        private string grade;
        private double batteryVoltage;

        public string Grade { get => grade; set => grade = value; }
        public double BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }

        public Vacumm()
        {

        }

        public Vacumm(string id, string brand, double quantity, double wattage, string color, double price, string grade, double batteryVoltage)
        {
            this.grade = grade;
            this.batteryVoltage = batteryVoltage;
        }
    }
}
