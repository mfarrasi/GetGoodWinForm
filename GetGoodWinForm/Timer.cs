using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGoodWinForm
{
    class Timer
    {
        int minutes;
        int seconds;
        public int setTime(int minutes, int seconds)
        {
            return minutes * 60 + seconds;
        }
        public void getPoint(int points)
        {
            
        }
        private bool hasCharacter()
        {
            bool dragon = true;
            bool dog = true;
            bool cat = true;
            bool golem = true;
            bool anakMiskin = true;
            if (dragon == true)
                return dragon;
            else if (dog == true)
                return dog;
            else if (cat == true)
                return cat;
            else if (golem == true)
                return golem;
            else if (anakMiskin == true)
                return anakMiskin;
            else
                return false;
            {

            }
        }
        public void showCharacter()
        {
            
        }
    }
}
