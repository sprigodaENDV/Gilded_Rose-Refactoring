using GildedRoseKata.Select;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        List<IQualityChanger> Changers;

        public GildedRose(IList<Item> itemsList, List<IQualityChanger> changerList)
        {
            this.Items = itemsList;
            this.Changers = changerList;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                Select.Selector.ChangeQuality(Changers, item);
                Select.Selector.ChangeSellIn(item);                        
            }            
        }
    }
}
