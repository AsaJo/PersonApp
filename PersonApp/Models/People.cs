using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Models
{
    public abstract class People
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weigth { get; set; }

        public People(string name,double weight, double height)
        {
            Name = name;
            Weigth=weight;
            Height = height;

        }

    }
}
