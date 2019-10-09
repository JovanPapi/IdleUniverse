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
    public partial class FirstTab : Form
    {
        public static List<BlockMaterials> QuantumMaterials = new List<BlockMaterials>();
        public static List<BlockMaterials> NanoMaterials = new List<BlockMaterials>();
        public static List<BlockMaterials> ComplexMaterials = new List<BlockMaterials>();
        public static List<BlockMaterials> BioMaterials = new List<BlockMaterials>();
        private PictureBox pbAtomicEnergyImage;
        private Label lblTotalAtomicEnergy;
        private RadioButton rbQuick;
        private RadioButton rbMAX;
        private RadioButton rbX100;
        private RadioButton rbX10;
        private RadioButton rbX1;
        private Panel QuantumPanel;
        private Panel NanoPanel;
        private Panel ComplexPanel;
        private Timer timerForAtomicEnergyProduce;
        private IContainer components;
        private Panel BioPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public static int totalEnergyProduced;
        private SectionForm sectionForm;
        public enum TypeOfSection { Quantum,Nano,Complex,Bio};
        public FirstTab()
        {
            totalEnergyProduced = 30;  
            InitializeComponent();
            fillQuantumList();
            fillNanoList();
            fillComplexList();
            fillBioList();
            pbAtomicEnergyImage.Image = Resources.AtomicImageForBeauty;
            timerForAtomicEnergyProduce.Start();
        }
        public void fillQuantumList()
        {
            QuantumMaterials.Add(new BlockMaterials(name: "String", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.StringElement));
            QuantumMaterials.Add(new BlockMaterials(name: "Quantum foam", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.QuantumFoam));
            QuantumMaterials.Add(new BlockMaterials(name: "Neutrino", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Neutrino));
            QuantumMaterials.Add(new BlockMaterials(name: "Higgs boson", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.HiggsBoson));
            QuantumMaterials.Add(new BlockMaterials(name: "Photon", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Photon));
            QuantumMaterials.Add(new BlockMaterials(name: "Quark", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Quarks));
            QuantumMaterials.Add(new BlockMaterials(name: "Electron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Electron));
            QuantumMaterials.Add(new BlockMaterials(name: "Neutron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Neutron));
            QuantumMaterials.Add(new BlockMaterials(name: "Proton", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: Resources.Proton));
            for (int i = 0; i < QuantumMaterials.Count; i++)
            {
                QuantumMaterials[i].HelperID = i;
                if (i == 0)
                {
                    QuantumMaterials[i].HowCost = 6 * 3;
                    QuantumMaterials[i].IncreaseProducingEnergy = 2 * 2;
                }
                else
                {
                    QuantumMaterials[i].HowCost = QuantumMaterials[i - 1].HowCost * 3;
                    QuantumMaterials[i].IncreaseProducingEnergy = QuantumMaterials[i - 1].IncreaseProducingEnergy * 2.81;
                }
            }
            QuantumPanel.BackgroundImage = Resources.QuantumPanel;
            QuantumPanel.BackgroundImageLayout = ImageLayout.Center;
        }
        public void fillNanoList()
        {
            NanoMaterials.Add(new BlockMaterials(name: "Positron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Nucleus", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Atom", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Plasma", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Sound wave", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Ion beam", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Isotope", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Hydrogen", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Carbon", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Oxygen", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Iron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            NanoMaterials.Add(new BlockMaterials(name: "Xenon", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            for (int i = 0; i < NanoMaterials.Count; i++)
            {
                NanoMaterials[i].HelperID = i;
                if (i == 0)
                {
                    NanoMaterials[i].HowCost = 6 * 3;
                    NanoMaterials[i].IncreaseProducingEnergy = 2 * 2;
                }
                else
                {
                    NanoMaterials[i].HowCost = NanoMaterials[i - 1].HowCost * 3;
                    NanoMaterials[i].IncreaseProducingEnergy = NanoMaterials[i - 1].IncreaseProducingEnergy * 2.81;
                }
            }
        }
        public void fillComplexList()
        {
            ComplexMaterials.Add(new BlockMaterials(name: "Water", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Salt", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Sand", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Lipid", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Carbohydrate", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Hemoglobin", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Dna", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Protein", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Chromosome", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Cell", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Neuron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            ComplexMaterials.Add(new BlockMaterials(name: "Microorganism", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            for (int i = 0; i < ComplexMaterials.Count; i++)
            {
                ComplexMaterials[i].HelperID = i;
                if (i == 0)
                {
                    ComplexMaterials[i].HowCost = 6 * 3;
                    ComplexMaterials[i].IncreaseProducingEnergy = 2 * 2;
                }
                else
                {
                    ComplexMaterials[i].HowCost = ComplexMaterials[i - 1].HowCost * 3;
                    ComplexMaterials[i].IncreaseProducingEnergy = ComplexMaterials[i - 1].IncreaseProducingEnergy * 2.81;
                }
            }

        }
        public void fillBioList()
        {
            BioMaterials.Add(new BlockMaterials(name: "Water", boughtTimes: 0,
               incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Salt", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Sand", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Lipid", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Carbohydrate", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Hemoglobin", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Dna", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Protein", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Chromosome", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Cell", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Neuron", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Microorganism", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Microorganism", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Microorganism", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            BioMaterials.Add(new BlockMaterials(name: "Microorganism", boughtTimes: 0,
                incomingEnergy: 0, howCost: 0, increaseIncomingEnergy: 0, totalEnergy: 0, materialImage: null));
            for (int i = 0; i < BioMaterials.Count; i++)
            {
                BioMaterials[i].HelperID = i;
                if (i == 0)
                {
                    BioMaterials[i].HowCost = 6 * 3;
                    BioMaterials[i].IncreaseProducingEnergy = 2 * 2;
                }

                else
                {
                    BioMaterials[i].HowCost = BioMaterials[i - 1].HowCost * 3;
                    BioMaterials[i].IncreaseProducingEnergy = BioMaterials[i - 1].IncreaseProducingEnergy * 2.81;
                }


            }


        }
        private void QuantumPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sectionForm = new SectionForm(QuantumMaterials,TypeOfSection.Quantum);
                this.Opacity = 0;
                if (sectionForm.ShowDialog() == DialogResult.Cancel)
                    this.Opacity = 100;
                
            }
        }
        private void NanoPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sectionForm = new SectionForm(NanoMaterials,TypeOfSection.Nano);
                this.Opacity = 0;
                if (sectionForm.ShowDialog() == DialogResult.Cancel)
                    this.Opacity = 100;
            }
        }

        private void ComplexPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sectionForm = new SectionForm(ComplexMaterials,TypeOfSection.Complex);
                if (sectionForm.ShowDialog() == DialogResult.OK)
                    sectionForm.Close();
                else
                    sectionForm.Close();
            }
        }

        private void BioPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                sectionForm = new SectionForm(BioMaterials,TypeOfSection.Bio);
                if (sectionForm.ShowDialog() == DialogResult.OK)
                    sectionForm.Close();
                else
                    sectionForm.Close();
            }
        }

        private void TimerForAtomicEnergyProduce_Tick(object sender, EventArgs e)
        {
            foreach (var item in QuantumMaterials)
                totalEnergyProduced += item.CurrentProducingEnergy;
            lblTotalAtomicEnergy.Text = totalEnergyProduced.ToString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbAtomicEnergyImage = new System.Windows.Forms.PictureBox();
            this.lblTotalAtomicEnergy = new System.Windows.Forms.Label();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbMAX = new System.Windows.Forms.RadioButton();
            this.rbX100 = new System.Windows.Forms.RadioButton();
            this.rbX10 = new System.Windows.Forms.RadioButton();
            this.rbX1 = new System.Windows.Forms.RadioButton();
            this.QuantumPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NanoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ComplexPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.timerForAtomicEnergyProduce = new System.Windows.Forms.Timer(this.components);
            this.BioPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtomicEnergyImage)).BeginInit();
            this.QuantumPanel.SuspendLayout();
            this.NanoPanel.SuspendLayout();
            this.ComplexPanel.SuspendLayout();
            this.BioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbAtomicEnergyImage
            // 
            this.pbAtomicEnergyImage.Location = new System.Drawing.Point(13, 13);
            this.pbAtomicEnergyImage.Name = "pbAtomicEnergyImage";
            this.pbAtomicEnergyImage.Size = new System.Drawing.Size(23, 22);
            this.pbAtomicEnergyImage.TabIndex = 0;
            this.pbAtomicEnergyImage.TabStop = false;
            // 
            // lblTotalAtomicEnergy
            // 
            this.lblTotalAtomicEnergy.AutoSize = true;
            this.lblTotalAtomicEnergy.Location = new System.Drawing.Point(43, 18);
            this.lblTotalAtomicEnergy.Name = "lblTotalAtomicEnergy";
            this.lblTotalAtomicEnergy.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAtomicEnergy.TabIndex = 1;
            this.lblTotalAtomicEnergy.Text = "0";
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Font = new System.Drawing.Font("Arial", 11F);
            this.rbQuick.Location = new System.Drawing.Point(239, 78);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(64, 21);
            this.rbQuick.TabIndex = 16;
            this.rbQuick.TabStop = true;
            this.rbQuick.Text = "Quick";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbMAX
            // 
            this.rbMAX.AutoSize = true;
            this.rbMAX.Font = new System.Drawing.Font("Arial", 11F);
            this.rbMAX.Location = new System.Drawing.Point(176, 78);
            this.rbMAX.Name = "rbMAX";
            this.rbMAX.Size = new System.Drawing.Size(55, 21);
            this.rbMAX.TabIndex = 15;
            this.rbMAX.TabStop = true;
            this.rbMAX.Text = "MAX";
            this.rbMAX.UseVisualStyleBackColor = true;
            // 
            // rbX100
            // 
            this.rbX100.AutoSize = true;
            this.rbX100.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX100.Location = new System.Drawing.Point(113, 78);
            this.rbX100.Name = "rbX100";
            this.rbX100.Size = new System.Drawing.Size(57, 21);
            this.rbX100.TabIndex = 14;
            this.rbX100.TabStop = true;
            this.rbX100.Text = "x100";
            this.rbX100.UseVisualStyleBackColor = true;
            // 
            // rbX10
            // 
            this.rbX10.AutoSize = true;
            this.rbX10.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX10.Location = new System.Drawing.Point(58, 78);
            this.rbX10.Name = "rbX10";
            this.rbX10.Size = new System.Drawing.Size(49, 21);
            this.rbX10.TabIndex = 13;
            this.rbX10.TabStop = true;
            this.rbX10.Text = "x10";
            this.rbX10.UseVisualStyleBackColor = true;
            // 
            // rbX1
            // 
            this.rbX1.AutoSize = true;
            this.rbX1.Font = new System.Drawing.Font("Arial", 11F);
            this.rbX1.Location = new System.Drawing.Point(11, 78);
            this.rbX1.Name = "rbX1";
            this.rbX1.Size = new System.Drawing.Size(41, 21);
            this.rbX1.TabIndex = 12;
            this.rbX1.TabStop = true;
            this.rbX1.Text = "x1";
            this.rbX1.UseVisualStyleBackColor = true;
            // 
            // QuantumPanel
            // 
            this.QuantumPanel.Controls.Add(this.label1);
            this.QuantumPanel.Location = new System.Drawing.Point(11, 106);
            this.QuantumPanel.Name = "QuantumPanel";
            this.QuantumPanel.Size = new System.Drawing.Size(128, 128);
            this.QuantumPanel.TabIndex = 17;
            this.QuantumPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuantumPanel_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantum";
            // 
            // NanoPanel
            // 
            this.NanoPanel.Controls.Add(this.label2);
            this.NanoPanel.Location = new System.Drawing.Point(145, 105);
            this.NanoPanel.Name = "NanoPanel";
            this.NanoPanel.Size = new System.Drawing.Size(128, 128);
            this.NanoPanel.TabIndex = 18;
            this.NanoPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NanoPanel_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(44, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nano";
            // 
            // ComplexPanel
            // 
            this.ComplexPanel.Controls.Add(this.label3);
            this.ComplexPanel.Location = new System.Drawing.Point(279, 106);
            this.ComplexPanel.Name = "ComplexPanel";
            this.ComplexPanel.Size = new System.Drawing.Size(128, 128);
            this.ComplexPanel.TabIndex = 18;
            this.ComplexPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComplexPanel_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Complex";
            // 
            // timerForAtomicEnergyProduce
            // 
            this.timerForAtomicEnergyProduce.Enabled = true;
            this.timerForAtomicEnergyProduce.Interval = 1000;
            this.timerForAtomicEnergyProduce.Tick += new System.EventHandler(this.TimerForAtomicEnergyProduce_Tick);
            // 
            // BioPanel
            // 
            this.BioPanel.Controls.Add(this.label4);
            this.BioPanel.Location = new System.Drawing.Point(12, 240);
            this.BioPanel.Name = "BioPanel";
            this.BioPanel.Size = new System.Drawing.Size(128, 128);
            this.BioPanel.TabIndex = 18;
            this.BioPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BioPanel_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(47, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bio";
            // 
            // FirstTab
            // 
            this.ClientSize = new System.Drawing.Size(420, 550);
            this.Controls.Add(this.BioPanel);
            this.Controls.Add(this.ComplexPanel);
            this.Controls.Add(this.NanoPanel);
            this.Controls.Add(this.QuantumPanel);
            this.Controls.Add(this.rbQuick);
            this.Controls.Add(this.rbMAX);
            this.Controls.Add(this.rbX100);
            this.Controls.Add(this.rbX10);
            this.Controls.Add(this.rbX1);
            this.Controls.Add(this.lblTotalAtomicEnergy);
            this.Controls.Add(this.pbAtomicEnergyImage);
            this.Name = "FirstTab";
            this.Text = "MenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbAtomicEnergyImage)).EndInit();
            this.QuantumPanel.ResumeLayout(false);
            this.QuantumPanel.PerformLayout();
            this.NanoPanel.ResumeLayout(false);
            this.NanoPanel.PerformLayout();
            this.ComplexPanel.ResumeLayout(false);
            this.ComplexPanel.PerformLayout();
            this.BioPanel.ResumeLayout(false);
            this.BioPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}

