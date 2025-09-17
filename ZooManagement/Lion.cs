using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    internal class Lion: Animal, IFeedable
    {
        public bool IsAlpha { get; set; }
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
        public void Feed()
        {
            Console.WriteLine($"{Name} the lion is being fed.");
        }
    }
}
