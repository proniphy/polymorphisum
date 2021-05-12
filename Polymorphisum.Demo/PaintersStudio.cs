using System;
using System.Collections.Generic;

namespace Polymorphisum.Demo
{
    class PaintersStudio
    {
        static void Main(string[] args)
        {
            var newClassicist = new Classicist("Lorain");
            var newImpessionist = new Impresionist("Monet");
            var newNeoClassicist = new NeoClassicist("Mengs");
            var newPainer = new Painter("Vankata");

            List<Painter> groupOfPainters = new List<Painter>
            {
                newPainer,
                newClassicist,
                newImpessionist,
                newNeoClassicist
            };

            foreach (Painter currentPainter in groupOfPainters)
            {
                currentPainter.DrawPainting();
            }

            newImpessionist.GetMixture(22, 33);
            Console.WriteLine("Mixture is: {0}", newImpessionist.Mixer.Mixture);
        }
    }
}
