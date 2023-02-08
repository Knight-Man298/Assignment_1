using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class MainClass
    {
        static List<Appliance> appliances = new List<Appliance>();
        public static void AddAppliances()
        {

            string[] path = File.ReadAllLines("C:\\Users\\msimm\\Desktop\\Semester 2\\OOP2\\Assignments\\Assignment_1\\Assignment_1\\resource\\appliances.txt");
            foreach (string appliance in path)
            {
                string[] position = appliance.Split(":");
                string identification = position[0];
                char firstChar = identification[0];

                if (firstChar == '1' || firstChar == '2' || firstChar == '3' || firstChar == '4')
                {

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
                    string itemNumber = Console.ReadLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Enter brand to search for:");
                    string brand = Console.ReadLine();
                    /* create a ToString() method that
                     * prints all the information */
                }
                else if (input == "3")
                {
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
