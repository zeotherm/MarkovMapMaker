using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HexMap;

namespace MarkovMapGenerator {
    public partial class DebugForm : Form {
        private Layout l;
        private Dictionary<Tuple<int, int>, Hex> storage = new Dictionary<Tuple<int, int>, Hex>();
        private List<Brush> ColorWheel = new List<Brush> { Brushes.Red, Brushes.Orange, Brushes.Yellow, Brushes.Green, Brushes.Blue, Brushes.Purple };
        private int brushThickness = 1;
        private int N, M, vOffset, hOffset, hex_size;
        private HexMap.Orientation o;
        private double hex_width, hex_height;
        private List<Tuple<int, int>> Locations = new List<Tuple<int, int>>();
        private MarkovMapper m;
        private bool mapperInitialized;
        private TransitionProbabilitiesForm transForm;

        public DebugForm() {
            InitializeComponent();
            mapperInitialized = false;
            transForm = new TransitionProbabilitiesForm();
            //mapperInitialized = true;
        }

        private void pBox_Paint(object sender, PaintEventArgs e) {
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
                    //e.Graphics.DrawPolygon(big_pen, points);
                    Brush b = Brushes.Black;
                    //e.Graphics.DrawPolygon(new Pen(Brushes.Black, 1), points);
                    switch (hex.Type) {
                        case State.LAND:
                            b = Brushes.Green;
                            break;
                        case State.SEA:
                            b = Brushes.CornflowerBlue;
                            break;
                        case State.HILL:
                            b = Brushes.SandyBrown;
                            break;
                        case State.MOUNTAIN:
                            b = Brushes.DarkGray;
                            break;
                    }
                    if (hex.Type != State.EMPTY) {
                        e.Graphics.FillPolygon(b, points);
                    }
                    if (hex.Filled)
                        e.Graphics.FillPolygon(Brushes.Red, points);
                    if (hex.CurrentProcessedHex)
                        e.Graphics.DrawPolygon(new Pen(Brushes.Red, 4), points);
                    if (hex.IsPrevStateHex)
                        e.Graphics.DrawPolygon(new Pen(Brushes.Black, 4), points);
                    if(hex.IsNeighborHighlight) {
                        e.Graphics.DrawPolygon(new Pen(Brushes.DarkOrange, 2), points);
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
            UpdateDetailsText();
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

        private void UpdateTransitionDisplay() {
            double SS, SL, SH, SM;
            double LS, LL, LH, LM;
            double HS, HL, HH, HM;
            double MS, ML, MH, MM;

            var tM = m.tM;

            SS = tM[(int)State.SEA, (int)State.SEA];
            SL = tM[(int)State.SEA, (int)State.LAND];
            SH = tM[(int)State.SEA, (int)State.HILL];
            SM = tM[(int)State.SEA, (int)State.MOUNTAIN];
            LS = tM[(int)State.LAND, (int)State.SEA];
            LL = tM[(int)State.LAND, (int)State.LAND];
            LH = tM[(int)State.LAND, (int)State.HILL];
            LM = tM[(int)State.LAND, (int)State.MOUNTAIN];
            HS = tM[(int)State.HILL, (int)State.SEA];
            HL = tM[(int)State.HILL, (int)State.LAND];
            HH = tM[(int)State.HILL, (int)State.HILL];
            HM = tM[(int)State.HILL, (int)State.MOUNTAIN];
            MS = tM[(int)State.MOUNTAIN, (int)State.SEA];
            ML = tM[(int)State.MOUNTAIN, (int)State.LAND];
            MH = tM[(int)State.MOUNTAIN, (int)State.HILL];
            MM = tM[(int)State.MOUNTAIN, (int)State.MOUNTAIN];

            CDF_SSLbl.Text = String.Format("{0:0.000}", SS);
            CDF_SLLbl.Text = String.Format("{0:0.000}", SL);
            CDF_SHLbl.Text = String.Format("{0:0.000}", SH);
            CDF_SMLbl.Text = String.Format("{0:0.000}", SM);
            CDF_LSLbl.Text = String.Format("{0:0.000}", LS);
            CDF_LLLbl.Text = String.Format("{0:0.000}", LL);
            CDF_LHLbl.Text = String.Format("{0:0.000}", LH);
            CDF_LMLbl.Text = String.Format("{0:0.000}", LM);
            CDF_HSLbl.Text = String.Format("{0:0.000}", HS);
            CDF_HLLbl.Text = String.Format("{0:0.000}", HL);
            CDF_HHLbl.Text = String.Format("{0:0.000}", HH);
            CDF_HMLbl.Text = String.Format("{0:0.000}", HM);
            CDF_MSLbl.Text = String.Format("{0:0.000}", MS);
            CDF_MLLbl.Text = String.Format("{0:0.000}", ML);
            CDF_MHLbl.Text = String.Format("{0:0.000}", MH);
            CDF_MMLbl.Text = String.Format("{0:0.000}", MM);
        }

        private async void genBtn_ClickAsync(object sender, EventArgs e) {
            Random rand = new Random();
            if (!mapperInitialized) m = new MarkovMapper(transForm.defaultTransitions);
            UpdateTransitionDisplay();
            // Start at the top left, assigning states as we go along
            State initState;
            if (rand.NextDouble() > 0.5) {
                initState = State.SEA;
            } else {
                initState = State.LAND;
            }
            var topLeft = storage[new Tuple<int, int>(0, 0)];
            if(topLeft.Type == State.EMPTY) topLeft.SetType(initState);
            var emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
            Hex currentHex = storage[new Tuple<int, int>(0,0)];
            emptyLocsLbl.Text = emptyLocations.Count.ToString();
            Stack<Tuple<int, int>> hexCoordStack = new Stack<Tuple<int, int>>();
            var nbs = GetNeighborCoords(currentHex).Where(c => storage[c].Type == State.EMPTY).ToList();
            nbs.Shuffle();
            foreach (var eNeighb in nbs) {
                hexCoordStack.Push(eNeighb);
            }
            while (hexCoordStack.Count != 0) {
                var nextHexCoord = hexCoordStack.Pop();
                var nextHex = storage[nextHexCoord];
                if (nextHex.Type != State.EMPTY) continue;
                //var nextHexAssignedNeighbors = nextHex.Neighbors()
                //    .SelectMany(nhn => GetNeighborCoords(nhn)).Where(nexth => storage[nexth].Type != State.EMPTY);

                var nextHexAssignedNeighbors = GetNeighborCoords(nextHex).Where(nh => storage[nh].Type != State.EMPTY);

                var neighborHexes = nextHexAssignedNeighbors.Select(n => storage[n]);

                foreach (var n in neighborHexes) {
                    if( n.Distance(nextHex) != 1) {
                        int rr = 0;
                    }
                }

                Hex filledNeighbor = null;
                if (nextHexAssignedNeighbors.Count() > 0) {
                    filledNeighbor = storage[nextHexAssignedNeighbors.First()];


                }
                //if( filledNeighbor == null) {
                //    filledNeighbor = currentHex;
                //}

                if( !storage[nextHexCoord].Neighbors().Contains(filledNeighbor)) {
                    int k = nextHexAssignedNeighbors.Count();
                }
                await DrawNewState(filledNeighbor, nextHexCoord);
                lblDistance.Text = nextHex.Distance(filledNeighbor).ToString();
                if (nextHex.Distance(filledNeighbor) != 1) {
                    int j = nextHex.Distance(filledNeighbor);
                    return;
                }
                currentHex = nextHex;
                var inbs = GetNeighborCoords(currentHex).Where(c => storage[c].Type == State.EMPTY).ToList();
                inbs.Shuffle();

                foreach (var eNeighb in inbs) {
                    hexCoordStack.Push(eNeighb);
                }
                stackDepthLbl.Text = hexCoordStack.Count().ToString();
                emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
                var empties = emptyLocations.Count;
                var counts = storage.Values.GroupBy(s => s.Type).ToDictionary(gdc => gdc.Key, gdc => gdc.Count());
                emptyLocsLbl.Text = counts.ContainsKey(State.EMPTY) ? counts[State.EMPTY].ToString() : "0";
                numSeaTxt.Text = counts.ContainsKey(State.SEA) ? counts[State.SEA].ToString() : "0";
                numLandTxt.Text = counts.ContainsKey(State.LAND) ? counts[State.LAND].ToString() : "0";
                numHillTxt.Text = counts.ContainsKey(State.HILL) ? counts[State.HILL].ToString() : "0";
                numMtnText.Text = counts.ContainsKey(State.MOUNTAIN) ? counts[State.MOUNTAIN].ToString() : "0";
                numEmptyTxt.Text = emptyLocsLbl.Text;
                if (empties == 0) break;

            }
            UpdateDetailsText();
            MessageBox.Show("Done!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Refresh();
        }
        private async Task DrawNewState(Hex markovBasis, Tuple<int, int> newHexCoords) {
            await Task.Delay(10);
            var thisHex = storage[newHexCoords];
            var neighbors = thisHex.Neighbors();
            foreach( var n in neighbors) {
                var neighKey = new Tuple<int, int>(n.q, n.r);
                if( storage.ContainsKey(neighKey)) storage[neighKey].SetNeighborHighlight();
            }


            storage[new Tuple<int, int>(markovBasis.q, markovBasis.r)].SetPrevStateBasis();
            storage[newHexCoords].SetType(m.GenerateNewState(markovBasis));
            storage[newHexCoords].SetCurrentProcessedHex();
            this.Refresh();
            int j;
            if (!neighbors.Contains(markovBasis)) {
                await Task.Delay(2000);
                j = 1;
            }
            storage[new Tuple<int, int>(markovBasis.q, markovBasis.r)].UnSetPrevStateBasis();
            storage[newHexCoords].UnSetCurrentProcessedHex();
            foreach (var n in neighbors) {
                var neighKey = new Tuple<int, int>(n.q, n.r);
                if (storage.ContainsKey(neighKey)) storage[neighKey].UnSetNeighborHighlight();
            }
        }

        private List<Tuple<int, int>> GetNeighborCoords(Hex h) =>
            h.Neighbors().Select(n => new Tuple<int, int>(n.q, n.r)).Where(k => storage.ContainsKey(k)).ToList();
        
        private bool HasEmptyNeighbors(Tuple<int, int> c) {
            return storage[c].Neighbors().Any(h => h.Type == State.EMPTY);
        }

        private Tuple<int, int> Coord(int q, int r) => new Tuple<int, int>(q, r);

        private void transPosBtn_Click(object sender, EventArgs e) {
            if(transForm.ShowDialog() == DialogResult.OK) {
                m = new MarkovMapper(transForm.Transitions);
                //m = new MarkovMapper(transForm.defaultTransitions);
                mapperInitialized = true;
                UpdateTransitionDisplay();
            }
        }

        private void drawButton_Click(object sender, EventArgs e) {
            if (pointyRadio.Checked)
                pointyRadio_CheckedChanged(sender, e);
            else
                flatRadio_CheckedChanged(sender, e);
            UpdateDetailsText();
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            using (Bitmap bitmap = new Bitmap(pBox.Width, pBox.Height)) {
                using (Graphics graphics = Graphics.FromImage(bitmap)) {
                    graphics.Clear(Color.Transparent);
                    graphics.DrawImage(pBox.Image, (bitmap.Width - pBox.Image.Width) / 2, (bitmap.Height - pBox.Image.Height) / 2);
                }

                var dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                bitmap.Save($@"{dir}\map.png", ImageFormat.Png);
            }
        }

        private void UpdateDetailsText() {
            numEmptyTxt.Text = "0";
            numSeaTxt.Text = "0";
            numLandTxt.Text = "0";
            numHillTxt.Text = "0";
            numMtnText.Text = "0";
            var groups = storage.Values.GroupBy(s => s.Type);
            foreach(var group in groups) {
                switch(group.Key) {
                    case State.EMPTY:
                        numEmptyTxt.Text = group.Count().ToString();
                        break;
                    case State.SEA:
                        numSeaTxt.Text = group.Count().ToString();
                        break;
                    case State.LAND:
                        numLandTxt.Text = group.Count().ToString();
                        break;
                    case State.HILL:
                        numHillTxt.Text = group.Count().ToString();
                        break;
                    case State.MOUNTAIN:
                        numMtnText.Text = group.Count().ToString();
                        break;
                }
            }
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
            UpdateDetailsText();
            this.Refresh();
        }

        private void pBox_Click(object sender, EventArgs e) {

        }
    }
}
