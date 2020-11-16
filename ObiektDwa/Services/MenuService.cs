namespace ObiektDwa
{
    class MenuService
    {

        private Item[] menus = new Item[]
        {
        new Item("Burgers"),
        new Item("Refreshments"),
        new Item("Nothing thanks")
        };

        public Item[] Menus { get => menus; }

    }
}
