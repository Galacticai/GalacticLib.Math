/// —————————————————————————————————————————————
//?
//!? 📜 Circle.cs
//!? 🖋️ Galacticai 📅 2022
//!  ⚖️ GPL-3.0-or-later
//?  🔗 Dependencies:
//      + (Galacticai) Math/Space2D/Point.cs
//?
/// —————————————————————————————————————————————


using GalacticLib.Math.Numerics;
using sMath = System.Math;

namespace GalacticLib.Math.Space2D {
    internal class Circle {
        public static readonly Circle UNIT_CIRCLE = new(Point.ORIGIN, 1);

        public bool IncludesPoint(Point point)
            => Center.Distance(point) <= Radius;
        public bool PassThroughPoint(Point point)
            => Center.Distance(point) == Radius;

        public double Distance_Center(Circle circle)
            => Center.Distance(circle.Center);

        /// <returns>
        ///     <list type="bullet">
        ///     <item> &gt;0 • No intersection • The distance between the spheres </item>
        ///     <item> =0 • Touching edges </item>
        ///     <item> &lt;0 • Intersecting </item>
        ///     </list>
        /// </returns>
        public double Distance_Edge(Circle circle)
            => Distance_Center(circle) - (Radius + circle.Radius);

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


        public Point Center { get; set; }
        public double Radius { get; set; }
        public double Area
            => sMath.PI * sMath.Pow(Radius, 2);

        public Circle(double x, double y, double radius) {
            Center = new Point(x, y);
            Radius = radius;
        }
        public Circle(Point center, double radius) {
            Center = center;
            Radius = radius;
        }
    }
}
