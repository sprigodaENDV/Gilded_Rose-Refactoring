using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    class QualityChanger_forConjured : IQualityChanger
    {
        public bool Change(Item item)
        {
            bool flag = false;

            if (item.Name == "Conjured Mana Cake")
            {
                if (item.Quality > 1)
                {
                    item.Quality = item.Quality - 2;
                }
                else
                {
                    item.Quality = item.Quality - 1;
                }

                flag = true;
            }

            return flag;
        }
    }
}
