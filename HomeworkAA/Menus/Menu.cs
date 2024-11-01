using HomeworkAA.Entity;
using System.Collections.Generic;

namespace HomeworkAA.Menus
{
    public class Menu
    {
        public List<MenuItem> Items { get; }

        public Menu()
        {
            Items = new List<MenuItem>
            {
                new MenuItem(1, "Пицца", 500m),
                new MenuItem(2, "Бургер", 250m),
                new MenuItem(3, "Суши", 700m),
                new MenuItem(4, "Паста", 300m),
                new MenuItem(5, "Салат", 150m)
            };
        }

        public MenuItem GetMenuItemById(int id)
        {
            return Items.Find(item => item.Id == id);
        }
    }
}
