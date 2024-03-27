using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEx5_start
{
    //static List<Vehicle> VehicleList();
    internal class Vehicle : IVehicle
    {
        public string name { get; set; }
        public string numberplate { get; set; }
        public string color { get; set; }
        public int wheels { get; set; }

        public Vehicle()
        {
            name = string.Empty;
            numberplate = string.Empty;
            color = string.Empty;
            wheels = 0;
        }

        public Vehicle(string a, string b, string c, int d)
        {
            name = a;
            numberplate = b;
            color = c;
            wheels = d;
        }

        public void Park()
        {
            Console.WriteLine("A new vehicle is parked.");
            //VehicleList.Add(newVehicle)  
            Vehicle vehicle = new Vehicle();
            string theNumberPlate = " ";
            Console.WriteLine("What is the \"name\" of vehicle parking ?");
            vehicle.name = Console.ReadLine();
            Console.WriteLine("What is the \"number plate\" ?");
            theNumberPlate = Console.ReadLine();
            vehicle.numberplate = theNumberPlate.ToUpper();
            Console.WriteLine("What is the  vehicle's \"color\" ?");
            vehicle.color = Console.ReadLine();
            Console.WriteLine("How many \"wheels\" does the vehicle has?");
            vehicle.wheels = int.Parse(Console.ReadLine());

            Console.WriteLine($" The parked vehicle is a " + vehicle.color, vehicle.name, vehicle.numberplate, vehicle.wheels);

            //static List<Vehicle> VehicleList();
        }
        public string Display()
        {
            return "Colour:" + color + "Name: " + name + "Number: " + numberplate + " with " + wheels + " wheels.";
        }

        public int Count()
        {
            ////Count all parked cars 
            int number = 0;
            //foreach (Vehicle item in Vehicle)
            //{
            //    Console.WriteLine(item);
            //    number += number;
            //}
            return number;
        }
        public void Leave()
        {
            Console.WriteLine("A vehicle is leaving the parking.");
            //search for the vehicle location in the garage using its number plate,
            //capture its location index,
            //remove a vehicle anywhere on the list using the capture location index
        }

        public void Find()
        {
            {
                // Search for the numberplate and display its location in the list. 
                // if plate = Vehicle.numberplate, display the location index 
                string theNplate = " ";
               
                Console.WriteLine("Provide the numberplate of the vehicle");
                theNplate = Console.ReadLine();
                string plate = theNplate.ToUpper();
               // IEnumerable<Vehicle> vehicleQuery = from vehicle in vehicles where numberplate = plate select vehicle;
              //    { Console.WriteLine($"{Vehicle.index}"); }


            }
        }


        public void SearchQuery()
        {
            //use LINQ to search for a set of vehicles
            int number = 0;
           // IEnumerable<Vehicle> vehicleQuery = from vehicle in vehicles where wheels=4 select vehicle;
            //foreach (Vehicle vehicle in vehiclesQuery)
            { Console.WriteLine($" vehicle found is {numberplate}");
               number += 1;
            }
        }



        class Airplane : Vehicle
        {
            public int engines = 4;
        }
        class Motorcycle : Vehicle
        {
            public int length = 2;
        }

        class Car : Vehicle
        {
            public int cylinders = 6;
        }
        class Bus : Vehicle
        {
            public int seats = 45;
        }
        class Boat : Vehicle
        {
            public string fueltype = "Gasoline";
        }
    }
}
