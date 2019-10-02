using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HexMap;

namespace MarkovMapGenerator {
    public partial class MapDisplay : Form {
        private Dictionary<Tuple<int, int>, Hex> storage = new Dictionary<Tuple<int, int>, Hex>();
        private int brushThickness = 1;
        private int vOffset, hOffset, hex_size;
        private double hex_width, hex_height;
        private List<Tuple<int, int>> Locations = new List<Tuple<int, int>>();
        private MarkovMapper m;
        private bool mapperInitialized;
        private TransitionProbabilitiesForm transForm;
        private Layout l;

        public MapDisplay() {
            InitializeComponent();
            mapperInitialized = false;
            transForm = new TransitionProbabilitiesForm();
        }

        private List<Tuple<int, int>> GetNeighborCoords(Hex h) =>
            h.Neighbors().Select(n => new Tuple<int, int>(n.q, n.r)).Where(k => storage.ContainsKey(k)).ToList();

        private bool HasEmptyNeighbors(Tuple<int, int> c) => storage[c].Neighbors().Any(h => h.Type == State.EMPTY);

        private Tuple<int, int> Coord(int q, int r) => new Tuple<int, int>(q, r);

        private async void genBtn_ClickAsync(object sender, EventArgs e) {
            InitializeGrid();
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
            if (topLeft.Type == State.EMPTY) topLeft.SetType(initState);
            var emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
            Hex currentHex = topLeft;
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

                var nextHexAssignedNeighbors = GetNeighborCoords(nextHex).Where(nh => storage[nh].Type != State.EMPTY);

                var neighborHexes = nextHexAssignedNeighbors.Select(n => storage[n]);

                Hex filledNeighbor = null;
                if (nextHexAssignedNeighbors.Count() > 0) {
                    filledNeighbor = storage[nextHexAssignedNeighbors.First()];
                }

                await DrawNewState(filledNeighbor, nextHexCoord);

                currentHex = nextHex;
                var inbs = GetNeighborCoords(currentHex).Where(c => storage[c].Type == State.EMPTY).ToList();
                inbs.Shuffle();

                foreach (var eNeighb in inbs) {
                    hexCoordStack.Push(eNeighb);
                }
                emptyLocations = Locations.Where(t => storage[t].Type == State.EMPTY).ToList();
                var empties = emptyLocations.Count;
                if (empties == 0) break;

            }
            MessageBox.Show("Done!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Refresh();

        }

        private async Task DrawNewState(Hex markovBasis, Tuple<int, int> newHexCoords) {
            //await Task.Delay(10);
            storage[newHexCoords].SetType(m.GenerateNewState(markovBasis));
            this.Refresh();
        }

        private void trnsBtn_Click(object sender, EventArgs e) {
            if (transForm.ShowDialog() == DialogResult.OK) {
                m = new MarkovMapper(transForm.Transitions);
                mapperInitialized = true;
                UpdateTransitionDisplay();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e) {
            foreach (var hex in storage.Values) {
                hex.ClearFilled();
                hex.EraseType();
            }
            this.Refresh();
        }

        private void mapDisplayBox_DoubleClick(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            var corrected = new Point(coordinates.X + (l.origin.X - brushThickness),
                                      coordinates.Y + (l.origin.Y - brushThickness));
            var myHex = l.GetFromClick(coordinates);
            var t = new Tuple<int, int>(myHex.q, myHex.r);
            if (storage.ContainsKey(t)) storage[t].CycleType();
            this.Refresh();
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

            SSTransLbl.Text = String.Format("{0:0.000}", SS);
            SLTransLbl.Text = String.Format("{0:0.000}", SL);
            SHTransLbl.Text = String.Format("{0:0.000}", SH);
            SMTransLbl.Text = String.Format("{0:0.000}", SM);
            LSTransLbl.Text = String.Format("{0:0.000}", LS);
            LLTransLbl.Text = String.Format("{0:0.000}", LL);
            LHTransLbl.Text = String.Format("{0:0.000}", LH);
            LMTransLbl.Text = String.Format("{0:0.000}", LM);
            HSTransLbl.Text = String.Format("{0:0.000}", HS);
            HLTransLbl.Text = String.Format("{0:0.000}", HL);
            HHTransLbl.Text = String.Format("{0:0.000}", HH);
            HMTransLbl.Text = String.Format("{0:0.000}", HM);
            MSTransLbl.Text = String.Format("{0:0.000}", MS);
            MLTransLbl.Text = String.Format("{0:0.000}", ML);
            MHTransLbl.Text = String.Format("{0:0.000}", MH);
            MMTransLbl.Text = String.Format("{0:0.000}", MM);
        }

        private void InitializeGrid() {
            storage.Clear();
            Locations.Clear();
            // refill storage so that things draw correctly
            double ws, hs;
            hex_size = Convert.ToInt32(100 - mapSizeBar.Value);
            hex_width = Math.Sqrt(3) * hex_size;
            hex_height = hex_size * 2.0;
            vOffset = (int)Math.Ceiling(hex_height / 2.0) + brushThickness;
            hOffset = hex_size + brushThickness;
            hs = (mapDisplayBox.Height / hex_height - 1.0) / 0.75;
            ws = mapDisplayBox.Width / hex_width - 1.5;
            int N = Convert.ToInt32(hs);
            int M = Convert.ToInt32(ws);
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

        private void mapDisplayBox_Paint(object sender, PaintEventArgs e) {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            l = new Layout(HexMap.Layout.pointy, new Point(hex_size, hex_size), new Point(hOffset, vOffset));
            using (Pen big_pen = new Pen(Color.Black, brushThickness)) { 
                foreach (var hex in storage.Values) {
                    var points = l.PolygonCorners(hex);
                    //e.Graphics.DrawPolygon(big_pen, points);
                    Brush b = Brushes.Black;
                    e.Graphics.DrawPolygon(new Pen(Brushes.Black, 1), points);
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
                }
            }
        }


    }
}
