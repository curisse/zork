using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Schism
{
    public class Program

    {
        public static Random rand = new Random();

        public static Player currentPlayer = new(); // same as writing ... = new Player() -- super cool...
        public static bool mainLoop = true;

        static void Main(string[] args)
        {
            if (!Directory.Exists("saves"))
            {
                Directory.CreateDirectory("saves");
            }
            currentPlayer = Load(out bool newP);
            if (newP) // if it's a single line command you don't need {}
            

            Encounters.WindowReflection();

            while (mainLoop)

            {
                Encounters.RandomEncounter();
            }

        }

		static Player Template(int i) // and not (string[] args)? why not?

		{
			Console.Clear();
			Player p = new Player();
			Console.WriteLine("Schism: A Journey through Mind");
			Console.WriteLine("Name:");
			p.name = Console.ReadLine();
			p.id = i;
			Console.Clear();

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
				Console.WriteLine("Male / Female / Non Binary / Other");
				Gender = Console.ReadLine().ToUpper();
				if (Gender == "MALE" || Gender == "FEMALE" || Gender == "NON BINARY" || Gender == "OTHER")
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
			Console.WriteLine("Inventory Test: type 'i' below");
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

			NewStart(p.id);
			return p;

		}

		static Player NewStart(int i)

        {
            Console.Clear();
            Player p = new Player();
            Console.WriteLine("Schism: A Journey through Mind");
            Console.WriteLine("Name:");
            p.name = Console.ReadLine();
            p.id = i;
            Console.Clear();
            Console.WriteLine("You wake up. It feels like morning. You are in a room that you don't recognise.");
            Console.WriteLine("Your head feels foggy. You try to remember the previous night but there's nothing to remember.");
            if (p.name == "")
                Console.WriteLine("You can't even remember your own name...");
            else
                Console.WriteLine("You know that your name is " + p.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You stand up and look around: a small bed behind you, a big window to your left with a small box below it, a pale grey wall in front of you, and a closed door to your right.");
            Console.WriteLine("You move towards the door and turn the handle. It's locked. You sigh deeply and feel a mix of relief and concern.");
            return p;

        }

        public static void Quit()
        {
            Save();
            Environment.Exit(0);
        }

        public static void Save()
        {
            BinaryFormatter binForm = new BinaryFormatter();
            string path = "saves/" + currentPlayer.id.ToString();
            FileStream file = File.Open(path, FileMode.OpenOrCreate);
            binForm.Serialize(file, currentPlayer);
            file.Close();
        }

        public static Player Load(out bool newP) // need to set OUT before we return anything...
        {
            newP = false; //serves as argument
            Console.Clear();
            Console.WriteLine("Choose your player name: ");    
            string[] paths = Directory.GetFiles("saves");
            List<Player> players = new List<Player>(); // creates new list of players
            int idCount = 0;

            BinaryFormatter binForm = new BinaryFormatter();
            foreach (string p in paths)
      
            {
                FileStream file = File.Open(p, FileMode.Open);
                //Player player = (Player)binForm.Deserialize(file); // this is called a 'cast'
                file.Close();
                //players.Add(player);
            }

            idCount = players.Count;

            while (true) // try function avoids infinite loop!
            {
                Console.Clear();
                Print("SCHISM: A JOURNEY THROUGH MIND");

                foreach (Player p in players)

                {
                    Console.WriteLine(p.id + ": " + p.name + p.wellbeing); // could be an issue if player uses another existing name
                }

                Print("Please input player name or id. Or, enter 'c' to start a new game.", 20);

                string[] data = Console.ReadLine().Split(':');

                // will take string from input and split it based on the character (e.g. ':') string[] data = Console.ReadLine().Split(':');

                try
                {
                    if (data[0] == "id")
                    {
                        if (int.TryParse(data[1], out int id)) // TryParse will return boolean, but will output an integer if TRUE ->  will only work if user inserts all info properly
                        {
                            foreach (Player player in players)
                            {
                                if (player.id == id)
                                {
                                    return player;
                                }
                            }
                            Console.WriteLine("There is no player with the id you entered.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Your id needs a number! Press any key to continue...");
                            Console.ReadKey();
                        }

                    }
                    else if (data[0] == "create" || data[0] == "c")
                    {
						Player newPlayer = NewStart(idCount); //Template(idCount); //or use NewStart(idCount);
                        newP = true;
                        return newPlayer;
                    }
                    else
                    {
                        foreach (Player player in players)
                        {
                            if (player.name == data[0])
                            {
                                return player;
                            }
                        }
                        Console.WriteLine("There is no player with the id you entered.");
                        Console.ReadKey();
                    }
                    
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Your id needs to be a number! Press any key to continue.");
                    Console.ReadKey();
                }

            }

           
        }
        public static void Print(string text, int speed = 40)    //void = not returning anything

        {

            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed); // the higher the speed integer the slower it will be
            }
            Console.WriteLine();
        }

    }
    
}