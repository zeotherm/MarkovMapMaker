using System;
using System.Collections.Generic;
using System.Text;

namespace HexMap {
    public enum State { EMPTY, SEA, LAND };
    public class MarkovMapper {
        public State GenerateNewState(Hex n) {
            State neighborState = n.Type;
            Random r = new Random();
            if (neighborState == State.EMPTY) throw new ArgumentException("A given neighbor cell did not have it's state set");
            if( neighborState == State.SEA) {
                // 80% chance we stay SEA and 20% chance we change to Land
                if ( r.NextDouble() <= 0.2) {
                    return State.LAND;
                } else {
                    return State.SEA;
                }
            } else {
                // 95% chance we stay land and 5% chance we switch to SEA
                if( r.NextDouble() <= 0.05) {
                    return State.SEA;
                } else {
                    return State.LAND;
                }
            }
            //return State.LAND;
        }
    }
}
