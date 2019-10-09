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
    public partial class SectionForm : Form
    {
        public static int multiplyNumber;
        public static string clickedMaterial;
        private enum TypeOfSection { Quantum,Nano,Complex,Bio }
        private List<BlockMaterials> SectionMaterials = new List<BlockMaterials>();
        private BlockMaterials AuxilaryObject;
        private List<Panel> panels;
        private string whichPanel = null;
        public SectionForm(List<BlockMaterials> list,Enum Type)
        {
            InitializeComponent();
            SectionMaterials = list;
            multiplyNumber = 1;
            clickedMaterial = "";
            lblAtomicEnergyNumber.Text = FirstTab.totalEnergyProduced.ToString();
            timerForEnergyProduce.Start();
            AuxilaryObject = null;
            pbAtomicEnergyPictureNumber.Image = Resources.AtomicImageForBeauty;
            pbAtomicEnergyPictureNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Type.ToString() == TypeOfSection.Quantum.ToString()){
                FillQuantumImages();
            }
            /*if (Type.Equals(TypeOfSection.Nano)) {
                FillNanoImages();
            }
            if (Type.Equals(TypeOfSection.Nano)){
                FillComplexImages();
            }
            if (Type.Equals(TypeOfSection.Nano)) {
                FillBioImages();
            }*/
            FillLabelNames();
            UpdateEnergyShowingLabels();
            FillPanelList();
            FillPanelNames();

        }
        public void FillQuantumImages()
        {
            AuxilaryObject = new BlockMaterials().FindMaterial("String", SectionMaterials);
            Panel1.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel1.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Quantum foam", SectionMaterials);
            Panel2.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel2.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Neutrino", SectionMaterials);
            Panel3.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel3.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Higgs boson", SectionMaterials);
            Panel4.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel4.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Photon", SectionMaterials);
            Panel5.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel5.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Quark", SectionMaterials);
            Panel6.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel6.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Electron", SectionMaterials);
            Panel7.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel7.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Neutron", SectionMaterials);
            Panel8.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel8.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Proton", SectionMaterials);
            Panel9.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel9.BackgroundImageLayout = ImageLayout.Center;

            pbGoBackToFirstTab.Image = Resources.BackPicture;
            pbGoBackToFirstTab.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void FillLabelNames()
        {
            lblElectron.Text = new BlockMaterials().FindNameForLabel("Electron", FirstTab.QuantumMaterials.ToList());
            lblHiggsBoson.Text = new BlockMaterials().FindNameForLabel("Higgs boson", FirstTab.QuantumMaterials.ToList());
            lblNeutrino.Text = new BlockMaterials().FindNameForLabel("Neutrino", FirstTab.QuantumMaterials.ToList());
            lblNeutron.Text = new BlockMaterials().FindNameForLabel("Neutron", FirstTab.QuantumMaterials.ToList());
            lblPhoton.Text = new BlockMaterials().FindNameForLabel("Proton", FirstTab.QuantumMaterials.ToList());
            lblProton.Text = new BlockMaterials().FindNameForLabel("Photon", FirstTab.QuantumMaterials.ToList());
            lblQuantiumFoam.Text = new BlockMaterials().FindNameForLabel("Quantium foam", FirstTab.QuantumMaterials.ToList());
            lblString.Text = new BlockMaterials().FindNameForLabel("String", FirstTab.QuantumMaterials.ToList());
            lblQuarks.Text = new BlockMaterials().FindNameForLabel("Quark", FirstTab.QuantumMaterials.ToList());

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
        private void FillPanelNames()
        {
            Panel1.Name = SectionMaterials.ElementAt(0).Name;
            Panel2.Name = SectionMaterials.ElementAt(1).Name;
            Panel3.Name = SectionMaterials.ElementAt(2).Name;
            Panel4.Name = SectionMaterials.ElementAt(3).Name;
            Panel5.Name = SectionMaterials.ElementAt(4).Name;
            Panel6.Name = SectionMaterials.ElementAt(5).Name;
            Panel7.Name = SectionMaterials.ElementAt(6).Name;
            Panel8.Name = SectionMaterials.ElementAt(7).Name;
            Panel9.Name = SectionMaterials.ElementAt(8).Name;
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
        private void UpdateEnergyShowingLabels()
        {
            int i = 0;
            lblStringProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblQuantiumFoamProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblNeutrinoProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblHiggsBosonProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblPhotonProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblQuarkProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblElectronProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblNeutronProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
            lblProtonProduceEnergy.Text = FirstTab.QuantumMaterials.ElementAt(i++).CurrentProducingEnergy.ToString() + "/s";
        }
        private void FillPanelList()
        {
            panels = new List<Panel>();
            panels.Add(Panel1);
            panels.Add(Panel2);
            panels.Add(Panel3);
            panels.Add(Panel4);
            panels.Add(Panel5);
            panels.Add(Panel6);
            panels.Add(Panel7);
            panels.Add(Panel8);
            panels.Add(Panel9);

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
        private void ClickedPanel(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var panel = sender as Panel;
                int i = 0;
                while (i != 15)
                {
                    if (panel.Name.Equals(SectionMaterials.ElementAt(i).Name))
                    {
                        whichPanel = panel.Name;
                        break;
                    }
                    i++;
                }
                if(whichPanel != "" && whichPanel != null)
                {
                    clickedMaterial = whichPanel;
                    MaterialDetailsForm form = new MaterialDetailsForm(SectionMaterials, clickedMaterial);
                    if (form.ShowDialog() == DialogResult.OK)
                        form.Close();
                    else
                        form.Close();
                }
                UpdateEnergyShowingLabels();
            }
        }
    }
}
