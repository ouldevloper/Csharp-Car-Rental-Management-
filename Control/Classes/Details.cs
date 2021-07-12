using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLocationVoiture.Control.Classes
{
    class Details
    {
        public string Name { get; set; }
        public string Matricule { get; set; }
        public string Model { get; set; }
        public string color { get; set; }
        public int NemberOfDays { get; set; }
        public float Price { get; set; }
        public float Count { get; set; }
        public Details(string a,string b,string c,string d,int e,float f,float g)
        {
            Name = a;
            Matricule = b;
            Model = c;
            color = d;
            NemberOfDays = e;
            Price = f;
            Count = g;
        }
    }
}
