namespace ClientApp
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
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(296, 320);
            buttonClear.Margin = new Padding(3, 4, 3, 4);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(95, 35);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxResultMass
            // 
            textBoxResultMass.Location = new Point(320, 259);
            textBoxResultMass.Margin = new Padding(3, 4, 3, 4);
            textBoxResultMass.Name = "textBoxResultMass";
            textBoxResultMass.ReadOnly = true;
            textBoxResultMass.Size = new Size(98, 27);
            textBoxResultMass.TabIndex = 7;
            textBoxResultMass.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultLuminosity
            // 
            textBoxResultLuminosity.Location = new Point(320, 212);
            textBoxResultLuminosity.Margin = new Padding(3, 4, 3, 4);
            textBoxResultLuminosity.Name = "textBoxResultLuminosity";
            textBoxResultLuminosity.ReadOnly = true;
            textBoxResultLuminosity.Size = new Size(98, 27);
            textBoxResultLuminosity.TabIndex = 6;
            textBoxResultLuminosity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultDistance
            // 
            textBoxResultDistance.Location = new Point(320, 161);
            textBoxResultDistance.Margin = new Padding(3, 4, 3, 4);
            textBoxResultDistance.Name = "textBoxResultDistance";
            textBoxResultDistance.ReadOnly = true;
            textBoxResultDistance.Size = new Size(98, 27);
            textBoxResultDistance.TabIndex = 3;
            textBoxResultDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxResultVelocity
            // 
            textBoxResultVelocity.Location = new Point(320, 113);
            textBoxResultVelocity.Margin = new Padding(3, 4, 3, 4);
            textBoxResultVelocity.Name = "textBoxResultVelocity";
            textBoxResultVelocity.ReadOnly = true;
            textBoxResultVelocity.Size = new Size(98, 27);
            textBoxResultVelocity.TabIndex = 2;
            textBoxResultVelocity.TextAlign = HorizontalAlignment.Center;
            // 
            // labelSettingsPanel
            // 
            labelSettingsPanel.AutoSize = true;
            labelSettingsPanel.Location = new Point(43, 384);
            labelSettingsPanel.Name = "labelSettingsPanel";
            labelSettingsPanel.Size = new Size(77, 20);
            labelSettingsPanel.TabIndex = 10;
            labelSettingsPanel.Text = "Language:";
            labelSettingsPanel.Click += labelSettingsPanel_Click;
            // 
            // buttonFontCustomization
            // 
            buttonFontCustomization.Location = new Point(279, 488);
            buttonFontCustomization.Margin = new Padding(3, 4, 3, 4);
            buttonFontCustomization.Name = "buttonFontCustomization";
            buttonFontCustomization.Size = new Size(159, 31);
            buttonFontCustomization.TabIndex = 6;
            buttonFontCustomization.Text = "Font Customization";
            buttonFontCustomization.UseVisualStyleBackColor = true;
            buttonFontCustomization.Click += buttonFontCustomization_Click;
            // 
            // buttonBackgroundColor
            // 
            buttonBackgroundColor.Location = new Point(43, 488);
            buttonBackgroundColor.Margin = new Padding(3, 4, 3, 4);
            buttonBackgroundColor.Name = "buttonBackgroundColor";
            buttonBackgroundColor.Size = new Size(159, 31);
            buttonBackgroundColor.TabIndex = 5;
            buttonBackgroundColor.Text = "Background Color";
            buttonBackgroundColor.UseVisualStyleBackColor = true;
            buttonBackgroundColor.Click += buttonBackgroundColor_Click;
            // 
            // checkBoxNightMode
            // 
            checkBoxNightMode.AutoSize = true;
            checkBoxNightMode.Location = new Point(279, 437);
            checkBoxNightMode.Margin = new Padding(3, 4, 3, 4);
            checkBoxNightMode.Name = "checkBoxNightMode";
            checkBoxNightMode.Size = new Size(100, 24);
            checkBoxNightMode.TabIndex = 0;
            checkBoxNightMode.Text = "Day/Night";
            checkBoxNightMode.UseVisualStyleBackColor = true;
            checkBoxNightMode.CheckedChanged += checkBoxNightMode_CheckedChanged;
            // 
            // labelErrorMessagingArea
            // 
            labelErrorMessagingArea.AutoSize = true;
            labelErrorMessagingArea.Location = new Point(43, 589);
            labelErrorMessagingArea.Name = "labelErrorMessagingArea";
            labelErrorMessagingArea.Size = new Size(106, 20);
            labelErrorMessagingArea.TabIndex = 6;
            labelErrorMessagingArea.Text = "Error Message:";
            // 
            // textBoxErrorHandler
            // 
            textBoxErrorHandler.Location = new Point(43, 620);
            textBoxErrorHandler.Margin = new Padding(3, 4, 3, 4);
            textBoxErrorHandler.Name = "textBoxErrorHandler";
            textBoxErrorHandler.Size = new Size(395, 27);
            textBoxErrorHandler.TabIndex = 0;
            textBoxErrorHandler.TextChanged += textBoxErrorHandler_TextChanged;
            // 
            // comboBoxLanguage
            // 
            comboBoxLanguage.FormattingEnabled = true;
            comboBoxLanguage.Location = new Point(279, 376);
            comboBoxLanguage.Margin = new Padding(3, 4, 3, 4);
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.Size = new Size(129, 28);
            comboBoxLanguage.TabIndex = 4;
            comboBoxLanguage.Text = "Language";
            comboBoxLanguage.SelectedIndexChanged += comboBoxLanguage_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe MDL2 Assets", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(77, 28);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(314, 28);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Astronomical Processing Client";
            labelTitle.TextAlign = ContentAlignment.TopCenter;
            labelTitle.Click += labelTitle_Click;
            // 
            // textBoxStarVelocity
            // 
            textBoxStarVelocity.Location = new Point(216, 113);
            textBoxStarVelocity.Margin = new Padding(3, 4, 3, 4);
            textBoxStarVelocity.Name = "textBoxStarVelocity";
            textBoxStarVelocity.Size = new Size(97, 27);
            textBoxStarVelocity.TabIndex = 0;
            textBoxStarVelocity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarDistance
            // 
            textBoxStarDistance.Location = new Point(216, 161);
            textBoxStarDistance.Margin = new Padding(3, 4, 3, 4);
            textBoxStarDistance.Name = "textBoxStarDistance";
            textBoxStarDistance.Size = new Size(97, 27);
            textBoxStarDistance.TabIndex = 1;
            textBoxStarDistance.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarLuminosity
            // 
            textBoxStarLuminosity.Location = new Point(216, 212);
            textBoxStarLuminosity.Margin = new Padding(3, 4, 3, 4);
            textBoxStarLuminosity.Name = "textBoxStarLuminosity";
            textBoxStarLuminosity.Size = new Size(97, 27);
            textBoxStarLuminosity.TabIndex = 7;
            textBoxStarLuminosity.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxStarMass
            // 
            textBoxStarMass.Location = new Point(217, 259);
            textBoxStarMass.Margin = new Padding(3, 4, 3, 4);
            textBoxStarMass.Name = "textBoxStarMass";
            textBoxStarMass.Size = new Size(97, 27);
            textBoxStarMass.TabIndex = 8;
            textBoxStarMass.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(77, 320);
            buttonCalculate.Margin = new Padding(3, 4, 3, 4);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(95, 35);
            buttonCalculate.TabIndex = 9;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelStarVelocity
            // 
            labelStarVelocity.AutoSize = true;
            labelStarVelocity.Location = new Point(34, 113);
            labelStarVelocity.Name = "labelStarVelocity";
            labelStarVelocity.Size = new Size(94, 20);
            labelStarVelocity.TabIndex = 10;
            labelStarVelocity.Text = "Star Velocity:";
            // 
            // labelStarDistance
            // 
            labelStarDistance.AutoSize = true;
            labelStarDistance.Location = new Point(34, 161);
            labelStarDistance.Name = "labelStarDistance";
            labelStarDistance.Size = new Size(99, 20);
            labelStarDistance.TabIndex = 11;
            labelStarDistance.Text = "Star Distance:";
            // 
            // labelStarLuminosity
            // 
            labelStarLuminosity.AutoSize = true;
            labelStarLuminosity.Location = new Point(34, 212);
            labelStarLuminosity.Name = "labelStarLuminosity";
            labelStarLuminosity.Size = new Size(150, 20);
            labelStarLuminosity.TabIndex = 12;
            labelStarLuminosity.Text = "Temperature (C to K):";
            // 
            // labelStarMass
            // 
            labelStarMass.AutoSize = true;
            labelStarMass.Location = new Point(34, 259);
            labelStarMass.Name = "labelStarMass";
            labelStarMass.Size = new Size(173, 20);
            labelStarMass.TabIndex = 13;
            labelStarMass.Text = "Blackhole Event Horizon:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 441);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 15;
            label1.Text = "Mode:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 548);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 16;
            label2.Text = "Server Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 548);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(492, 690);
            Controls.Add(textBox1);
            Controls.Add(label2);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label2;
        private TextBox textBox1;
    }
}
