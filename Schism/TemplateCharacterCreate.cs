using System;

namespace Schism
{
	class TemplateCharacterCreate
	{

		public static void Template(int i) // and not (string[] args)? why not?

			{
				//Ints:
				int correct = 0;
				int Player_One_Handed = 0;
				int Player_Two_Handed = 0;
				int Player_Ranged_Weapon = 0;
				int Player_Magic = 0;
				int Arraycount = 0;



				//Strings:
				string Gender;
				string Race;
				string Class;
				string[] Inventory = new string[20];
				string Input;

				//Character Creation:

				do
				{
					Console.Clear();
					Console.WriteLine("Please choose a gender as below:");
					Console.WriteLine("Male / Female");
					Gender = Console.ReadLine().ToUpper();
					if (Gender == "MALE" || Gender == "FEMALE")
					{
						correct = 1;
					}
					else { }
				} while (correct == 0);
				correct = 0;




				//Race Creation:
				do
				{
					Console.Clear();
					Console.WriteLine("Please choose a race as below:");
					Console.WriteLine("Human");
					Console.WriteLine("Dwarf");
					Console.WriteLine("Elf");
					Console.WriteLine("Orc");
					Console.WriteLine("Your Choice:");
					Race = Console.ReadLine().ToUpper();
					if (Race == "HUMAN")
					{
						Console.WriteLine("This race gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 1 Point");
						Console.WriteLine("Two Handed Weapons. 1 Point");
						Console.WriteLine("Ranged Weapons. 1 Point");
						Console.WriteLine("Magical Attack. 1 Point");
						Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}

					if (Race == "DWARF")
					{
						Console.WriteLine("This race gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 1 Point");
						Console.WriteLine("Two Handed Weapons. 2 Point");
						Console.WriteLine("Ranged Weapons. 1 Point");
						Console.WriteLine("Magical Attack. 0 Point");
						Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}

					if (Race == "ELF")
					{
						Console.WriteLine("This race gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 0 Point");
						Console.WriteLine("Two Handed Weapons. 1 Point");
						Console.WriteLine("Ranged Weapons. 2 Point");
						Console.WriteLine("Magical Attack. 1 Point");
						Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}

					if (Race == "ORC")
					{
						Console.WriteLine("This race gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 2 Point");
						Console.WriteLine("Two Handed Weapons. 2 Point");
						Console.WriteLine("Ranged Weapons. 0 Point");
						Console.WriteLine("Magical Attack. 0 Point");
						Console.WriteLine("Is this the race you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}
				} while (correct == 0);
				correct = 0;




				//Class Creation:
				do
				{
					Console.Clear();
					Console.WriteLine("Please choose a class as below:");
					Console.WriteLine("Warrior");
					Console.WriteLine("Hunter");
					Console.WriteLine("Mage");
					Console.WriteLine("Thief");
					Console.WriteLine("Your Choice:");
					Class = Console.ReadLine().ToUpper();
					if (Class == "WARRIOR")
					{
						Console.WriteLine("This class gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 2 Point");
						Console.WriteLine("Two Handed Weapons. 2 Point");
						Console.WriteLine("Ranged Weapons. 0 Point");
						Console.WriteLine("Magical Attack. 0 Point");
						Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}
					if (Class == "HUNTER")
					{
						Console.WriteLine("This class gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 1 Point");
						Console.WriteLine("Two Handed Weapons. 1 Point");
						Console.WriteLine("Ranged Weapons. 2 Point");
						Console.WriteLine("Magical Attack. 0 Point");
						Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}
					if (Class == "MAGE")
					{
						Console.WriteLine("This class gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 1 Point");
						Console.WriteLine("Two Handed Weapons. 0 Point");
						Console.WriteLine("Ranged Weapons. 1 Point");
						Console.WriteLine("Magical Attack. 2 Point");
						Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}
					if (Class == "THIEF")
					{
						Console.WriteLine("This class gives a bonus to the following stats:");
						Console.WriteLine("One Handed Weapons. 2 Point");
						Console.WriteLine("Two Handed Weapons. 0 Point");
						Console.WriteLine("Ranged Weapons. 1 Point");
						Console.WriteLine("Magical Attack. 1 Point");
						Console.WriteLine("Is this the class you wish to play? Enter Yes/No Below:");
						Input = Console.ReadLine().ToUpper();
						if (Input == "YES")
						{
							correct = 1;
						}
						if (Input == "NO")
						{
							correct = 0;
						}
					}
					else { }
				} while (correct == 0);
				correct = 0;

				//Bonuses:
				//Race Bonus:
				if (Race == "HUMAN")
				{
					Player_One_Handed++;
					Player_Two_Handed++;
					Player_Ranged_Weapon++;
					Player_Magic++;
				}
				if (Race == "DWARF")
				{
					Player_One_Handed++;
					Player_Two_Handed = Player_Two_Handed + 2;
					Player_Ranged_Weapon++;
				}
				if (Race == "ELF")
				{
					Player_One_Handed++;
					Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
					Player_Magic++;
				}
				if (Race == "ORC")
				{
					Player_One_Handed = Player_One_Handed + 2;
					Player_Two_Handed = Player_Two_Handed + 2;
				}

				//Class Bonus:
				if (Class == "WARRIOR")
				{
					Player_One_Handed = Player_One_Handed + 2;
					Player_Two_Handed = Player_Two_Handed + 2;
				}
				if (Class == "HUNTER")
				{
					Player_One_Handed++;
					Player_Two_Handed++;
					Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
				}
				if (Class == "MAGE")
				{
					Player_One_Handed++;
					Player_Ranged_Weapon++;
					Player_Magic = Player_Magic + 2;
				}
				if (Class == "THIEF")
				{
					Player_One_Handed = Player_One_Handed + 2;
					Player_Ranged_Weapon++;
					Player_Magic++;
				}



				Inventory[0] = "a"; Inventory[1] = "b"; Inventory[2] = "snails";

				Console.Clear();
				Console.WriteLine("Inventory Test: type inventory below");
				Input = Console.ReadLine().ToUpper();
				//Inventory System:
				if (Input == "INVENTORY")
				{
					Console.Clear();
					Console.WriteLine("Your Inventory Contains:");
					for (Arraycount = 0; Arraycount < 20; Arraycount++)
					{
						int inventory_possition = Arraycount + 1;
						Console.SetCursorPosition(0, inventory_possition);
						Console.WriteLine("{0}", Inventory[Arraycount]);
					}
				}
				else
				{
				}

				Console.ReadLine();


			}

	}
	
}

