using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public Program()
        {
            InitializePlainConstants();
            InitializeItemList();
        }

        private static Dictionary<string, int> neverChangingItems;
        private static List<Item> itemsList;       

        
        private void InitializePlainConstants()
        {
            neverChangingItems = new Dictionary<string, int>();
            const int sulfurasQuantity = 80;
            neverChangingItems.Add("Sulfuras_Quality", sulfurasQuantity);
            const int sulfurasSellIn = 0;
            neverChangingItems.Add("Sulfuras_SellIn", sulfurasSellIn);
            const int QualityUpperBound = 50;
            neverChangingItems.Add("QualityUpperBound", QualityUpperBound);
            const int QualityLowerBound = 0;
            neverChangingItems.Add("QualityLowerBound", QualityLowerBound);
        }

        private void InitializeItemList()
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

        protected internal void AddNewItem(string newItemName, int newItemSellIn, int newItemQuality )
        {
            itemsList.Add(new Item { Name = newItemName, Quality = newItemSellIn, SellIn = newItemQuality });
        }

        protected internal void IntroduceNewPlainConstraint(string newPlainConstraintReferenceName, int newPlainConstraintValue)
        {
            neverChangingItems.Add(newPlainConstraintReferenceName, newPlainConstraintValue);
        }

        
        public static void Main(string[] args)
        {
            GildedRose rose = new GildedRose(itemsList);

            Console.WriteLine("OMGHAI!"); 

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
            }
        }
    }
}
