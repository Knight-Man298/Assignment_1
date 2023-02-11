using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Dishwasher : Appliance
    {
        private string feature;
        private string soundrating;
     

        public string Feature { get => feature; set => feature = value; }
        public string Soundrating { get => soundrating; set => soundrating = value; }

        public Dishwasher()
        {

        }

        public Dishwasher(long itemNumber, string brand, double quantity, double wattage, string color, double price,string feature, string soundrating) : base(itemNumber, brand, quantity, wattage, color, price)
        {
            this.Soundrating = soundrating;
            this.Feature = feature;
        }

        public string getSoundRating(string inputSoundRating)
        {
            if( inputSoundRating == "Qt")
            {
                return "Quietest";
            }
            else if ( inputSoundRating == "Qr")
            {
                return "Quieter";
            }
            else if (inputSoundRating == "Qu")
            {
                return "Quiet";
            }
            else if (inputSoundRating == "M")
            {
                return "Moderate";
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
                Feture: {Feature}
                SoundRating: {getSoundRating(Soundrating)}                
                """;
        }
    }
}
