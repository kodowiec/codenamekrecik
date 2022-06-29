using System.ComponentModel;

namespace krecikthegame
{
    public class UserSettings
    {
        public UserKeys keymappings = new UserKeys();
        public bool mutesounds = false;
    }

    public class UserKeys
    {
        public int MoveUp = (int)ConsoleKey.UpArrow;
        public int MoveDown = (int)ConsoleKey.DownArrow;
        public int MoveLeft = (int)ConsoleKey.LeftArrow;
        public int MoveRight = (int)ConsoleKey.RightArrow;
        public int Inventory = (int)ConsoleKey.E;
        public int HideHUD = (int)ConsoleKey.H;

        // if we want to make interactions independent of move actions
        public int Interact = (int)ConsoleKey.Enter;
        public int Attack = (int)ConsoleKey.Enter;

        internal int Get(KeyboardSettings i)
        {
            switch (i)
            {
                case KeyboardSettings.MoveUp:
                    return this.MoveUp;
                case KeyboardSettings.MoveDown:
                    return this.MoveDown;
                case KeyboardSettings.MoveLeft:
                    return this.MoveLeft;
                case KeyboardSettings.MoveRight:
                    return this.MoveRight;
                case KeyboardSettings.Inventory:
                    return this.Inventory;
                case KeyboardSettings.Interact:
                    return this.Interact;
                case KeyboardSettings.Attack:
                    return this.Attack;
                case KeyboardSettings.HideHUD:
                    return this.HideHUD;
                    break;
                default:
                    return -1;
            }
        }

        internal void Set(KeyboardSettings i, int value)
        {
            switch (i)
            {
                case KeyboardSettings.MoveUp:
                    this.MoveUp = value;
                    break;
                case KeyboardSettings.MoveDown:
                    this.MoveDown = value;
                    break;
                case KeyboardSettings.MoveLeft:
                    this.MoveLeft = value;
                    break;
                case KeyboardSettings.MoveRight:
                    this.MoveRight = value;
                    break;
                case KeyboardSettings.Inventory:
                    this.Inventory = value;
                    break;
                case KeyboardSettings.Interact:
                    this.Interact = value;
                    break;
                case KeyboardSettings.Attack:
                    this.Attack = value;
                    break;
                case KeyboardSettings.HideHUD:
                    this.HideHUD = value;
                    break;
                default:
                    break;
            }
        }

        public int this[KeyboardSettings i]
        {
            get => Get(i);
            set => Set(i, value);
        }

        public string GetDescription(KeyboardSettings i)
        {
            switch (i)
            {
                case KeyboardSettings.MoveUp:
                    return "Move Up";
                case KeyboardSettings.MoveDown:
                    return "Move Down";
                case KeyboardSettings.MoveLeft:
                    return "Move Left";
                case KeyboardSettings.MoveRight:
                    return "Move Right";
                case KeyboardSettings.Inventory:
                    return "Inventory";
                case KeyboardSettings.Interact:
                    return "Interact";
                case KeyboardSettings.Attack:
                    return "Attack";
                case KeyboardSettings.HideHUD:
                    return "Hide HUD";
                default:
                    return String.Empty;
            }
        }
    }
}
