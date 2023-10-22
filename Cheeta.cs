using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_6___OOP_ARV
{
	internal class Cheeta : Cat
	{
        //Unique property to set the speed of a cheeta
        public int speed {  get; set; }
        public Cheeta() :base(true, 4, "African plains", "Orange/black striped", "Cheeta")
        {
            speed = 120;
        }

        //Overridden method for the cheetas sound
        public override void MakeSound()
		{
            Console.WriteLine("Hiss!");
        }

        public void Hunt()
        {
            Console.WriteLine("The cheeta hunts down its prey with the incredible speed of {0} km/h", speed);
        }
	}
}
