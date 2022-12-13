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
		const int maxValue = 100;
		int sisa;

		float total, power;

		float health, attack, defense, agility, accuracy, resistance, critChance, critDamage;
		int healthP, attackP, defenseP, agilityP, accuracyP, resistanceP, critChanceP, critDamageP;

		public Form1()
		{
			InitializeComponent();
		}

		private void LockCheckBoxChanged(object sender, EventArgs e)
		{
			nmcHealth.Enabled = !checkHealth.Checked;
			nmcAttack.Enabled = !checkAttack.Checked;
			nmcDefense.Enabled = !checkDefense.Checked;
			nmcAgility.Enabled = !checkAgility.Checked;
			nmcAccuracy.Enabled = !checkAccuracy.Checked;
			nmcResistance.Enabled = !checkResistance.Checked;
			nmcCritChance.Enabled = !checkCritChance.Checked;
			nmcCritDamage.Enabled = !checkCritDamage.Checked;
		}

		private void OnNumericValueChanged(object sender, EventArgs e)
		{
			CalculateNew();
		}

		private void buttonRandomize_Click(object sender, EventArgs e)
		{
			CalculateRandom();
		}

		private void CalculateRandom()
		{
			Random rand = new Random();
			var totalP = 0;
			total = 0;
			while (total < 95 || total > 100)
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

				nmcHealth.Text = healthP.ToString();
				nmcAttack.Text = attackP.ToString();
				nmcDefense.Text = defenseP.ToString();
				nmcAgility.Text = agilityP.ToString();
				nmcAccuracy.Text = accuracyP.ToString();
				nmcResistance.Text = resistanceP.ToString();
				nmcCritDamage.Text = critDamageP.ToString();
				nmcCritChance.Text = critChanceP.ToString();
			}			
		}

		private void CalculateNew()
		{
			health = (float)(nmcHealth.Value * maxValue / 100 * 4);
			attack = (float)(nmcAttack.Value * maxValue / 100 * 4);
			defense = (float)(nmcDefense.Value * maxValue / 100 * 4);
			agility = (float)(nmcAgility.Value * maxValue / 100 * 4);
			accuracy = (float)(nmcAccuracy.Value * maxValue / 100 * 4);
			resistance = (float)(nmcResistance.Value * maxValue / 100 * 4);
			critChance = (float)(nmcCritChance.Value * maxValue / 100 * 4);
			critDamage = (float)(nmcCritDamage.Value * maxValue / 100 * 4);

			textHealth.Text = health.ToString();
			textAttack.Text = attack.ToString();
			textDefense.Text = defense.ToString();
			textAgility.Text = agility.ToString();
			textAccuracy.Text = accuracy.ToString();
			textResistance.Text = resistance.ToString();
			textCritChance.Text = critChance.ToString();
			textCritDamage.Text = critDamage.ToString();


			power = (float)Math.Floor(((float)health * 0.35f * 2) + ((float)attack * 0.15f * 2) + ((float)defense * 0.15f * 2) + ((float)agility * 0.10f * 2) +
				((float)accuracy * 0.05f * 2) + ((float)resistance * 0.10f * 2) + ((float)critChance * 0.05f * 2) + ((float)critDamage * 0.05f * 2));

			total = (float)(nmcHealth.Value + nmcAttack.Value + nmcDefense.Value + nmcAgility.Value + nmcAccuracy.Value + nmcResistance.Value + nmcCritChance.Value + nmcCritDamage.Value);
			labelTotal.Text = $"Total = {total}%";
			labelPower.Text = $"Total Power = {power}";
		}
	}
}
