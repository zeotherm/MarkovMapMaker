namespace MarkovMapGenerator {
    partial class Form1 {
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
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pointyRadio = new System.Windows.Forms.RadioButton();
            this.flatRadio = new System.Windows.Forms.RadioButton();
            this.drawButton = new System.Windows.Forms.Button();
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.HexSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWide = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(35, 31);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(880, 545);
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            this.pBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pBox_Paint);
            this.pBox.DoubleClick += new System.EventHandler(this.pBox_DoubleClick);
            // 
            // pointyRadio
            // 
            this.pointyRadio.AutoSize = true;
            this.pointyRadio.Checked = true;
            this.pointyRadio.Location = new System.Drawing.Point(934, 31);
            this.pointyRadio.Name = "pointyRadio";
            this.pointyRadio.Size = new System.Drawing.Size(68, 21);
            this.pointyRadio.TabIndex = 1;
            this.pointyRadio.TabStop = true;
            this.pointyRadio.Text = "Pointy";
            this.pointyRadio.UseVisualStyleBackColor = true;
            this.pointyRadio.CheckedChanged += new System.EventHandler(this.pointyRadio_CheckedChanged);
            // 
            // flatRadio
            // 
            this.flatRadio.AutoSize = true;
            this.flatRadio.Location = new System.Drawing.Point(934, 68);
            this.flatRadio.Name = "flatRadio";
            this.flatRadio.Size = new System.Drawing.Size(52, 21);
            this.flatRadio.TabIndex = 2;
            this.flatRadio.Text = "Flat";
            this.flatRadio.UseVisualStyleBackColor = true;
            this.flatRadio.CheckedChanged += new System.EventHandler(this.flatRadio_CheckedChanged);
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(924, 326);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(94, 48);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(924, 163);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(124, 22);
            this.sizeBox.TabIndex = 4;
            this.sizeBox.Text = "10";
            // 
            // HexSizeLabel
            // 
            this.HexSizeLabel.AutoSize = true;
            this.HexSizeLabel.Location = new System.Drawing.Point(924, 134);
            this.HexSizeLabel.Name = "HexSizeLabel";
            this.HexSizeLabel.Size = new System.Drawing.Size(63, 17);
            this.HexSizeLabel.TabIndex = 5;
            this.HexSizeLabel.Text = "Hex Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hexes Wide:";
            // 
            // lblWide
            // 
            this.lblWide.AutoSize = true;
            this.lblWide.Location = new System.Drawing.Point(1012, 267);
            this.lblWide.Name = "lblWide";
            this.lblWide.Size = new System.Drawing.Size(46, 17);
            this.lblWide.TabIndex = 7;
            this.lblWide.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(921, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hexes High:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(1012, 301);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(46, 17);
            this.lblHigh.TabIndex = 9;
            this.lblHigh.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hex Width: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(921, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hex Height: ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(1012, 199);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 17);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "label5";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(1012, 233);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 17);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 588);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HexSizeLabel);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.flatRadio);
            this.Controls.Add(this.pointyRadio);
            this.Controls.Add(this.pBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.RadioButton pointyRadio;
        private System.Windows.Forms.RadioButton flatRadio;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Label HexSizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
    }
}

