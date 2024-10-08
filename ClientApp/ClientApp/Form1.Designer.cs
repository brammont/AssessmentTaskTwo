namespace ClientApp
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.startVelocityTextbox = new System.Windows.Forms.TextBox();
			this.starDistanceTextbox = new System.Windows.Forms.TextBox();
			this.tempCKTextbox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.calculateButton = new System.Windows.Forms.Button();
			this.Reset = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.LenguageComboBox = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label11 = new System.Windows.Forms.Label();
			this.BlackholeEventTextbox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Astronomical Processing Client";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Star Velocity:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Star Distance:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Temperature (C to K):";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 246);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Language:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Mode:";
			// 
			// startVelocityTextbox
			// 
			this.startVelocityTextbox.Location = new System.Drawing.Point(164, 74);
			this.startVelocityTextbox.Name = "startVelocityTextbox";
			this.startVelocityTextbox.Size = new System.Drawing.Size(100, 20);
			this.startVelocityTextbox.TabIndex = 6;
			// 
			// starDistanceTextbox
			// 
			this.starDistanceTextbox.Location = new System.Drawing.Point(164, 105);
			this.starDistanceTextbox.Name = "starDistanceTextbox";
			this.starDistanceTextbox.Size = new System.Drawing.Size(100, 20);
			this.starDistanceTextbox.TabIndex = 7;
			// 
			// tempCKTextbox
			// 
			this.tempCKTextbox.Location = new System.Drawing.Point(164, 138);
			this.tempCKTextbox.Name = "tempCKTextbox";
			this.tempCKTextbox.Size = new System.Drawing.Size(100, 20);
			this.tempCKTextbox.TabIndex = 8;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// calculateButton
			// 
			this.calculateButton.Location = new System.Drawing.Point(75, 208);
			this.calculateButton.Name = "calculateButton";
			this.calculateButton.Size = new System.Drawing.Size(75, 23);
			this.calculateButton.TabIndex = 9;
			this.calculateButton.Text = "Calculate";
			this.calculateButton.UseVisualStyleBackColor = true;
			this.calculateButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(237, 208);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(75, 23);
			this.Reset.TabIndex = 10;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(26, 321);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(132, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Color Customination";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(171, 321);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(141, 23);
			this.button4.TabIndex = 12;
			this.button4.Text = "Font Customization";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// LenguageComboBox
			// 
			this.LenguageComboBox.FormattingEnabled = true;
			this.LenguageComboBox.Items.AddRange(new object[] {
            "English",
            "French",
            "German"});
			this.LenguageComboBox.Location = new System.Drawing.Point(97, 243);
			this.LenguageComboBox.Name = "LenguageComboBox";
			this.LenguageComboBox.Size = new System.Drawing.Size(121, 21);
			this.LenguageComboBox.TabIndex = 13;
			this.LenguageComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(97, 275);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 14;
			this.button5.Text = "Day/Night Mode";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(275, 74);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Result";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(275, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Result";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(275, 141);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(37, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Result";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(65, 390);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Server Status:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(31, 172);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(127, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "Blackhole Event Horizon:";
			// 
			// BlackholeEventTextbox
			// 
			this.BlackholeEventTextbox.Location = new System.Drawing.Point(164, 169);
			this.BlackholeEventTextbox.Name = "BlackholeEventTextbox";
			this.BlackholeEventTextbox.Size = new System.Drawing.Size(100, 20);
			this.BlackholeEventTextbox.TabIndex = 20;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(275, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(37, 13);
			this.label12.TabIndex = 21;
			this.label12.Text = "Result";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(145, 390);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 22;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.BlackholeEventTextbox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.LenguageComboBox);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.calculateButton);
			this.Controls.Add(this.tempCKTextbox);
			this.Controls.Add(this.starDistanceTextbox);
			this.Controls.Add(this.startVelocityTextbox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox startVelocityTextbox;
		private System.Windows.Forms.TextBox starDistanceTextbox;
		private System.Windows.Forms.TextBox tempCKTextbox;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox LenguageComboBox;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button calculateButton;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox BlackholeEventTextbox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
	}
}

