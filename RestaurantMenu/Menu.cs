using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    public class Menu
    {
        private List<MenuItem> items;
        private DateTime pubdate;

        public List<MenuItem> Items { get; set; }
        public DateTime Pubdate { get; set; }

        public Menu(List<MenuItem> items, DateTime pubdate)
        {
            this.items = items;
            this.pubdate = pubdate; 
        }

        public Menu() : this(new List<MenuItem>(), DateTime.Now) { }
    }
}
