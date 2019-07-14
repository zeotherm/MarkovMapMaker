using System;
namespace HexMap {

    public struct Orientation {
        // M is the matrix that transforms a vector [q,r] to the eqivalent [x,y]
        public readonly double M_00;
        public readonly double M_01;
        public readonly double M_10;
        public readonly double M_11;
        public readonly double Minv_00;
        public readonly double Minv_01;
        public readonly double Minv_10;
        public readonly double Minv_11;
        public readonly double start_angle; // In radians
        public Orientation(double M_00, double M_01, double M_10, double M_11, double start_angle) {
            this.M_00 = M_00;
            this.M_01 = M_01;
            this.M_10 = M_10;
            this.M_11 = M_11;
            var det = M_00 * M_11 - M_01 * M_10;
            this.Minv_00 = M_11 / det;
            this.Minv_01 = -M_01 / det;
            this.Minv_10 = -M_10 / det;
            this.Minv_11 = M_00 / det;
            this.start_angle = start_angle;
        }
    }
}
