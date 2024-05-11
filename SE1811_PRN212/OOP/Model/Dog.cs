using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Dog : Animal
    {
        public string color { get; set; }

        // using new for inheritance
        // using override for abstraction
        public new void Speak() => Console.WriteLine("Run");
        public void InputInfo()
        {
            base.InputInfo();
            Console.WriteLine("Input color: ");
            this.color = Console.ReadLine();
        }
    }
}
