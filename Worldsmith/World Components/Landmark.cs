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
        public Color Color { get; set; }
        public string Description { get; set; }
        public Map InternalMap { get; set; }

        /// <summary>
        /// Base constructor.
        /// </summary>
        /// <param name="name">Name of this Landmark.</param>
        /// <param name="position">Position of this Landmark on the container Map.</param>
        public Landmark(string name, Point position)
        {
            Name = name;
            Position = position;
            Color = Color.White;
        }
    }
}
