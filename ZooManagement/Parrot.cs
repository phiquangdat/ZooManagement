using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    internal class Parrot: Animal, IFeedable
    {
        public string Vocabulary { get; set; }
        public Parrot(string name, int age, string vocabulary) : base(name, age)
        {
            Vocabulary = vocabulary;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Squawk");
        }
        public void Feed()
        {
            Console.WriteLine($"{Name} the parrot is being fed.");
        }
    }
}
