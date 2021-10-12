using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> itemsList)
        {
            this.Items = itemsList;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                QualityChanger(item);
                SellInChanger(item);
            }            
        }

        public void QualityChanger(Item item)
        {
            switch (item.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    {
                        return;
                    }

                case "Aged Brie":
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality = item.Quality + 1;
                        }
                        return;
                    }
                case "Backstage passes to a TAFKAL80ETC concert":
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
                        return;
                    }
                case "Conjured Mana Cake":
                    {
                        if (item.Quality > 1)
                        {
                            item.Quality = item.Quality - 2;
                        }
                        else
                        {
                            item.Quality = item.Quality - 1;
                        }
                        return;
                    }
                default:
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
                        return;
                    }
            }
        }

        public void SellInChanger(Item item)
        {   
            item.SellIn = item.SellIn - 1;
        }
    }
}
