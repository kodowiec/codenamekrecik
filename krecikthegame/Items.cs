namespace Gameplay
{
    enum ItemType
    {
        RED_POTION,
        GOLD_KEY,
        // ITP ITD
    }

    class Item: IEquatable<Item>
    {
        public ItemType Type;
        public string Name;
        public string Description;


        public bool Equals(Item? other)
        {   
            if(other == null) return false;
            return Type == other.Type;
        }
    }

    class UsableItem: Item
    {
        public bool CanUse = true;

        public virtual void Use() { }
    }

    // ITEMS

    // EXAMPLE ////////////////////////////
    class RedPotion: UsableItem
    {
        float HP = 30.0f;

        public RedPotion() 
        {
            Type = ItemType.RED_POTION;
            Name = "Red Potion";
            Description = "Restores some HP points";
        }

        public override void Use() 
        {
            Console.WriteLine("+30hp");
        }
    }

    
}