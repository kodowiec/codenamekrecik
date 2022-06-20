namespace Gameplay
{
    class Equipment
    {
        List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(ItemType itemType)
        {
            Item item = Items.Find(x => x.Type == itemType);
            if (item != null)
                Items.Remove(item);
        }

        public bool HasItem(ItemType itemType)
        {
            return Items.Exists(x => x.Type == itemType);
        }

        public int ItemCount(ItemType itemType)
        {
            return Items.Where(x => x.Type == itemType).Count();
        }

        public List<Item> GetAllItems() { return Items; }
    }
}