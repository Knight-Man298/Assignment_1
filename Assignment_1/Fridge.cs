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
        public Fridge(string id, string brand, double quantity, double wattage, string color, double price, double capacity, string roomType, double height , double width , double numberOfDoors) : base(id, brand, quantity, wattage, color, price, capacity, roomType)
        {
            this.Height = height;
            this.Width = width;
            this.NumberOfDoors = numberOfDoors;
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
                Number Of Doors: {NumberOfDoors}
                """;
        }
    }
}
