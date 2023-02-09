﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Microwave : Appliance
    {
        private double capacity;
        private string roomType;

        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }

        public Microwave()
        {

        }

        public Microwave(long itemNumber, string brand, double quantity, double wattage, string color, double price, double capacity, string roomType)
        {
            this.capacity = capacity;
            this.roomType = roomType;
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
                Capacity: {Capacity}
                Room Type: {RoomType}
                """;
<<<<<<< HEAD
        }    }
=======
        }
    }
>>>>>>> 2259f3bd223db1fc40ea8fdd2dcfe81e81fc5a85
}
