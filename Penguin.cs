using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	internal class Penguin : Animal
	{
		//Property for penguin
		public bool CanSwim {  get; set; }

		//Constructor to initiate a penguin
		public Penguin() : base(false, 2, "glaciers", "black and white", "penguin")
		{
			CanSwim = true;
		}

		//Unique sound for a penguin
		public override void MakeSound()
		{
            Console.WriteLine("Squeak");
        }

		//Method for making a penguin swin
		public void Swim()
		{
            Console.WriteLine("The penguin dives into the water");
        }
	}
}
