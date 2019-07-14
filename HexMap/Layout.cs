using System;
using System.Collections.Generic;
using System.Drawing;

namespace HexMap {
    public class Layout {
        public readonly Orientation orientation;
        public readonly Point size;
        public readonly Point origin;

        public Layout(Orientation o, Point size, Point origin) {
            this.orientation = o;
            this.size = size;
            this.origin = origin;
        }

        public static Orientation pointy = new Orientation(Math.Sqrt(3.0), Math.Sqrt(3.0) / 2.0, 0.0, 1.5, 0.5);
        public static Orientation flat = new Orientation(1.5, 0.0, Math.Sqrt(3.0) / 2.0, Math.Sqrt(3.0), 0.0);

        public PointF CenterPixel(Hex h) {
            Orientation O = orientation;
            var x = (float)(O.M_00 * h.q + O.M_01 * h.r) * size.X;
            var y = (float)(O.M_10 * h.q + O.M_11 * h.r) * size.Y;
            return new PointF(x + origin.X, y + origin.Y);
        }

        public Hex GetFromClick(Point p) {
            Orientation O = orientation;

            var pt = new PointF((float)(p.X - origin.X) / size.X, (float)(p.Y - origin.Y) / size.Y);
            double q = O.Minv_00 * pt.X + O.Minv_01 * pt.Y;
            double r = O.Minv_10 * pt.X + O.Minv_11 * pt.Y;
            return new Hex(q, r, -q - r);
        }

        private PointF CornerOffset(int corner) {
            Orientation O = orientation;
            double angle = 2.0 * Math.PI * (O.start_angle - corner) / 6.0;
            return new PointF(size.X * (float)Math.Cos(angle), size.Y * (float)Math.Sin(angle));
        }

        public PointF[] PolygonCorners(Hex h) {
            var corners = new List<PointF>();
            PointF center = CenterPixel(h);
            for( int i = 0; i < 6; i++) {
                var offset = CornerOffset(i);
                corners.Add(new PointF(center.X + offset.X, (center.Y + offset.Y)));
            }
            return corners.ToArray();
        }

        public PointF[] SectionCorners(Hex h, int s) {
            var trianglePoints = new List<PointF>();
            PointF center = CenterPixel(h);
            var p1 = CornerOffset(s);
            var p2 = CornerOffset((s + 1) % 6);
            trianglePoints.Add(new PointF(center.X, center.Y));
            trianglePoints.Add(new PointF(center.X + p1.X, center.Y + p1.Y));
            trianglePoints.Add(new PointF(center.X + p2.X, center.Y + p2.Y));
            return trianglePoints.ToArray();
        }
    }
}
