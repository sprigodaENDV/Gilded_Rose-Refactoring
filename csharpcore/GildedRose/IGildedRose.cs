using System.Collections.Generic;


namespace GildedRoseKata
{
    public interface IGildedRose
    {
        void UpdateQuality();
        void QualityChanger(Item item);
        void SellInChanger(Item item);
    }
}