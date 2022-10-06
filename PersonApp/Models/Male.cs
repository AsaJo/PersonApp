using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Models
{
    public class Male : People
    {
        public string Beard { get; set; }
        public Male( string beard, string name, double weight, double height) : base(name, weight, height)
        {
            Beard= beard;
        }
    }
}
