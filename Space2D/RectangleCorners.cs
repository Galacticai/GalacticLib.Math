// —————————————————————————————————————————————
//? 
//!? 📜 RectanglePoints.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies:
//      + (Galacticai) Math/Space2D/Point.cs
//      + (Galacticai) Math/Space2D/Rectangle.cs
//? 
// —————————————————————————————————————————————


namespace GalacticLib.Math.Space2D {
    //? Example: 
    //  OY--------------OXY
    //  |               |
    //  |               |
    //  |               |
    //  |               |
    //  |               |
    //  |               |
    //  O---------------OX

    /// <summary> Corner points of a <see cref="Rectangle"/> </summary>
    public class RectangleCorners {
        /// <summary> (x, y) </summary>
        public Point O { get; }
        /// <summary> (x+w, y) </summary>
        public Point OX { get; }
        /// <summary> (x, y+h) </summary>
        public Point OY { get; }
        /// <summary> (x+w, y+h) </summary>
        public Point OXY { get; }
        /// <summary> Corner points of <paramref name="rectangle"/> </summary>
        /// <param name="rectangle"> Target <see cref="Rectangle"/> </param>
        public RectangleCorners(Rectangle rectangle) {
            //? (x, y)
            O = new(rectangle.X, rectangle.Y);
            //? (x+w, y)
            OX = new(rectangle.X + rectangle.XLength, rectangle.Y);
            //? (x, y+h)
            OY = new(rectangle.X, rectangle.Y + rectangle.YLength);
            //? (x+w, y+h)
            OXY = new(rectangle.X + rectangle.XLength, rectangle.Y + rectangle.YLength);
        }
    }
}
