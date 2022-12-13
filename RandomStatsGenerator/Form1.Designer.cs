namespace RandomStatsGenerator
{
	partial class Form1
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.nmcHealth = new System.Windows.Forms.NumericUpDown();
			this.labelHealth = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nmcAttack = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.nmcDefense = new System.Windows.Forms.NumericUpDown();
			this.checkHealth = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nmcAgility = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nmcAccuracy = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.nmcResistance = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.nmcCritChance = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.nmcCritDamage = new System.Windows.Forms.NumericUpDown();
			this.textHealth = new System.Windows.Forms.TextBox();
			this.textAttack = new System.Windows.Forms.TextBox();
			this.textDefense = new System.Windows.Forms.TextBox();
			this.textAgility = new System.Windows.Forms.TextBox();
			this.textAccuracy = new System.Windows.Forms.TextBox();
			this.textResistance = new System.Windows.Forms.TextBox();
			this.textCritChance = new System.Windows.Forms.TextBox();
			this.textCritDamage = new System.Windows.Forms.TextBox();
			this.checkAttack = new System.Windows.Forms.CheckBox();
			this.checkDefense = new System.Windows.Forms.CheckBox();
			this.checkAgility = new System.Windows.Forms.CheckBox();
			this.checkAccuracy = new System.Windows.Forms.CheckBox();
			this.checkResistance = new System.Windows.Forms.CheckBox();
			this.checkCritChance = new System.Windows.Forms.CheckBox();
			this.checkCritDamage = new System.Windows.Forms.CheckBox();
			this.labelTotal = new System.Windows.Forms.Label();
			this.buttonRandomize = new System.Windows.Forms.Button();
			this.labelPower = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nmcHealth)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAttack)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcDefense)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAgility)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAccuracy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcResistance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcCritChance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcCritDamage)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.labelTitle.Location = new System.Drawing.Point(46, 27);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(393, 37);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Character Stats Generator";
			// 
			// nmcHealth
			// 
			this.nmcHealth.DecimalPlaces = 2;
			this.nmcHealth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcHealth.Location = new System.Drawing.Point(176, 104);
			this.nmcHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcHealth.Name = "nmcHealth";
			this.nmcHealth.Size = new System.Drawing.Size(60, 20);
			this.nmcHealth.TabIndex = 1;
			this.nmcHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcHealth.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// labelHealth
			// 
			this.labelHealth.AutoSize = true;
			this.labelHealth.Location = new System.Drawing.Point(72, 107);
			this.labelHealth.Name = "labelHealth";
			this.labelHealth.Size = new System.Drawing.Size(55, 13);
			this.labelHealth.TabIndex = 2;
			this.labelHealth.Text = "Health (%)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 132);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Attack (%)";
			// 
			// nmcAttack
			// 
			this.nmcAttack.DecimalPlaces = 2;
			this.nmcAttack.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcAttack.Location = new System.Drawing.Point(176, 130);
			this.nmcAttack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAttack.Name = "nmcAttack";
			this.nmcAttack.Size = new System.Drawing.Size(60, 20);
			this.nmcAttack.TabIndex = 3;
			this.nmcAttack.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAttack.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(72, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Defense (%)";
			// 
			// nmcDefense
			// 
			this.nmcDefense.DecimalPlaces = 2;
			this.nmcDefense.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcDefense.Location = new System.Drawing.Point(176, 156);
			this.nmcDefense.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcDefense.Name = "nmcDefense";
			this.nmcDefense.Size = new System.Drawing.Size(60, 20);
			this.nmcDefense.TabIndex = 5;
			this.nmcDefense.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcDefense.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// checkHealth
			// 
			this.checkHealth.AutoSize = true;
			this.checkHealth.Location = new System.Drawing.Point(349, 107);
			this.checkHealth.Name = "checkHealth";
			this.checkHealth.Size = new System.Drawing.Size(50, 17);
			this.checkHealth.TabIndex = 7;
			this.checkHealth.Text = "Lock";
			this.checkHealth.UseVisualStyleBackColor = true;
			this.checkHealth.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(72, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Agility (%)";
			// 
			// nmcAgility
			// 
			this.nmcAgility.DecimalPlaces = 2;
			this.nmcAgility.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcAgility.Location = new System.Drawing.Point(176, 182);
			this.nmcAgility.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAgility.Name = "nmcAgility";
			this.nmcAgility.Size = new System.Drawing.Size(60, 20);
			this.nmcAgility.TabIndex = 8;
			this.nmcAgility.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAgility.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 210);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Accuracy (%)";
			// 
			// nmcAccuracy
			// 
			this.nmcAccuracy.DecimalPlaces = 2;
			this.nmcAccuracy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcAccuracy.Location = new System.Drawing.Point(176, 208);
			this.nmcAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAccuracy.Name = "nmcAccuracy";
			this.nmcAccuracy.Size = new System.Drawing.Size(60, 20);
			this.nmcAccuracy.TabIndex = 10;
			this.nmcAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcAccuracy.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(72, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Resistance (%)";
			// 
			// nmcResistance
			// 
			this.nmcResistance.DecimalPlaces = 2;
			this.nmcResistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcResistance.Location = new System.Drawing.Point(176, 234);
			this.nmcResistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcResistance.Name = "nmcResistance";
			this.nmcResistance.Size = new System.Drawing.Size(60, 20);
			this.nmcResistance.TabIndex = 12;
			this.nmcResistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcResistance.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(72, 262);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Crit. Chance (%)";
			// 
			// nmcCritChance
			// 
			this.nmcCritChance.DecimalPlaces = 2;
			this.nmcCritChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcCritChance.Location = new System.Drawing.Point(176, 260);
			this.nmcCritChance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcCritChance.Name = "nmcCritChance";
			this.nmcCritChance.Size = new System.Drawing.Size(60, 20);
			this.nmcCritChance.TabIndex = 14;
			this.nmcCritChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcCritChance.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(72, 288);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 13);
			this.label7.TabIndex = 17;
			this.label7.Text = "Crit. Damage (%)";
			// 
			// nmcCritDamage
			// 
			this.nmcCritDamage.DecimalPlaces = 2;
			this.nmcCritDamage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.nmcCritDamage.Location = new System.Drawing.Point(176, 286);
			this.nmcCritDamage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcCritDamage.Name = "nmcCritDamage";
			this.nmcCritDamage.Size = new System.Drawing.Size(60, 20);
			this.nmcCritDamage.TabIndex = 16;
			this.nmcCritDamage.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.nmcCritDamage.ValueChanged += new System.EventHandler(this.OnNumericValueChanged);
			// 
			// textHealth
			// 
			this.textHealth.Location = new System.Drawing.Point(243, 103);
			this.textHealth.Name = "textHealth";
			this.textHealth.Size = new System.Drawing.Size(100, 20);
			this.textHealth.TabIndex = 18;
			// 
			// textAttack
			// 
			this.textAttack.Location = new System.Drawing.Point(243, 132);
			this.textAttack.Name = "textAttack";
			this.textAttack.Size = new System.Drawing.Size(100, 20);
			this.textAttack.TabIndex = 19;
			// 
			// textDefense
			// 
			this.textDefense.Location = new System.Drawing.Point(243, 158);
			this.textDefense.Name = "textDefense";
			this.textDefense.Size = new System.Drawing.Size(100, 20);
			this.textDefense.TabIndex = 20;
			// 
			// textAgility
			// 
			this.textAgility.Location = new System.Drawing.Point(242, 184);
			this.textAgility.Name = "textAgility";
			this.textAgility.Size = new System.Drawing.Size(100, 20);
			this.textAgility.TabIndex = 21;
			// 
			// textAccuracy
			// 
			this.textAccuracy.Location = new System.Drawing.Point(243, 210);
			this.textAccuracy.Name = "textAccuracy";
			this.textAccuracy.Size = new System.Drawing.Size(100, 20);
			this.textAccuracy.TabIndex = 22;
			// 
			// textResistance
			// 
			this.textResistance.Location = new System.Drawing.Point(243, 234);
			this.textResistance.Name = "textResistance";
			this.textResistance.Size = new System.Drawing.Size(100, 20);
			this.textResistance.TabIndex = 23;
			// 
			// textCritChance
			// 
			this.textCritChance.Location = new System.Drawing.Point(243, 259);
			this.textCritChance.Name = "textCritChance";
			this.textCritChance.Size = new System.Drawing.Size(100, 20);
			this.textCritChance.TabIndex = 24;
			// 
			// textCritDamage
			// 
			this.textCritDamage.Location = new System.Drawing.Point(243, 285);
			this.textCritDamage.Name = "textCritDamage";
			this.textCritDamage.Size = new System.Drawing.Size(100, 20);
			this.textCritDamage.TabIndex = 25;
			// 
			// checkAttack
			// 
			this.checkAttack.AutoSize = true;
			this.checkAttack.Location = new System.Drawing.Point(349, 135);
			this.checkAttack.Name = "checkAttack";
			this.checkAttack.Size = new System.Drawing.Size(50, 17);
			this.checkAttack.TabIndex = 26;
			this.checkAttack.Text = "Lock";
			this.checkAttack.UseVisualStyleBackColor = true;
			this.checkAttack.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkDefense
			// 
			this.checkDefense.AutoSize = true;
			this.checkDefense.Location = new System.Drawing.Point(349, 161);
			this.checkDefense.Name = "checkDefense";
			this.checkDefense.Size = new System.Drawing.Size(50, 17);
			this.checkDefense.TabIndex = 27;
			this.checkDefense.Text = "Lock";
			this.checkDefense.UseVisualStyleBackColor = true;
			this.checkDefense.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkAgility
			// 
			this.checkAgility.AutoSize = true;
			this.checkAgility.Location = new System.Drawing.Point(348, 187);
			this.checkAgility.Name = "checkAgility";
			this.checkAgility.Size = new System.Drawing.Size(50, 17);
			this.checkAgility.TabIndex = 28;
			this.checkAgility.Text = "Lock";
			this.checkAgility.UseVisualStyleBackColor = true;
			this.checkAgility.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkAccuracy
			// 
			this.checkAccuracy.AutoSize = true;
			this.checkAccuracy.Location = new System.Drawing.Point(348, 213);
			this.checkAccuracy.Name = "checkAccuracy";
			this.checkAccuracy.Size = new System.Drawing.Size(50, 17);
			this.checkAccuracy.TabIndex = 29;
			this.checkAccuracy.Text = "Lock";
			this.checkAccuracy.UseVisualStyleBackColor = true;
			this.checkAccuracy.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkResistance
			// 
			this.checkResistance.AutoSize = true;
			this.checkResistance.Location = new System.Drawing.Point(349, 237);
			this.checkResistance.Name = "checkResistance";
			this.checkResistance.Size = new System.Drawing.Size(50, 17);
			this.checkResistance.TabIndex = 30;
			this.checkResistance.Text = "Lock";
			this.checkResistance.UseVisualStyleBackColor = true;
			this.checkResistance.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkCritChance
			// 
			this.checkCritChance.AutoSize = true;
			this.checkCritChance.Location = new System.Drawing.Point(349, 263);
			this.checkCritChance.Name = "checkCritChance";
			this.checkCritChance.Size = new System.Drawing.Size(50, 17);
			this.checkCritChance.TabIndex = 31;
			this.checkCritChance.Text = "Lock";
			this.checkCritChance.UseVisualStyleBackColor = true;
			this.checkCritChance.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// checkCritDamage
			// 
			this.checkCritDamage.AutoSize = true;
			this.checkCritDamage.Location = new System.Drawing.Point(349, 288);
			this.checkCritDamage.Name = "checkCritDamage";
			this.checkCritDamage.Size = new System.Drawing.Size(50, 17);
			this.checkCritDamage.TabIndex = 32;
			this.checkCritDamage.Text = "Lock";
			this.checkCritDamage.UseVisualStyleBackColor = true;
			this.checkCritDamage.CheckedChanged += new System.EventHandler(this.LockCheckBoxChanged);
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.labelTotal.Location = new System.Drawing.Point(71, 324);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(117, 20);
			this.labelTotal.TabIndex = 33;
			this.labelTotal.Text = "Total Stats: 0%";
			// 
			// buttonRandomize
			// 
			this.buttonRandomize.Location = new System.Drawing.Point(75, 386);
			this.buttonRandomize.Name = "buttonRandomize";
			this.buttonRandomize.Size = new System.Drawing.Size(99, 23);
			this.buttonRandomize.TabIndex = 34;
			this.buttonRandomize.Text = "Randomize";
			this.buttonRandomize.UseVisualStyleBackColor = true;
			this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
			// 
			// labelPower
			// 
			this.labelPower.AutoSize = true;
			this.labelPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.labelPower.Location = new System.Drawing.Point(71, 353);
			this.labelPower.Name = "labelPower";
			this.labelPower.Size = new System.Drawing.Size(109, 20);
			this.labelPower.TabIndex = 35;
			this.labelPower.Text = "Total Power: 0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 450);
			this.Controls.Add(this.labelPower);
			this.Controls.Add(this.buttonRandomize);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.checkCritDamage);
			this.Controls.Add(this.checkCritChance);
			this.Controls.Add(this.checkResistance);
			this.Controls.Add(this.checkAccuracy);
			this.Controls.Add(this.checkAgility);
			this.Controls.Add(this.checkDefense);
			this.Controls.Add(this.checkAttack);
			this.Controls.Add(this.textCritDamage);
			this.Controls.Add(this.textCritChance);
			this.Controls.Add(this.textResistance);
			this.Controls.Add(this.textAccuracy);
			this.Controls.Add(this.textAgility);
			this.Controls.Add(this.textDefense);
			this.Controls.Add(this.textAttack);
			this.Controls.Add(this.textHealth);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.nmcCritDamage);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.nmcCritChance);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.nmcResistance);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nmcAccuracy);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nmcAgility);
			this.Controls.Add(this.checkHealth);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nmcDefense);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nmcAttack);
			this.Controls.Add(this.labelHealth);
			this.Controls.Add(this.nmcHealth);
			this.Controls.Add(this.labelTitle);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generator";
			((System.ComponentModel.ISupportInitialize)(this.nmcHealth)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAttack)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcDefense)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAgility)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcAccuracy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcResistance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcCritChance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmcCritDamage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.NumericUpDown nmcHealth;
		private System.Windows.Forms.Label labelHealth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nmcAttack;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nmcDefense;
		private System.Windows.Forms.CheckBox checkHealth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nmcAgility;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nmcAccuracy;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown nmcResistance;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nmcCritChance;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nmcCritDamage;
		private System.Windows.Forms.TextBox textHealth;
		private System.Windows.Forms.TextBox textAttack;
		private System.Windows.Forms.TextBox textDefense;
		private System.Windows.Forms.TextBox textAgility;
		private System.Windows.Forms.TextBox textAccuracy;
		private System.Windows.Forms.TextBox textResistance;
		private System.Windows.Forms.TextBox textCritChance;
		private System.Windows.Forms.TextBox textCritDamage;
		private System.Windows.Forms.CheckBox checkAttack;
		private System.Windows.Forms.CheckBox checkDefense;
		private System.Windows.Forms.CheckBox checkAgility;
		private System.Windows.Forms.CheckBox checkAccuracy;
		private System.Windows.Forms.CheckBox checkResistance;
		private System.Windows.Forms.CheckBox checkCritChance;
		private System.Windows.Forms.CheckBox checkCritDamage;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Button buttonRandomize;
		private System.Windows.Forms.Label labelPower;
	}
}

