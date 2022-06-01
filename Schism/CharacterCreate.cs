using System;

namespace Schism
{
    public class CharacterClass
    {
        public static void Character(string[] args)
        {
            //Ints:
            int correct = 0;
            int Player_One_Handed = 0;
            int Player_Ranged_Weapon = 0;
            int Player_Magic = 0;
            int Player_Coins = 0;
            int Player_Resilience = 0;
            int Player_Apathy = 0;
            int Player_Vibrance = 0;
            int Player_Dexterity = 0;


            //Strings:
            string Gender;
            string Orientation;
            string Sin;
            string Virtue;


            //Character Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please specify gender:");
                Console.WriteLine("Male / Female / Non-Binary / Other");
                Gender = Console.ReadLine().ToUpper();
                if (Gender == "MALE")
                {
                    correct = 1;
                }
                if (Gender == "FEMALE")
                {
                    correct = 1;
                }
                if (Gender == "NON-BINARY")
                {
                    correct = 1;
                }
                if (Gender == "OTHER")
                {
                    correct = 1;
                }
                else
                {

                }

            } while (correct == 0);
            correct = 0;

            //Orientation Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose your orientation:");
                Console.WriteLine("Savant");
                Console.WriteLine("Liar");
                Console.WriteLine("Clairvoyant");
                Console.WriteLine("Nihilist");
                Console.WriteLine("Joker");
                Console.WriteLine("Your Choice:");
                Orientation = Console.ReadLine().ToUpper();
                if (Orientation == "SAVANT" || Orientation == "LIAR" || Orientation == "CLAIRVOYANT" || Orientation == "NIHILIST" || Orientation == "JOKER")
                {
                    correct = 1;
                }
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            //Sin Selection:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose your sin:");
                Console.WriteLine("Pride");
                Console.WriteLine("Greed");
                Console.WriteLine("Wrath");
                Console.WriteLine("Envy");
                Console.WriteLine("Lust");
                Console.WriteLine("Gluttony");
                Console.WriteLine("Sloth");
                Sin = Console.ReadLine().ToUpper();
                if (Sin == "PRIDE" || Sin == "GREED" || Sin == "WRATH" || Sin == "ENVY" || Sin == "LUST" || Sin == "GLUTTONY" || Sin == "SLOTH")
                {
                    correct = 1;
                }
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            //Virtue Selection:
            do
            {
                Console.Clear();
                Console.WriteLine("Please choose your Virtue:");
                Console.WriteLine("Focus");
                Console.WriteLine("Patience");
                Console.WriteLine("Humbleness");
                Console.WriteLine("Kindness");
                Console.WriteLine("Charity");
                Console.WriteLine("Curiosity");
                Console.WriteLine("Control");
                Virtue = Console.ReadLine().ToUpper();
                if (Virtue == "FOCUS" || Virtue == "PATIENCE" || Virtue == "HUMBLENESS" || Virtue == "KINDNESS" || Virtue == "CHARITY" || Virtue == "CURIOSITY" || Virtue == "CONTROL")
                {
                    correct = 1;
                }
                else { }
            } while (correct == 0);
            correct = 0;

            //Bonuses:
            //Orientation Bonus:
            if (Orientation == "SAVANT")
            {
                Player_One_Handed++;
                Player_Dexterity = Player_Dexterity + 10;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 5;
                Player_Magic = Player_Magic + 7;
                Player_Coins = Player_Coins + 100;
                Player_Resilience = Player_Resilience + 3;
                Player_Apathy = Player_Apathy + 10;
                Player_Vibrance = Player_Vibrance + 5;
            }
            if (Orientation == "LIAR")
            {
                Player_One_Handed = Player_One_Handed + 4;
                Player_Dexterity = Player_Dexterity + 2;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 5;
                Player_Magic = Player_Magic + 13;
                Player_Coins = Player_Coins + 100;
                Player_Resilience = Player_Resilience + 7;
                Player_Apathy = Player_Apathy + 5;
                Player_Vibrance = Player_Vibrance + 10;
            }
            if (Orientation == "CLAIRVOYANT")
            {
                Player_One_Handed = Player_One_Handed + 5;
                Player_Dexterity = Player_Dexterity + 5;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 10;
                Player_Magic = Player_Magic + 10;
                Player_Coins = Player_Coins + 100;
                Player_Resilience = Player_Resilience + 7;
                Player_Apathy = Player_Apathy + 5;
                Player_Vibrance = Player_Vibrance + 10;
            }
            if (Orientation == "NIHILIST")
            {
                Player_One_Handed = Player_One_Handed + 1;
                Player_Dexterity = Player_Dexterity + 1;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 1;
                Player_Magic = Player_Magic + 25;
                Player_Coins = Player_Coins + 100;
                Player_Resilience = Player_Resilience + 10;
                Player_Apathy = Player_Apathy + 25;
                Player_Vibrance = Player_Vibrance + 1;
            }
            if (Orientation == "JOKER")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Dexterity = Player_Dexterity + 5;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
                Player_Magic = Player_Magic + 15;
                Player_Coins = Player_Coins + 100;
                Player_Resilience = Player_Resilience + 2;
                Player_Apathy = Player_Apathy + 15;
                Player_Vibrance = Player_Vibrance + 10;
            }

            //Class Bonus:
            if (Sin == "PRIDE")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Dexterity = Player_Dexterity + 2;
            }
            if (Sin == "GREED")
            {
                Player_One_Handed++;
                Player_Dexterity++;
                Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
            }
            if (Sin == "WRATH")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic = Player_Magic + 2;
            }
            if (Sin == "ENVY")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Sin == "LUST")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Sin == "GLUTTONY")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (Sin == "SLOTH")
            {
                Player_One_Handed = Player_One_Handed + 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
        }
    }
}
