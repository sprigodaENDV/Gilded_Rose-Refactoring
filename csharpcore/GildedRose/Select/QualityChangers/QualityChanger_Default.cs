using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    class QualityChanger_Default : IQualityChanger
    {       

        public bool Change(Item item)
        {
            bool flag = false;

            if ((item.Name != "Aged Brie") 
                ^ (item.Name != "Backstage passes to a TAFKAL80ETC concert") 
                ^ (item.Name != "Conjured Mana Cake") 
                ^ (item.Name != "Sulfuras, Hand of Ragnaros"))
            {
                if (item.SellIn > 0)
                {
                    item.Quality = item.Quality - 1;
                }
                else
                {
                    if (item.Quality > 1)
                    {
                        item.Quality = item.Quality - 2;
                    }
                    else
                    {
                        item.Quality = item.Quality - 1;
                    }
                }

                flag = true;
            }

            return flag;
        }
    }
}
