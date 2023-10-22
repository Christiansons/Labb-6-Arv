using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	internal abstract class Animal
	{
		//5 properties that all animals share
		public bool Dangerous {  get; set; }
		public int NumberOfLegs {  get; set; }
		public string Habitat {  get; set; }
		public string Color { get; set; }
		public string Species {  get; set; }

		//Constructor that all child-classes need to implement
		public Animal(bool dangerous, int numberOfLegs, string habitat, string color, string species) 
		{
			Dangerous = dangerous;
			NumberOfLegs = numberOfLegs;
			Habitat = habitat;
			Color = color;
			Species = species;
		}
		
		//Abstract method for an animals sound
		public abstract void MakeSound();

		//Method that makes animal attack
		public void Attack()
		{
			if (Dangerous)
			{
				Console.WriteLine($"The {Species} viciously attacks");
			}
			else
			{
				Console.WriteLine($"The {Species} playfully attacks");
			}
		}

		//Method for making an animal play
		public void Play()
		{
            Console.WriteLine($"The {Species} plays in its natural habitat of {Habitat}");
        }

		//prints info about an animal
		public void Info()
		{
            Console.WriteLine($"The {Species} is an animal with {NumberOfLegs} legs. Its color: {Color}, its usual habitat is: {Habitat}. Dangerous: {Dangerous}.");
        }
		
		
	}
}
