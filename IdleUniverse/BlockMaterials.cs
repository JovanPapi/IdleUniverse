using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleUniverse
{
    [Serializable]
    public class BlockMaterials
    {
        public int HelperID { get; set; }
        public string Name { get; set; }
        public int BoughtTimes { get; set; }
        public long CurrentProducingEnergy { get; set; }
        public long HowCost { get; set; }
        public long IncreaseProducingEnergy { get; set; }
        public long TotalEnergy { get; set; }
        public Image MaterialImage { get; set; }
        public int TotalNumberUpgrade { get; set; }
        public int CheckForDoubleIncome { get; set; }
        public string InfoText { get; set; }

        public BlockMaterials(string name, int boughtTimes, int incomingEnergy, int howCost, int increaseIncomingEnergy, int totalEnergy, Image materialImage)
        {
            HelperID = 0;
            Name = name;
            BoughtTimes = boughtTimes;
            CurrentProducingEnergy = incomingEnergy;
            HowCost = howCost;
            IncreaseProducingEnergy = increaseIncomingEnergy;
            TotalEnergy = totalEnergy;
            MaterialImage = materialImage;
            CheckForDoubleIncome = 25;
            this.InfoText = "";
        }
        public BlockMaterials() { }
        public String FindNameForLabel(String labelName,List<BlockMaterials> someList)
        {
            foreach(var item in someList)
            {
                if(labelName.Equals(item.Name))
                {
                    return item.Name;
                }
            }
            return null;
        }
        public BlockMaterials FindMaterial(String materialName,List<BlockMaterials> someList)
        {
            foreach(var item in someList)
            {
                if (materialName.Equals(item.Name))
                    return item;
            }
            return null;
        }

        public void UpgradeMaterial(int multiplyNumber)
        {
            if(multiplyNumber == 1)
            {
                BoughtTimes++;
                double temp = HowCost + (HowCost / 10);
                HowCost = (long)Math.Round(temp);
                if (BoughtTimes == CheckForDoubleIncome - 1)
                {
                    CheckForDoubleIncome += 25;
                    IncreaseProducingEnergy *= (long)25.92;
                }
                else if (BoughtTimes == (CheckForDoubleIncome - 25))
                {
                    IncreaseProducingEnergy = (long)(IncreaseProducingEnergy / 25.92);
                    IncreaseProducingEnergy *= 2;
                }
                CurrentProducingEnergy += IncreaseProducingEnergy;
                TotalEnergy = (CurrentProducingEnergy + IncreaseProducingEnergy);
            }
            else if(multiplyNumber == 10)
            {
                BoughtTimes += 10;
                double temp = HowCost * 2.59;
                HowCost = (int)Math.Round(temp);
                if (BoughtTimes == CheckForDoubleIncome - 1)
                {
                    CheckForDoubleIncome += 25;
                    IncreaseProducingEnergy *= (long)1.69;
                }
                else if (BoughtTimes == (CheckForDoubleIncome - 25))
                {
                    IncreaseProducingEnergy = (long)(IncreaseProducingEnergy / 1.69);
                    IncreaseProducingEnergy *= 2;
                }
                CurrentProducingEnergy += IncreaseProducingEnergy;
                TotalEnergy = (CurrentProducingEnergy + IncreaseProducingEnergy);
            }
            /*else if(multiplyNumber == 100)
            {
                BoughtTimes += 100;
                double temp = HowCost + (HowCost / 10);
                HowCost = (int)Math.Round(temp);
                {
                    IncreaseProducingEnergy = IncreaseProducingEnergy / 1.69;
                    IncreaseProducingEnergy *= 2;
                }
            }*/
        }
        public bool CheckBeforeBuy(long totalProducedEnergy)
        {
            return totalProducedEnergy > this.HowCost;
        }
    }
}
