using System;

public class MainOrderingSystem
{
	static void Main(string[] args)
	{
		FurnitureFactory fFactory = null;

		string mappedChoice = null;

		do
		{
			Console.WriteLine("Please select a furniture set below: \n1) French\n2) Italian\n3) Japanese");

			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					mappedChoice = "FRENCH";
					break;
				case "2":
					mappedChoice = "ITALIAN";
					break;
				case "3":
					mappedChoice = "JAPANESE";
					break;
				default:
					break;
			}
		}
		while (mappedChoice == null);
		
		fFactory = FurnitureFactory.createFurnitureFactory(mappedChoice);
		fFactory.buildFurniture();
		Console.WriteLine("-----------------------");
		Console.WriteLine(fFactory.viewFurniture().getType() + " Furniture set is ready to be shipped.");
		Console.WriteLine("Contents:\nChair - " + fFactory.viewFurniture().getChair().getStyle() + 
			"\nTable - " + fFactory.viewFurniture().getTable().getStyle() +
			"\nSofa - " + fFactory.viewFurniture().getSofa().getStyle());

	}
}
