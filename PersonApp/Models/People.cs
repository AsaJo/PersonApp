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

        // ctrl + D = Duplicate line
        // cw = Console.WriteLine
        // prop = property
        // ctor = constructor
        // Mark file use del/delete to delete file
        // F5 debug
        // ctrl + F6 = Window like alt tab
        // ctrl tab = shift between tabs
        // ctrl + s Save your stuff
        // ctrl + shift b build
        // ctrl F12 Explains things
        // Declared variable = F12
        // ctrl +k +f = format code
        // alt + arrows up down mark your code
        // mark the line arrow up and down
        // ctrl + left right
        // alt + ctrl + click = to have multiple cursors
        // ctrl + c copy
        // ctrl + x cutting out
        // ctrl + v paste
        // ctrl + a mark All 
        // ctrl + z = undo
        // ctrl + y = redo
        // alt + f4 = close latest window
        // ctrl + r + r rename actually references word one class
        // ctrl + f search the text.




    }
}
