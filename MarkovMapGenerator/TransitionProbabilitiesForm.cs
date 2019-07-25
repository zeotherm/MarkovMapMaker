using System;
using System.Drawing;
using System.Windows.Forms;
using HexMap;

namespace MarkovMapGenerator {
    public partial class TransitionProbabilitiesForm : Form {
        private Color defaultColor;
        public double[,] Transitions { get; private set; }
        public readonly double[,] defaultTransitions;
        public TransitionProbabilitiesForm() {
            InitializeComponent();
            defaultColor = seaSumLbl.BackColor;
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text) + Convert.ToDouble(seaHillText.Text));
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text) + Convert.ToDouble(landHillText.Text));
            hillSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(hillLandText.Text) + Convert.ToDouble(hillSeaText.Text) + Convert.ToDouble(hillHillText.Text));
            Transitions = new double[3, 3];
            defaultTransitions = new double[3,3]{{0.990, 0.010, 0.000 },
                                                 {0.005, 0.955, 0.040 },
                                                 {0.000, 0.800, 0.200 }};
        }

        private void landLandTxt_TextChanged(object sender, EventArgs e) {
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text) + Convert.ToDouble(landHillText.Text));

        }

        private void landSeaTxt_TextChanged(object sender, EventArgs e) {
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text) + Convert.ToDouble(landHillText.Text));
        }

        private void landHillText_TextChanged(object sender, EventArgs e) {
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text) + Convert.ToDouble(landHillText.Text));
        }


        private void seaSeaTxt_TextChanged(object sender, EventArgs e) {
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text) + Convert.ToDouble(seaHillText.Text));
        }

        private void seaLandTxt_TextChanged(object sender, EventArgs e) {
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text) + Convert.ToDouble(seaHillText.Text));
        }

        private void seaHillText_TextChanged(object sender, EventArgs e) {
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text) + Convert.ToDouble(seaHillText.Text));
        }

        private void hillHillText_TextChanged(object sender, EventArgs e) {
            hillSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(hillLandText.Text) + Convert.ToDouble(hillSeaText.Text) + Convert.ToDouble(hillHillText.Text));
        }

        private void hillLandText_TextChanged(object sender, EventArgs e) {
            hillSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(hillLandText.Text) + Convert.ToDouble(hillSeaText.Text) + Convert.ToDouble(hillHillText.Text));
        }

        private void hillSeaText_TextChanged(object sender, EventArgs e) {
            hillSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(hillLandText.Text) + Convert.ToDouble(hillSeaText.Text) + Convert.ToDouble(hillHillText.Text));
        }

        private void seaSumLbl_TextChanged(object sender, EventArgs e) {
            if (seaSumLbl.Text != "1.000") {
                seaSumLbl.BackColor = Color.Red;
                seaSumLbl.ForeColor = Color.White;
            } else {
                seaSumLbl.BackColor = defaultColor;
                seaSumLbl.ForeColor = Color.Black;
            }
        }

        private void landSumLbl_TextChanged(object sender, EventArgs e) {
            if (landSumLbl.Text != "1.000") {
                landSumLbl.BackColor = Color.Red;
                landSumLbl.ForeColor = Color.White;
            } else {
                landSumLbl.BackColor = defaultColor;
                landSumLbl.ForeColor = Color.Black;
            }
        }

        private void okBtn_Click(object sender, EventArgs e) {
            if (seaSumLbl.Text != "1.000" || landSumLbl.Text != "1.000") {
                MessageBox.Show("Each Terrain Type Must Sum to 1.000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Transitions[(int)State.SEA, (int)State.SEA] = Convert.ToDouble(seaSeaTxt.Text);
            Transitions[(int)State.SEA, (int)State.LAND] = Convert.ToDouble(seaLandTxt.Text);
            Transitions[(int)State.SEA, (int)State.HILL] = Convert.ToDouble(seaHillText.Text);
            Transitions[(int)State.LAND, (int)State.SEA] = Convert.ToDouble(landSeaTxt.Text);
            Transitions[(int)State.LAND, (int)State.LAND] = Convert.ToDouble(landLandTxt.Text);
            Transitions[(int)State.LAND, (int)State.HILL] = Convert.ToDouble(landHillText.Text);
            Transitions[(int)State.HILL, (int)State.SEA] = Convert.ToDouble(hillSeaText.Text);
            Transitions[(int)State.HILL, (int)State.LAND] = Convert.ToDouble(hillLandText.Text);
            Transitions[(int)State.HILL, (int)State.HILL] = Convert.ToDouble(hillHillText.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void hillSumLbl_TextChanged(object sender, EventArgs e) {
            if (hillSumLbl.Text != "1.000") {
                hillSumLbl.BackColor = Color.Red;
                hillSumLbl.ForeColor = Color.White;
            } else {
                hillSumLbl.BackColor = defaultColor;
                hillSumLbl.ForeColor = Color.Black;
            }
        }
    }
}
