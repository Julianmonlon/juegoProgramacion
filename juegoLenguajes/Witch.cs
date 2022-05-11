using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace juegoLenguajes
{
    class Witch:Sprite
    {
        public Witch() : base("Sprites/muriel", new Point(350,30), new Point(100, 115))
        {
            
        }

        public void Move()
        {
            if (direction == 0)
            {
                Location = new Point(Location.X + 5, Location.Y);
            }
            else if (direction == 0)
            {
                Location = new Point(Location.X - 5, Location.Y);
            }
        }

    }
}
