using System;
using System.Collections.Generic;
using GildedRoseKata.Select;

namespace GildedRoseKata
{
    public class Program
    {    
        
        private static List<Item> itemsList;
        public static List<IQualityChanger> changerList;
         

        private static void InitializeItemList()
        {
            itemsList = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49},
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }


        private static void InitializeChangerList()
        {
            changerList = new List<IQualityChanger>();
            
            changerList.Add(new QualityChanger_forAgedBrie());
            changerList.Add(new QualityChanger_forBackstageTAFKAL80ETC());
            changerList.Add(new QualityChanger_forConjured());
            changerList.Add(new QualityChanger_forSulfuras());
            changerList.Add(new QualityChanger_Default());
        }

                
        public static void Main(string[] args)
        {
            InitializeItemList();
            InitializeChangerList();

            GildedRose rose = new GildedRose(itemsList, changerList);

            Console.WriteLine("OMGHAI!"); 

            // Not sure if it is worth listing everything 31 times. err it's stupid.
            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < itemsList.Count; j++)
                {
                    System.Console.WriteLine(itemsList[j].Name + ", " + itemsList[j].SellIn + ", " + itemsList[j].Quality);
                }
                Console.WriteLine("");
                rose.UpdateQuality();
                //Console.ReadLine();
            }
        }
    }
}
