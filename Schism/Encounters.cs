using System;
namespace Schism

{
    
    public class Encounters

    {
        
        //Encounters Generic

        //Encounters

        //public static void FirstEncounter()

        //{
        //    Console.WriteLine("With uncertainty, you turn around and make your way towards the window.");
        //    Console.ReadKey();
        //    Reflection(false, Program.currentPlayer.name, 5, 0, 2, 10, 3);
            
        //}

        public static void WindowReflection()

        {
            Console.Clear();
            Console.WriteLine("Windows are places of quiet reflection. Your thinking begins...");
            Console.WriteLine("During this time of reflection, you look inwards. You analyse your key character attributes: ");
            Console.ReadKey();
            Reflection(true, Program.currentPlayer.name, Program.currentPlayer.wellbeing, Program.currentPlayer.coins, Program.currentPlayer.resilience, Program.currentPlayer.apathy, Program.currentPlayer.vibrance);
        }

        public static void StrangerEncounter()

        {
            Console.Clear();
            Console.WriteLine("The door slowly creaks open as you peer into the dark room. You see a tall man with a ");
            Console.WriteLine("book in his hand. ");
            Console.ReadKey();
            Conversations(true, getConversationPartnerName(), getConversationPartnerPuzzle(), 100, 5, 5);

        }

        //Encounter Tools//////////

        public static void RandomEncounter()

        {
            switch(Program.rand.Next(0,2))
            {
                case 0:
                    WindowReflection();
                    break;
                case 1:
                    StrangerEncounter();
                    break;
            }
        }

        public static string getCompanionName()

        {
            switch (Program.rand.Next(0, 4))
            {
                case 0:
                    return "Maya";
                case 1:
                    return "Ayla";
                case 2:
                    return "Muji";
                case 3:
                    return "Tori";
            }
            return "Miko";

        }

        public static string getConversationPartnerName()

        {
            switch (Program.rand.Next(0, 4))
            {
                case 0:
                    return "ABSO***ION";
                case 1:
                    return "TRA***ENDENCE";
                case 2:
                    return "RUMI***ION";
                case 3:
                    return "TOLER**CE";
            }
            return "INQ***Y";

        }

        public static string getConversationPartnerPuzzle()
        {
            switch (Program.rand.Next(0, 2))

            {
                case 0:
                    return "What is always racing, but always in the same place?";
                case 1:
                    return "yaw siht sgniht ees dluow i";
            }
            return "...";
        }

        //Reflection Encounter////////////////

        public static void Reflection(bool random, string name, int wellbeing, int coins, int resilience, int apathy, int vibrance)

