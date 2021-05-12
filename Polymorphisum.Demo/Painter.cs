using System;
using System.Collections.Generic;
using System.Text;
using Encapsolation;

namespace Polymorphisum.Demo
{
    public class Painter
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        public Painter(string name)
        {
            Name = name;
        }
        public virtual void DrawPainting()
        {
            Console.Write($"{Name} draws ");
            //Console.WriteLine($"{Name} draw a painting!");
        }

    }
}
