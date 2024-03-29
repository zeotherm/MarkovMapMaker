﻿namespace MarkovMapGenerator {
    partial class DebugForm {
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
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.xCoordLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yCoordLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lastXClickCoordLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lastYCoordClickLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.qValLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rValLbl = new System.Windows.Forms.Label();
            this.hPt1Lbl = new System.Windows.Forms.Label();
            this.hPt2Lbl = new System.Windows.Forms.Label();
            this.hPt3Lbl = new System.Windows.Forms.Label();
            this.hPt4Lbl = new System.Windows.Forms.Label();
            this.hPt5Lbl = new System.Windows.Forms.Label();
            this.hPt6Lbl = new System.Windows.Forms.Label();
            this.hexPtsTxt = new System.Windows.Forms.TextBox();
            this.getPtsBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.forceClickLocationTxt = new System.Windows.Forms.TextBox();
            this.clickHereBtn = new System.Windows.Forms.Button();
            this.showCoordsChk = new System.Windows.Forms.CheckBox();
            this.genBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.stackDepthLbl = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.emptyLocsLbl = new System.Windows.Forms.Label();
            this.transPosBtn = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.numSeaTxt = new System.Windows.Forms.Label();
            this.numLandTxt = new System.Windows.Forms.Label();
            this.numEmptyTxt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CDF_HHLbl = new System.Windows.Forms.Label();
            this.CDF_HLLbl = new System.Windows.Forms.Label();
            this.CDF_HSLbl = new System.Windows.Forms.Label();
            this.CDF_LHLbl = new System.Windows.Forms.Label();
            this.CDF_LLLbl = new System.Windows.Forms.Label();
            this.CDF_LSLbl = new System.Windows.Forms.Label();
            this.CDF_SHLbl = new System.Windows.Forms.Label();
            this.CDF_SLLbl = new System.Windows.Forms.Label();
            this.CDF_SSLbl = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numHillTxt = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.numMtnText = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.CDF_SMLbl = new System.Windows.Forms.Label();
            this.CDF_LMLbl = new System.Windows.Forms.Label();
            this.CDF_HMLbl = new System.Windows.Forms.Label();
            this.CDF_MSLbl = new System.Windows.Forms.Label();
            this.CDF_MLLbl = new System.Windows.Forms.Label();
            this.CDF_MHLbl = new System.Windows.Forms.Label();
            this.CDF_MMLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pBox.MouseLeave += new System.EventHandler(this.pBox_MouseLeave);
            this.pBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pBox_MouseMove);
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
            this.drawButton.Location = new System.Drawing.Point(921, 239);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(94, 48);
            this.drawButton.TabIndex = 3;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(924, 124);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(124, 22);
            this.sizeBox.TabIndex = 4;
            this.sizeBox.Text = "12";
            // 
            // HexSizeLabel
            // 
            this.HexSizeLabel.AutoSize = true;
            this.HexSizeLabel.Location = new System.Drawing.Point(924, 95);
            this.HexSizeLabel.Name = "HexSizeLabel";
            this.HexSizeLabel.Size = new System.Drawing.Size(63, 17);
            this.HexSizeLabel.TabIndex = 5;
            this.HexSizeLabel.Text = "Hex Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hexes Wide:";
            // 
            // lblWide
            // 
            this.lblWide.AutoSize = true;
            this.lblWide.Location = new System.Drawing.Point(1012, 193);
            this.lblWide.Name = "lblWide";
            this.lblWide.Size = new System.Drawing.Size(46, 17);
            this.lblWide.TabIndex = 7;
            this.lblWide.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(921, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hexes High:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(1012, 210);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(46, 17);
            this.lblHigh.TabIndex = 9;
            this.lblHigh.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hex Width: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(921, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hex Height: ";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(1012, 159);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 17);
            this.lblWidth.TabIndex = 12;
            this.lblWidth.Text = "label5";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(1012, 176);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(46, 17);
            this.lblHeight.TabIndex = 13;
            this.lblHeight.Text = "label6";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(921, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 51);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mouse X Coord: ";
            // 
            // xCoordLbl
            // 
            this.xCoordLbl.AutoSize = true;
            this.xCoordLbl.Location = new System.Drawing.Point(151, 602);
            this.xCoordLbl.Name = "xCoordLbl";
            this.xCoordLbl.Size = new System.Drawing.Size(12, 17);
            this.xCoordLbl.TabIndex = 16;
            this.xCoordLbl.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mouse Y Coord:";
            // 
            // yCoordLbl
            // 
            this.yCoordLbl.AutoSize = true;
            this.yCoordLbl.Location = new System.Drawing.Point(349, 602);
            this.yCoordLbl.Name = "yCoordLbl";
            this.yCoordLbl.Size = new System.Drawing.Size(0, 17);
            this.yCoordLbl.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Last X Click Coord:";
            // 
            // lastXClickCoordLbl
            // 
            this.lastXClickCoordLbl.AutoSize = true;
            this.lastXClickCoordLbl.Location = new System.Drawing.Point(593, 602);
            this.lastXClickCoordLbl.Name = "lastXClickCoordLbl";
            this.lastXClickCoordLbl.Size = new System.Drawing.Size(0, 17);
            this.lastXClickCoordLbl.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(711, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Last Y Click Coord:";
            // 
            // lastYCoordClickLbl
            // 
            this.lastYCoordClickLbl.AutoSize = true;
            this.lastYCoordClickLbl.Location = new System.Drawing.Point(844, 602);
            this.lastYCoordClickLbl.Name = "lastYCoordClickLbl";
            this.lastYCoordClickLbl.Size = new System.Drawing.Size(0, 17);
            this.lastYCoordClickLbl.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(921, 602);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "q:";
            // 
            // qValLbl
            // 
            this.qValLbl.AutoSize = true;
            this.qValLbl.Location = new System.Drawing.Point(947, 602);
            this.qValLbl.Name = "qValLbl";
            this.qValLbl.Size = new System.Drawing.Size(0, 17);
            this.qValLbl.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(979, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "r:";
            // 
            // rValLbl
            // 
            this.rValLbl.AutoSize = true;
            this.rValLbl.Location = new System.Drawing.Point(1002, 602);
            this.rValLbl.Name = "rValLbl";
            this.rValLbl.Size = new System.Drawing.Size(0, 17);
            this.rValLbl.TabIndex = 26;
            // 
            // hPt1Lbl
            // 
            this.hPt1Lbl.AutoSize = true;
            this.hPt1Lbl.Location = new System.Drawing.Point(1013, 443);
            this.hPt1Lbl.Name = "hPt1Lbl";
            this.hPt1Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt1Lbl.TabIndex = 27;
            // 
            // hPt2Lbl
            // 
            this.hPt2Lbl.AutoSize = true;
            this.hPt2Lbl.Location = new System.Drawing.Point(1013, 460);
            this.hPt2Lbl.Name = "hPt2Lbl";
            this.hPt2Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt2Lbl.TabIndex = 28;
            // 
            // hPt3Lbl
            // 
            this.hPt3Lbl.AutoSize = true;
            this.hPt3Lbl.Location = new System.Drawing.Point(1013, 477);
            this.hPt3Lbl.Name = "hPt3Lbl";
            this.hPt3Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt3Lbl.TabIndex = 29;
            // 
            // hPt4Lbl
            // 
            this.hPt4Lbl.AutoSize = true;
            this.hPt4Lbl.Location = new System.Drawing.Point(1013, 494);
            this.hPt4Lbl.Name = "hPt4Lbl";
            this.hPt4Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt4Lbl.TabIndex = 30;
            // 
            // hPt5Lbl
            // 
            this.hPt5Lbl.AutoSize = true;
            this.hPt5Lbl.Location = new System.Drawing.Point(1013, 511);
            this.hPt5Lbl.Name = "hPt5Lbl";
            this.hPt5Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt5Lbl.TabIndex = 31;
            // 
            // hPt6Lbl
            // 
            this.hPt6Lbl.AutoSize = true;
            this.hPt6Lbl.Location = new System.Drawing.Point(1013, 528);
            this.hPt6Lbl.Name = "hPt6Lbl";
            this.hPt6Lbl.Size = new System.Drawing.Size(0, 17);
            this.hPt6Lbl.TabIndex = 32;
            // 
            // hexPtsTxt
            // 
            this.hexPtsTxt.Location = new System.Drawing.Point(921, 375);
            this.hexPtsTxt.Name = "hexPtsTxt";
            this.hexPtsTxt.Size = new System.Drawing.Size(100, 22);
            this.hexPtsTxt.TabIndex = 33;
            this.hexPtsTxt.Text = "5,5";
            // 
            // getPtsBtn
            // 
            this.getPtsBtn.Location = new System.Drawing.Point(921, 403);
            this.getPtsBtn.Name = "getPtsBtn";
            this.getPtsBtn.Size = new System.Drawing.Size(98, 23);
            this.getPtsBtn.TabIndex = 34;
            this.getPtsBtn.Text = "Get Points";
            this.getPtsBtn.UseVisualStyleBackColor = true;
            this.getPtsBtn.Click += new System.EventHandler(this.getPtsBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(921, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Top:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(921, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Top Left:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(921, 511);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Bot. Left:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(921, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Bottom:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(921, 460);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 39;
            this.label15.Text = "Top Right:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(921, 443);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "Bot. Right:";
            // 
            // forceClickLocationTxt
            // 
            this.forceClickLocationTxt.Location = new System.Drawing.Point(1037, 375);
            this.forceClickLocationTxt.Name = "forceClickLocationTxt";
            this.forceClickLocationTxt.Size = new System.Drawing.Size(100, 22);
            this.forceClickLocationTxt.TabIndex = 41;
            this.forceClickLocationTxt.Text = "92,33";
            // 
            // clickHereBtn
            // 
            this.clickHereBtn.Location = new System.Drawing.Point(1037, 403);
            this.clickHereBtn.Name = "clickHereBtn";
            this.clickHereBtn.Size = new System.Drawing.Size(100, 23);
            this.clickHereBtn.TabIndex = 42;
            this.clickHereBtn.Text = "Precise Click";
            this.clickHereBtn.UseVisualStyleBackColor = true;
            this.clickHereBtn.Click += new System.EventHandler(this.clickHereBtn_Click);
            // 
            // showCoordsChk
            // 
            this.showCoordsChk.AutoSize = true;
            this.showCoordsChk.Location = new System.Drawing.Point(921, 350);
            this.showCoordsChk.Name = "showCoordsChk";
            this.showCoordsChk.Size = new System.Drawing.Size(113, 21);
            this.showCoordsChk.TabIndex = 43;
            this.showCoordsChk.Text = "Show Coords";
            this.showCoordsChk.UseVisualStyleBackColor = true;
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(1143, 375);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(100, 51);
            this.genBtn.TabIndex = 44;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_ClickAsync);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(921, 545);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 17);
            this.label17.TabIndex = 45;
            this.label17.Text = "Stack Depth:";
            // 
            // stackDepthLbl
            // 
            this.stackDepthLbl.AutoSize = true;
            this.stackDepthLbl.Location = new System.Drawing.Point(1016, 545);
            this.stackDepthLbl.Name = "stackDepthLbl";
            this.stackDepthLbl.Size = new System.Drawing.Size(16, 17);
            this.stackDepthLbl.TabIndex = 46;
            this.stackDepthLbl.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(921, 562);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "Empty Locs:";
            // 
            // emptyLocsLbl
            // 
            this.emptyLocsLbl.AutoSize = true;
            this.emptyLocsLbl.Location = new System.Drawing.Point(1016, 562);
            this.emptyLocsLbl.Name = "emptyLocsLbl";
            this.emptyLocsLbl.Size = new System.Drawing.Size(16, 17);
            this.emptyLocsLbl.TabIndex = 48;
            this.emptyLocsLbl.Text = "0";
            // 
            // transPosBtn
            // 
            this.transPosBtn.Location = new System.Drawing.Point(1021, 37);
            this.transPosBtn.Name = "transPosBtn";
            this.transPosBtn.Size = new System.Drawing.Size(129, 31);
            this.transPosBtn.TabIndex = 49;
            this.transPosBtn.Text = "Trans Probs.";
            this.transPosBtn.UseVisualStyleBackColor = true;
            this.transPosBtn.Click += new System.EventHandler(this.transPosBtn_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 164);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 17);
            this.label23.TabIndex = 54;
            this.label23.Text = "Sea Total:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 181);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 17);
            this.label24.TabIndex = 55;
            this.label24.Text = "Land Total:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 235);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 17);
            this.label25.TabIndex = 56;
            this.label25.Text = "Empty Total:";
            // 
            // numSeaTxt
            // 
            this.numSeaTxt.AutoSize = true;
            this.numSeaTxt.Location = new System.Drawing.Point(137, 164);
            this.numSeaTxt.Name = "numSeaTxt";
            this.numSeaTxt.Size = new System.Drawing.Size(23, 17);
            this.numSeaTxt.TabIndex = 61;
            this.numSeaTxt.Text = "---";
            // 
            // numLandTxt
            // 
            this.numLandTxt.AutoSize = true;
            this.numLandTxt.Location = new System.Drawing.Point(137, 181);
            this.numLandTxt.Name = "numLandTxt";
            this.numLandTxt.Size = new System.Drawing.Size(23, 17);
            this.numLandTxt.TabIndex = 62;
            this.numLandTxt.Text = "---";
            // 
            // numEmptyTxt
            // 
            this.numEmptyTxt.AutoSize = true;
            this.numEmptyTxt.Location = new System.Drawing.Point(137, 235);
            this.numEmptyTxt.Name = "numEmptyTxt";
            this.numEmptyTxt.Size = new System.Drawing.Size(23, 17);
            this.numEmptyTxt.TabIndex = 63;
            this.numEmptyTxt.Text = "---";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CDF_MMLbl);
            this.groupBox1.Controls.Add(this.CDF_MHLbl);
            this.groupBox1.Controls.Add(this.CDF_MLLbl);
            this.groupBox1.Controls.Add(this.CDF_MSLbl);
            this.groupBox1.Controls.Add(this.CDF_HMLbl);
            this.groupBox1.Controls.Add(this.CDF_LMLbl);
            this.groupBox1.Controls.Add(this.CDF_SMLbl);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.numMtnText);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.CDF_HHLbl);
            this.groupBox1.Controls.Add(this.CDF_HLLbl);
            this.groupBox1.Controls.Add(this.CDF_HSLbl);
            this.groupBox1.Controls.Add(this.CDF_LHLbl);
            this.groupBox1.Controls.Add(this.CDF_LLLbl);
            this.groupBox1.Controls.Add(this.CDF_LSLbl);
            this.groupBox1.Controls.Add(this.CDF_SHLbl);
            this.groupBox1.Controls.Add(this.CDF_SLLbl);
            this.groupBox1.Controls.Add(this.CDF_SSLbl);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.numHillTxt);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.numEmptyTxt);
            this.groupBox1.Controls.Add(this.numLandTxt);
            this.groupBox1.Controls.Add(this.numSeaTxt);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Location = new System.Drawing.Point(1083, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 269);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mapper Stats";
            // 
            // CDF_HHLbl
            // 
            this.CDF_HHLbl.AutoSize = true;
            this.CDF_HHLbl.Location = new System.Drawing.Point(172, 114);
            this.CDF_HHLbl.Name = "CDF_HHLbl";
            this.CDF_HHLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_HHLbl.TabIndex = 80;
            this.CDF_HHLbl.Text = "---";
            // 
            // CDF_HLLbl
            // 
            this.CDF_HLLbl.AutoSize = true;
            this.CDF_HLLbl.Location = new System.Drawing.Point(106, 114);
            this.CDF_HLLbl.Name = "CDF_HLLbl";
            this.CDF_HLLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_HLLbl.TabIndex = 79;
            this.CDF_HLLbl.Text = "---";
            // 
            // CDF_HSLbl
            // 
            this.CDF_HSLbl.AutoSize = true;
            this.CDF_HSLbl.Location = new System.Drawing.Point(47, 114);
            this.CDF_HSLbl.Name = "CDF_HSLbl";
            this.CDF_HSLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_HSLbl.TabIndex = 78;
            this.CDF_HSLbl.Text = "---";
            // 
            // CDF_LHLbl
            // 
            this.CDF_LHLbl.AutoSize = true;
            this.CDF_LHLbl.Location = new System.Drawing.Point(172, 84);
            this.CDF_LHLbl.Name = "CDF_LHLbl";
            this.CDF_LHLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_LHLbl.TabIndex = 77;
            this.CDF_LHLbl.Text = "---";
            // 
            // CDF_LLLbl
            // 
            this.CDF_LLLbl.AutoSize = true;
            this.CDF_LLLbl.Location = new System.Drawing.Point(106, 84);
            this.CDF_LLLbl.Name = "CDF_LLLbl";
            this.CDF_LLLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_LLLbl.TabIndex = 76;
            this.CDF_LLLbl.Text = "---";
            // 
            // CDF_LSLbl
            // 
            this.CDF_LSLbl.AutoSize = true;
            this.CDF_LSLbl.Location = new System.Drawing.Point(47, 84);
            this.CDF_LSLbl.Name = "CDF_LSLbl";
            this.CDF_LSLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_LSLbl.TabIndex = 75;
            this.CDF_LSLbl.Text = "---";
            // 
            // CDF_SHLbl
            // 
            this.CDF_SHLbl.AutoSize = true;
            this.CDF_SHLbl.Location = new System.Drawing.Point(172, 54);
            this.CDF_SHLbl.Name = "CDF_SHLbl";
            this.CDF_SHLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_SHLbl.TabIndex = 74;
            this.CDF_SHLbl.Text = "---";
            // 
            // CDF_SLLbl
            // 
            this.CDF_SLLbl.AutoSize = true;
            this.CDF_SLLbl.Location = new System.Drawing.Point(106, 54);
            this.CDF_SLLbl.Name = "CDF_SLLbl";
            this.CDF_SLLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_SLLbl.TabIndex = 73;
            this.CDF_SLLbl.Text = "---";
            // 
            // CDF_SSLbl
            // 
            this.CDF_SSLbl.AutoSize = true;
            this.CDF_SSLbl.Location = new System.Drawing.Point(47, 54);
            this.CDF_SSLbl.Name = "CDF_SSLbl";
            this.CDF_SSLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_SSLbl.TabIndex = 72;
            this.CDF_SSLbl.Text = "---";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(13, 114);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 17);
            this.label29.TabIndex = 71;
            this.label29.Text = "H";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 84);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 17);
            this.label28.TabIndex = 70;
            this.label28.Text = "L";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 54);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 17);
            this.label22.TabIndex = 69;
            this.label22.Text = "S";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(172, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 17);
            this.label21.TabIndex = 68;
            this.label21.Text = "H";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(113, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 17);
            this.label20.TabIndex = 67;
            this.label20.Text = "L";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 17);
            this.label19.TabIndex = 66;
            this.label19.Text = "S";
            // 
            // numHillTxt
            // 
            this.numHillTxt.AutoSize = true;
            this.numHillTxt.Location = new System.Drawing.Point(137, 198);
            this.numHillTxt.Name = "numHillTxt";
            this.numHillTxt.Size = new System.Drawing.Size(23, 17);
            this.numHillTxt.TabIndex = 65;
            this.numHillTxt.Text = "---";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 17);
            this.label27.TabIndex = 64;
            this.label27.Text = "Hill Total:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1053, 602);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 17);
            this.label26.TabIndex = 65;
            this.label26.Text = "Distance:";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(1133, 602);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(23, 17);
            this.lblDistance.TabIndex = 66;
            this.lblDistance.Text = "---";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(1249, 375);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 51);
            this.saveBtn.TabIndex = 67;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(232, 34);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 17);
            this.label30.TabIndex = 81;
            this.label30.Text = "M";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(11, 216);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(106, 17);
            this.label31.TabIndex = 82;
            this.label31.Text = "Mountain Total:";
            // 
            // numMtnText
            // 
            this.numMtnText.AutoSize = true;
            this.numMtnText.Location = new System.Drawing.Point(137, 215);
            this.numMtnText.Name = "numMtnText";
            this.numMtnText.Size = new System.Drawing.Size(23, 17);
            this.numMtnText.TabIndex = 83;
            this.numMtnText.Text = "---";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(13, 144);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 17);
            this.label32.TabIndex = 84;
            this.label32.Text = "M";
            // 
            // CDF_SMLbl
            // 
            this.CDF_SMLbl.AutoSize = true;
            this.CDF_SMLbl.Location = new System.Drawing.Point(232, 54);
            this.CDF_SMLbl.Name = "CDF_SMLbl";
            this.CDF_SMLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_SMLbl.TabIndex = 85;
            this.CDF_SMLbl.Text = "---";
            // 
            // CDF_LMLbl
            // 
            this.CDF_LMLbl.AutoSize = true;
            this.CDF_LMLbl.Location = new System.Drawing.Point(232, 84);
            this.CDF_LMLbl.Name = "CDF_LMLbl";
            this.CDF_LMLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_LMLbl.TabIndex = 86;
            this.CDF_LMLbl.Text = "---";
            // 
            // CDF_HMLbl
            // 
            this.CDF_HMLbl.AutoSize = true;
            this.CDF_HMLbl.Location = new System.Drawing.Point(232, 114);
            this.CDF_HMLbl.Name = "CDF_HMLbl";
            this.CDF_HMLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_HMLbl.TabIndex = 87;
            this.CDF_HMLbl.Text = "---";
            // 
            // CDF_MSLbl
            // 
            this.CDF_MSLbl.AutoSize = true;
            this.CDF_MSLbl.Location = new System.Drawing.Point(47, 144);
            this.CDF_MSLbl.Name = "CDF_MSLbl";
            this.CDF_MSLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_MSLbl.TabIndex = 88;
            this.CDF_MSLbl.Text = "---";
            // 
            // CDF_MLLbl
            // 
            this.CDF_MLLbl.AutoSize = true;
            this.CDF_MLLbl.Location = new System.Drawing.Point(106, 144);
            this.CDF_MLLbl.Name = "CDF_MLLbl";
            this.CDF_MLLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_MLLbl.TabIndex = 89;
            this.CDF_MLLbl.Text = "---";
            // 
            // CDF_MHLbl
            // 
            this.CDF_MHLbl.AutoSize = true;
            this.CDF_MHLbl.Location = new System.Drawing.Point(172, 144);
            this.CDF_MHLbl.Name = "CDF_MHLbl";
            this.CDF_MHLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_MHLbl.TabIndex = 90;
            this.CDF_MHLbl.Text = "---";
            // 
            // CDF_MMLbl
            // 
            this.CDF_MMLbl.AutoSize = true;
            this.CDF_MMLbl.Location = new System.Drawing.Point(232, 144);
            this.CDF_MMLbl.Name = "CDF_MMLbl";
            this.CDF_MMLbl.Size = new System.Drawing.Size(23, 17);
            this.CDF_MMLbl.TabIndex = 91;
            this.CDF_MMLbl.Text = "---";
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 628);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.transPosBtn);
            this.Controls.Add(this.emptyLocsLbl);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.stackDepthLbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.showCoordsChk);
            this.Controls.Add(this.clickHereBtn);
            this.Controls.Add(this.forceClickLocationTxt);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.getPtsBtn);
            this.Controls.Add(this.hexPtsTxt);
            this.Controls.Add(this.hPt6Lbl);
            this.Controls.Add(this.hPt5Lbl);
            this.Controls.Add(this.hPt4Lbl);
            this.Controls.Add(this.hPt3Lbl);
            this.Controls.Add(this.hPt2Lbl);
            this.Controls.Add(this.hPt1Lbl);
            this.Controls.Add(this.rValLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.qValLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lastYCoordClickLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastXClickCoordLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.yCoordLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xCoordLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
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
            this.Name = "DebugForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label xCoordLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label yCoordLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lastXClickCoordLbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lastYCoordClickLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label qValLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rValLbl;
        private System.Windows.Forms.Label hPt1Lbl;
        private System.Windows.Forms.Label hPt2Lbl;
        private System.Windows.Forms.Label hPt3Lbl;
        private System.Windows.Forms.Label hPt4Lbl;
        private System.Windows.Forms.Label hPt5Lbl;
        private System.Windows.Forms.Label hPt6Lbl;
        private System.Windows.Forms.TextBox hexPtsTxt;
        private System.Windows.Forms.Button getPtsBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox forceClickLocationTxt;
        private System.Windows.Forms.Button clickHereBtn;
        private System.Windows.Forms.CheckBox showCoordsChk;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label stackDepthLbl;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label emptyLocsLbl;
        private System.Windows.Forms.Button transPosBtn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label numSeaTxt;
        private System.Windows.Forms.Label numLandTxt;
        private System.Windows.Forms.Label numEmptyTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label numHillTxt;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label CDF_HHLbl;
        private System.Windows.Forms.Label CDF_HLLbl;
        private System.Windows.Forms.Label CDF_HSLbl;
        private System.Windows.Forms.Label CDF_LHLbl;
        private System.Windows.Forms.Label CDF_LLLbl;
        private System.Windows.Forms.Label CDF_LSLbl;
        private System.Windows.Forms.Label CDF_SHLbl;
        private System.Windows.Forms.Label CDF_SLLbl;
        private System.Windows.Forms.Label CDF_SSLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label CDF_MMLbl;
        private System.Windows.Forms.Label CDF_MHLbl;
        private System.Windows.Forms.Label CDF_MLLbl;
        private System.Windows.Forms.Label CDF_MSLbl;
        private System.Windows.Forms.Label CDF_HMLbl;
        private System.Windows.Forms.Label CDF_LMLbl;
        private System.Windows.Forms.Label CDF_SMLbl;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label numMtnText;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
    }
}

