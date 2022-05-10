using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace juegoLenguajes
{
    class bread : Sprite
    {
        public bread(ContentManager contentManager) : this(contentManager, new Point())
        {

        }

        public bread(ContentManager contentManager, Point location) : base("Sprites/bread", location, new Point(50, 25))
        {
            LoadContent(contentManager);
        }

        public void MoveUp()
        {
            Location = new Point(Location.X,Location.Y-5);
        }

    }
}
