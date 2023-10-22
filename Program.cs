namespace Labb_6___OOP_ARV
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Initiate all the different animals
			Animal dog = new Dog("backyard", "black", "labrador");
			Animal tiger = new Tiger();
			Animal cheeta = new Cheeta();
			Animal houseCat = new Housecat();
			Animal penguin = new Penguin();

			//Make all the animals speak
			tiger.MakeSound();
			dog.MakeSound();
			cheeta.MakeSound();
			houseCat.MakeSound();
			penguin.MakeSound();
		}
	}
}