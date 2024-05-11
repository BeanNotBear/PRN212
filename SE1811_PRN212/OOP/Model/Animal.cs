using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Rate { get; set; }
        public int[] Rate2 { get; set; }
        public void Move() => Console.WriteLine("Move");

        public void Speak() => Console.WriteLine("baw, baw");
        public int this[int index]
        {
            get => this.Rate[index];
            set => this.Rate[index] = value;
        }
        public void InputInfo()
        {
            Console.WriteLine("Input id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input name: ");
            Name = Console.ReadLine();
        }
    }
}
