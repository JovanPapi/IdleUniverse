namespace IdleUniverse
{
    partial class SectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbMAX = new System.Windows.Forms.RadioButton();
            this.rbX100 = new System.Windows.Forms.RadioButton();
            this.rbX10 = new System.Windows.Forms.RadioButton();
            this.rbX1 = new System.Windows.Forms.RadioButton();
            this.lblAtomicEnergyNumber = new System.Windows.Forms.Label();
            this.timerForEnergyProduce = new System.Windows.Forms.Timer(this.components);
            this.pbGoBackToFirstTab = new System.Windows.Forms.PictureBox();
            this.pbAtomicEnergyPictureNumber = new System.Windows.Forms.PictureBox();
            this.lblProton = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.lblNeutron = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.lblElectron = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lbQuark = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblQuarks = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.lblPhoton = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.lblHiggsBoson = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lblNeutrino = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblQuantiumFoam = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblString = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.Panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.Panel12 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.Panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBackToFirstTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtomicEnergyPictureNumber)).BeginInit();
            this.Panel9.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.Panel6.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel10.SuspendLayout();
            this.Panel12.SuspendLayout();
            this.Panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Font = new System.Drawing.Font("Arial", 11F);
            this.rbQuick.Location = new System.Drawing.Point(237, 62);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(64, 21);
            this.rbQuick.TabIndex = 11;
            this.rbQuick.TabStop = true;
            this.rbQuick.Text = "Quick";
            this.rbQuick.UseVisualStyleBackColor = true;
            this.rbQuick.CheckedChanged += new System.EventHandler(this.RadioButtonClick);
            // 
            // rbMAX
            // 
            this.rbMAX.AutoSize = true;
            this.rbMAX.Font = new System.Drawing.Font("Arial", 11F);
            this.rbMAX.Location = new System.Drawing.Point(176, 62);
            this.rbMAX.Name = "rbMAX";
            this.rbMAX.Size = new System.Drawing.Size(55, 21);
            this.rbMAX.TabIndex = 10;
            this.rbMAX.TabStop = true;
            this.rbMAX.Text = "MAX";
            this.rbMAX.UseVisualStyleBackColor = true;
            this.rbMAX.CheckedChanged += new System.EventHandler(this.RadioButtonClick);
            // 
            // rbX100
            // 
            this.rbX100.AutoSize = true;
            this.rbX100.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX100.Location = new System.Drawing.Point(109, 62);
            this.rbX100.Name = "rbX100";
            this.rbX100.Size = new System.Drawing.Size(57, 21);
            this.rbX100.TabIndex = 9;
            this.rbX100.TabStop = true;
            this.rbX100.Text = "x100";
            this.rbX100.UseVisualStyleBackColor = true;
            this.rbX100.CheckedChanged += new System.EventHandler(this.RadioButtonClick);
            // 
            // rbX10
            // 
            this.rbX10.AutoSize = true;
            this.rbX10.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX10.Location = new System.Drawing.Point(54, 62);
            this.rbX10.Name = "rbX10";
            this.rbX10.Size = new System.Drawing.Size(49, 21);
            this.rbX10.TabIndex = 8;
            this.rbX10.TabStop = true;
            this.rbX10.Text = "x10";
            this.rbX10.UseVisualStyleBackColor = true;
            this.rbX10.CheckedChanged += new System.EventHandler(this.RadioButtonClick);
            // 
            // rbX1
            // 
            this.rbX1.AutoSize = true;
            this.rbX1.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX1.Location = new System.Drawing.Point(7, 62);
            this.rbX1.Name = "rbX1";
            this.rbX1.Size = new System.Drawing.Size(41, 21);
            this.rbX1.TabIndex = 7;
            this.rbX1.TabStop = true;
            this.rbX1.Text = "x1";
            this.rbX1.UseVisualStyleBackColor = true;
            this.rbX1.CheckedChanged += new System.EventHandler(this.RadioButtonClick);
            // 
            // lblAtomicEnergyNumber
            // 
            this.lblAtomicEnergyNumber.AutoSize = true;
            this.lblAtomicEnergyNumber.Location = new System.Drawing.Point(38, 18);
            this.lblAtomicEnergyNumber.Name = "lblAtomicEnergyNumber";
            this.lblAtomicEnergyNumber.Size = new System.Drawing.Size(13, 13);
            this.lblAtomicEnergyNumber.TabIndex = 13;
            this.lblAtomicEnergyNumber.Text = "0";
            // 
            // timerForEnergyProduce
            // 
            this.timerForEnergyProduce.Enabled = true;
            this.timerForEnergyProduce.Interval = 1000;
            this.timerForEnergyProduce.Tick += new System.EventHandler(this.TimerForEnergyProduce_Tick);
            // 
            // pbGoBackToFirstTab
            // 
            this.pbGoBackToFirstTab.Location = new System.Drawing.Point(407, 40);
            this.pbGoBackToFirstTab.Name = "pbGoBackToFirstTab";
            this.pbGoBackToFirstTab.Size = new System.Drawing.Size(122, 43);
            this.pbGoBackToFirstTab.TabIndex = 18;
            this.pbGoBackToFirstTab.TabStop = false;
            this.pbGoBackToFirstTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbGoBackToFirstTab_MouseClick);
            // 
            // pbAtomicEnergyPictureNumber
            // 
            this.pbAtomicEnergyPictureNumber.Location = new System.Drawing.Point(7, 12);
            this.pbAtomicEnergyPictureNumber.Name = "pbAtomicEnergyPictureNumber";
            this.pbAtomicEnergyPictureNumber.Size = new System.Drawing.Size(25, 26);
            this.pbAtomicEnergyPictureNumber.TabIndex = 19;
            this.pbAtomicEnergyPictureNumber.TabStop = false;
            // 
            // lblProton
            // 
            this.lblProton.AutoSize = true;
            this.lblProton.Location = new System.Drawing.Point(28, 9);
            this.lblProton.Name = "lblProton";
            this.lblProton.Size = new System.Drawing.Size(0, 13);
            this.lblProton.TabIndex = 0;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(65, 135);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(35, 13);
            this.lbl9.TabIndex = 9;
            this.lbl9.Text = "label9";
            // 
            // Panel9
            // 
            this.Panel9.Controls.Add(this.lbl9);
            this.Panel9.Controls.Add(this.lblProton);
            this.Panel9.Location = new System.Drawing.Point(359, 443);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(170, 170);
            this.Panel9.TabIndex = 17;
            this.Panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblNeutron
            // 
            this.lblNeutron.AutoSize = true;
            this.lblNeutron.Location = new System.Drawing.Point(28, 9);
            this.lblNeutron.Name = "lblNeutron";
            this.lblNeutron.Size = new System.Drawing.Size(0, 13);
            this.lblNeutron.TabIndex = 0;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(63, 135);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(35, 13);
            this.lbl8.TabIndex = 8;
            this.lbl8.Text = "label8";
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.lbl8);
            this.Panel8.Controls.Add(this.lblNeutron);
            this.Panel8.Location = new System.Drawing.Point(183, 443);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(170, 170);
            this.Panel8.TabIndex = 17;
            this.Panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblElectron
            // 
            this.lblElectron.AutoSize = true;
            this.lblElectron.Location = new System.Drawing.Point(28, 9);
            this.lblElectron.Name = "lblElectron";
            this.lblElectron.Size = new System.Drawing.Size(0, 13);
            this.lblElectron.TabIndex = 0;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(67, 135);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(35, 13);
            this.lbl7.TabIndex = 7;
            this.lbl7.Text = "label7";
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.lbl7);
            this.Panel7.Controls.Add(this.lblElectron);
            this.Panel7.Location = new System.Drawing.Point(7, 443);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(170, 170);
            this.Panel7.TabIndex = 16;
            this.Panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lbQuark
            // 
            this.lbQuark.AutoSize = true;
            this.lbQuark.Location = new System.Drawing.Point(28, 9);
            this.lbQuark.Name = "lbQuark";
            this.lbQuark.Size = new System.Drawing.Size(0, 13);
            this.lbQuark.TabIndex = 0;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(65, 135);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(35, 13);
            this.lbl6.TabIndex = 6;
            this.lbl6.Text = "label6";
            // 
            // lblQuarks
            // 
            this.lblQuarks.AutoSize = true;
            this.lblQuarks.Location = new System.Drawing.Point(77, 9);
            this.lblQuarks.Name = "lblQuarks";
            this.lblQuarks.Size = new System.Drawing.Size(0, 13);
            this.lblQuarks.TabIndex = 6;
            // 
            // Panel6
            // 
            this.Panel6.Controls.Add(this.lblQuarks);
            this.Panel6.Controls.Add(this.lbl6);
            this.Panel6.Controls.Add(this.lbQuark);
            this.Panel6.Location = new System.Drawing.Point(359, 267);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(170, 170);
            this.Panel6.TabIndex = 16;
            this.Panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblPhoton
            // 
            this.lblPhoton.AutoSize = true;
            this.lblPhoton.Location = new System.Drawing.Point(28, 9);
            this.lblPhoton.Name = "lblPhoton";
            this.lblPhoton.Size = new System.Drawing.Size(0, 13);
            this.lblPhoton.TabIndex = 0;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(63, 135);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(35, 13);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "label5";
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.lbl5);
            this.Panel5.Controls.Add(this.lblPhoton);
            this.Panel5.Location = new System.Drawing.Point(183, 267);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(170, 170);
            this.Panel5.TabIndex = 15;
            this.Panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblHiggsBoson
            // 
            this.lblHiggsBoson.AutoSize = true;
            this.lblHiggsBoson.Location = new System.Drawing.Point(28, 9);
            this.lblHiggsBoson.Name = "lblHiggsBoson";
            this.lblHiggsBoson.Size = new System.Drawing.Size(0, 13);
            this.lblHiggsBoson.TabIndex = 0;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(67, 135);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "label4";
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.lbl4);
            this.Panel4.Controls.Add(this.lblHiggsBoson);
            this.Panel4.Location = new System.Drawing.Point(7, 267);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(170, 170);
            this.Panel4.TabIndex = 15;
            this.Panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblNeutrino
            // 
            this.lblNeutrino.AutoSize = true;
            this.lblNeutrino.Location = new System.Drawing.Point(28, 9);
            this.lblNeutrino.Name = "lblNeutrino";
            this.lblNeutrino.Size = new System.Drawing.Size(0, 13);
            this.lblNeutrino.TabIndex = 0;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(65, 136);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "label3";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.lbl3);
            this.Panel3.Controls.Add(this.lblNeutrino);
            this.Panel3.Location = new System.Drawing.Point(359, 91);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(170, 170);
            this.Panel3.TabIndex = 15;
            this.Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblQuantiumFoam
            // 
            this.lblQuantiumFoam.AutoSize = true;
            this.lblQuantiumFoam.Location = new System.Drawing.Point(28, 9);
            this.lblQuantiumFoam.Name = "lblQuantiumFoam";
            this.lblQuantiumFoam.Size = new System.Drawing.Size(0, 13);
            this.lblQuantiumFoam.TabIndex = 0;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(63, 136);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "label2";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lbl2);
            this.Panel2.Controls.Add(this.lblQuantiumFoam);
            this.Panel2.Location = new System.Drawing.Point(183, 91);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(170, 170);
            this.Panel2.TabIndex = 15;
            this.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(28, 9);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(0, 13);
            this.lblString.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(67, 136);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "label1";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lbl1);
            this.Panel1.Controls.Add(this.lblString);
            this.Panel1.Location = new System.Drawing.Point(7, 91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(170, 170);
            this.Panel1.TabIndex = 14;
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(65, 135);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(41, 13);
            this.lbl10.TabIndex = 9;
            this.lbl10.Text = "label10";
            // 
            // Panel10
            // 
            this.Panel10.Controls.Add(this.lbl10);
            this.Panel10.Controls.Add(this.label2);
            this.Panel10.Location = new System.Drawing.Point(7, 619);
            this.Panel10.Name = "Panel10";
            this.Panel10.Size = new System.Drawing.Size(170, 170);
            this.Panel10.TabIndex = 18;
            this.Panel10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Location = new System.Drawing.Point(65, 135);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(41, 13);
            this.lbl12.TabIndex = 9;
            this.lbl12.Text = "label12";
            // 
            // Panel12
            // 
            this.Panel12.AutoSize = true;
            this.Panel12.Controls.Add(this.lbl12);
            this.Panel12.Controls.Add(this.label6);
            this.Panel12.Location = new System.Drawing.Point(359, 619);
            this.Panel12.Name = "Panel12";
            this.Panel12.Size = new System.Drawing.Size(170, 170);
            this.Panel12.TabIndex = 18;
            this.Panel12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Location = new System.Drawing.Point(65, 135);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(41, 13);
            this.lbl11.TabIndex = 9;
            this.lbl11.Text = "label11";
            // 
            // Panel11
            // 
            this.Panel11.Controls.Add(this.lbl11);
            this.Panel11.Controls.Add(this.label4);
            this.Panel11.Location = new System.Drawing.Point(183, 619);
            this.Panel11.Name = "Panel11";
            this.Panel11.Size = new System.Drawing.Size(170, 170);
            this.Panel11.TabIndex = 18;
            this.Panel11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedMaterialPanel);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 617);
            this.Controls.Add(this.Panel12);
            this.Controls.Add(this.Panel11);
            this.Controls.Add(this.Panel10);
            this.Controls.Add(this.pbAtomicEnergyPictureNumber);
            this.Controls.Add(this.pbGoBackToFirstTab);
            this.Controls.Add(this.Panel8);
            this.Controls.Add(this.Panel9);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel6);
            this.Controls.Add(this.Panel7);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.lblAtomicEnergyNumber);
            this.Controls.Add(this.rbQuick);
            this.Controls.Add(this.rbMAX);
            this.Controls.Add(this.rbX100);
            this.Controls.Add(this.rbX10);
            this.Controls.Add(this.rbX1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SectionForm";
            this.Text = "SectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBackToFirstTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtomicEnergyPictureNumber)).EndInit();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.Panel6.ResumeLayout(false);
            this.Panel6.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel10.ResumeLayout(false);
            this.Panel10.PerformLayout();
            this.Panel12.ResumeLayout(false);
            this.Panel12.PerformLayout();
            this.Panel11.ResumeLayout(false);
            this.Panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbMAX;
        private System.Windows.Forms.RadioButton rbX100;
        private System.Windows.Forms.RadioButton rbX10;
        private System.Windows.Forms.RadioButton rbX1;
        private System.Windows.Forms.Label lblAtomicEnergyNumber;
        private System.Windows.Forms.Timer timerForEnergyProduce;
        private System.Windows.Forms.PictureBox pbGoBackToFirstTab;
        private System.Windows.Forms.PictureBox pbAtomicEnergyPictureNumber;
        private System.Windows.Forms.Label lblProton;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Panel Panel9;
        private System.Windows.Forms.Label lblNeutron;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Panel Panel8;
        private System.Windows.Forms.Label lblElectron;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Panel Panel7;
        private System.Windows.Forms.Label lbQuark;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblQuarks;
        private System.Windows.Forms.Panel Panel6;
        private System.Windows.Forms.Label lblPhoton;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.Label lblHiggsBoson;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Label lblNeutrino;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Label lblQuantiumFoam;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Panel Panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Panel Panel12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Panel Panel11;
    }
}