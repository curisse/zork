using System;
namespace Schism
{
	public class Shop
	{

		//static int resilienceMod;
		//static int apathyMod;
		//static int vibranceMod;


		public static void LoadShop(Player p)
        {
			RunShop(p);
			//resilienceMod = p.resilience;
			//apathyMod = p.apathy;
			//vibranceMod = p.vibrance;
        }

		public static void RunShop(Player p)

        {

			int therapyP;
			int companionTrainerP;
			int mapP;
			int caffeinePillP;

			while (true)

            {
				therapyP = 100 + 10 * p.mods;
				companionTrainerP = 50 + 5 * p.mods;
				mapP = 200 + 2 * p.mods;
				caffeinePillP = 20 + 5 * p.mods;
				Console.Clear();
				Console.Write("		     PSYCHIATRIST	      ");
				Console.WriteLine("===========================");
				Console.WriteLine("| (T)herapy				$|");
				Console.WriteLine("| (Co)mpanion Trainer	$|");
				Console.WriteLine("| (M)ap					$|");
				Console.WriteLine("| (Ca)ffeine Pill		$|");
				Console.WriteLine("===========================");
				Console.WriteLine("(E)xit Shop");
				Console.WriteLine("(Q)uit Game");

				Console.WriteLine();
				Console.WriteLine();
				Console.Write(p.name + "'s STATS");
				Console.WriteLine("===========================");
				Console.WriteLine("Wellbeing: " + p.wellbeing);
				//Console.WriteLine("Companion Development: " + p.companion);
				Console.WriteLine("Resilience: " + p.resilience);
				Console.WriteLine("Coins: " + p.coins);
				Console.WriteLine("===========================");

				//wait for input

				string input = Console.ReadLine().ToLower();

				if (input == "t" || input == "therapy")

				{
					TryBuy("therapy", therapyP, p);
				}

				else if (input == "co" || input == "companion trainer")

				{
					TryBuy("companion trainer", companionTrainerP, p);
				}

				else if (input == "m" || input == "map")

				{
					TryBuy("map", mapP, p);
				}

				else if (input == "ca" || input == "caffeine pill")

				{
					TryBuy("caffeine pill", caffeinePillP, p);
				}

				else if (input == "q" || input == "quit")

				{
					Program.Quit(); // no arguments needed 
				}

				else if (input == "e" || input == "exit")
					break;
			}
		}

		static void TryBuy(string item, int cost, Player p)

		{
			if(p.coins >= cost)

            {
				if (item == "therapy")
					p.wellbeing++;

				//ADD THESE FEATURES BELOW

				//else if (item == "companion trainer")
				//	p.companionWellbeing++;
				//else if (item == "map")
				//	p.map;
				
				else if (item == "caffeine pill")
					p.vibrance++;

				p.coins -= cost;
            }

            else

			{
				Console.WriteLine("You don't have enough coins to make this purchase.");
				Console.ReadKey();
            }

        }
	}

}

