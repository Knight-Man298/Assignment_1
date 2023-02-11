using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Math;

namespace Assignment_1
{
    internal class MainClass
    {

        static List<Appliance> appliances = new List<Appliance>();

        public static string CheckoutAppliance(long input)
        {
            string output = "";
            foreach (Appliance appliance in appliances)
            {
                
                if (appliance.ItemNumber == input)
                {
                    output = $"Appliance {input} has been checked out. \n";
                    return output;
                }
                else if (appliance.Quantity == 0)
                {
                    output = "The appliance is not available to be checked out. \n";
                }
                else
                {
                    output = "No appliances found with that item number. \n";
                    return output;
                }
            }
            return output;
        }
        public static void SearchBrandByName(string input)
        { // ONLY PRINTS LAST INSTANCE, NEEDS TO PRINT ALL INSTANCES
            List<Appliance> CalledAppliances = new List <Appliance>();
            string output = "";
            foreach (Appliance appliance in appliances)
            {
                if (appliance.Brand == input)
                {
                    CalledAppliances.Add(appliance);
                    output = $"Matching Appliances: \n";
                continue;
                    
                }
                else
                {
                    output = "No appliances found with that item number. \n";
                    continue;
                }
            }
            Console.WriteLine(output);
            foreach(Appliance x in CalledAppliances)
            {
                Console.WriteLine(x.ToString());
            }
                        
        }
        public static void DisplayApplianceByType(string input)
        {
            string output = "";
            foreach(Appliance appliance in appliances)
            {
                if (appliance is Fridge)
                {
                    string numberDoor = Convert.ToString(((Fridge)appliance).NumberOfDoors);
                    if (numberDoor == input)
                    {
                        Console.WriteLine(appliance.ToString());
                    }
                  
                else if(appliance is Vacumm)
                    {
                        string volts = Convert.ToString(((Vacumm)appliance).BatteryVoltage);
                        if (volts == input)
                        {
                            Console.WriteLine(appliance.ToString());
                        }
                    }
                    else
                    {
                        continue;
                    }   
                }

            }
        }

        public static void AddAppliances()
        {

            string[] path = File.ReadAllLines("/Users/sk/Documents/sem2/OOP2/Assigment/Assigment#1/Assignment_1/Assignment_1/resource/appliances.txt");
            foreach (string appliance in path)
            {
                string[] position = appliance.Split(";");
                string identification = position[0];
                char firstChar = identification[0];

                switch (firstChar)
                {
                    case '1':
                        Fridge fridge = new Fridge();
                        fridge.ItemNumber = long.Parse(position[0]);
                        fridge.Brand = position[1];
                        fridge.Quantity = double.Parse(position[2]);
                        fridge.Wattage = double.Parse(position[3]);
                        fridge.Color = position[4];
                        fridge.Price = double.Parse(position[5]);
                        fridge.NumberOfDoors = double.Parse(position[6]);
                        fridge.Height = double.Parse(position[7]);
                        fridge.Width = double.Parse(position[8]);

                        appliances.Add(fridge);
                        break;

                    case '2':

                        Vacumm vacumm = new Vacumm();
                        vacumm.ItemNumber = long.Parse(position[0]);
                        vacumm.Brand = position[1];
                        vacumm.Quantity = double.Parse(position[2]);
                        vacumm.Wattage = double.Parse(position[3]);
                        vacumm.Color = position[4];
                        vacumm.Price = double.Parse(position[5]);
                        vacumm.Grade = position[6];
                        vacumm.BatteryVoltage = double.Parse(position[7]);

                        appliances.Add(vacumm);
                        break;

                    case '3':
                        Microwave microwave = new Microwave();
                        microwave.ItemNumber = long.Parse(position[0]);
                        microwave.Brand = position[1];
                        microwave.Quantity = double.Parse(position[2]);
                        microwave.Wattage = double.Parse(position[3]);
                        microwave.Color = position[4];
                        microwave.Price = double.Parse(position[5]);
                        microwave.Capacity = double.Parse(position[6]);
                        microwave.RoomType = position[7];

                        appliances.Add(microwave);
                        break;
                    case '4': case '5':
                        Dishwasher dishwasher = new Dishwasher();
                        dishwasher.ItemNumber= long.Parse(position[0]);
                        dishwasher.Brand = position[1];
                        dishwasher.Quantity = double.Parse(position[2]);
                        dishwasher.Wattage = double.Parse(position[3]);
                        dishwasher.Color = position[4];
                        dishwasher.Price = double.Parse(position[5]);
                        dishwasher.Feature = position[6];
                        dishwasher.Soundrating = position[7];
                        

                        appliances.Add(dishwasher);
                        break;
                }
            }
           
        }

