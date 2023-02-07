using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Appliance
    {
        private string id;
        private string brand;
        private double quantity;
        private double wattage;
        private string color;
        private double price;
        private double capacity;
        private string roomType;

        public string ID { get => id; set => id = value; }
        public string Brand { get => brand; set => brand = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }
        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }

        public Appliance()
        {

        }

        public Appliance(string id, string brand, double quantity, double wattage, string color, double price, double capacity, string roomType)
        {
            this.Id = id;
            this.Brand = brand;
            this.Quantity = quantity;
            this.Wattage = wattage;
            this.Color = color;
            this.Price = price;
            this.Capacity = capacity;
            this.RoomType = roomType;
        }

        public static string ToString()
        {
            return $"""
                ID:
                Brand:
                Quantity:
                Wattage: 
                Color:
                Price: $
                Capacity:
                Room Type:
                """;
        }


    }
}
