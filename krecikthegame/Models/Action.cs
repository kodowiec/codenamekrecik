using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krecikthegame.Models
{
    public class GameAction
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Action<int> Do() => throw new NotImplementedException();
    }
}
