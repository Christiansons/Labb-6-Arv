using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	internal class Housecat : Cat
	{
		//Unique property to check if its true that a cat is cute
        public bool Cute { get; set; }
        public Housecat() : base(false, 4, "woods", "varies", "housecat")
		{
			Cute = true;
		}

		//Overridden method to make sound
		public override void MakeSound()
		{
            Console.WriteLine("Mjauu");
        }

		//Unique method for housecat
		public void CatchMice()
		{
            Console.WriteLine("The cat catches a mouse");
        }
	}
}
