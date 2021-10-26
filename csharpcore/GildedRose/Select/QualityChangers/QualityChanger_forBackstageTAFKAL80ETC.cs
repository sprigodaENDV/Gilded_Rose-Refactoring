using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    class QualityChanger_forBackstageTAFKAL80ETC : IQualityChanger
    {        
        public bool Change(Item item)
        {
            bool flag = false;

            if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (item.SellIn < 0)
                {
                    item.Quality = 0;
                }
                else
                {
                    if ((item.SellIn < 11) && (item.SellIn > 5))
                    {
                        item.Quality = item.Quality + 2;
                    }
                    else if (item.SellIn < 6)
                    {
                        item.Quality = item.Quality + 3;
                    }
                    else
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                flag = true;
            }

            return flag;
        }    
    }    
}
