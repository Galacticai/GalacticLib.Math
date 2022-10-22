// —————————————————————————————————————————————
//? 
//!? 📜 Point.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies: No special dependencies
//? 
// —————————————————————————————————————————————


using sMath = System.Math;

namespace GalacticLib.Math.Space2D {
    /// <summary> A representation of a point in 2D space </summary>
    public class Point {
        /// <summary> Origin point (0,0) </summary>
        public static readonly Point ORIGIN = new(0, 0);

        /// <summary> Get the distance between this <see cref="Point"/> and another one </summary>
        /// <param name="point"> Target <see cref="Point"/> </param>
        /// <returns> Distance from this <see cref="Point"/> to the other <paramref name="point"/> </returns>
        public double Distance(Point point)
            => sMath.Sqrt(
                sMath.Pow(X - point.X, 2)
                + sMath.Pow(Y - point.Y, 2));

        /// <summary> Get the distance between this <see cref="Point"/> and the <see cref="ORIGIN"/> (0,0) </summary>
        /// <returns> Distance from this <see cref="Point"/> to the <see cref="ORIGIN"/> (0,0) </returns>
        public double DistanceToOrigin
            => Distance(ORIGIN);

        /// <summary> Position of this <see cref="Point"/> on the x-axis </summary>
        public double X { get; set; }
        /// <summary> Position of this <see cref="Point"/> on the y-axis </summary>
        public double Y { get; set; }
        /// <summary> A representation of a point in 2D space 
        /// <br/> Generated with <see cref="X"/> and <see cref="Y"/> positions </summary>
        public Point(double x, double y) {
            X = x; Y = y;
        }
    }
}
