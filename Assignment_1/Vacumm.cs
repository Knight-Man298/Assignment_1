using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Vacumm : Appliance
    {
        private string grade;
        private double batteryVoltage;

        public string Grade { get => grade; set => grade = value; }
        public double BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }

        public Vacumm()
        {

        }

        public Vacumm(long itemNumber, string brand, double quantity, double wattage, string color, double price, string grade, double batteryVoltage)
        {
            this.Grade = grade;
            this.BatteryVoltage = batteryVoltage;
        }

        public string getVoltage(double voltageInput)
        {
            if (batteryVoltage == 18)
            {
                return "Low";
            }
            else if (batteryVoltage == 24)
            {
                return "High";
            }
            else
            {
                return  "Not availible";
            }

            
        }
       

        public override string ToString()
        {
            return $"""
                Item Number: {ItemNumber}
                Brand: {Brand}
                Quantity: {Quantity}
                Wattage: {Wattage}
                Color: {Color}
                Price: {Price}
                Grade: {Grade}
                Battery Voltage: {getVoltage(BatteryVoltage)}
                """;
        }


    }
} // Complete
