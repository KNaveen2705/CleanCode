using System.Collections.Generic;
using System.Xml.Linq;

namespace hamaraBasket
{
    public class HamaraBasket
    {
        IList<Item> Items;
        public HamaraBasket(IList<Item> list)
        {
            this.Items = list;
        }

        public static HamaraBasket CreateHamaraBasket(IList<Item> list)
        {
            return new HamaraBasket(list);
        }

        public static IList<Item> CreateHamaraBasketList(string name, int sellIn, int quality)
        {
            Item item = new Item();
            item.Name = name;
            item.Quality = quality;
            item.SellIn = sellIn;
            IList<Item> myList = new List<Item>();
            myList.Add(item);
            return myList;
        }
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Indian Wine" && Items[i].Name != "Movie Tickets")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Forest Honey")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Movie Tickets")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Forest Honey")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Indian Wine")
                    {
                        if (Items[i].Name != "Movie Tickets")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Forest Honey")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }

    }
}