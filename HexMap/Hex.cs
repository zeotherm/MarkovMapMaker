using System;
using System.Collections.Generic;

namespace HexMap {
    public class Hex : IEquatable<Hex> {
        public readonly int q;
        public readonly int r;
        public readonly int s;

        public Hex(int q, int r, int s) {
            this.q = q;
            this.r = r;
            this.s = s;
            if (q + r + s != 0) throw new ArgumentException("q + r + s must equal 0");
        }

        public Hex(int q, int r) {
            this.q = q;
            this.r = r;
            this.s = -q - r; // for constraint q + r + s == 0
        }

        public static Hex operator +(Hex l, Hex r) => new Hex(l.q + r.q, l.r + r.r, l.s + r.s);
        public static Hex operator -(Hex l, Hex r) => new Hex(l.q - r.q, l.r - r.r, l.s - r.s);
        public static Hex operator *(Hex h, int k) => new Hex(h.q * k, h.r * k, h.s * k);

        private int length() => Convert.ToInt32((Math.Abs(q) + Math.Abs(r) + Math.Abs(s)) / 2.0);

        public int Distance(Hex other) => (this - other).length();

        public Hex RotateRight() => new Hex(-r, -s, -q);
        public Hex RotateLeft() => new Hex(-s, -q, -r);

        private static List<Hex> directions = new List<Hex>{new Hex(1, 0, -1), new Hex(1, -1, 0), new Hex(0, -1, 1),
                                                      new Hex(-1, 0, 1), new Hex(-1, 1, 0), new Hex(0, 1, -1)};

        private static Hex direction(int d) {
            if (d < 0 || d >= 6) throw new ArgumentException("Direction must be a side value between 0 and 5");
            return Hex.directions[d];
        }

        public Hex Neighbor(int d) => this + Hex.direction(d);

        private static List<Hex> diagonals = new List<Hex> { new Hex(2, -1, -1), new Hex(1, -2, 1),  new Hex(-1, -1, 2),
                                                       new Hex(-2, 1, 1),  new Hex(-1, 2, -1), new Hex(1, 1, -2) };

        private static Hex diag_direction(int d) {
            if (d < 0 || d >= 6) throw new ArgumentException("Direction must be a side value between 0 and 5");
            return Hex.diagonals[d];
        }

        public Hex DiagonalNeighbor(int d) => this + Hex.diag_direction(d);

        public bool Equals(Hex other) {
            if (other == null)
                return false;

            if (this.q == other.q && this.r == other.r && this.s == other.s)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj) {
            if (obj == null)
                return false;

            if (!(obj is Hex hexObj))
                return false;
            else
                return Equals(hexObj);
        }

        public override int GetHashCode() {
            int hash = 23;
            hash = hash * 31 + this.q;
            hash = hash * 31 + this.r;
            hash = hash * 31 + this.s;
            return hash;
        }

        public static bool operator ==(Hex l, Hex r) {
            if (((object)l) == null || ((object)r) == null)
                return Object.Equals(l, r);

            return l.Equals(r);
        }

        public static bool operator !=(Hex l, Hex r) {
            if (((object)l) == null || ((object)r) == null)
                return !Object.Equals(l, r);

            return !(l.Equals(r));
        }
    }

}