        public static int Doors(int input)
        {
            if (input == 2)
            {

            }
            else if (input == 3) {
                
            }
            else if (input == 4)
            {

            }
            return 0;
        }

        public static void Main()
        {
            AddAppliances();
            while (true)
            {
                Console.WriteLine("Welcome to Modern Appliances!");
                Console.WriteLine("""
                    How may we assist you?
                    1 – Check out appliance
                    2 – Find appliances by brand
                    3 – Display appliances by type
                    4 – Produce random appliance list
                    5 – Save & exit
                    Enter option:

                    """);
                
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("\nEnter item number of Appliance:\n");
                    long itemNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine(CheckoutAppliance(itemNumber));
                    
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter brand to search for:");
                    string brand = Console.ReadLine();
                    SearchBrandByName(brand);
                    
                }
                else if (input == "3")
                {
                    while (true) {
                        Console.WriteLine("""
                            Appliance Types
                            1 – Refrigerators
                            2 – Vacuums
                            3 – Microwaves
                            4 – Dishwashers
                        
                            Enter type of appliance:
                            """);
                        string type = Console.ReadLine();

                        if (type == "1")
                        {
                            Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):");
                            string doors = (Console.ReadLine());
                            foreach (Appliance appliance in appliances)
                            {
                                if (appliance is Fridge)
                                {
                                    string numberDoor = Convert.ToString(((Fridge)appliance).NumberOfDoors);
                                    if (numberDoor == input)
                                    {
                                        Console.WriteLine(appliance.ToString());
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                        else if (type == "2")
                        {
                            Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
                            string volts = (Console.ReadLine());
                            //DisplayApplianceByType(v);
                            foreach (Appliance appliance in appliances)
                            {
                                if (appliance is Vacumm)
                                {
                                    string volt = Convert.ToString(((Vacumm)appliance).BatteryVoltage);
                                    if (volts == volt)
                                    {
                                        Console.WriteLine(appliance.ToString());
                                    }
                                }
                                else
                                {
                                    continue;
                                }

                            }
                        }
                        else if (type == "3")
                        {
                            Console.WriteLine("Room where the mircowave will be installed: K (kitchen) or W (work site)");
                            string locationinput = (Console.ReadLine());
                            foreach (Appliance appliance in appliances)
                            {
                                if (appliance is Microwave)
                                {
                                    string location = ((Microwave)appliance).RoomType;
                                    if (locationinput == location)
                                    {
                                        Console.WriteLine(appliance.ToString());
                                    }
                                }
                                else
                                {
                                    continue;
                                }

                            }
                        }
                        else if (type == "4")
                        {
                            Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu (Quiet) or M (Moderate)");
                            string locationinput = (Console.ReadLine());
                            foreach (Appliance appliance in appliances)
                            {
                                if (appliance is Dishwasher)
                                {
                                    string location = ((Dishwasher)appliance).Soundrating;
                                    if (locationinput == location)
                                    {
                                        Console.WriteLine(appliance.ToString());
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            }
                        else
                        {
                            break;
                        }
                    }

                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter number of appliances:");
                    int numberOfAppliances = int.Parse(Console.ReadLine());

           
                }
                else
                {
                    break;
                }
 
            }
        }
    }
}
