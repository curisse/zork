using System;
namespace Schism
{
    [Serializable]

    public class Player
    {
        Random rand;

        public string name;
        public int id;
        public int wellbeing = 5;
        public int coins = 0;
        public int resilience = 2;
        public int apathy = 10;
        public int vibrance = 3;

        public int mods = 0;

        public int GetVibrance()
        {
            int upper = ((2 * mods) + 7);
            int lower = (mods + 2);
            return rand.Next(lower, upper);

        }

        public int GetWellbeing ()
        {
            int upper = ((2 * mods) + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);

        }


    }
}
