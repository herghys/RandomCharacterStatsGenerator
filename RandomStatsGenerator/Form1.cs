using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomStatsGenerator
{
	public partial class Form1 : Form
	{
		Random random = new Random();
		const int maxValue = 100;
		int sisa;

		float total, power;

		//float health, attack, defense, agility, accuracy, resistance, critChance, critDamage;
		//double healthP, attackP, defenseP, agilityP, accuracyP, resistanceP, critChanceP, critDamageP;

		float[] statsList= new float[8];
		double[] statsPList = new double[8];
		bool[] unlocked = new bool[8];

		public Form1()
		{
			InitializeComponent();
		}

		private void LockCheckBoxChanged(object sender, EventArgs e)
		{
			nmcHealth.Enabled =	!checkHealth.Checked;
			nmcAttack.Enabled =	!checkAttack.Checked;
			nmcDefense.Enabled =!checkDefense.Checked;
			nmcAgility.Enabled =!checkAgility.Checked;
			nmcAccuracy.Enabled =!checkAccuracy.Checked;
			nmcResistance.Enabled = !checkResistance.Checked;
			nmcCritChance.Enabled = !checkCritChance.Checked;
			nmcCritDamage.Enabled = !checkCritDamage.Checked;


			unlocked[0] =checkHealth.Checked;
			unlocked[1] =checkAttack.Checked;
			unlocked[2] =checkDefense.Checked;
			unlocked[3] =checkAgility.Checked;
			unlocked[4] =checkAccuracy.Checked;
			unlocked[5] =checkResistance.Checked;
			unlocked[6] =checkCritChance.Checked;
			unlocked[7] =checkCritDamage.Checked;
		}

		private void OnNumericValueChanged(object sender, EventArgs e)
		{
			CalculateNew();
		}

		private void buttonRandomize_Click(object sender, EventArgs e)
		{
			CalculateRandom();
		}

		public double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
		{
			var rDouble = random.NextDouble();
			var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
			return( rRangeDouble);
		}
		private void CalculateRandom()
		{
			if (!unlocked[0])
				statsPList[0]= GetPseudoDoubleWithinRange(0.1, 0.35f);

			if (!unlocked[1])
				statsPList[1]= GetPseudoDoubleWithinRange(0.01, 0.15f);

			if (!unlocked[2])
				statsPList[2]= GetPseudoDoubleWithinRange(0.01, 0.15f);

			if (!unlocked[3])
				statsPList[3]= GetPseudoDoubleWithinRange(0.01, 0.10f);

			if (!unlocked[4])
				statsPList[4]= GetPseudoDoubleWithinRange(0.01, 0.05f);

			if (!unlocked[5])
				statsPList[5] = GetPseudoDoubleWithinRange(0.025, 0.10f);

			if (!unlocked[6])
				statsPList[6] = GetPseudoDoubleWithinRange(0.01, 0.05f);

			if (!unlocked[7])
				statsPList[7] = GetPseudoDoubleWithinRange(0.01, 0.05f);

			CalculateNew();
			UpdateUI();
		}

		private void UpdateUI()
		{
			nmcHealth.Text = (statsPList[0] * 100).ToString();
			nmcAttack.Text = (statsPList[1] * 100).ToString();
			nmcDefense.Text = (statsPList[2] * 100).ToString();
			nmcAgility.Text = (statsPList[3] * 100).ToString();
			nmcAccuracy.Text = (statsPList[4] * 100).ToString();
			nmcResistance.Text = (statsPList[5] * 100).ToString();
			nmcCritChance.Text = (statsPList[6] * 100).ToString();
			nmcCritDamage.Text = (statsPList[7] * 100).ToString();
			

			textHealth.Text = statsList[0].ToString();
			textAttack.Text = statsList[1].ToString();
			textDefense.Text = statsList[2].ToString();
			textAgility.Text = statsList[3].ToString();
			textAccuracy.Text = statsList[4].ToString();
			textResistance.Text = statsList[5].ToString();
			textCritDamage.Text = statsList[6].ToString();
			textCritChance.Text = statsList[7].ToString();
			
			labelTotal.Text = $"Total = {total}%";
			labelPower.Text = $"Total Power = {power}";
		}

		private void CalculateNew()
		{
			statsList[0] = (float)Math.Ceiling(nmcHealth.Value * maxValue / 100 * 4);
			statsList[1] = (float)Math.Ceiling(nmcAttack.Value * maxValue / 100 * 4);
			statsList[2] = (float)Math.Ceiling(nmcDefense.Value * maxValue / 100 * 4);
			statsList[3] = (float)Math.Ceiling(nmcAgility.Value * maxValue / 100 * 4);
			statsList[4] = (float)Math.Ceiling(nmcAccuracy.Value * maxValue / 100 * 4);
			statsList[5] = (float)Math.Ceiling(nmcResistance.Value * maxValue / 100 * 4);
			statsList[6] = (float)Math.Ceiling(nmcCritChance.Value * maxValue / 100 * 4);
			statsList[7] = (float)Math.Ceiling(nmcCritDamage.Value * maxValue / 100 * 4);

			
			power = (float)Math.Floor(((float)statsList[0] * 0.35f * 2) + ((float)statsList[1] * 0.15f * 2) + ((float)statsList[2] * 0.15f * 2) + ((float)statsList[3] * 0.10f * 2) +
				((float)statsList[4] * 0.05f * 2) + ((float)statsList[5] * 0.10f * 2) + ((float)statsList[6] * 0.05f * 2) + ((float)statsList[7] * 0.05f * 2));

			total = (float)(nmcHealth.Value + nmcAttack.Value + nmcDefense.Value + nmcAgility.Value + nmcAccuracy.Value + nmcResistance.Value + nmcCritChance.Value + nmcCritDamage.Value);
		}
	}
}



/*while (total < 95 || total > 100)
{
	critDamageP = rand.Next(1, 5);
	critChanceP = rand.Next(1, 5);
	accuracyP = rand.Next(1, 6);
	resistanceP = rand.Next(1, 6);
	totalP = (critChanceP + critDamageP + accuracyP + resistanceP);
	sisa = 100 - totalP;

	healthP = rand.Next(1, sisa);
	totalP = (critChanceP + critDamageP + accuracyP + resistanceP + healthP);
	sisa = 100 - totalP;

	attackP = rand.Next(1, sisa);
	totalP = (critChanceP + critDamageP + accuracyP + resistanceP + healthP + attackP);
	sisa = 100 - totalP ;

	try
	{
		defenseP = rand.Next(1, sisa);
		totalP = (critChanceP + critDamageP + accuracyP + resistanceP + healthP + attackP + defenseP);
		sisa = 100 - totalP;
	}
	catch { }

	try
	{
		agilityP = rand.Next(1, sisa);
		totalP = (critChanceP + critDamageP + accuracyP + resistanceP + healthP + attackP + defenseP + agilityP);
		sisa = 100 - totalP;
	}
	catch { }


}*/