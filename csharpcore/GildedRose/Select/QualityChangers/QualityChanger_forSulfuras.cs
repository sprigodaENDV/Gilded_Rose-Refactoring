using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRoseKata.Select
{
    class QualityChanger_forSulfuras : IQualityChanger
    {
        public bool Change(Item item)
        {
            bool flag = false;

            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                flag = true;
            }

            return flag;
        }
    }
}
