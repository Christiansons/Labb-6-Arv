using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	//Tiger class that inherits from the cat class
	internal class Tiger : Cat
	{
		//unique property to set a tigers biteforce
        public int BiteForce { get; set; }

		//Constructor to initiate a tiger
        public Tiger() : base(true, 4, "jungle", "black and orange striped", "Tiger")
		{	
			BiteForce = 1050;
		}

		//Method that makes the tiger bite
		public void Bite()
		{
            Console.WriteLine("The tiger chomps down with a biteforce of {0} psi", BiteForce);
        }

		//Overridden method for a tigers sound
		public override void MakeSound()
		{
            Console.WriteLine("Roaar!");
        }
	}
}
