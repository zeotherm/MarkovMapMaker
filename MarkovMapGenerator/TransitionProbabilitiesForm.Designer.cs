namespace MarkovMapGenerator {
    partial class TransitionProbabilitiesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.landSeaTxt = new System.Windows.Forms.TextBox();
            this.landLandTxt = new System.Windows.Forms.TextBox();
            this.landSumLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.seaSeaTxt = new System.Windows.Forms.TextBox();
            this.seaLandTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.seaSumLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.seaHillText = new System.Windows.Forms.TextBox();
            this.landHillText = new System.Windows.Forms.TextBox();
            this.hillSeaText = new System.Windows.Forms.TextBox();
            this.hillLandText = new System.Windows.Forms.TextBox();
            this.hillHillText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hillSumLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seaMtnText = new System.Windows.Forms.TextBox();
            this.landMtnText = new System.Windows.Forms.TextBox();
            this.hillMtnText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtnSeaText = new System.Windows.Forms.TextBox();
            this.mtnLandText = new System.Windows.Forms.TextBox();
            this.mtnHillText = new System.Windows.Forms.TextBox();
            this.mtnMtnText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtnSumLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "LAND";
            // 
            // landSeaTxt
            // 
            this.landSeaTxt.Location = new System.Drawing.Point(128, 158);
            this.landSeaTxt.Name = "landSeaTxt";
            this.landSeaTxt.Size = new System.Drawing.Size(100, 22);
            this.landSeaTxt.TabIndex = 7;
            this.landSeaTxt.Text = "0.005";
            this.landSeaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landSeaTxt.TextChanged += new System.EventHandler(this.landSeaTxt_TextChanged);
            // 
            // landLandTxt
            // 
            this.landLandTxt.Location = new System.Drawing.Point(279, 158);
            this.landLandTxt.Name = "landLandTxt";
            this.landLandTxt.Size = new System.Drawing.Size(100, 22);
            this.landLandTxt.TabIndex = 9;
            this.landLandTxt.Text = "0.945";
            this.landLandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landLandTxt.TextChanged += new System.EventHandler(this.landLandTxt_TextChanged);
            // 
            // landSumLbl
            // 
            this.landSumLbl.AutoSize = true;
            this.landSumLbl.Location = new System.Drawing.Point(733, 163);
            this.landSumLbl.Name = "landSumLbl";
            this.landSumLbl.Size = new System.Drawing.Size(23, 17);
            this.landSumLbl.TabIndex = 10;
            this.landSumLbl.Text = "---";
            this.landSumLbl.TextChanged += new System.EventHandler(this.landSumLbl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label8.Location = new System.Drawing.Point(702, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "S:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(706, 359);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(706, 388);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // seaSeaTxt
            // 
            this.seaSeaTxt.Location = new System.Drawing.Point(128, 90);
            this.seaSeaTxt.Name = "seaSeaTxt";
            this.seaSeaTxt.Size = new System.Drawing.Size(100, 22);
            this.seaSeaTxt.TabIndex = 2;
            this.seaSeaTxt.Text = "0.990";
            this.seaSeaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaSeaTxt.TextChanged += new System.EventHandler(this.seaSeaTxt_TextChanged);
            // 
            // seaLandTxt
            // 
            this.seaLandTxt.Location = new System.Drawing.Point(279, 90);
            this.seaLandTxt.Name = "seaLandTxt";
            this.seaLandTxt.Size = new System.Drawing.Size(100, 22);
            this.seaLandTxt.TabIndex = 4;
            this.seaLandTxt.Text = "0.010";
            this.seaLandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaLandTxt.TextChanged += new System.EventHandler(this.seaLandTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(702, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "S:";
            // 
            // seaSumLbl
            // 
            this.seaSumLbl.AutoSize = true;
            this.seaSumLbl.Location = new System.Drawing.Point(733, 91);
            this.seaSumLbl.Name = "seaSumLbl";
            this.seaSumLbl.Size = new System.Drawing.Size(23, 17);
            this.seaSumLbl.TabIndex = 6;
            this.seaSumLbl.Text = "---";
            this.seaSumLbl.TextChanged += new System.EventHandler(this.seaSumLbl_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "HILL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 29);
            this.label10.TabIndex = 15;
            this.label10.Text = "SEA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "LAND";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "HILL";
            // 
            // seaHillText
            // 
            this.seaHillText.Location = new System.Drawing.Point(442, 90);
            this.seaHillText.Name = "seaHillText";
            this.seaHillText.Size = new System.Drawing.Size(100, 22);
            this.seaHillText.TabIndex = 18;
            this.seaHillText.Text = "0.000";
            this.seaHillText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaHillText.TextChanged += new System.EventHandler(this.seaHillText_TextChanged);
            // 
            // landHillText
            // 
            this.landHillText.Location = new System.Drawing.Point(442, 158);
            this.landHillText.Name = "landHillText";
            this.landHillText.Size = new System.Drawing.Size(100, 22);
            this.landHillText.TabIndex = 19;
            this.landHillText.Text = "0.040";
            this.landHillText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landHillText.TextChanged += new System.EventHandler(this.landHillText_TextChanged);
            // 
            // hillSeaText
            // 
            this.hillSeaText.Location = new System.Drawing.Point(128, 225);
            this.hillSeaText.Name = "hillSeaText";
            this.hillSeaText.Size = new System.Drawing.Size(100, 22);
            this.hillSeaText.TabIndex = 20;
            this.hillSeaText.Text = "0.000";
            this.hillSeaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hillSeaText.TextChanged += new System.EventHandler(this.hillSeaText_TextChanged);
            // 
            // hillLandText
            // 
            this.hillLandText.Location = new System.Drawing.Point(279, 225);
            this.hillLandText.Name = "hillLandText";
            this.hillLandText.Size = new System.Drawing.Size(100, 22);
            this.hillLandText.TabIndex = 21;
            this.hillLandText.Text = "0.750";
            this.hillLandText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hillLandText.TextChanged += new System.EventHandler(this.hillLandText_TextChanged);
            // 
            // hillHillText
            // 
            this.hillHillText.Location = new System.Drawing.Point(442, 225);
            this.hillHillText.Name = "hillHillText";
            this.hillHillText.Size = new System.Drawing.Size(100, 22);
            this.hillHillText.TabIndex = 22;
            this.hillHillText.Text = "0.200";
            this.hillHillText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hillHillText.TextChanged += new System.EventHandler(this.hillHillText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(702, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "S:";
            // 
            // hillSumLbl
            // 
            this.hillSumLbl.AutoSize = true;
            this.hillSumLbl.Location = new System.Drawing.Point(733, 230);
            this.hillSumLbl.Name = "hillSumLbl";
            this.hillSumLbl.Size = new System.Drawing.Size(23, 17);
            this.hillSumLbl.TabIndex = 24;
            this.hillSumLbl.Text = "---";
            this.hillSumLbl.TextChanged += new System.EventHandler(this.hillSumLbl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(594, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "MNT";
            // 
            // seaMtnText
            // 
            this.seaMtnText.Location = new System.Drawing.Point(584, 90);
            this.seaMtnText.Name = "seaMtnText";
            this.seaMtnText.Size = new System.Drawing.Size(100, 22);
            this.seaMtnText.TabIndex = 26;
            this.seaMtnText.Text = "0.000";
            this.seaMtnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaMtnText.TextChanged += new System.EventHandler(this.seaMtnText_TextChanged);
            // 
            // landMtnText
            // 
            this.landMtnText.Location = new System.Drawing.Point(584, 158);
            this.landMtnText.Name = "landMtnText";
            this.landMtnText.Size = new System.Drawing.Size(100, 22);
            this.landMtnText.TabIndex = 27;
            this.landMtnText.Text = "0.010";
            this.landMtnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landMtnText.TextChanged += new System.EventHandler(this.landMtnText_TextChanged);
            // 
            // hillMtnText
            // 
            this.hillMtnText.Location = new System.Drawing.Point(584, 227);
            this.hillMtnText.Name = "hillMtnText";
            this.hillMtnText.Size = new System.Drawing.Size(100, 22);
            this.hillMtnText.TabIndex = 28;
            this.hillMtnText.Text = "0.050";
            this.hillMtnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hillMtnText.TextChanged += new System.EventHandler(this.hillMtnText_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "MNT";
            // 
            // mtnSeaText
            // 
            this.mtnSeaText.Location = new System.Drawing.Point(128, 290);
            this.mtnSeaText.Name = "mtnSeaText";
            this.mtnSeaText.Size = new System.Drawing.Size(100, 22);
            this.mtnSeaText.TabIndex = 30;
            this.mtnSeaText.Text = "0.001";
            this.mtnSeaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtnSeaText.TextChanged += new System.EventHandler(this.mtnSeaText_TextChanged);
            // 
            // mtnLandText
            // 
            this.mtnLandText.Location = new System.Drawing.Point(279, 290);
            this.mtnLandText.Name = "mtnLandText";
            this.mtnLandText.Size = new System.Drawing.Size(100, 22);
            this.mtnLandText.TabIndex = 31;
            this.mtnLandText.Text = "0.049";
            this.mtnLandText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtnLandText.TextChanged += new System.EventHandler(this.mtnLandText_TextChanged);
            // 
            // mtnHillText
            // 
            this.mtnHillText.Location = new System.Drawing.Point(442, 290);
            this.mtnHillText.Name = "mtnHillText";
            this.mtnHillText.Size = new System.Drawing.Size(100, 22);
            this.mtnHillText.TabIndex = 32;
            this.mtnHillText.Text = "0.400";
            this.mtnHillText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtnHillText.TextChanged += new System.EventHandler(this.mtnHillText_TextChanged);
            // 
            // mtnMtnText
            // 
            this.mtnMtnText.Location = new System.Drawing.Point(584, 290);
            this.mtnMtnText.Name = "mtnMtnText";
            this.mtnMtnText.Size = new System.Drawing.Size(100, 22);
            this.mtnMtnText.TabIndex = 33;
            this.mtnMtnText.Text = "0.550";
            this.mtnMtnText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtnMtnText.TextChanged += new System.EventHandler(this.mtnMtnText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label6.Location = new System.Drawing.Point(702, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 21);
            this.label6.TabIndex = 34;
            this.label6.Text = "S:";
            // 
            // mtnSumLbl
            // 
            this.mtnSumLbl.AutoSize = true;
            this.mtnSumLbl.Location = new System.Drawing.Point(733, 293);
            this.mtnSumLbl.Name = "mtnSumLbl";
            this.mtnSumLbl.Size = new System.Drawing.Size(23, 17);
            this.mtnSumLbl.TabIndex = 35;
            this.mtnSumLbl.Text = "---";
            this.mtnSumLbl.TextChanged += new System.EventHandler(this.mtnSumLbl_TextChanged);
            // 
            // TransitionProbabilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 425);
            this.Controls.Add(this.mtnSumLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtnMtnText);
            this.Controls.Add(this.mtnHillText);
            this.Controls.Add(this.mtnLandText);
            this.Controls.Add(this.mtnSeaText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hillMtnText);
            this.Controls.Add(this.landMtnText);
            this.Controls.Add(this.seaMtnText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hillSumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hillHillText);
            this.Controls.Add(this.hillLandText);
            this.Controls.Add(this.hillSeaText);
            this.Controls.Add(this.landHillText);
            this.Controls.Add(this.seaHillText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.seaSumLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.landSumLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.landLandTxt);
            this.Controls.Add(this.seaLandTxt);
            this.Controls.Add(this.landSeaTxt);
            this.Controls.Add(this.seaSeaTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TransitionProbabilitiesForm";
            this.Text = "TransitionProbabilitiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox landSeaTxt;
        private System.Windows.Forms.TextBox landLandTxt;
        private System.Windows.Forms.Label landSumLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox seaSeaTxt;
        private System.Windows.Forms.TextBox seaLandTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label seaSumLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox seaHillText;
        private System.Windows.Forms.TextBox landHillText;
        private System.Windows.Forms.TextBox hillSeaText;
        private System.Windows.Forms.TextBox hillLandText;
        private System.Windows.Forms.TextBox hillHillText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hillSumLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seaMtnText;
        private System.Windows.Forms.TextBox landMtnText;
        private System.Windows.Forms.TextBox hillMtnText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mtnSeaText;
        private System.Windows.Forms.TextBox mtnLandText;
        private System.Windows.Forms.TextBox mtnHillText;
        private System.Windows.Forms.TextBox mtnMtnText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label mtnSumLbl;
    }
}