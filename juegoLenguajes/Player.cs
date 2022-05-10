using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;


namespace juegoLenguajes
{
    class Player : Sprite
    {
        public List<bread> breads;
        public Player() : base("Sprites/Hansel", new Point(50, 480), new Point(100, 115))
        {
            breads = new List<bread>();
        }
        public void Move(string direction)
        {
            if (direction == "j")
            {
                Location = new Point(Location.X + 5, Location.Y);
            }
            else if (direction == "m")
            {
                Location = new Point(Location.X - 5, Location.Y);
            }
        }
        public void Shoot(ContentManager content, Point location)
        {

            breads.Add(new bread(content, location));

        }
    }
}
