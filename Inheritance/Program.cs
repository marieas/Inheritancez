using System;

namespace Inheritance
{
    //Virtual
    //Abstract
    //override
    internal class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();
            cat.Sound();
            dog.Sound();
        }
    }
}
