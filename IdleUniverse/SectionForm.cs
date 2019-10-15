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
        private enum TypeOfSection { Quantum,Nano,Complex,Bio }
        private List<BlockMaterials> SectionMaterials = new List<BlockMaterials>();
        private BlockMaterials AuxilaryObject;
        private SectionForm sectionForm;
        public SectionForm(List<BlockMaterials> list,Enum Type)
        {
            InitializeComponent();
            SectionMaterials = list;
            multiplyNumber = 1;
            lblAtomicEnergyNumber.Text = string.Format("{0:#,0}", FirstTab.totalEnergyProduced);
            timerForEnergyProduce.Start();
            AuxilaryObject = null;
            pbAtomicEnergyPictureNumber.Image = Resources.AtomicImageForBeauty;
            pbAtomicEnergyPictureNumber.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGoBackToFirstTab.Image = Resources.BackPicture;
            pbGoBackToFirstTab.SizeMode = PictureBoxSizeMode.StretchImage;

            if (Type.ToString() == TypeOfSection.Quantum.ToString()){
                FillQuantumImages();
                this.AutoScroll = false;
            }
            if (Type.ToString() == TypeOfSection.Nano.ToString()) {
                FillNanoImages();
                this.AutoScroll = true;
            }
            if (Type.ToString() == TypeOfSection.Complex.ToString()){
                FillComplexImages();
                this.AutoScroll = true;
            }
            /*if (Type.Equals(TypeOfSection.Nano)) {
                FillBioImages();
            }*/
            FillLabelNames();
            UpdateEnergyShowingLabels();
            FillPanelNames();

        }
        private void FillQuantumImages()
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

        }
        private void FillNanoImages()
        {
            AuxilaryObject = new BlockMaterials().FindMaterial("Positron", SectionMaterials);
            Panel1.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel1.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Nucleus", SectionMaterials);
            Panel2.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel2.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Atom", SectionMaterials);
            Panel3.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel3.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Plasma", SectionMaterials);
            Panel4.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel4.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Sound wave", SectionMaterials);
            Panel5.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel5.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Ion beam", SectionMaterials);
            Panel6.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel6.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Isotope", SectionMaterials);
            Panel7.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel7.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Hydrogen", SectionMaterials);
            Panel8.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel8.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Carbon", SectionMaterials);
            Panel9.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel9.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Oxygen", SectionMaterials);
            Panel10.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel10.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Iron", SectionMaterials);
            Panel11.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel11.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Xenon", SectionMaterials);
            Panel12.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel12.BackgroundImageLayout = ImageLayout.Center;

            Panel10.Name = SectionMaterials.ElementAt(9).Name;
            Panel11.Name = SectionMaterials.ElementAt(10).Name;
            Panel12.Name = SectionMaterials.ElementAt(11).Name;
        }
        private void FillComplexImages()
        {
            AuxilaryObject = new BlockMaterials().FindMaterial("Water", SectionMaterials);
            Panel1.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel1.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Salt", SectionMaterials);
            Panel2.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel2.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Sand", SectionMaterials);
            Panel3.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel3.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Lipid", SectionMaterials);
            Panel4.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel4.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Carbohydrate", SectionMaterials);
            Panel5.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel5.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Hemoglobin", SectionMaterials);
            Panel6.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel6.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Dna", SectionMaterials);
            Panel7.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel7.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Protein", SectionMaterials);
            Panel8.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel8.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Chromosome", SectionMaterials);
            Panel9.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel9.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Cell", SectionMaterials);
            Panel10.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel10.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Neuron", SectionMaterials);
            Panel11.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel11.BackgroundImageLayout = ImageLayout.Center;

            AuxilaryObject = new BlockMaterials().FindMaterial("Microorganism", SectionMaterials);
            Panel12.BackgroundImage = AuxilaryObject.MaterialImage;
            Panel12.BackgroundImageLayout = ImageLayout.Center;

            Panel10.Name = SectionMaterials.ElementAt(9).Name;
            Panel11.Name = SectionMaterials.ElementAt(10).Name;
            Panel12.Name = SectionMaterials.ElementAt(11).Name;

        }
        private void FillLabelNames()
        {
            lbl1.Text = SectionMaterials.ElementAt(0).Name;
            lbl2.Text = SectionMaterials.ElementAt(1).Name;
            lbl3.Text = SectionMaterials.ElementAt(2).Name;
            lbl4.Text = SectionMaterials.ElementAt(3).Name;
            lbl5.Text = SectionMaterials.ElementAt(4).Name;
            lbl6.Text = SectionMaterials.ElementAt(5).Name;
            lbl7.Text = SectionMaterials.ElementAt(6).Name;
            lbl8.Text = SectionMaterials.ElementAt(7).Name;
            lbl9.Text = SectionMaterials.ElementAt(8).Name;

            lbl1.Left = lbl2.Left = lbl3.Left = lbl4.Left = lbl5.Left = lbl6.Left =
                lbl7.Left = lbl8.Left = lbl9.Left = lbl10.Left = lbl11.Left = lbl12.Left = 70;

            lbl1.BackColor = lbl2.BackColor = lbl3.BackColor = lbl4.BackColor = lbl5.BackColor = lbl6.BackColor =
                lbl7.BackColor = lbl8.BackColor = lbl9.BackColor = lbl10.BackColor =
                lbl11.BackColor = lbl12.BackColor = Color.Transparent;

            lbl1.ForeColor = lbl2.ForeColor = lbl3.ForeColor = lbl4.ForeColor = lbl5.ForeColor = lbl6.ForeColor =
                lbl7.ForeColor = lbl8.ForeColor = lbl9.ForeColor = lbl10.BackColor =
                lbl11.BackColor = lbl12.BackColor = Color.Red;
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
            lbl1.Text = string.Format("{0:#,0}",SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl2.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl3.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl4.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl5.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl6.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl7.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl8.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            lbl9.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            if (SectionMaterials.Count >= 10)
            {
                lbl10.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
                lbl11.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
                lbl12.Text = string.Format("{0:#,0}", SectionMaterials.ElementAt(i++).CurrentProducingEnergy) + "/s";
            }
        }
        private void TimerForEnergyProduce_Tick(object sender, EventArgs e)
        {
            lblAtomicEnergyNumber.Text = string.Format("{0:#,0}",FirstTab.totalEnergyProduced);
        }

        private void PbGoBackToFirstTab_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            
        }
        private void ClickedMaterialPanel(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var panelMaterial = sender as Panel;
                if(panelMaterial != null)
                {
                    MaterialDetailsForm form = new MaterialDetailsForm(SectionMaterials, panelMaterial.Name);
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
