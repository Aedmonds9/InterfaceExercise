using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
      public bool RemoteStart { get; set; }
      public int NumberOfdoors { get; set; }
        public string Model { get; }
        int IVehicle.Year { get; set; }
        string IVehicle.Make { get; set; }
        string IVehicle.Model { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public bool Starts { get; set; }

        public Car(string model, string v, string v1)
        {
            Model = model;
        }
    }
}
