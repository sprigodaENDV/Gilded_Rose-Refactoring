using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    static class Selector
    {               
        public static void ChangeQuality(List<IQualityChanger> changerList, Item item)
        {
            foreach (var changer in changerList)
            {
                changer.Change(item);
            }
        }

        public static void ChangeSellIn(Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
