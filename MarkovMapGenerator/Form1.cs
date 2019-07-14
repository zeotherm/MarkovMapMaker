using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HexMap;

namespace MarkovMapGenerator {
    public partial class Form1 : Form {
        private Layout l;
        private Dictionary<Tuple<int, int>, Hex> storage = new Dictionary<Tuple<int, int>, Hex>();
        private List<Brush> ColorWheel = new List<Brush> { Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Purple };
        private int brushThickness = 1;
        private int N, M, vOffset, hOffset, hex_size;
        private HexMap.Orientation o;
        private double hex_width, hex_height;
        public Form1() {
            InitializeComponent();
        }

        private void pBox_Paint(object sender, PaintEventArgs e) {
            // determine how many hexagons we can fit in the space given a size value
            var h = pBox.Size.Height;
            var w = pBox.Size.Width;
            // N hexagons high = hex_height*(1 + 0.75*N) total height
            // (size.h/hex_height - 1)/0.75 = N high
            // M hexagons wide = hex_width*(M + 0.5) total width
            // (size.w/hex_width - 0.5) = M wide
            lblWide.Text = M.ToString();
            lblHigh.Text = N.ToString();
            lblWidth.Text = String.Format("{0:0.000}", hex_width);
            lblHeight.Text = String.Format("{0:0.000}", hex_height);
            l = new Layout(o, new Point(hex_size, hex_size), new Point(hOffset, vOffset));
            using (Pen big_pen = new Pen(Color.Black, brushThickness)) {
                foreach (var hex in storage.Values) {
                    e.Graphics.DrawPolygon(big_pen, l.PolygonCorners(hex));
                    if (hex.Filled)
                        e.Graphics.FillPolygon(Brushes.Red, l.PolygonCorners(hex));
                }
            }
        }

        private void drawButton_Click(object sender, EventArgs e) {
            if (pointyRadio.Checked)
                pointyRadio_CheckedChanged(sender, e);
            else
                flatRadio_CheckedChanged(sender, e);
        }

        private void pointyRadio_CheckedChanged(object sender, EventArgs e) {
            storage.Clear();
            // refill storage so that things draw correctly
            double ws, hs;
            o = HexMap.Layout.pointy;
            hex_size = Convert.ToInt32(sizeBox.Text);
            hex_width = Math.Sqrt(3) * hex_size;
            hex_height = hex_size * 2.0;
            vOffset = (int)Math.Ceiling(hex_height / 2.0) + brushThickness;
            hOffset = hex_size + brushThickness;
            hs = (pBox.Height / hex_height - 1.0) / 0.75;
            ws = pBox.Width / hex_width - 1.5;
            N = Convert.ToInt32(hs);
            M = Convert.ToInt32(ws);
            for (int r = 0; r < N; r++) {
                int r_offset = (int)Math.Floor(r / 2.0); // or r>>1
                for (int q = -r_offset; q < M - r_offset; q++) {
                    storage[new Tuple<int, int>(q, r)] = new Hex(q, r);
                }
            }


            this.Refresh();
        }

        private void flatRadio_CheckedChanged(object sender, EventArgs e) {
            storage.Clear();
            // refill storage so that things draw correctly
            double ws, hs;
            o = HexMap.Layout.flat;
            int hex_size = Convert.ToInt32(sizeBox.Text);

            hex_width = hex_size * 2.0;
            hex_height = Math.Sqrt(3) * hex_size;
            vOffset = hex_size + brushThickness;
            hOffset = (int)Math.Ceiling(hex_width / 2.0) + brushThickness;
            hs = pBox.Height / hex_height - 1.5;
            ws = (pBox.Width / hex_width - 1.0) / 0.75;
            N = Convert.ToInt32(hs);
            M = Convert.ToInt32(ws);

            for (int q = 0; q < M; q++) {
                int q_offset = (int)Math.Floor(q / 2.0); // or r>>1
                for (int r = -q_offset; r < N - q_offset; r++) {
                    var this_hex = new Hex(q, r);
                    storage[new Tuple<int, int>(q, r)] = new Hex(q, r);
                }
            }

            this.Refresh();
        }

        private void pBox_DoubleClick(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            var myHex = l.GetFromClick(coordinates);
            var t = new Tuple<int, int>(myHex.q, myHex.r);
            storage[t].SetFilled();
            this.Refresh();
        }

        private void pBox_Click(object sender, EventArgs e) {

        }
    }
}
