using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Fridge : Appliance
    {
        private double height;
        private double width;
        private double numberOfDoors;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }
        public double NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }

        public Fridge()
        {
        }
        public Fridge(long itemNumber, string brand, double quantity, double wattage, string color, double price, double height , double width , double numberOfDoors) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfDoors = numberOfDoors;
        }

        public string getNumberOfDoors(double inputnumberofdoors)
        {
            if (inputnumberofdoors == 2)
            {
                return "Two Doors";
            }
            else if (inputnumberofdoors == 3)
            {
                return "Three Doors";
            }
            else if (inputnumberofdoors == 4)
            {
                return "Four Doors";
            }
            else
            {
                return "Not avaliable";
            }
        }

        public override string ToString()
        {
            return $"""
                ID: {ItemNumber}
                Brand: {Brand}
                Quantity: {Quantity}
                Wattage: {Wattage}
                Color: {Color}
                Price: ${Price}
                Height: {Height}
                Width: {Width}
                Number Of Doors: {getNumberOfDoors(NumberOfDoors)}
                """;
        }
    }
} // Complete
