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
            this.Type = State.EMPTY;
            if (q + r + s != 0) throw new ArgumentException("q + r + s must equal 0");
        }
        public bool Filled { get; private set; }
        public void SetFilled() => Filled = true;
        public void ClearFilled() => Filled = false;

        public bool IsPrevStateHex { get; private set; }
        public void SetPrevStateBasis() => IsPrevStateHex = true;
        public void UnSetPrevStateBasis() => IsPrevStateHex = false;

        public bool IsNeighborHighlight { get; private set; }
        public void SetNeighborHighlight() => IsNeighborHighlight = true;
        public void UnSetNeighborHighlight() => IsNeighborHighlight = false;

        public bool CurrentProcessedHex { get; private set; }
        public void SetCurrentProcessedHex() => CurrentProcessedHex = true;
        public void UnSetCurrentProcessedHex() => CurrentProcessedHex = false;

        public State Type { get; private set; }
        public void CycleType() {
            switch (Type) {
                case State.EMPTY:
                    Type = State.SEA;
                    break;
                case State.SEA:
                    Type = State.LAND;
                    break;
                case State.LAND:
                    Type = State.HILL;
                    break;
                case State.HILL:
                    Type = State.MOUNTAIN;
                    break;
                case State.MOUNTAIN:
                    Type = State.EMPTY;
                    break;
            }
        }
        public void SetType(State t) => Type = t;
        public void EraseType() => Type = State.EMPTY;
        public void Clear() {
            ClearFilled();
            EraseType();
        }
        public Hex(double qf, double rf, double sf) {
            if (Math.Round(qf + rf + sf) != 0) throw new ArgumentException("q + r + s must be 0");

            int qi = Convert.ToInt32(Math.Round(qf));
            int ri = Convert.ToInt32(Math.Round(rf));
            int si = Convert.ToInt32(Math.Round(sf));

            double q_diff = Math.Abs(qi - qf);
            double r_diff = Math.Abs(ri - rf);
            double s_diff = Math.Abs(si - sf);
            if (q_diff > r_diff && q_diff > s_diff) {
                qi = -ri - si;
            } else
                if (r_diff > s_diff) {
                ri = -qi - si;
            } else {
                si = -qi - ri;
            }
            this.q = qi;
            this.s = si;
            this.r = ri;
        }

        public Hex(int q, int r) {
            this.q = q;
            this.r = r;
            this.s = -q - r; // for constraint q + r + s == 0
            this.Type = State.EMPTY;
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

        public List<Hex> Neighbors() {
            List<Hex> ret = new List<Hex>();
            for ( int i = 0; i < 6; i++) {
                ret.Add(Neighbor(i));
            }
            return ret;
        }

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
