using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
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
        private List<Tuple<int, int>> Locations = new List<Tuple<int, int>>();
        private MarkovMapper m = new MarkovMapper();

        public Form1() {
            InitializeComponent();
        }

        private void pBox_Paint(object sender, PaintEventArgs e) {
            // determine how many hexagons we can fit in the space given a size value
            // N hexagons high = hex_height*(1 + 0.75*N) total height
            // (size.h/hex_height - 1)/0.75 = N high
            // M hexagons wide = hex_width*(M + 0.5) total width
            // (size.w/hex_width - 0.5) = M wide
            lblWide.Text = M.ToString();
            lblHigh.Text = N.ToString();
            lblWidth.Text = String.Format("{0:0.000}", hex_width);
            lblHeight.Text = String.Format("{0:0.000}", hex_height);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            l = new Layout(o, new Point(hex_size, hex_size), new Point(hOffset, vOffset));
            using (Pen big_pen = new Pen(Color.Black, brushThickness))
            using (Font f = new Font("Arial", 10)) {
                foreach (var hex in storage.Values) {
                    var points = l.PolygonCorners(hex);
                    e.Graphics.DrawPolygon(big_pen, points);
                    if (hex.Filled)
                        e.Graphics.FillPolygon(Brushes.Red, points);
                    Brush b = Brushes.Black;
                    switch (hex.Type) {
                        case State.LAND:
                            b = Brushes.Green;
                            break;
                        case State.SEA:
                            b = Brushes.CornflowerBlue;
                            break;
                    }
                    if (hex.Type != State.EMPTY) {
                        e.Graphics.FillPolygon(b, points);
                    }
                    if (showCoordsChk.Checked) {
                        var center = l.CenterPixel(hex);
                        var topleft = new PointF(center.X - hex_size / 1.8f, center.Y - hex_size / 2.0f);
                        e.Graphics.DrawString($"{hex.q}, {hex.r}", f, Brushes.Black, topleft);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            foreach (var hex in storage.Values) {
                hex.ClearFilled();
                hex.EraseType();
            }
            this.Refresh();
        }

        private void pBox_MouseMove(object sender, MouseEventArgs e) {
            xCoordLbl.Text = e.X.ToString();
            yCoordLbl.Text = e.Y.ToString();
        }

        private void pBox_MouseLeave(object sender, EventArgs e) {
            xCoordLbl.Text = String.Empty;
            yCoordLbl.Text = String.Empty;
        }

        private void getPtsBtn_Click(object sender, EventArgs e) {
            var input = hexPtsTxt.Text;
            var q_r = input.Split(',');
            if (q_r.Length != 2) return;
            int q, r;
            try {
                q = Convert.ToInt32(q_r[0]);
                r = Convert.ToInt32(q_r[1]);
            } catch (FormatException) {
                return;
            }
            var t = new Tuple<int, int>(q, r);
            if (!storage.ContainsKey(t)) return;
            var corners = l.PolygonCorners(storage[t]);
            hPt1Lbl.Text = corners[0].ToString();
            hPt2Lbl.Text = corners[1].ToString();
            hPt3Lbl.Text = corners[2].ToString();
            hPt4Lbl.Text = corners[3].ToString();
            hPt5Lbl.Text = corners[4].ToString();
            hPt6Lbl.Text = corners[5].ToString();
        }

        private void clickHereBtn_Click(object sender, EventArgs e) {
            var pinpoint = forceClickLocationTxt.Text.Split(',');
            int x, y;
            if (pinpoint.Length != 2) return;
            try {
                x = Convert.ToInt32(pinpoint[0]);
                y = Convert.ToInt32(pinpoint[1]);
            } catch (FormatException) {
                return;
            }
            var meA = new MouseEventArgs(MouseButtons.Left, 1, x, y, 0);
            pBox_DoubleClick(sender, meA);
        }

        private async void genBtn_ClickAsync(object sender, EventArgs e) {
            Random rand = new Random();
            // Start at the top left, assigning states as we go along
            var emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
            Hex h = storage[new Tuple<int, int>(0,0)];
            emptyLocsLbl.Text = emptyLocations.Count.ToString();
            Stack<Tuple<int, int>> neighborStack = new Stack<Tuple<int, int>>();
            var nbs = GetNeighborCoords(h).Where(c => storage[c].Type == State.EMPTY).ToList();
            nbs.Shuffle();
            foreach (var eNeighb in nbs) {
                neighborStack.Push(eNeighb);
            }
            while (neighborStack.Count != 0) {
                var noi = neighborStack.Pop();
                if (storage[noi].Type != State.EMPTY) continue;
                await DrawNewState(h, noi);
                h = storage[noi];
                var inbs = GetNeighborCoords(h).Where(c => storage[c].Type == State.EMPTY).ToList();
                inbs.Shuffle();

                foreach (var eNeighb in inbs) {
                    neighborStack.Push(eNeighb);
                }
                stackDepthLbl.Text = neighborStack.Count().ToString();
                emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
                var empties = emptyLocations.Count;
                emptyLocsLbl.Text = empties.ToString();
                if (empties == 0) break;

            }
            MessageBox.Show("Done!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Refresh();
        }
        private async Task DrawNewState(Hex h, Tuple<int, int> coord) {
            await Task.Delay(25);
            storage[coord].SetType(m.GenerateNewState(h));
            this.Refresh();
        }

        private List<Tuple<int, int>> GetNeighborCoords(Hex h) =>
            h.Neighbors().Select(n => new Tuple<int, int>(n.q, n.r)).Where(k => storage.ContainsKey(k)).ToList();
        
        private bool HasEmptyNeighbors(Tuple<int, int> c) {
            return storage[c].Neighbors().Any(h => h.Type == State.EMPTY);
        }

        private Tuple<int, int> Coord(int q, int r) => new Tuple<int, int>(q, r);

        private void drawButton_Click(object sender, EventArgs e) {
            if (pointyRadio.Checked)
                pointyRadio_CheckedChanged(sender, e);
            else
                flatRadio_CheckedChanged(sender, e);
        }

        private void pointyRadio_CheckedChanged(object sender, EventArgs e) {
            storage.Clear();
            Locations.Clear();
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
                    var qr = new Tuple<int, int>(q, r);
                    Locations.Add(qr);
                    storage[qr] = new Hex(q, r);
                }
            }

            this.Refresh();
        }

        private void flatRadio_CheckedChanged(object sender, EventArgs e) {
            storage.Clear();
            Locations.Clear();
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
                    var qr = new Tuple<int, int>(q, r);
                    Locations.Add(qr);
                    storage[qr] = new Hex(q, r);
                }
            }

            this.Refresh();
        }

        private void pBox_DoubleClick(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            lastXClickCoordLbl.Text = coordinates.X.ToString();
            lastYCoordClickLbl.Text = coordinates.Y.ToString();
            var corrected = new Point(coordinates.X + (l.origin.X - brushThickness), 
                                      coordinates.Y + (l.origin.Y - brushThickness));
            var myHex = l.GetFromClick(coordinates);
            var t = new Tuple<int, int>(myHex.q, myHex.r);
            qValLbl.Text = myHex.q.ToString();
            rValLbl.Text = myHex.r.ToString();
            if (storage.ContainsKey(t)) storage[t].CycleType();
            this.Refresh();
        }

        private void pBox_Click(object sender, EventArgs e) {

        }
    }
}
