﻿using System;
using System.Collections.Generic;
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
        public double Capacity { get => capacity; set => capacity = value; }

        public Appliance()
        {

        }

        public Appliance(long id, string brand, double quantity, double wattage, string color, double price)
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
                ID: {ItemNumber}
                Brand: {Brand}
                Quantity: {Quantity}
                Wattage: {Wattage}
                Color: {Color}
                Price: ${Price}
                """;
        }

        public bool IsAvailable()
        {
            return true;
        }

        public string CheckOut()
        {
            return string.Empty;
        }

        public string FormatForFile()
        {
            return $"";
        }


    }
}
