/// —————————————————————————————————————————————
//? 
//!? 📜 RectanglePoints.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies:
//      + (Galacticai) Math/Space2D/Point.cs
//      + (Galacticai) Math/Space2D/Rectangle.cs
//? 
/// —————————————————————————————————————————————


namespace GalacticLib.Math.Space2D {
    public class RectanglePoints {
        public Point O { get; }
        public Point OX { get; }
        public Point OY { get; }
        public Point OXY { get; }
        public RectanglePoints(Rectangle rectangle) {
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
