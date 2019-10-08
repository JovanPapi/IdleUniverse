namespace IdleUniverse
{
    partial class QuantiumForm
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
            this.AtomicImagePanel = new System.Windows.Forms.Panel();
            this.StringPanel = new System.Windows.Forms.Panel();
            this.lblStringProduceEnergy = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.QuantiumFoamPanel = new System.Windows.Forms.Panel();
            this.lblQuantiumFoamProduceEnergy = new System.Windows.Forms.Label();
            this.lblQuantiumFoam = new System.Windows.Forms.Label();
            this.HiggsBosonPanel = new System.Windows.Forms.Panel();
            this.lblHiggsBosonProduceEnergy = new System.Windows.Forms.Label();
            this.lblHiggsBoson = new System.Windows.Forms.Label();
            this.NeutrinoPanel = new System.Windows.Forms.Panel();
            this.lblNeutrinoProduceEnergy = new System.Windows.Forms.Label();
            this.lblNeutrino = new System.Windows.Forms.Label();
            this.PhotonPanel = new System.Windows.Forms.Panel();
            this.lblPhotonProduceEnergy = new System.Windows.Forms.Label();
            this.lblPhoton = new System.Windows.Forms.Label();
            this.ElectronPanel = new System.Windows.Forms.Panel();
            this.lblElectronProduceEnergy = new System.Windows.Forms.Label();
            this.lblElectron = new System.Windows.Forms.Label();
            this.QuarkPanel = new System.Windows.Forms.Panel();
            this.lblQuarks = new System.Windows.Forms.Label();
            this.lblQuarkProduceEnergy = new System.Windows.Forms.Label();
            this.lbQuark = new System.Windows.Forms.Label();
            this.NeutronPanel = new System.Windows.Forms.Panel();
            this.lblNeutronProduceEnergy = new System.Windows.Forms.Label();
            this.lblNeutron = new System.Windows.Forms.Label();
            this.ProtonPanel = new System.Windows.Forms.Panel();
            this.lblProtonProduceEnergy = new System.Windows.Forms.Label();
            this.lblProton = new System.Windows.Forms.Label();
            this.timerForEnergyProduce = new System.Windows.Forms.Timer(this.components);
            this.pbGoBackToFirstTab = new System.Windows.Forms.PictureBox();
            this.StringPanel.SuspendLayout();
            this.QuantiumFoamPanel.SuspendLayout();
            this.HiggsBosonPanel.SuspendLayout();
            this.NeutrinoPanel.SuspendLayout();
            this.PhotonPanel.SuspendLayout();
            this.ElectronPanel.SuspendLayout();
            this.QuarkPanel.SuspendLayout();
            this.NeutronPanel.SuspendLayout();
            this.ProtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBackToFirstTab)).BeginInit();
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
            // AtomicImagePanel
            // 
            this.AtomicImagePanel.Location = new System.Drawing.Point(11, 14);
            this.AtomicImagePanel.Name = "AtomicImagePanel";
            this.AtomicImagePanel.Size = new System.Drawing.Size(20, 21);
            this.AtomicImagePanel.TabIndex = 12;
            // 
            // StringPanel
            // 
            this.StringPanel.Controls.Add(this.lblStringProduceEnergy);
            this.StringPanel.Controls.Add(this.lblString);
            this.StringPanel.Location = new System.Drawing.Point(7, 91);
            this.StringPanel.Name = "StringPanel";
            this.StringPanel.Size = new System.Drawing.Size(170, 170);
            this.StringPanel.TabIndex = 14;
            this.StringPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StringPanel_MouseClick);
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
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(28, 9);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(0, 13);
            this.lblString.TabIndex = 0;
            // 
            // QuantiumFoamPanel
            // 
            this.QuantiumFoamPanel.Controls.Add(this.lblQuantiumFoamProduceEnergy);
            this.QuantiumFoamPanel.Controls.Add(this.lblQuantiumFoam);
            this.QuantiumFoamPanel.Location = new System.Drawing.Point(183, 91);
            this.QuantiumFoamPanel.Name = "QuantiumFoamPanel";
            this.QuantiumFoamPanel.Size = new System.Drawing.Size(170, 170);
            this.QuantiumFoamPanel.TabIndex = 15;
            this.QuantiumFoamPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuantiumFoamPanel_MouseClick);
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
            // lblQuantiumFoam
            // 
            this.lblQuantiumFoam.AutoSize = true;
            this.lblQuantiumFoam.Location = new System.Drawing.Point(28, 9);
            this.lblQuantiumFoam.Name = "lblQuantiumFoam";
            this.lblQuantiumFoam.Size = new System.Drawing.Size(0, 13);
            this.lblQuantiumFoam.TabIndex = 0;
            // 
            // HiggsBosonPanel
            // 
            this.HiggsBosonPanel.Controls.Add(this.lblHiggsBosonProduceEnergy);
            this.HiggsBosonPanel.Controls.Add(this.lblHiggsBoson);
            this.HiggsBosonPanel.Location = new System.Drawing.Point(7, 267);
            this.HiggsBosonPanel.Name = "HiggsBosonPanel";
            this.HiggsBosonPanel.Size = new System.Drawing.Size(170, 170);
            this.HiggsBosonPanel.TabIndex = 15;
            this.HiggsBosonPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HiggsBosonPanel_MouseClick);
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
            // lblHiggsBoson
            // 
            this.lblHiggsBoson.AutoSize = true;
            this.lblHiggsBoson.Location = new System.Drawing.Point(28, 9);
            this.lblHiggsBoson.Name = "lblHiggsBoson";
            this.lblHiggsBoson.Size = new System.Drawing.Size(0, 13);
            this.lblHiggsBoson.TabIndex = 0;
            // 
            // NeutrinoPanel
            // 
            this.NeutrinoPanel.Controls.Add(this.lblNeutrinoProduceEnergy);
            this.NeutrinoPanel.Controls.Add(this.lblNeutrino);
            this.NeutrinoPanel.Location = new System.Drawing.Point(359, 91);
            this.NeutrinoPanel.Name = "NeutrinoPanel";
            this.NeutrinoPanel.Size = new System.Drawing.Size(170, 170);
            this.NeutrinoPanel.TabIndex = 15;
            this.NeutrinoPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NeutrinoPanel_MouseClick);
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
            // lblNeutrino
            // 
            this.lblNeutrino.AutoSize = true;
            this.lblNeutrino.Location = new System.Drawing.Point(28, 9);
            this.lblNeutrino.Name = "lblNeutrino";
            this.lblNeutrino.Size = new System.Drawing.Size(0, 13);
            this.lblNeutrino.TabIndex = 0;
            // 
            // PhotonPanel
            // 
            this.PhotonPanel.Controls.Add(this.lblPhotonProduceEnergy);
            this.PhotonPanel.Controls.Add(this.lblPhoton);
            this.PhotonPanel.Location = new System.Drawing.Point(183, 267);
            this.PhotonPanel.Name = "PhotonPanel";
            this.PhotonPanel.Size = new System.Drawing.Size(170, 170);
            this.PhotonPanel.TabIndex = 15;
            this.PhotonPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PhotonPanel_MouseClick);
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
            // lblPhoton
            // 
            this.lblPhoton.AutoSize = true;
            this.lblPhoton.Location = new System.Drawing.Point(28, 9);
            this.lblPhoton.Name = "lblPhoton";
            this.lblPhoton.Size = new System.Drawing.Size(0, 13);
            this.lblPhoton.TabIndex = 0;
            // 
            // ElectronPanel
            // 
            this.ElectronPanel.Controls.Add(this.lblElectronProduceEnergy);
            this.ElectronPanel.Controls.Add(this.lblElectron);
            this.ElectronPanel.Location = new System.Drawing.Point(7, 443);
            this.ElectronPanel.Name = "ElectronPanel";
            this.ElectronPanel.Size = new System.Drawing.Size(170, 170);
            this.ElectronPanel.TabIndex = 16;
            this.ElectronPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ElectronPanel_MouseClick);
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
            // lblElectron
            // 
            this.lblElectron.AutoSize = true;
            this.lblElectron.Location = new System.Drawing.Point(28, 9);
            this.lblElectron.Name = "lblElectron";
            this.lblElectron.Size = new System.Drawing.Size(0, 13);
            this.lblElectron.TabIndex = 0;
            // 
            // QuarkPanel
            // 
            this.QuarkPanel.Controls.Add(this.lblQuarks);
            this.QuarkPanel.Controls.Add(this.lblQuarkProduceEnergy);
            this.QuarkPanel.Controls.Add(this.lbQuark);
            this.QuarkPanel.Location = new System.Drawing.Point(359, 267);
            this.QuarkPanel.Name = "QuarkPanel";
            this.QuarkPanel.Size = new System.Drawing.Size(170, 170);
            this.QuarkPanel.TabIndex = 16;
            this.QuarkPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuarkPanel_MouseClick);
            // 
            // lblQuarks
            // 
            this.lblQuarks.AutoSize = true;
            this.lblQuarks.Location = new System.Drawing.Point(77, 9);
            this.lblQuarks.Name = "lblQuarks";
            this.lblQuarks.Size = new System.Drawing.Size(0, 13);
            this.lblQuarks.TabIndex = 6;
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
            // lbQuark
            // 
            this.lbQuark.AutoSize = true;
            this.lbQuark.Location = new System.Drawing.Point(28, 9);
            this.lbQuark.Name = "lbQuark";
            this.lbQuark.Size = new System.Drawing.Size(0, 13);
            this.lbQuark.TabIndex = 0;
            // 
            // NeutronPanel
            // 
            this.NeutronPanel.Controls.Add(this.lblNeutronProduceEnergy);
            this.NeutronPanel.Controls.Add(this.lblNeutron);
            this.NeutronPanel.Location = new System.Drawing.Point(183, 443);
            this.NeutronPanel.Name = "NeutronPanel";
            this.NeutronPanel.Size = new System.Drawing.Size(170, 170);
            this.NeutronPanel.TabIndex = 17;
            this.NeutronPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NeutronPanel_MouseClick);
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
            // lblNeutron
            // 
            this.lblNeutron.AutoSize = true;
            this.lblNeutron.Location = new System.Drawing.Point(28, 9);
            this.lblNeutron.Name = "lblNeutron";
            this.lblNeutron.Size = new System.Drawing.Size(0, 13);
            this.lblNeutron.TabIndex = 0;
            // 
            // ProtonPanel
            // 
            this.ProtonPanel.Controls.Add(this.lblProtonProduceEnergy);
            this.ProtonPanel.Controls.Add(this.lblProton);
            this.ProtonPanel.Location = new System.Drawing.Point(359, 443);
            this.ProtonPanel.Name = "ProtonPanel";
            this.ProtonPanel.Size = new System.Drawing.Size(170, 170);
            this.ProtonPanel.TabIndex = 17;
            this.ProtonPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProtonPanel_MouseClick);
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
            // lblProton
            // 
            this.lblProton.AutoSize = true;
            this.lblProton.Location = new System.Drawing.Point(28, 9);
            this.lblProton.Name = "lblProton";
            this.lblProton.Size = new System.Drawing.Size(0, 13);
            this.lblProton.TabIndex = 0;
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
            // QuantiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 679);
            this.Controls.Add(this.pbGoBackToFirstTab);
            this.Controls.Add(this.NeutronPanel);
            this.Controls.Add(this.ProtonPanel);
            this.Controls.Add(this.PhotonPanel);
            this.Controls.Add(this.QuarkPanel);
            this.Controls.Add(this.ElectronPanel);
            this.Controls.Add(this.HiggsBosonPanel);
            this.Controls.Add(this.NeutrinoPanel);
            this.Controls.Add(this.QuantiumFoamPanel);
            this.Controls.Add(this.StringPanel);
            this.Controls.Add(this.lblAtomicEnergyNumber);
            this.Controls.Add(this.AtomicImagePanel);
            this.Controls.Add(this.rbQuick);
            this.Controls.Add(this.rbMAX);
            this.Controls.Add(this.rbX100);
            this.Controls.Add(this.rbX10);
            this.Controls.Add(this.rbX1);
            this.Name = "QuantiumForm";
            this.Text = "QuantiumForm";
            this.StringPanel.ResumeLayout(false);
            this.StringPanel.PerformLayout();
            this.QuantiumFoamPanel.ResumeLayout(false);
            this.QuantiumFoamPanel.PerformLayout();
            this.HiggsBosonPanel.ResumeLayout(false);
            this.HiggsBosonPanel.PerformLayout();
            this.NeutrinoPanel.ResumeLayout(false);
            this.NeutrinoPanel.PerformLayout();
            this.PhotonPanel.ResumeLayout(false);
            this.PhotonPanel.PerformLayout();
            this.ElectronPanel.ResumeLayout(false);
            this.ElectronPanel.PerformLayout();
            this.QuarkPanel.ResumeLayout(false);
            this.QuarkPanel.PerformLayout();
            this.NeutronPanel.ResumeLayout(false);
            this.NeutronPanel.PerformLayout();
            this.ProtonPanel.ResumeLayout(false);
            this.ProtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoBackToFirstTab)).EndInit();
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
        private System.Windows.Forms.Panel AtomicImagePanel;
        private System.Windows.Forms.Panel StringPanel;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Panel QuantiumFoamPanel;
        private System.Windows.Forms.Label lblQuantiumFoam;
        private System.Windows.Forms.Panel HiggsBosonPanel;
        private System.Windows.Forms.Label lblHiggsBoson;
        private System.Windows.Forms.Panel NeutrinoPanel;
        private System.Windows.Forms.Label lblNeutrino;
        private System.Windows.Forms.Panel PhotonPanel;
        private System.Windows.Forms.Label lblPhoton;
        private System.Windows.Forms.Panel ElectronPanel;
        private System.Windows.Forms.Label lblElectron;
        private System.Windows.Forms.Panel QuarkPanel;
        private System.Windows.Forms.Label lbQuark;
        private System.Windows.Forms.Panel NeutronPanel;
        private System.Windows.Forms.Label lblNeutron;
        private System.Windows.Forms.Panel ProtonPanel;
        private System.Windows.Forms.Label lblProton;
        private System.Windows.Forms.Label lblStringProduceEnergy;
        private System.Windows.Forms.Label lblQuantiumFoamProduceEnergy;
        private System.Windows.Forms.Label lblHiggsBosonProduceEnergy;
        private System.Windows.Forms.Label lblNeutrinoProduceEnergy;
        private System.Windows.Forms.Label lblPhotonProduceEnergy;
        private System.Windows.Forms.Label lblElectronProduceEnergy;
        private System.Windows.Forms.Label lblQuarkProduceEnergy;
        private System.Windows.Forms.Label lblNeutronProduceEnergy;
        private System.Windows.Forms.Label lblProtonProduceEnergy;
        private System.Windows.Forms.Label lblQuarks;
        private System.Windows.Forms.Timer timerForEnergyProduce;
        private System.Windows.Forms.PictureBox pbGoBackToFirstTab;
    }
}