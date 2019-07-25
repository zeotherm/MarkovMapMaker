using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HexMap {
    public enum State { SEA = 0, LAND = 1, HILL = 2, EMPTY };
    public class MarkovMapper {
        public readonly double[,] tM;
        private double SS, SL, SH;
        private double LS, LL, LH;
        private double HS, HL, HH;

        public MarkovMapper(double[,] t) {
            tM = t;
            //int s = Convert.ToInt32(Math.Sqrt(t.Length));
            //for( var r = 0; r < s; r++) {
            //    double sum = 0.0;
            //    for ( var c = 0; c < s; c++) {
            //        sum += tM[r,c];
            //    }
            //    Debug.Assert(sum == 1.0);
            //}

            SS = tM[(int)State.SEA, (int)State.SEA];
            SL = SS + tM[(int)State.SEA, (int)State.LAND];
            SH = SL + tM[(int)State.SEA, (int)State.HILL];
            LS = tM[(int)State.LAND, (int)State.SEA];
            LL = LS + tM[(int)State.LAND, (int)State.LAND];
            LH = LL + tM[(int)State.LAND, (int)State.HILL];
            HS = tM[(int)State.HILL, (int)State.SEA];
            HL = HS + tM[(int)State.HILL, (int)State.LAND];
            HH = HL + tM[(int)State.HILL, (int)State.HILL];

            Debug.Assert(LH == 1.0);

            Debug.Assert(SH == 1.0);

            Debug.Assert(HH == 1.0);
        }

        public State GenerateNewState(Hex n) {
            State neighborState = n.Type;
            Random r = new Random();
            if (neighborState == State.EMPTY) throw new ArgumentException("A given neighbor cell did not have it's state set");
            var p = r.NextDouble();
            if (neighborState == State.SEA) {
                if (p <= SS) return State.SEA;
                if (p <= SL) return State.LAND;
                return State.HILL;
            }

            else if( neighborState == State.LAND) {
                if (p <= LS) return State.SEA;
                if (p <= LL) return State.LAND;
                return State.HILL;
            }

            else {
                if (p <= HS) return State.SEA;
                if (p <= HL) return State.LAND;
                return State.HILL;
            }
       }
    }
}
