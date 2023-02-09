using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Dishwasher : Appliance
    {
        private string soundrating;
        private string feature;

        public string Soundrating { get => soundrating; set => soundrating = value; }
        public string Feature { get => feature; set => feature = value; }

        public Dishwasher()
        {

        }

        public Dishwasher(long itemNumber, string brand, double quantity, double wattage, string color, double price, string soundrating, string feature) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Soundrating = soundrating;
            this.Feature = feature;
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
                SoundRating: {Soundrating}
                Feture: {Feature}
                """;
        }
    }
}
