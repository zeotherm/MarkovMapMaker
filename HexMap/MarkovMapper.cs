using System;
using System.Collections.Generic;
using System.Text;

namespace HexMap {
    public enum State { SEA = 0, LAND = 1, EMPTY };
    public class MarkovMapper {
        public readonly double[,] transitionMatrix;

        public MarkovMapper(double[,] t) => transitionMatrix = t;

        public State GenerateNewState(Hex n) {
            State neighborState = n.Type;
            Random r = new Random(1000);
            if (neighborState == State.EMPTY) throw new ArgumentException("A given neighbor cell did not have it's state set");
            if( neighborState == State.SEA) {
                if ( r.NextDouble() <= transitionMatrix[(int)State.SEA, (int)State.LAND]) {
                    return State.LAND;
                } else {
                    return State.SEA;
                }
            } else {
                // 95% chance we stay land and 5% chance we switch to SEA
                if( r.NextDouble() <= transitionMatrix[(int)State.LAND,(int)State.SEA]) {
                    return State.SEA;
                } else {
                    return State.LAND;
                }
            }
            //return State.LAND;
        }
    }
}
