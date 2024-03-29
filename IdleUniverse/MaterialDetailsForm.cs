﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleUniverse
{
    public partial class MaterialDetailsForm : Form
    {
        private BlockMaterials material;
        private List<BlockMaterials> materials = new List<BlockMaterials>();
        public MaterialDetailsForm(List<BlockMaterials> list,string clickedMaterial)
        {
            InitializeComponent();            
            material = new BlockMaterials().FindMaterial(clickedMaterial,list);
            materials = list;
            SetInitialLabels();
            
        }
        public void SetInitialLabels()
        {
            lblIncreaseIncoming.RightToLeft = 0;
            lblTotalEnergyIncome.RightToLeft = 0;
            lblAtomicEnergyCost.RightToLeft = 0;

            lblMaterialName.Left = 60;

            lblAtomicEnergyCost.Font = new Font("Arial", 11);
            lblTotalEnergyIncome.Font = new Font("Arial", 11);
            lblIncreaseIncoming.Font = new Font("Arial", 11);
            lblMaterialName.Font = new Font("Arial", 9);
            lblMaterialName.TextAlign = ContentAlignment.MiddleCenter;

            lblIncreaseIncoming.Text = string.Format("{0:#,0}",(material.IncreaseProducingEnergy)) + "/s";
            lblTotalEnergyIncome.Text = string.Format("{0:#,0}", ((long)material.IncreaseProducingEnergy + material.CurrentProducingEnergy)) + "/s";
            lblAtomicEnergyCost.Text = string.Format("{0:#,0}", material.HowCost) + "/s";
            lblMaterialName.Text = material.Name + "\n   " + material.BoughtTimes;
            lblMaterialName.BackColor = Color.Transparent;
            lblMaterialName.ForeColor = Color.Red;
            ImagePanel.BackgroundImage = material.MaterialImage;
            ImagePanel.BackgroundImageLayout = ImageLayout.Center;

            lblIncreaseIncoming.RightToLeft = RightToLeft.Inherit;
            lblTotalEnergyIncome.RightToLeft = RightToLeft.Inherit;
            lblAtomicEnergyCost.RightToLeft = RightToLeft.Inherit;
        }
        private void LblClose_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void LblUpgrade_MouseClick(object sender, MouseEventArgs e) 
        {
            if(e.Button == MouseButtons.Left)
            {
                if (material.CheckBeforeBuy(FirstTab.totalEnergyProduced))
                {
                    FirstTab.totalEnergyProduced -= (int)material.HowCost;
                    materials.ElementAt(material.HelperID).
                        UpgradeMaterial(SectionForm.multiplyNumber);
                    UpdateLabels(materials.ElementAt(material.HelperID));
                }
            }
        }

        public void UpdateLabels(BlockMaterials blockMaterial)
        {
            lblIncreaseIncoming.Text = string.Format("{0:#,0}", ((int)blockMaterial.IncreaseProducingEnergy)) + "/s";
            lblTotalEnergyIncome.Text = string.Format("{0:#,0}", blockMaterial.TotalEnergy) + "/s";
            lblAtomicEnergyCost.Text = string.Format("{0:#,0}", blockMaterial.HowCost) + "/s";
            lblMaterialName.Text = material.Name + "\n" + material.BoughtTimes;
        }
    }
}
