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
            if (dragon == true && dog == true && cat == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void showCharacter()
        {

        }
    }
}
