using IdleUniverse.Properties;
using System;
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
    public partial class QuantiumForm : Form
    {
        public static int multiplyNumber;
        public static string clickedMaterial;
        public QuantiumForm()
        {
            InitializeComponent();
            multiplyNumber = 1;
            clickedMaterial = "";
            lblAtomicEnergyNumber.Text = FirstTab.totalEnergyProduced.ToString();
            timerForEnergyProduce.Start();
            FillLabelNames();
            UpdateEnergyShowingLabels();
            FillImages();

            AtomicImagePanel.BackgroundImage = Resources.AtomicImageForBeauty;
        }
        public void FillImages()
        {
            StringPanel.BackgroundImage = Resources.StringElement;
            StringPanel.BackgroundImageLayout = ImageLayout.Center;

            QuantiumFoamPanel.BackgroundImage = Resources.QuantumFoam;
            QuantiumFoamPanel.BackgroundImageLayout = ImageLayout.Center;

            NeutrinoPanel.BackgroundImage = Resources.Neutrino;
            NeutrinoPanel.BackgroundImageLayout = ImageLayout.Center;

            HiggsBosonPanel.BackgroundImage = Resources.HiggsBoson;
            HiggsBosonPanel.BackgroundImageLayout = ImageLayout.Center;

            PhotonPanel.BackgroundImage = Resources.Photon;
            PhotonPanel.BackgroundImageLayout = ImageLayout.Center;

            QuarkPanel.BackgroundImage = Resources.Quarks;
            QuarkPanel.BackgroundImageLayout = ImageLayout.Center;

            ElectronPanel.BackgroundImage = Resources.Electron;
            ElectronPanel.BackgroundImageLayout = ImageLayout.Center;

            NeutronPanel.BackgroundImage = Resources.Neutron;
            NeutronPanel.BackgroundImageLayout = ImageLayout.Center;

            ProtonPanel.BackgroundImage = Resources.Proton;
            ProtonPanel.BackgroundImageLayout = ImageLayout.Center;

            pbGoBackToFirstTab.Image = Resources.BackPicture;
            pbGoBackToFirstTab.BackgroundImageLayout = ImageLayout.Center;
        }
        public void FillLabelNames()
        {
            lblElectron.Text = new BlockMaterials().FindNameForLabel("Electron", FirstTab.QuantiumMaterials.ToList());
            lblHiggsBoson.Text = new BlockMaterials().FindNameForLabel("Higgs boson", FirstTab.QuantiumMaterials.ToList());
            lblNeutrino.Text = new BlockMaterials().FindNameForLabel("Neutrino", FirstTab.QuantiumMaterials.ToList());
            lblNeutron.Text = new BlockMaterials().FindNameForLabel("Neutron", FirstTab.QuantiumMaterials.ToList());
            lblPhoton.Text = new BlockMaterials().FindNameForLabel("Proton", FirstTab.QuantiumMaterials.ToList());
            lblProton.Text = new BlockMaterials().FindNameForLabel("Photon", FirstTab.QuantiumMaterials.ToList());
            lblQuantiumFoam.Text = new BlockMaterials().FindNameForLabel("Quantium foam", FirstTab.QuantiumMaterials.ToList());
            lblString.Text = new BlockMaterials().FindNameForLabel("String", FirstTab.QuantiumMaterials.ToList());
            lblQuarks.Text = new BlockMaterials().FindNameForLabel("Quark", FirstTab.QuantiumMaterials.ToList());

            lblElectron.Left = 70;
            lblHiggsBoson.Left = 70;
            lblNeutrino.Left = 70;
            lblNeutron.Left = 70;
            lblPhoton.Left = 70;
            lblProton.Left = 70;
            lblQuantiumFoam.Left = 60;
            lblString.Left = 70;

            lblElectron.BackColor = Color.Transparent;
            lblHiggsBoson.BackColor = Color.Transparent;
            lblNeutrino.BackColor = Color.Transparent;
            lblNeutron.BackColor = Color.Transparent;
            lblPhoton.BackColor = Color.Transparent;
            lblProton.BackColor = Color.Transparent;
            lblQuantiumFoam.BackColor = Color.Transparent;
            lblString.BackColor = Color.Transparent;
            lblQuarks.BackColor = Color.Transparent;

            lblElectron.ForeColor = Color.Red;
            lblHiggsBoson.ForeColor = Color.Red;
            lblNeutrino.ForeColor = Color.Red;
            lblNeutron.ForeColor = Color.Red;
            lblPhoton.ForeColor = Color.Red;
            lblProton.ForeColor = Color.Red;
            lblQuantiumFoam.ForeColor = Color.Red;
            lblString.ForeColor = Color.Red;
            lblQuarks.ForeColor = Color.Red;
        }
        private void RadioButtonClick(object sender, EventArgs e)
        {
            if (rbX1.Checked)
                multiplyNumber = 1;
            if (rbX10.Checked)
                multiplyNumber = 10;
            if (rbX100.Checked)
                multiplyNumber = 100;
        }
        public void UpdateEnergyShowingLabels()
        {
            int i = 0;
            lblStringProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblQuantiumFoamProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblNeutrinoProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblHiggsBosonProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblPhotonProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblQuarkProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblElectronProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblNeutronProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblProtonProduceEnergy.Text = FirstTab.QuantiumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
        }
        public void ShowNewForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                QuantiumDetailsForm form = new QuantiumDetailsForm();
                if (form.ShowDialog() == DialogResult.OK)
                    form.Close();
                else
                    form.Close();
            }
            UpdateEnergyShowingLabels();
        }
        private void StringPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "String";
            ShowNewForm(e);
        }

        private void QuantiumFoamPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Quantium foam";
            ShowNewForm(e);
        }

        private void NeutrinoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Neutrino";
            ShowNewForm(e);
        }

        private void HiggsBosonPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Higgs boson";
            ShowNewForm(e);
        }

        private void PhotonPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Photon";
            ShowNewForm(e);
        }

        private void QuarkPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Quark";
            ShowNewForm(e);
        }

        private void ElectronPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Electron";
            ShowNewForm(e);
        }

        private void NeutronPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Neutron";
            ShowNewForm(e);
        }

        private void ProtonPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickedMaterial = "Proton";
            ShowNewForm(e);
        }

        private void TimerForEnergyProduce_Tick(object sender, EventArgs e)
        {
            lblAtomicEnergyNumber.Text = FirstTab.totalEnergyProduced.ToString();
        }

        private void PbGoBackToFirstTab_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            
        }
    }
}