        {
            string n = "";
            int w = 5;
            int c = 0;
            int r = 2;
            int a = 10;
            int v = 3;

            if (random)

            {
                n = getCompanionName();
            }

            else

            {
                n = name;
                w = wellbeing;
                c = coins;
                r = resilience;
                a = apathy;
                v = vibrance;

            }

            while (w > 0)

            {
                Console.Clear();
                Console.WriteLine("wellbeing: " + w + ", coins: " + c + ", resilience: " + r + ", apathy: " + a + ", vibrance: " + v);
                Console.WriteLine("'What next?' you say aloud...");
                Console.WriteLine("=========");
                Console.WriteLine("| Enter 'b' to Brood // or //  'r' to Rest // or 'o' to Open Box |");
                Console.WriteLine("========");
                string input = Console.ReadLine();

                if (input.ToLower() == "b" || input.ToLower() == "brood")

                {
                    //Brood

                    Console.WriteLine("You stare out the window. You see a neatly kept garden. There are many trees. One tree catches your eye: it has large brown leaves.");
                    Console.WriteLine("You watch a leaf fall from the tree. As the leaf touches the ground, a small stem abruptly emerges from the soil, piercing through the leaf.");
                    Console.WriteLine("'Time is a flat circle,' you say to yourself. Your voice is deeper than you remember.");
                    int levelApathy = a + Program.currentPlayer.apathy;
                    int levelResilience = Program.rand.Next(0, Program.currentPlayer.resilience) + Program.rand.Next(1, 3);
                    Console.WriteLine("You feel heavier. Your apathy is now: " + apathy);
                    Console.WriteLine("Despite this new heaviness, you feek stronger. Your resilience is now: " + resilience);
                }

                else if (input.ToLower() == "r" || input.ToLower() == "rest")

                {
                    //Rest
                    Console.Clear();
                    Console.WriteLine("You return to bed. Soon, you are englufed by an infinite but kind shadow.");
                    Console.WriteLine("You wake feeling rested. You are reminded of a darker time when you rested too much. Times are different, now...");
                    Console.WriteLine("Your vibrance is now: " + Program.currentPlayer.vibrance + Program.rand.Next(1, 3));
                    Console.WriteLine("You stand up and reorientate yourself. Window to your left, small box beneath window, plain wall in front of you, door to your right, bed behind you.");
                }

                else if (input.ToLower() == "o" || input.ToLower() == "open" || input.ToLower() == "open box")

                {
                    //Open Box
                    Console.Clear();
                    Console.WriteLine("You kneel down and place your hand on a freshly polished box.");
                    Console.WriteLine("Reaching down, you pick up the small box and hold it in your left hand. With your right hand, you reach for a small key protruding from a strange-looking lock.");
                    Console.WriteLine("Upon closer inspection, you realise that the box can be unlocked in two ways.");
                    Console.WriteLine("Before you turn the key, you hear a sound from outside the window...");
                    Console.WriteLine("=========");
                    Console.WriteLine("| Enter 'c' to turn the key Clockwise // or 'a' to turn the key Anti-Clockwise // or 'o' to open the window |");
                    Console.WriteLine("========");
                    string input2 = Console.ReadLine();

                    if (input2.ToLower() == "c" || input2.ToLower() == "clockwise")

                    {
                        Console.Clear();
                        Console.WriteLine("You turn the key clockwise and a hidden compartment pops out from the left side of the box.");
                        Console.WriteLine("Something is glowing inside the hidden compartment...");
                        int wealth = Program.rand.Next(0, Program.currentPlayer.coins) + Program.rand.Next(50, 100);
                        Console.WriteLine("You reach into the hidden compartment and extract " + wealth + " coins.");
                    }

                    else if (input2.ToLower() == "a" || input2.ToLower() == "anticlockwise")
                    {
                        Console.Clear();
                        Console.WriteLine("You turn the key anti-clockwise and a hidden compartment pops out from the right side of the box.");
                        Console.WriteLine("Something is glowing inside the hidden compartment...");
                        Console.WriteLine("You reach into the hidden compartment and feel your fingers touch hair.");
                        Console.WriteLine("Your hand hesitates momentarily, before wrapping itself around the small object coated in hair.");
                        Console.WriteLine("Your left hand drops the box and it hits the ground with a quiet thud.");
                        Console.WriteLine("The hidden compartment is no longer glowing, and the key is nowhere to be seen.");
                        Console.WriteLine("Your attention returns to your right hand, where you feel movement.");
                        Console.WriteLine("To your amazement, there is a little creature in your palm. It stares at you with its kind and large hazel eyes.");
                        Console.WriteLine("My name is " + name + ", you say to the creature.");
                        Console.WriteLine("The creature blinks and its mouth loosens into a warm smile.");
                        Console.WriteLine("Without language, the creature communicates to you that its name is " + n);
                        Console.WriteLine("Suddenly, the little  creature yawns. Its large eyes struggle to stay open, and it curls up into a ball in your palm.");
                        Console.WriteLine("You place the sleepy creature into your breast pocket, and you feel its gentle breathing against your chest.");
                    }

                    else if (input2.ToLower() == "open window" || input2.ToLower() == "o")

                    {
                        Console.Clear();
                        Console.WriteLine("The window opens.");
                        Console.WriteLine("You poke your head out the window. To your immediate left, there is a ladder that has been nailed to the wall. Below you there is a garden, although there is quite a considerable drop. To your right, there is another window, with another ladder next to it. This window and ladder are out of reach.");
                        Console.WriteLine("=========");
                        Console.WriteLine("| Enter 'c' to climb out the window // or 'r' to return to the room |");
                        Console.WriteLine("========");
                        string input3 = Console.ReadLine();

                        if (input3.ToLower() == "c" || input3.ToLower() == "climb")

                        {
                            Console.Clear();
                            Console.WriteLine("You climb out the window and sit on the window sil.");
                            Console.WriteLine("=========");
                            Console.WriteLine("| Enter 'd' to climb out down the ladder // or 'j' to jump into the garden below |");
                            Console.WriteLine("========");
                            string input4 = Console.ReadLine();

                            if (input4.ToLower() == "d" || input4.ToLower() == "down")
                            {
                                Console.Clear();
                                Console.WriteLine("You slide yourself closer to the ladder, and tentatively place your left foot on one of the rungs. Very ungracefully, you shift your body weight off the window sil and direct it towards the ladder.");
                                Console.WriteLine("For a moment, you are totally off balance. Fortunately, though, the momentum from shifting your body weight onto the ladder swings you into the brick wall.");
                                Console.WriteLine("Ouch.");
                                Console.WriteLine("As you climb down the ladder, you look over your shoulder to see where you are going.");
                                Console.WriteLine("Moments later, you are standing on the balcony.");
                                Console.WriteLine("The balcony is barren except for a mirror and an open door leading inside.");
                                Console.WriteLine("=========");
                                Console.WriteLine("| Enter 'i' to inspect your reflection // or 'e' to enter the door |");
                                Console.WriteLine("========");
                                string input5 = Console.ReadLine();

                                if (input5.ToLower() == "i" || input5.ToLower() == "inspect")
                                {
                                    Console.Clear();
                                    Console.WriteLine("You move towards the mirror and soon you are staring at an unrecognisable figure.");
                                    Console.WriteLine("You move towards the mirror and an unrecognisable figure materialises before you.");
                                    Console.WriteLine("You are transfixed by the figure before you. You stare deeply into a set of large hazel eyes.");
                                    Console.WriteLine("Your vision begins to blur and your reflection begins to move.");
                                    Console.WriteLine("A figure materialises in the mirror and points at you.");
                                    Console.WriteLine("'Welcome. It's been a long time.' the figure exclaims, eyes still locked with your own.");
                                    Console.WriteLine("You feel as though you are falling into the eyes of this strange figure...");
                                    Shop.LoadShop(Program.currentPlayer);
                                }
                            }
                            else if (input4.ToLower() == "j" || input4.ToLower() == "down")
                            {
                                Console.Clear();
                                Console.WriteLine("You leap into the air. Soon, the powerful tug of the universe pulls you downwards.");
                                Console.WriteLine("Deeper, and deeper, and deeper you fall.");
                                Console.WriteLine("There is no colour where you are, there is no feeling, there is no light. There is nothing.");
                                Console.ReadKey();
                                System.Environment.Exit(0);
                            }
                        }
                        //Console.Clear();
                        //Console.WriteLine("Your vibrance is now: " + Program.currentPlayer.vibrance + Program.rand.Next(1, 3));
                        //Console.WriteLine("You stand up and reorientate yourself. Window to your left, small box beneath window, plain wall in front of you, door to your right, bed behind you.");
                    }

                }

                else if (input.ToLower() == "r" || input.ToLower() == "return")

                {
                    Console.WriteLine("You turn the key anti-clockwise and a hidden compartment pops out from the right side of the box.");
                    Console.WriteLine("Something is glowing inside the hidden compartment...");
                    Console.WriteLine("You reach into the hidden compartment and feel your fingers touch hair.");
                    Console.WriteLine("Your hand hesitates momentarily, before wrapping itself around the small object coated in hair.");
                    Console.WriteLine("Your left hand drops the box and it hits the ground with a quiet thud.");
                    Console.WriteLine("The hidden compartment is no longer glowing, and the key is nowhere to be seen.");
                    Console.WriteLine("Your attention returns to your right hand, where you feel movement.");
                    Console.WriteLine("To your amazement, there is a little creature in your palm. It stares at you with its kind and large hazel eyes.");
                    Console.WriteLine("My name is " + name + ", you say to the creature.");
                    Console.WriteLine("The creature blinks and its mouth loosens into a warm smile.");
                    Console.WriteLine("Without language, the creature communicates to you that its name is " + n);
                    Console.WriteLine("Suddenly, the little  creature yawns. Its large eyes struggle to stay open, and it curls up into a ball in your palm.");
                    Console.WriteLine("You place the sleepy creature into your breast pocket, and you feel its gentle breathing against your chest.");
                }
                    //Console.Clear();
                    //Console.WriteLine("Your vibrance is now: " + Program.currentPlayer.vibrance + Program.rand.Next(1, 3));
                    //Console.WriteLine("You stand up and reorientate yourself. Window to your left, small box beneath window, plain wall in front of you, door to your right, bed behind you.");

                

                if (Program.currentPlayer.wellbeing <= 0)

                {
                    Console.WriteLine("You leap into the air. Soon, the powerful tug of the universe pulls you downwards.");
                    Console.WriteLine("Deeper, and deeper, and deeper you fall.");
                    Console.WriteLine("There is no colour where you are, there is no feeling, there is no light. There is nothing.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }

                Console.ReadKey();

            }

            Console.ReadKey();
        }

        //Conversation Encounter////////////////

        public static void Conversations(bool random, string name, string quote, int coins, int vibrance, int wellbeing)

        {
            {
                string n = "";
                string q = "";
                int c = 0;
                int v = 0;
                int w = 0;

                if (random)
                {
                    n = getConversationPartnerName();
                    q = getConversationPartnerPuzzle();
                    v = Program.currentPlayer.GetVibrance();
                    w = Program.currentPlayer.GetWellbeing();
                }
                else
                {
                    n = name;
                    c = coins;
                    v = vibrance;
                    w = wellbeing;
                }


            }
        }

    }
}