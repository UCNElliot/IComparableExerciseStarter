using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class HeartilySorter : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            int xValue = x.Value;
            int yValue = y.Value;

            if (x.Suit == Suit.Hearts)
            {
                xValue += 13;
            }
            if (y.Suit == Suit.Hearts)
            {
                yValue += 13;
            }

            return xValue - yValue;
        }
    }
}
