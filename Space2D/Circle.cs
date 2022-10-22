// —————————————————————————————————————————————
//?
//!? 📜 Circle.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies:
//      + (Galacticai) Math/Space2D/Point.cs
//?
// —————————————————————————————————————————————


using GalacticLib.Math.Numerics;
using sMath = System.Math;

namespace GalacticLib.Math.Space2D {
    /// <summary> A representation of a circle in 2D space </summary>
    internal class Circle {
        /// <summary> Unit <see cref="Circle"/> of size 1 and <see cref="Point.ORIGIN"/> as the center </summary>
        public static readonly Circle UNIT_CIRCLE = new(Point.ORIGIN, 1);

        /// <summary> Determines whether the <paramref name="point"/> is included in this <see cref="Circle"/> </summary>
        /// <param name="point"> Target <see cref="Point"/> </param>
        /// <returns> true if the <paramref name="point"/> exists within this <see cref="Circle"/> </returns>
        public bool IncludesPoint(Point point)
            => Center.Distance(point) <= Radius;
        /// <summary> Determines whether this <see cref="Circle"/> passes through the <paramref name="point"/> </summary>
        /// <param name="point"> Target <see cref="Point"/> </param>
        /// <returns> true if this <see cref="Circle"/>'s edge passes through the <paramref name="point"/> </returns>
        public bool PassThroughPoint(Point point)
            => Center.Distance(point) == Radius;

        /// <summary> Get the distance between the <see cref="Center"/> points of this <see cref="Circle"/> and another one </summary>
        /// <param name="circle"> Target <see cref="Circle"/> </param>
        /// <returns> Distance from the <see cref="Center"/> of this <see cref="Circle"/> to the <see cref="Center"/> of the other <paramref name="circle"/> </returns>
        public double Distance_Center(Circle circle)
            => Center.Distance(circle.Center);

        /// <summary> Get the distance between the edge of this <see cref="Circle"/> and another one </summary>
        /// <param name="circle"> Target <see cref="Circle"/> </param>
        /// <returns>
        ///     <list type="bullet">
        ///     <item> &gt;0 • No intersection • The distance between the spheres </item>
        ///     <item> =0 • Touching edges </item>
        ///     <item> &lt;0 • Intersecting </item>
        ///     </list>
        /// </returns>
        public double Distance_Edge(Circle circle)
            => Distance_Center(circle) - (Radius + circle.Radius);

        /// <summary> Determine whether this <see cref="Circle"/> and another one are intersecting </summary>
        /// <param name="circle"> Target <see cref="Circle"/> </param>
        /// <returns> true if the distance between the edges of this <see cref="Circle"/> and <paramref name="circle"/> is &lt;=0</returns>
        public bool IntersectsSphere(Circle circle)
            => Distance_Edge(circle) <= 0;

        //TODO: TEST Circle.howClose(Point)
        /// <returns> Ratio of how close <paramref name="point"/> is to <see cref="Center"/>
        /// relative to <see cref="Radius"/> </returns>
        public double HowClose(Point point) {
            double distance = Center.Distance(point);
            //? close 0 -- 1 far
            double ratio_inverse = distance / Radius;
            //? close 1 -- 0 far
            double ratio = sMath.Abs(ratio_inverse - 1);
            return ratio.AtOrBetween(0, 1);
        }

        /// <summary> Center <see cref="Point"/> of this <see cref="Circle"/> </summary>
        public Point Center { get; set; }
        /// <summary> Radius of this <see cref="Circle"/> </summary>
        public double Radius { get; set; }
        /// <summary> Area of this <see cref="Circle"/> </summary>
        public double Area
            => sMath.PI * sMath.Pow(Radius, 2);

        /// <summary> A representation of a circle in 2D space
        /// <br/> Generated with center poistion and radius data </summary>
        /// <param name="x"> Position of <see cref="Center"/> on the x-axis </param>
        /// <param name="y"> Position of <see cref="Center"/> on the y-axis </param>
        /// <param name="radius"> Radius of this <see cref="Circle"/> </param>
        public Circle(double x, double y, double radius) {
            Center = new Point(x, y);
            Radius = radius;
        }
        /// <summary> A representation of a circle in 2D space
        /// <br/> Generated with center <see cref="Point"/> and radius data </summary>
        /// <param name="center"> Center <see cref="Point"/> of this <see cref="Circle"/> </param>
        /// <param name="radius"> Radius of this <see cref="Circle"/> </param>
        public Circle(Point center, double radius) {
            Center = center;
            Radius = radius;
        }
    }
}
