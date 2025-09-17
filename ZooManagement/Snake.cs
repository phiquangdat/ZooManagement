using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    internal class Snake: Animal, IFeedable
    {
        public bool IsVenomous { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Hiss");
        }
        public void Feed()
        {
            Console.WriteLine($"{Name} the snake is being fed.");
        }
    }
}
