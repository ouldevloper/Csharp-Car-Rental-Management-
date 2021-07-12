using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace GestionDeLocationVoiture.Control.Classes
{
    class Logs
    {
        public string User { get; set; }
        public DateTime Actiondate { get; set; }
        public string action { get; set; }
        public Logs(string a, DateTime b, string c)
        {
            User = a;
            Actiondate = b;
            action = c;
        }
    }
}
