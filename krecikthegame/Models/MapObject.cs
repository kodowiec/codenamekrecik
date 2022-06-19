using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame.Models
{
    public class MapObject
    {
        public int ID { get; set; }
        public string ColorID { get; set; }
        public string Name { get; set; }
        public string Display { get; set; }
        public bool IsInteractive { get; set; }
        public bool IsColliding { get; set; }
        public ConsoleColor DrawColor { get; set; }
    }
}
