using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisum.Demo
{
    internal class NeoClassicist : Classicist
    {
        public NeoClassicist(string name) : base(name)
        {
        }

        public new void DrawPainting()
        {
            Console.WriteLine($"{Name} draws a Neo Classical painting!");
        }
    }
}
