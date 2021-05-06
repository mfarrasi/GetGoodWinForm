using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetGoodWinForm
{
    class Gacha
    {
        double rates;
        bool characterList;
        int points = 0;

        public void pullSingle()
        {
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next(10));
            Console.WriteLine(random.Next(0, 10));
        }
        public bool seeRates(bool showRates)
        {
            showRates = true;
            return showRates;
        }
        public bool seeCharacterList(bool showCharacterList)
        {
            showCharacterList = true;
            return true;
        }
    }
}
