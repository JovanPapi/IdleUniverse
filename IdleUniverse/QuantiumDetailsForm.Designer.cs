namespace IdleUniverse
{
    partial class QuantiumDetailsForm
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
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.pbMaterialInformation = new System.Windows.Forms.PictureBox();
            this.lblMaterialName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAtomicEnergyCost = new System.Windows.Forms.Label();
            this.lblTotalEnergyIncome = new System.Windows.Forms.Label();
            this.lblIncreaseIncoming = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblUpgrade = new System.Windows.Forms.Label();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.Controls.Add(this.pbMaterialInformation);
            this.ImagePanel.Controls.Add(this.lblMaterialName);
            this.ImagePanel.Location = new System.Drawing.Point(16, 12);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(190, 190);
            this.ImagePanel.TabIndex = 0;
            // 
            // pbMaterialInformation
            // 
            this.pbMaterialInformation.Location = new System.Drawing.Point(218, 3);
            this.pbMaterialInformation.Name = "pbMaterialInformation";
            this.pbMaterialInformation.Size = new System.Drawing.Size(32, 24);
            this.pbMaterialInformation.TabIndex = 1;
            this.pbMaterialInformation.TabStop = false;
            // 
            // lblMaterialName
            // 
            this.lblMaterialName.AutoSize = true;
            this.lblMaterialName.Location = new System.Drawing.Point(108, 11);
            this.lblMaterialName.Name = "lblMaterialName";
            this.lblMaterialName.Size = new System.Drawing.Size(0, 14);
            this.lblMaterialName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(10, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cost :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(10, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(10, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Increase : ";
            // 
            // lblAtomicEnergyCost
            // 
            this.lblAtomicEnergyCost.AutoSize = true;
            this.lblAtomicEnergyCost.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblAtomicEnergyCost.Location = new System.Drawing.Point(231, 209);
            this.lblAtomicEnergyCost.Name = "lblAtomicEnergyCost";
            this.lblAtomicEnergyCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAtomicEnergyCost.Size = new System.Drawing.Size(0, 14);
            this.lblAtomicEnergyCost.TabIndex = 4;
            // 
            // lblTotalEnergyIncome
            // 
            this.lblTotalEnergyIncome.AutoSize = true;
            this.lblTotalEnergyIncome.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblTotalEnergyIncome.Location = new System.Drawing.Point(231, 252);
            this.lblTotalEnergyIncome.Name = "lblTotalEnergyIncome";
            this.lblTotalEnergyIncome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalEnergyIncome.Size = new System.Drawing.Size(0, 14);
            this.lblTotalEnergyIncome.TabIndex = 5;
            // 
            // lblIncreaseIncoming
            // 
            this.lblIncreaseIncoming.AutoSize = true;
            this.lblIncreaseIncoming.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblIncreaseIncoming.Location = new System.Drawing.Point(231, 294);
            this.lblIncreaseIncoming.Name = "lblIncreaseIncoming";
            this.lblIncreaseIncoming.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblIncreaseIncoming.Size = new System.Drawing.Size(0, 14);
            this.lblIncreaseIncoming.TabIndex = 6;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Arial", 11.5F);
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(13, 338);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(57, 18);
            this.lblClose.TabIndex = 7;
            this.lblClose.Text = "Cancel";
            this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblClose_MouseClick);
            // 
            // lblUpgrade
            // 
            this.lblUpgrade.AutoSize = true;
            this.lblUpgrade.Font = new System.Drawing.Font("Arial", 11.5F);
            this.lblUpgrade.ForeColor = System.Drawing.Color.Green;
            this.lblUpgrade.Location = new System.Drawing.Point(137, 338);
            this.lblUpgrade.Name = "lblUpgrade";
            this.lblUpgrade.Size = new System.Drawing.Size(69, 18);
            this.lblUpgrade.TabIndex = 8;
            this.lblUpgrade.Text = "Upgrade";
            this.lblUpgrade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LblUpgrade_MouseClick);
            // 
            // QuantiumDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 363);
            this.Controls.Add(this.lblUpgrade);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblIncreaseIncoming);
            this.Controls.Add(this.lblTotalEnergyIncome);
            this.Controls.Add(this.lblAtomicEnergyCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImagePanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "QuantiumDetailsForm";
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterialInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAtomicEnergyCost;
        private System.Windows.Forms.Label lblTotalEnergyIncome;
        private System.Windows.Forms.Label lblIncreaseIncoming;
        private System.Windows.Forms.Label lblMaterialName;
        private System.Windows.Forms.PictureBox pbMaterialInformation;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblUpgrade;
    }
}