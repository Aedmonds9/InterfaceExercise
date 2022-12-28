using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;

namespace InterfaceExercise
{
    class Program
    {
        public static string Year { get; private set; }
        public static string Make { get; private set; }
        public static string Model { get; private set; }

        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - DONE

            //Create 3 classes called Car , Truck , & SUV - DONE

            //In your IVehicle - DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */

            //DONE

            //In ICompany - DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //DONE

            //In each of your car, truck, and suv classes 

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //DONE

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Truck truck = new Truck(Year = "2002", Make = "Chevy", Model = "Silverado");
            Car car = new Car(Model = "Chevy", Make = "Cruze", Year = "2019");
                  
                
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(car); 
            vehicles.Add(truck);

            foreach (IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year:{vehicle.Year} Make:{vehicle.Make} Model:{vehicle.Model}  Starts:{vehicle.Starts}");
            }

        }
    }
}

