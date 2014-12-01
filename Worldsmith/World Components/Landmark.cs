using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Worldsmith
{
    public class Landmark
    {
        public string Name { get; set; }
        public Point Position { get; set; }

        public Landmark(string name, Point position)
        {
            Name = name;
            Position = position;
        }
    }
}
