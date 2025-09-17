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
