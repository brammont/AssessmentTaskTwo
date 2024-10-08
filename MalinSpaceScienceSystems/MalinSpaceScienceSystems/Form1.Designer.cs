namespace MalinSpaceScienceSystems
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			buttonClear = new Button();
			textBoxResultMass = new TextBox();
			textBoxResultLuminosity = new TextBox();
			textBoxResultDistance = new TextBox();
			textBoxResultVelocity = new TextBox();
			labelSettingsPanel = new Label();
			buttonFontCustomization = new Button();
			buttonBackgroundColor = new Button();
			checkBoxNightMode = new CheckBox();
			labelErrorMessagingArea = new Label();
			textBoxErrorHandler = new TextBox();
			bindingSource1 = new BindingSource(components);
			comboBoxLanguage = new ComboBox();
			bindingSource2 = new BindingSource(components);
			colorDialog1 = new ColorDialog();
			fontDialog1 = new FontDialog();
			labelTitle = new Label();
			textBoxStarVelocity = new TextBox();
			textBoxStarDistance = new TextBox();
			textBoxStarLuminosity = new TextBox();
			textBoxStarMass = new TextBox();
			buttonCalculate = new Button();
			labelStarVelocity = new Label();
			labelStarDistance = new Label();
			labelStarLuminosity = new Label();
			labelStarMass = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
			((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
			SuspendLayout();
			// 
			// buttonClear
			// 
			buttonClear.Location = new Point(244, 240);
			buttonClear.Name = "buttonClear";
			buttonClear.Size = new Size(83, 26);
			buttonClear.TabIndex = 14;
			buttonClear.Text = "Clear";
			buttonClear.UseVisualStyleBackColor = true;
			buttonClear.Click += buttonClear_Click;
			// 
			// textBoxResultMass
			// 
			textBoxResultMass.Location = new Point(280, 194);
			textBoxResultMass.Name = "textBoxResultMass";
			textBoxResultMass.ReadOnly = true;
			textBoxResultMass.Size = new Size(86, 23);
			textBoxResultMass.TabIndex = 7;
			textBoxResultMass.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxResultLuminosity
			// 
			textBoxResultLuminosity.Location = new Point(280, 159);
			textBoxResultLuminosity.Name = "textBoxResultLuminosity";
			textBoxResultLuminosity.ReadOnly = true;
			textBoxResultLuminosity.Size = new Size(86, 23);
			textBoxResultLuminosity.TabIndex = 6;
			textBoxResultLuminosity.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxResultDistance
			// 
			textBoxResultDistance.Location = new Point(280, 118);
			textBoxResultDistance.Name = "textBoxResultDistance";
			textBoxResultDistance.ReadOnly = true;
			textBoxResultDistance.Size = new Size(86, 23);
			textBoxResultDistance.TabIndex = 3;
			textBoxResultDistance.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxResultVelocity
			// 
			textBoxResultVelocity.Location = new Point(280, 77);
			textBoxResultVelocity.Name = "textBoxResultVelocity";
			textBoxResultVelocity.ReadOnly = true;
			textBoxResultVelocity.Size = new Size(86, 23);
			textBoxResultVelocity.TabIndex = 2;
			textBoxResultVelocity.TextAlign = HorizontalAlignment.Center;
			// 
			// labelSettingsPanel
			// 
			labelSettingsPanel.AutoSize = true;
			labelSettingsPanel.Location = new Point(38, 288);
			labelSettingsPanel.Name = "labelSettingsPanel";
			labelSettingsPanel.Size = new Size(62, 15);
			labelSettingsPanel.TabIndex = 10;
			labelSettingsPanel.Text = "Language:";
			labelSettingsPanel.Click += labelSettingsPanel_Click;
			// 
			// buttonFontCustomization
			// 
			buttonFontCustomization.Location = new Point(227, 377);
			buttonFontCustomization.Name = "buttonFontCustomization";
			buttonFontCustomization.Size = new Size(139, 23);
			buttonFontCustomization.TabIndex = 6;
			buttonFontCustomization.Text = "Font Customization";
			buttonFontCustomization.UseVisualStyleBackColor = true;
			buttonFontCustomization.Click += buttonFontCustomization_Click;
			// 
			// buttonBackgroundColor
			// 
			buttonBackgroundColor.Location = new Point(38, 377);
			buttonBackgroundColor.Name = "buttonBackgroundColor";
			buttonBackgroundColor.Size = new Size(139, 23);
			buttonBackgroundColor.TabIndex = 5;
			buttonBackgroundColor.Text = "Background Color";
			buttonBackgroundColor.UseVisualStyleBackColor = true;
			buttonBackgroundColor.Click += buttonBackgroundColor_Click;
			// 
			// checkBoxNightMode
			// 
			checkBoxNightMode.AutoSize = true;
			checkBoxNightMode.Location = new Point(153, 327);
			checkBoxNightMode.Name = "checkBoxNightMode";
			checkBoxNightMode.Size = new Size(81, 19);
			checkBoxNightMode.TabIndex = 0;
			checkBoxNightMode.Text = "Day/Night";
			checkBoxNightMode.UseVisualStyleBackColor = true;
			checkBoxNightMode.CheckedChanged += checkBoxNightMode_CheckedChanged;
			// 
			// labelErrorMessagingArea
			// 
			labelErrorMessagingArea.AutoSize = true;
			labelErrorMessagingArea.Location = new Point(38, 421);
			labelErrorMessagingArea.Name = "labelErrorMessagingArea";
			labelErrorMessagingArea.Size = new Size(74, 15);
			labelErrorMessagingArea.TabIndex = 6;
			labelErrorMessagingArea.Text = "Server Status";
			// 
			// textBoxErrorHandler
			// 
			textBoxErrorHandler.Location = new Point(136, 421);
			textBoxErrorHandler.Name = "textBoxErrorHandler";
			textBoxErrorHandler.Size = new Size(139, 23);
			textBoxErrorHandler.TabIndex = 0;
			// 
			// comboBoxLanguage
			// 
			comboBoxLanguage.FormattingEnabled = true;
			comboBoxLanguage.Location = new Point(153, 285);
			comboBoxLanguage.Name = "comboBoxLanguage";
			comboBoxLanguage.Size = new Size(113, 23);
			comboBoxLanguage.TabIndex = 4;
			comboBoxLanguage.Text = "Language";
			comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
			// 
			// labelTitle
			// 
			labelTitle.AutoSize = true;
			labelTitle.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labelTitle.Location = new Point(12, 25);
			labelTitle.Name = "labelTitle";
			labelTitle.Size = new Size(367, 27);
			labelTitle.TabIndex = 5;
			labelTitle.Text = "Astronomical Processing Client";
			labelTitle.TextAlign = ContentAlignment.TopCenter;
			// 
			// textBoxStarVelocity
			// 
			textBoxStarVelocity.Location = new Point(174, 77);
			textBoxStarVelocity.Name = "textBoxStarVelocity";
			textBoxStarVelocity.Size = new Size(85, 23);
			textBoxStarVelocity.TabIndex = 0;
			textBoxStarVelocity.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxStarDistance
			// 
			textBoxStarDistance.Location = new Point(174, 121);
			textBoxStarDistance.Name = "textBoxStarDistance";
			textBoxStarDistance.Size = new Size(85, 23);
			textBoxStarDistance.TabIndex = 1;
			textBoxStarDistance.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxStarLuminosity
			// 
			textBoxStarLuminosity.Location = new Point(174, 156);
			textBoxStarLuminosity.Name = "textBoxStarLuminosity";
			textBoxStarLuminosity.Size = new Size(85, 23);
			textBoxStarLuminosity.TabIndex = 7;
			textBoxStarLuminosity.TextAlign = HorizontalAlignment.Center;
			// 
			// textBoxStarMass
			// 
			textBoxStarMass.Location = new Point(174, 191);
			textBoxStarMass.Name = "textBoxStarMass";
			textBoxStarMass.Size = new Size(85, 23);
			textBoxStarMass.TabIndex = 8;
			textBoxStarMass.TextAlign = HorizontalAlignment.Center;
			// 
			// buttonCalculate
			// 
			buttonCalculate.Location = new Point(94, 240);
			buttonCalculate.Name = "buttonCalculate";
			buttonCalculate.Size = new Size(83, 26);
			buttonCalculate.TabIndex = 9;
			buttonCalculate.Text = "Calculate";
			buttonCalculate.UseVisualStyleBackColor = true;
			buttonCalculate.Click += buttonCalculate_Click;
			// 
			// labelStarVelocity
			// 
			labelStarVelocity.AutoSize = true;
			labelStarVelocity.Location = new Point(30, 85);
			labelStarVelocity.Name = "labelStarVelocity";
			labelStarVelocity.Size = new Size(74, 15);
			labelStarVelocity.TabIndex = 10;
			labelStarVelocity.Text = "Star Velocity:";
			// 
			// labelStarDistance
			// 
			labelStarDistance.AutoSize = true;
			labelStarDistance.Location = new Point(30, 121);
			labelStarDistance.Name = "labelStarDistance";
			labelStarDistance.Size = new Size(78, 15);
			labelStarDistance.TabIndex = 11;
			labelStarDistance.Text = "Star Distance:";
			// 
			// labelStarLuminosity
			// 
			labelStarLuminosity.AutoSize = true;
			labelStarLuminosity.Location = new Point(30, 159);
			labelStarLuminosity.Name = "labelStarLuminosity";
			labelStarLuminosity.Size = new Size(119, 15);
			labelStarLuminosity.TabIndex = 12;
			labelStarLuminosity.Text = "Temperature (C to K):";
			// 
			// labelStarMass
			// 
			labelStarMass.AutoSize = true;
			labelStarMass.Location = new Point(30, 194);
			labelStarMass.Name = "labelStarMass";
			labelStarMass.Size = new Size(138, 15);
			labelStarMass.TabIndex = 13;
			labelStarMass.Text = "Blackhole Event Horizon:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(38, 331);
			label1.Name = "label1";
			label1.Size = new Size(41, 15);
			label1.TabIndex = 15;
			label1.Text = "Mode:";
			label1.Click += label1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(391, 482);
			Controls.Add(label1);
			Controls.Add(textBoxErrorHandler);
			Controls.Add(labelErrorMessagingArea);
			Controls.Add(buttonFontCustomization);
			Controls.Add(labelSettingsPanel);
			Controls.Add(buttonBackgroundColor);
			Controls.Add(buttonClear);
			Controls.Add(checkBoxNightMode);
			Controls.Add(labelStarMass);
			Controls.Add(textBoxStarMass);
			Controls.Add(labelTitle);
			Controls.Add(textBoxStarLuminosity);
			Controls.Add(textBoxResultMass);
			Controls.Add(labelStarLuminosity);
			Controls.Add(textBoxStarDistance);
			Controls.Add(textBoxResultLuminosity);
			Controls.Add(comboBoxLanguage);
			Controls.Add(labelStarDistance);
			Controls.Add(textBoxResultDistance);
			Controls.Add(textBoxResultVelocity);
			Controls.Add(labelStarVelocity);
			Controls.Add(buttonCalculate);
			Controls.Add(textBoxStarVelocity);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
			((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox textBoxResultDistance;
        private TextBox textBoxResultVelocity;
        private BindingSource bindingSource1;
        private TextBox textBoxResultMass;
        private TextBox textBoxResultLuminosity;
        private ComboBox comboBoxLanguage;
        private CheckBox checkBoxNightMode;
        private BindingSource bindingSource2;
        private Button buttonFontCustomization;
        private Button buttonBackgroundColor;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private TextBox textBoxErrorHandler;
        private Label labelSettingsPanel;
        private Label labelErrorMessagingArea;
        private Button buttonClear;
		private Label labelTitle;
		private TextBox textBoxStarVelocity;
		private TextBox textBoxStarDistance;
		private TextBox textBoxStarLuminosity;
		private TextBox textBoxStarMass;
		private Button buttonCalculate;
		private Label labelStarVelocity;
		private Label labelStarDistance;
		private Label labelStarLuminosity;
		private Label labelStarMass;
		private Label label1;
	}
}
