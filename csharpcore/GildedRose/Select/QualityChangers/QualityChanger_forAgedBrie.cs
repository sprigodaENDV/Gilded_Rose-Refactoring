using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    class QualityChanger_forAgedBrie : IQualityChanger
    {
        public bool Change(Item item) 
        {
            bool flag = false;

            if (item.Name == "Aged Brie")
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                flag = true;
            }

            return flag;
        }
    }
}
