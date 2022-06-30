namespace Gameplay.Items
{
    enum ItemType
    {
        SLING,
        FLASHLIGHT,
        SANDWITCH,
        MAP,
        STRAWBERRY,
        KEY,
        KEY_FRAGMENT,
        RECIPE,
    }

    class Item: IEquatable<Item>
    {
        public ItemType Type;
        public string Name;
        public string Description;
        public bool Stackable = false;
        public int Count = 1;


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

    class Weapon: UsableItem
    {
        public float Damage;

        public override void Use()
        {
            // TUTAJ POTRZEBNE JEST ODWOŁANIE DO GRACZA (STATYCZNA KLASA GAME???) Game.GetPlayer().Wear(this);
        }
    }
 
}