using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Appliance
    {
        private long itemNumber;
        private string brand;
        private double quantity;
        private double wattage;
        private string color;
        private double price;
        private double capacity;

        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }

        public Appliance()
        {

        }

        public Appliance(long itemNumber, string brand, double quantity, double wattage, string color, double price)
        {
            this.ItemNumber = itemNumber;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = wattage;
            this.Color = color;
            this.Price = price;
        }

        public virtual string ToString()
        {
            return $"""
                Item Number: {ItemNumber}
                Brand: {Brand}
                Quantity: {Quantity}
                Wattage: {Wattage}
                Color: {Color}
                Price: ${Price}
                """;
        }

        public bool IsAvailable(bool itemAttribute)
        {
            if (itemAttribute == false) 
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public string CheckOut()
        {
            return string.Empty;
        }

        public string FormatForFile()
        {
            return $"{ItemNumber};{Brand};{Quantity};{Wattage};{Color};{Price}";
        }


    }
}
