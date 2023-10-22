using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	internal class Dog : Animal
	{
		//Unique member for dog class
		public string Breed {  get; set; }

		//Constructor for initiating a dog
        public Dog(string habitat, string color,string breed) : base(false, 4, habitat, color, "Dog")
        {
            Color = color;
            Habitat = habitat;
			Breed = breed;
        }

		//Unique method that tames the dog
		public void Tame()
		{
            Console.WriteLine("The dog is tamed");
        }

		//Overridden method that makes a dog sound
		public override void MakeSound()
		{
            Console.WriteLine("Woff!");
        }
	}
}
