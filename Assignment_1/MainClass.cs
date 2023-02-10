using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    internal class MainClass
    {

        static List<Appliance> appliances = new List<Appliance>();

        public string CheckoutAppliance(long input)

        {
            string output;

            foreach (Appliance x in appliances)
            {
                if (x.ItemNumber == input)
                {
                    if (x.Quantity > 0)
                    {
                        output = "Appliance " + input + " has been checked out ";
                    }

                    else
                    {
                        output = "The appliance is not available to be checked out";
                    }
                }

                else
                {
                    output = "No appliance found with that item number";
                }
            }
            return output;

            //i hate this
            //bruh


        }
        public static void AddAppliances()
        {

            string[] path = File.ReadAllLines("C:\\Users\\msimm\\Desktop\\Semester 2\\OOP2\\Assignments\\Assignment_1\\Assignment_1\\resource\\appliances.txt");
            foreach (string appliance in path)
            {
                string[] position = appliance.Split(";");
                string identification = position[0];
                char firstChar = identification[0];

                if (firstChar == '1')
                {
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
;                }
                else if (firstChar == '2')
                {
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
                }
                else if (firstChar == '3')
                {
                    Microwave microwave= new Microwave();
                    microwave.ItemNumber= long.Parse(position[0]);
                    microwave.Brand = position[1];
                    microwave.Quantity = double.Parse(position[2]);
                    microwave.Wattage = double.Parse(position[3]);
                    microwave.Color = position[4];
                    microwave.Price = double.Parse(position[5]);

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
                    Console.WriteLine("Enter item number of Appliance:");
                    long itemNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine(CheckoutAppliance((itemNumber));

                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter brand to search for:");
                    string brand = Console.ReadLine();
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
                            int doors = int.Parse(Console.ReadLine());
                            Doors(doors);
                        }
                        else if (type == "2")
                        {

                        }
                        else if (type == "3")
                        {

                        }
                        else if (type == "4")
                        {

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
                    for (int index = 0; index < numberOfAppliances; index++)
                    { 
                       // print random appliances depending on the number entered
                    }
                }
                else
                {
                    break;
                }
 
            }
        }
    }
}
