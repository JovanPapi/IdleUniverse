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
            this.lblProtonProduceEnergy = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.lblNeutron = new System.Windows.Forms.Label();
            this.lblNeutronProduceEnergy = new System.Windows.Forms.Label();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.lblElectron = new System.Windows.Forms.Label();
            this.lblElectronProduceEnergy = new System.Windows.Forms.Label();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.lbQuark = new System.Windows.Forms.Label();
            this.lblQuarkProduceEnergy = new System.Windows.Forms.Label();
            this.lblQuarks = new System.Windows.Forms.Label();
            this.Panel6 = new System.Windows.Forms.Panel();
            this.lblPhoton = new System.Windows.Forms.Label();
            this.lblPhotonProduceEnergy = new System.Windows.Forms.Label();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.lblHiggsBoson = new System.Windows.Forms.Label();
            this.lblHiggsBosonProduceEnergy = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lblNeutrino = new System.Windows.Forms.Label();
            this.lblNeutrinoProduceEnergy = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblQuantiumFoam = new System.Windows.Forms.Label();
            this.lblQuantiumFoamProduceEnergy = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lblString = new System.Windows.Forms.Label();
            this.lblStringProduceEnergy = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
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
            // lblProtonProduceEnergy
            // 
            this.lblProtonProduceEnergy.AutoSize = true;
            this.lblProtonProduceEnergy.Location = new System.Drawing.Point(65, 135);
            this.lblProtonProduceEnergy.Name = "lblProtonProduceEnergy";
            this.lblProtonProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblProtonProduceEnergy.TabIndex = 9;
            this.lblProtonProduceEnergy.Text = "label9";
            // 
            // Panel9
            // 
            this.Panel9.Controls.Add(this.lblProtonProduceEnergy);
            this.Panel9.Controls.Add(this.lblProton);
            this.Panel9.Location = new System.Drawing.Point(359, 443);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(170, 170);
            this.Panel9.TabIndex = 17;
            this.Panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblNeutron
            // 
            this.lblNeutron.AutoSize = true;
            this.lblNeutron.Location = new System.Drawing.Point(28, 9);
            this.lblNeutron.Name = "lblNeutron";
            this.lblNeutron.Size = new System.Drawing.Size(0, 13);
            this.lblNeutron.TabIndex = 0;
            // 
            // lblNeutronProduceEnergy
            // 
            this.lblNeutronProduceEnergy.AutoSize = true;
            this.lblNeutronProduceEnergy.Location = new System.Drawing.Point(63, 135);
            this.lblNeutronProduceEnergy.Name = "lblNeutronProduceEnergy";
            this.lblNeutronProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblNeutronProduceEnergy.TabIndex = 8;
            this.lblNeutronProduceEnergy.Text = "label8";
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.lblNeutronProduceEnergy);
            this.Panel8.Controls.Add(this.lblNeutron);
            this.Panel8.Location = new System.Drawing.Point(183, 443);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(170, 170);
            this.Panel8.TabIndex = 17;
            this.Panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblElectron
            // 
            this.lblElectron.AutoSize = true;
            this.lblElectron.Location = new System.Drawing.Point(28, 9);
            this.lblElectron.Name = "lblElectron";
            this.lblElectron.Size = new System.Drawing.Size(0, 13);
            this.lblElectron.TabIndex = 0;
            // 
            // lblElectronProduceEnergy
            // 
            this.lblElectronProduceEnergy.AutoSize = true;
            this.lblElectronProduceEnergy.Location = new System.Drawing.Point(67, 135);
            this.lblElectronProduceEnergy.Name = "lblElectronProduceEnergy";
            this.lblElectronProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblElectronProduceEnergy.TabIndex = 7;
            this.lblElectronProduceEnergy.Text = "label7";
            // 
            // Panel7
            // 
            this.Panel7.Controls.Add(this.lblElectronProduceEnergy);
            this.Panel7.Controls.Add(this.lblElectron);
            this.Panel7.Location = new System.Drawing.Point(7, 443);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(170, 170);
            this.Panel7.TabIndex = 16;
            this.Panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lbQuark
            // 
            this.lbQuark.AutoSize = true;
            this.lbQuark.Location = new System.Drawing.Point(28, 9);
            this.lbQuark.Name = "lbQuark";
            this.lbQuark.Size = new System.Drawing.Size(0, 13);
            this.lbQuark.TabIndex = 0;
            // 
            // lblQuarkProduceEnergy
            // 
            this.lblQuarkProduceEnergy.AutoSize = true;
            this.lblQuarkProduceEnergy.Location = new System.Drawing.Point(65, 135);
            this.lblQuarkProduceEnergy.Name = "lblQuarkProduceEnergy";
            this.lblQuarkProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblQuarkProduceEnergy.TabIndex = 6;
            this.lblQuarkProduceEnergy.Text = "label6";
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
            this.Panel6.Controls.Add(this.lblQuarkProduceEnergy);
            this.Panel6.Controls.Add(this.lbQuark);
            this.Panel6.Location = new System.Drawing.Point(359, 267);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(170, 170);
            this.Panel6.TabIndex = 16;
            this.Panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblPhoton
            // 
            this.lblPhoton.AutoSize = true;
            this.lblPhoton.Location = new System.Drawing.Point(28, 9);
            this.lblPhoton.Name = "lblPhoton";
            this.lblPhoton.Size = new System.Drawing.Size(0, 13);
            this.lblPhoton.TabIndex = 0;
            // 
            // lblPhotonProduceEnergy
            // 
            this.lblPhotonProduceEnergy.AutoSize = true;
            this.lblPhotonProduceEnergy.Location = new System.Drawing.Point(63, 135);
            this.lblPhotonProduceEnergy.Name = "lblPhotonProduceEnergy";
            this.lblPhotonProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblPhotonProduceEnergy.TabIndex = 5;
            this.lblPhotonProduceEnergy.Text = "label5";
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.lblPhotonProduceEnergy);
            this.Panel5.Controls.Add(this.lblPhoton);
            this.Panel5.Location = new System.Drawing.Point(183, 267);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(170, 170);
            this.Panel5.TabIndex = 15;
            this.Panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblHiggsBoson
            // 
            this.lblHiggsBoson.AutoSize = true;
            this.lblHiggsBoson.Location = new System.Drawing.Point(28, 9);
            this.lblHiggsBoson.Name = "lblHiggsBoson";
            this.lblHiggsBoson.Size = new System.Drawing.Size(0, 13);
            this.lblHiggsBoson.TabIndex = 0;
            // 
            // lblHiggsBosonProduceEnergy
            // 
            this.lblHiggsBosonProduceEnergy.AutoSize = true;
            this.lblHiggsBosonProduceEnergy.Location = new System.Drawing.Point(67, 135);
            this.lblHiggsBosonProduceEnergy.Name = "lblHiggsBosonProduceEnergy";
            this.lblHiggsBosonProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblHiggsBosonProduceEnergy.TabIndex = 4;
            this.lblHiggsBosonProduceEnergy.Text = "label4";
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.lblHiggsBosonProduceEnergy);
            this.Panel4.Controls.Add(this.lblHiggsBoson);
            this.Panel4.Location = new System.Drawing.Point(7, 267);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(170, 170);
            this.Panel4.TabIndex = 15;
            this.Panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblNeutrino
            // 
            this.lblNeutrino.AutoSize = true;
            this.lblNeutrino.Location = new System.Drawing.Point(28, 9);
            this.lblNeutrino.Name = "lblNeutrino";
            this.lblNeutrino.Size = new System.Drawing.Size(0, 13);
            this.lblNeutrino.TabIndex = 0;
            // 
            // lblNeutrinoProduceEnergy
            // 
            this.lblNeutrinoProduceEnergy.AutoSize = true;
            this.lblNeutrinoProduceEnergy.Location = new System.Drawing.Point(65, 136);
            this.lblNeutrinoProduceEnergy.Name = "lblNeutrinoProduceEnergy";
            this.lblNeutrinoProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblNeutrinoProduceEnergy.TabIndex = 3;
            this.lblNeutrinoProduceEnergy.Text = "label3";
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.lblNeutrinoProduceEnergy);
            this.Panel3.Controls.Add(this.lblNeutrino);
            this.Panel3.Location = new System.Drawing.Point(359, 91);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(170, 170);
            this.Panel3.TabIndex = 15;
            this.Panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblQuantiumFoam
            // 
            this.lblQuantiumFoam.AutoSize = true;
            this.lblQuantiumFoam.Location = new System.Drawing.Point(28, 9);
            this.lblQuantiumFoam.Name = "lblQuantiumFoam";
            this.lblQuantiumFoam.Size = new System.Drawing.Size(0, 13);
            this.lblQuantiumFoam.TabIndex = 0;
            // 
            // lblQuantiumFoamProduceEnergy
            // 
            this.lblQuantiumFoamProduceEnergy.AutoSize = true;
            this.lblQuantiumFoamProduceEnergy.Location = new System.Drawing.Point(63, 136);
            this.lblQuantiumFoamProduceEnergy.Name = "lblQuantiumFoamProduceEnergy";
            this.lblQuantiumFoamProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblQuantiumFoamProduceEnergy.TabIndex = 2;
            this.lblQuantiumFoamProduceEnergy.Text = "label2";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lblQuantiumFoamProduceEnergy);
            this.Panel2.Controls.Add(this.lblQuantiumFoam);
            this.Panel2.Location = new System.Drawing.Point(183, 91);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(170, 170);
            this.Panel2.TabIndex = 15;
            this.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(28, 9);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(0, 13);
            this.lblString.TabIndex = 0;
            // 
            // lblStringProduceEnergy
            // 
            this.lblStringProduceEnergy.AutoSize = true;
            this.lblStringProduceEnergy.Location = new System.Drawing.Point(67, 136);
            this.lblStringProduceEnergy.Name = "lblStringProduceEnergy";
            this.lblStringProduceEnergy.Size = new System.Drawing.Size(35, 13);
            this.lblStringProduceEnergy.TabIndex = 1;
            this.lblStringProduceEnergy.Text = "label1";
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.lblStringProduceEnergy);
            this.Panel1.Controls.Add(this.lblString);
            this.Panel1.Location = new System.Drawing.Point(7, 91);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(170, 170);
            this.Panel1.TabIndex = 14;
            this.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickedPanel);
            // 
            // SectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 679);
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
        private System.Windows.Forms.Label lblProtonProduceEnergy;
        private System.Windows.Forms.Panel Panel9;
        private System.Windows.Forms.Label lblNeutron;
        private System.Windows.Forms.Label lblNeutronProduceEnergy;
        private System.Windows.Forms.Panel Panel8;
        private System.Windows.Forms.Label lblElectron;
        private System.Windows.Forms.Label lblElectronProduceEnergy;
        private System.Windows.Forms.Panel Panel7;
        private System.Windows.Forms.Label lbQuark;
        private System.Windows.Forms.Label lblQuarkProduceEnergy;
        private System.Windows.Forms.Label lblQuarks;
        private System.Windows.Forms.Panel Panel6;
        private System.Windows.Forms.Label lblPhoton;
        private System.Windows.Forms.Label lblPhotonProduceEnergy;
        private System.Windows.Forms.Panel Panel5;
        private System.Windows.Forms.Label lblHiggsBoson;
        private System.Windows.Forms.Label lblHiggsBosonProduceEnergy;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Label lblNeutrino;
        private System.Windows.Forms.Label lblNeutrinoProduceEnergy;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Label lblQuantiumFoam;
        private System.Windows.Forms.Label lblQuantiumFoamProduceEnergy;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblStringProduceEnergy;
        private System.Windows.Forms.Panel Panel1;
    }
}