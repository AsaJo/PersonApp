using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Models
{
    public class FeMale : People
    {

        public string Boobs { get; set; }
        public FeMale(string boobs, string name, double weight, double height) : base(name, weight, height)
        {
            Boobs = boobs;
        }
    }
}
