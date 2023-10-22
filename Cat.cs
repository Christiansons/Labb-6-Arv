using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	//Abstract class for cat species to inherit from
	internal abstract class Cat : Animal
	{

		protected Cat(bool dangerous, int numberOfLegs, string habitat, string color, string species) : base(dangerous, 4, habitat, color, species)
		{
		}
	}
}
