using Gameplay.Items;
namespace Gameplay
{
    class Equipment
    {
        List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            if(item.Stackable && HasItem(item.Type))
            {
                Item stack = Items.Find(x => x.Equals(item));
                if(stack != null)
                {
                    stack.Count += item.Count;
                    return;
                }
            }

            Items.Add(item);
        }

        public void RemoveItem(ItemType itemType, int amount = 1)
        {
            Item item = Items.Find(x => x.Type == itemType);
            if (item != null)
            {
                if(item.Stackable && item.Count > amount)
                    item.Count -= amount;
                else
                    Items.Remove(item);
            }
                
        }

        public bool HasItem(ItemType itemType)
        {
            return Items.Exists(x => x.Type == itemType);
        }

        public int Count => Items.Count;

        public Item GetAt(int index)
        {
            if (index < 0 || index >= Items.Count)
                return null;
            return Items[index];
        }

        public List<Item> GetAllItems() { return Items; }
    }
}