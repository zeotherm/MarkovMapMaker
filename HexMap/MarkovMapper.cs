using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HexMap {
    public enum State { SEA = 0, LAND = 1, HILL = 2, MOUNTAIN = 3, EMPTY };
    public class MarkovMapper {
        public readonly double[,] tM;
        private double SS, SL, SH, SM;
        private double LS, LL, LH, LM;
        private double HS, HL, HH, HM;
        private double MS, ML, MH, MM;
        private Random r;

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
            SM = SH + tM[(int)State.SEA, (int)State.MOUNTAIN];
            LS = tM[(int)State.LAND, (int)State.SEA];
            LL = LS + tM[(int)State.LAND, (int)State.LAND];
            LH = LL + tM[(int)State.LAND, (int)State.HILL];
            LM = LH + tM[(int)State.LAND, (int)State.MOUNTAIN];
            HS = tM[(int)State.HILL, (int)State.SEA];
            HL = HS + tM[(int)State.HILL, (int)State.LAND];
            HH = HL + tM[(int)State.HILL, (int)State.HILL];
            HM = HH + tM[(int)State.HILL, (int)State.MOUNTAIN];
            MS = tM[(int)State.MOUNTAIN, (int)State.SEA];
            ML = MS + tM[(int)State.MOUNTAIN, (int)State.LAND];
            MH = ML + tM[(int)State.MOUNTAIN, (int)State.HILL];
            MM = MH + tM[(int)State.MOUNTAIN, (int)State.MOUNTAIN];

            Debug.Assert(LM == 1.0);

            Debug.Assert(SM == 1.0);

            Debug.Assert(HM == 1.0);

            Debug.Assert(MM == 1.0);

            r = new Random();
        }

        public State GenerateNewState(Hex n) {
            State neighborState = n.Type;
            if (neighborState == State.EMPTY) throw new ArgumentException("A given neighbor cell did not have it's state set");
            var p = r.NextDouble();
            if (neighborState == State.SEA) {
                if (p <= SS) return State.SEA;
                if (p <= SL) return State.LAND;
                if (p <= SH) return State.HILL;
                return State.MOUNTAIN;
            }

            else if( neighborState == State.LAND) {
                if (p <= LS) return State.SEA;
                if (p <= LL) return State.LAND;
                if (p <= LH) return State.HILL;
                return State.MOUNTAIN;
            } 
            
            else if (neighborState == State.HILL) {
                if (p <= HS) return State.SEA;
                if (p <= HL) return State.LAND;
                if (p <= HH) return State.HILL;
                return State.MOUNTAIN;
            }
            
            else {
                if (p <= MS) return State.SEA;
                if (p <= ML) return State.LAND;
                if (p <= MH) return State.HILL;
                return State.MOUNTAIN;
            }
       }
    }
}
