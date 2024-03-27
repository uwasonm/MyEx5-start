using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MyEx5_start
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //List<Vehicle> vehicles = new List<Vehicle>();
            Vehicle vehicle = new Vehicle();


            int choice = Perform();
            while (choice != 0)
            {
                choice = Perform();
            }


            static int Perform()
            {
                int option = 0;
                Console.WriteLine("Enter your choice: 1 for PARKING, 2 for LEAVING the parking,   PARKING or 0 for EXITING the application");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            Console.WriteLine("PARKING");
                            //add the new vehicle "newvehicle" to the
                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine(" A vehicle is leaving");
                        }
                        break;

                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    default:
                        Console.WriteLine("Please provide a valid input (0, 1,or 2)");
                        break;
                }

                return option;
            }

            Console.ReadLine();
        }

          
     }
}

    

