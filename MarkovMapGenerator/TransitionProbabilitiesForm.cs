using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HexMap;

namespace MarkovMapGenerator {
    public partial class TransitionProbabilitiesForm : Form {
        private Color defaultColor;
        public double[,] Transitions { get; private set; }
        public readonly double[,] defaultTransitions;
        private List<TextBox> landEntries, seaEntries, hillEntries, mtnEntries;
        public TransitionProbabilitiesForm() {
            InitializeComponent();
            defaultColor = seaSumLbl.BackColor;
            Transitions = new double[4, 4];
            defaultTransitions = new double[4, 4]{{0.990, 0.010, 0.000, 0.000},
                                                  {0.005, 0.945, 0.040, 0.010},
                                                  {0.000, 0.750, 0.200, 0.050},
                                                  {0.001, 0.049, 0.400, 0.550}};

            landEntries = new List<TextBox> { landLandTxt, landSeaTxt, landHillText, landMtnText };
            seaEntries = new List<TextBox> { seaLandTxt, seaSeaTxt, seaHillText, seaMtnText };
            hillEntries = new List<TextBox> { hillLandText, hillSeaText, hillHillText, hillMtnText };
            mtnEntries = new List<TextBox> { mtnLandText, mtnSeaText, mtnHillText, mtnMtnText };
            seaSumLbl.Text = EntrySumAsText(seaEntries);
            landSumLbl.Text = EntrySumAsText(landEntries);
            hillSumLbl.Text = EntrySumAsText(hillEntries);
            mtnSumLbl.Text = EntrySumAsText(mtnEntries);
        }

        private String EntrySumAsText(List<TextBox> entries) => String.Format("{0:0.000}", entries.Sum(le => Convert.ToDouble(le.Text)));

        private void landLandTxt_TextChanged(object sender, EventArgs e) => landSumLbl.Text = EntrySumAsText(landEntries);

        private void landSeaTxt_TextChanged(object sender, EventArgs e) => landSumLbl.Text = EntrySumAsText(landEntries);

        private void landHillText_TextChanged(object sender, EventArgs e) => landSumLbl.Text = EntrySumAsText(landEntries);

        private void landMtnText_TextChanged(object sender, EventArgs e) => landSumLbl.Text = EntrySumAsText(landEntries);

        private void seaSeaTxt_TextChanged(object sender, EventArgs e) => seaSumLbl.Text = EntrySumAsText(seaEntries);

        private void seaLandTxt_TextChanged(object sender, EventArgs e) => seaSumLbl.Text = EntrySumAsText(seaEntries);

        private void seaHillText_TextChanged(object sender, EventArgs e) => seaSumLbl.Text = EntrySumAsText(seaEntries);

        private void seaMtnText_TextChanged(object sender, EventArgs e) => seaSumLbl.Text = EntrySumAsText(seaEntries);

        private void hillHillText_TextChanged(object sender, EventArgs e) => hillSumLbl.Text = EntrySumAsText(hillEntries);

        private void hillLandText_TextChanged(object sender, EventArgs e) => hillSumLbl.Text = EntrySumAsText(hillEntries);

        private void hillSeaText_TextChanged(object sender, EventArgs e) => hillSumLbl.Text = EntrySumAsText(hillEntries);

        private void hillMtnText_TextChanged(object sender, EventArgs e) => hillSumLbl.Text = EntrySumAsText(hillEntries);

        private void mtnSeaText_TextChanged(object sender, EventArgs e) => mtnSumLbl.Text = EntrySumAsText(mtnEntries);

        private void mtnLandText_TextChanged(object sender, EventArgs e) => mtnSumLbl.Text = EntrySumAsText(mtnEntries);

        private void mtnHillText_TextChanged(object sender, EventArgs e) => mtnSumLbl.Text = EntrySumAsText(mtnEntries);

        private void mtnMtnText_TextChanged(object sender, EventArgs e) => mtnSumLbl.Text = EntrySumAsText(mtnEntries);

        private void LabelSumCheck(Label l) {
            if (l.Text != "1.000") {
                l.BackColor = Color.Red;
                l.ForeColor = Color.White;
            } else {
                l.BackColor = defaultColor;
                l.ForeColor = Color.Black;
            }
            return;
        }

        private void seaSumLbl_TextChanged(object sender, EventArgs e) => LabelSumCheck(seaSumLbl);

        private void landSumLbl_TextChanged(object sender, EventArgs e) => LabelSumCheck(landSumLbl);

        private void mtnSumLbl_TextChanged(object sender, EventArgs e) => LabelSumCheck(mtnSumLbl);

        private void hillSumLbl_TextChanged(object sender, EventArgs e) => LabelSumCheck(hillSumLbl);

        private void okBtn_Click(object sender, EventArgs e) {
            if (seaSumLbl.Text != "1.000" || landSumLbl.Text != "1.000" || hillSumLbl.Text != "1.000" || mtnSumLbl.Text != "1.000") {
                MessageBox.Show("Each Terrain Type Must Sum to 1.000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Transitions[(int)State.SEA, (int)State.SEA] = Convert.ToDouble(seaSeaTxt.Text);
            Transitions[(int)State.SEA, (int)State.LAND] = Convert.ToDouble(seaLandTxt.Text);
            Transitions[(int)State.SEA, (int)State.HILL] = Convert.ToDouble(seaHillText.Text);
            Transitions[(int)State.SEA, (int)State.MOUNTAIN] = Convert.ToDouble(seaMtnText.Text);
            Transitions[(int)State.LAND, (int)State.SEA] = Convert.ToDouble(landSeaTxt.Text);
            Transitions[(int)State.LAND, (int)State.LAND] = Convert.ToDouble(landLandTxt.Text);
            Transitions[(int)State.LAND, (int)State.HILL] = Convert.ToDouble(landHillText.Text);
            Transitions[(int)State.LAND, (int)State.MOUNTAIN] = Convert.ToDouble(landMtnText.Text);
            Transitions[(int)State.HILL, (int)State.SEA] = Convert.ToDouble(hillSeaText.Text);
            Transitions[(int)State.HILL, (int)State.LAND] = Convert.ToDouble(hillLandText.Text);
            Transitions[(int)State.HILL, (int)State.HILL] = Convert.ToDouble(hillHillText.Text);
            Transitions[(int)State.HILL, (int)State.MOUNTAIN] = Convert.ToDouble(hillMtnText.Text);
            Transitions[(int)State.MOUNTAIN, (int)State.SEA] = Convert.ToDouble(mtnSeaText.Text);
            Transitions[(int)State.MOUNTAIN, (int)State.LAND] = Convert.ToDouble(mtnLandText.Text);
            Transitions[(int)State.MOUNTAIN, (int)State.HILL] = Convert.ToDouble(mtnHillText.Text);
            Transitions[(int)State.MOUNTAIN, (int)State.MOUNTAIN] = Convert.ToDouble(mtnMtnText.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
