using NUnit.Framework;
using System.Collections.Generic;

namespace hamaraBasket
{
    [TestFixture]
    public class HamaraBasketTest
    {
        HamaraBasket app;
        IList<Item> items;
        int sellIn = 10;
        int quality = 10;

        [SetUp]
        public void Setup()
        {
            items = HamaraBasket.CreateHamaraBasketList("Apples", sellIn, quality);
            app = HamaraBasket.CreateHamaraBasket(items);
        }

        [Test]
        public void ShouldReduceSellInValueByOneEOD()
        {
            //Arrage
            app.UpdateQuality();
            Assert.That(items[0].SellIn, Is.EqualTo(sellIn - 1));
        }

        [Test]
        public void ShouldReduceQualityValueByOneEOD()
        {
            //Arrage
            app.UpdateQuality();
            Assert.That(items[0].Quality, Is.EqualTo(quality - 1));
        }
    }
}