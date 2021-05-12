using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisum.Demo
{
    public class Classicist : Painter
    {
        public Classicist(string name) : base(name)
        {
        }

        public sealed override void DrawPainting()
        {
            Console.WriteLine();
            base.DrawPainting();
            Console.WriteLine(" Classical painting!");
        }
    }
}
