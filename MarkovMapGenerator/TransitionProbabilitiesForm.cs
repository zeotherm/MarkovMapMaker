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
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text));
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text));
            Transitions = new double[2, 2];
            defaultTransitions = new double[2,2]{ { 0.99, 0.01}, { 0.005, 0.995} };
        }

        private void landLandTxt_TextChanged(object sender, EventArgs e) {
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text));

        }

        private void landSeaTxt_TextChanged(object sender, EventArgs e) {
            landSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(landLandTxt.Text) + Convert.ToDouble(landSeaTxt.Text));        
        }

        private void seaSeaTxt_TextChanged(object sender, EventArgs e) {
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text));
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

        private void seaLandTxt_TextChanged(object sender, EventArgs e) {
            seaSumLbl.Text = String.Format("{0:0.000}", Convert.ToDouble(seaLandTxt.Text) + Convert.ToDouble(seaSeaTxt.Text));
        }

        private void okBtn_Click(object sender, EventArgs e) {
            if (seaSumLbl.Text != "1.000" || landSumLbl.Text != "1.000") {
                MessageBox.Show("Each Terrain Type Must Sum to 1.000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Transitions[(int)State.SEA, (int)State.SEA] = Convert.ToDouble(seaSeaTxt.Text);
            Transitions[(int)State.SEA, (int)State.LAND] = Convert.ToDouble(seaLandTxt.Text);
            Transitions[(int)State.LAND, (int)State.SEA] = Convert.ToDouble(landSeaTxt.Text);
            Transitions[(int)State.LAND, (int)State.LAND] = Convert.ToDouble(landLandTxt.Text);


            this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
