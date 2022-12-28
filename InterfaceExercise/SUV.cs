using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }

        public bool BikeRack { get; set; }
        public int CargoSize { get; set; }
        public int Year { get; set; }
       public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

       public bool Starts { get; set; }
    
    }
}