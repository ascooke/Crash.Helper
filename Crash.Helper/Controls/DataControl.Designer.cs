namespace Crash.Helper.Controls
{
	partial class DataControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.masksDownButton = new System.Windows.Forms.Button();
            this.masksUpButton = new System.Windows.Forms.Button();
            this.livesUpButton = new System.Windows.Forms.Button();
            this.livesDownButton = new System.Windows.Forms.Button();
            this.freezeLivesCheckbox = new System.Windows.Forms.CheckBox();
            this.livesLabel = new System.Windows.Forms.Label();
            this.masksLabel = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.GroupBox();
            this.infiniteMasksCheckbox = new System.Windows.Forms.CheckBox();
            this.DamageMaskformCheckbox = new System.Windows.Forms.CheckBox();
            this.dataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // masksDownButton
            // 
            this.masksDownButton.Image = global::Crash.Helper.Properties.Resources.Subtract;
            this.masksDownButton.Location = new System.Drawing.Point(62, 48);
            this.masksDownButton.Name = "masksDownButton";
            this.masksDownButton.Size = new System.Drawing.Size(28, 28);
            this.masksDownButton.TabIndex = 10;
            this.masksDownButton.UseVisualStyleBackColor = true;
            this.masksDownButton.Click += new System.EventHandler(this.masksDownButton_Click);
            // 
            // masksUpButton
            // 
            this.masksUpButton.Image = global::Crash.Helper.Properties.Resources.Add;
            this.masksUpButton.Location = new System.Drawing.Point(91, 48);
            this.masksUpButton.Name = "masksUpButton";
            this.masksUpButton.Size = new System.Drawing.Size(28, 28);
            this.masksUpButton.TabIndex = 11;
            this.masksUpButton.UseVisualStyleBackColor = true;
            this.masksUpButton.Click += new System.EventHandler(this.masksUpButton_Click);
            // 
            // livesUpButton
            // 
            this.livesUpButton.Image = global::Crash.Helper.Properties.Resources.Add;
            this.livesUpButton.Location = new System.Drawing.Point(91, 19);
            this.livesUpButton.Name = "livesUpButton";
            this.livesUpButton.Size = new System.Drawing.Size(28, 28);
            this.livesUpButton.TabIndex = 9;
            this.livesUpButton.UseVisualStyleBackColor = true;
            this.livesUpButton.Click += new System.EventHandler(this.livesUpButton_Click);
            // 
            // livesDownButton
            // 
            this.livesDownButton.Image = global::Crash.Helper.Properties.Resources.Subtract;
            this.livesDownButton.Location = new System.Drawing.Point(62, 19);
            this.livesDownButton.Name = "livesDownButton";
            this.livesDownButton.Size = new System.Drawing.Size(28, 28);
            this.livesDownButton.TabIndex = 8;
            this.livesDownButton.UseVisualStyleBackColor = true;
            this.livesDownButton.Click += new System.EventHandler(this.livesDownButton_Click);
            // 
            // freezeLivesCheckbox
            // 
            this.freezeLivesCheckbox.AutoSize = true;
            this.freezeLivesCheckbox.Location = new System.Drawing.Point(125, 26);
            this.freezeLivesCheckbox.Name = "freezeLivesCheckbox";
            this.freezeLivesCheckbox.Size = new System.Drawing.Size(82, 17);
            this.freezeLivesCheckbox.TabIndex = 12;
            this.freezeLivesCheckbox.Text = "Freeze lives";
            this.freezeLivesCheckbox.UseVisualStyleBackColor = true;
            this.freezeLivesCheckbox.CheckedChanged += new System.EventHandler(this.freezeLivesCheckbox_CheckedChanged);
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Location = new System.Drawing.Point(7, 26);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(41, 13);
            this.livesLabel.TabIndex = 13;
            this.livesLabel.Text = "Lives: -";
            // 
            // masksLabel
            // 
            this.masksLabel.AutoSize = true;
            this.masksLabel.Location = new System.Drawing.Point(6, 55);
            this.masksLabel.Name = "masksLabel";
            this.masksLabel.Size = new System.Drawing.Size(47, 13);
            this.masksLabel.TabIndex = 14;
            this.masksLabel.Text = "Masks: -";
            // 
            // dataBox
            // 
            this.dataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dataBox.Controls.Add(this.DamageMaskformCheckbox);
            this.dataBox.Controls.Add(this.infiniteMasksCheckbox);
            this.dataBox.Controls.Add(this.masksLabel);
            this.dataBox.Controls.Add(this.livesLabel);
            this.dataBox.Controls.Add(this.freezeLivesCheckbox);
            this.dataBox.Controls.Add(this.livesDownButton);
            this.dataBox.Controls.Add(this.livesUpButton);
            this.dataBox.Controls.Add(this.masksUpButton);
            this.dataBox.Controls.Add(this.masksDownButton);
            this.dataBox.Location = new System.Drawing.Point(0, 0);
            this.dataBox.Margin = new System.Windows.Forms.Padding(0);
            this.dataBox.MinimumSize = new System.Drawing.Size(250, 0);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(285, 83);
            this.dataBox.TabIndex = 0;
            this.dataBox.TabStop = false;
            this.dataBox.Text = "Data";
            this.dataBox.EnabledChanged += new System.EventHandler(this.dataBox_EnabledChanged);
            // 
            // infiniteMasksCheckbox
            // 
            this.infiniteMasksCheckbox.AutoSize = true;
            this.infiniteMasksCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infiniteMasksCheckbox.Location = new System.Drawing.Point(125, 47);
            this.infiniteMasksCheckbox.Name = "infiniteMasksCheckbox";
            this.infiniteMasksCheckbox.Size = new System.Drawing.Size(90, 17);
            this.infiniteMasksCheckbox.TabIndex = 15;
            this.infiniteMasksCheckbox.Text = "Infinite masks";
            this.infiniteMasksCheckbox.UseVisualStyleBackColor = true;
            this.infiniteMasksCheckbox.CheckedChanged += new System.EventHandler(this.infiniteMasksCheckbox_CheckedChanged);
            // 
            // DamageMaskformCheckbox
            // 
            this.DamageMaskformCheckbox.AutoSize = true;
            this.DamageMaskformCheckbox.BackColor = System.Drawing.SystemColors.Control;
            this.DamageMaskformCheckbox.Enabled = false;
            this.DamageMaskformCheckbox.Location = new System.Drawing.Point(125, 61);
            this.DamageMaskformCheckbox.Name = "DamageMaskformCheckbox";
            this.DamageMaskformCheckbox.Size = new System.Drawing.Size(115, 17);
            this.DamageMaskformCheckbox.TabIndex = 16;
            this.DamageMaskformCheckbox.Text = "Maskform when hit";
            this.DamageMaskformCheckbox.UseVisualStyleBackColor = false;
            this.DamageMaskformCheckbox.CheckedChanged += new System.EventHandler(this.damageMaskformCheckbox_CheckedChanged);
            this.DamageMaskformCheckbox.EnabledChanged += new System.EventHandler(this.damageMaskformCheckbox_EnabledChanged);
            // 
            // DataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.dataBox);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Name = "DataControl";
            this.Size = new System.Drawing.Size(285, 85);
            this.dataBox.ResumeLayout(false);
            this.dataBox.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button masksDownButton;
        private System.Windows.Forms.Button masksUpButton;
        private System.Windows.Forms.Button livesUpButton;
        private System.Windows.Forms.Button livesDownButton;
        private System.Windows.Forms.CheckBox freezeLivesCheckbox;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label masksLabel;
        private System.Windows.Forms.GroupBox dataBox;
        private System.Windows.Forms.CheckBox infiniteMasksCheckbox;
        private System.Windows.Forms.CheckBox DamageMaskformCheckbox;
    }
}
