using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        private string v1;
        private string v2;
        private string v3;

        public Truck(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int BedSize { get; set; }
    public bool HasHitch { get; set; }
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Logo { get; set; } 
     public string Name { get; set; }
    public bool Starts { get; set; }
    }
 }
