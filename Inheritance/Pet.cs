using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Pause til 13.00 ;D
    abstract class Pet : Animal
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

        public abstract void Play();

        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a noise");
        }
    }
}
