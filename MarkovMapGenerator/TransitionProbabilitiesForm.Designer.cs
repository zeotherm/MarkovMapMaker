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
            this.label2 = new System.Windows.Forms.Label();
            this.seaSeaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seaLandTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.landSeaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.landLandTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seaSumLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.landSumLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Remain Sea:";
            // 
            // seaSeaTxt
            // 
            this.seaSeaTxt.Location = new System.Drawing.Point(114, 47);
            this.seaSeaTxt.Name = "seaSeaTxt";
            this.seaSeaTxt.Size = new System.Drawing.Size(100, 22);
            this.seaSeaTxt.TabIndex = 2;
            this.seaSeaTxt.Text = "0.80";
            this.seaSeaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaSeaTxt.TextChanged += new System.EventHandler(this.seaSeaTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Switch to Land";
            // 
            // seaLandTxt
            // 
            this.seaLandTxt.Location = new System.Drawing.Point(114, 89);
            this.seaLandTxt.Name = "seaLandTxt";
            this.seaLandTxt.Size = new System.Drawing.Size(100, 22);
            this.seaLandTxt.TabIndex = 4;
            this.seaLandTxt.Text = "0.20";
            this.seaLandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seaLandTxt.TextChanged += new System.EventHandler(this.seaLandTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "LAND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Switch to Sea:";
            // 
            // landSeaTxt
            // 
            this.landSeaTxt.Location = new System.Drawing.Point(117, 51);
            this.landSeaTxt.Name = "landSeaTxt";
            this.landSeaTxt.Size = new System.Drawing.Size(100, 22);
            this.landSeaTxt.TabIndex = 7;
            this.landSeaTxt.Text = "0.05";
            this.landSeaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landSeaTxt.TextChanged += new System.EventHandler(this.landSeaTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remain Land:";
            // 
            // landLandTxt
            // 
            this.landLandTxt.Location = new System.Drawing.Point(117, 93);
            this.landLandTxt.Name = "landLandTxt";
            this.landLandTxt.Size = new System.Drawing.Size(100, 22);
            this.landLandTxt.TabIndex = 9;
            this.landLandTxt.Text = "0.95";
            this.landLandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.landLandTxt.TextChanged += new System.EventHandler(this.landLandTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seaSumLbl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.seaLandTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.seaSeaTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sea Transitions";
            // 
            // seaSumLbl
            // 
            this.seaSumLbl.AutoSize = true;
            this.seaSumLbl.Location = new System.Drawing.Point(127, 130);
            this.seaSumLbl.Name = "seaSumLbl";
            this.seaSumLbl.Size = new System.Drawing.Size(23, 17);
            this.seaSumLbl.TabIndex = 6;
            this.seaSumLbl.Text = "---";
            this.seaSumLbl.TextChanged += new System.EventHandler(this.seaSumLbl_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label7.Location = new System.Drawing.Point(83, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "S:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.landSumLbl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.landLandTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.landSeaTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(269, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 165);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Land Transitions";
            // 
            // landSumLbl
            // 
            this.landSumLbl.AutoSize = true;
            this.landSumLbl.Location = new System.Drawing.Point(131, 130);
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
            this.label8.Location = new System.Drawing.Point(79, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "S:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(537, 162);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(537, 191);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // TransitionProbabilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 226);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "TransitionProbabilitiesForm";
            this.Text = "TransitionProbabilitiesForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seaSeaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seaLandTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox landSeaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox landLandTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label seaSumLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label landSumLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}