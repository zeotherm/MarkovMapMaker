using System;
namespace HexMap {
    public class Layout {
        public Layout() {
        }

        public static Orientation pointy = new Orientation(Math.Sqrt(3.0), Math.Sqrt(3.0) / 2.0, 0.0, 1.5, 0.5);
        public static Orientation flat = new Orientation(1.5, 0.0, Math.Sqrt(3.0) / 2.0, Math.Sqrt(3.0), 0.0);
    }
}
