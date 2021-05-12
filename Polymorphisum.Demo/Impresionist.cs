using Encapsolation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphisum.Demo
{
    public class Impresionist : Painter
    {
        public ColorMixer Mixer { get; set; }

        public Impresionist(string name) : base(name)
        {
            Mixer = new ColorMixer();
        }

        public override void DrawPainting()
        {
            //base.DrawPainting();
            Console.WriteLine($"{Name} draw an impression!");
        }
 
        public int GetMixture(int color1, int color2)
        {
            Mixer.Mixture = color1 + color2;

            return Mixer.Mixture;
        }
    }
}
