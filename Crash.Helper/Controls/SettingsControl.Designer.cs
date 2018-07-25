namespace Crash.Helper.Controls
{
	partial class SettingsControl
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
			this.settingsBox = new System.Windows.Forms.GroupBox();
			this.unlimitedLivesCheckbox = new System.Windows.Forms.CheckBox();
			this.settingsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// settingsBox
			// 
			this.settingsBox.Controls.Add(this.unlimitedLivesCheckbox);
			this.settingsBox.Location = new System.Drawing.Point(4, 4);
			this.settingsBox.Name = "settingsBox";
			this.settingsBox.Size = new System.Drawing.Size(230, 263);
			this.settingsBox.TabIndex = 0;
			this.settingsBox.TabStop = false;
			this.settingsBox.Text = "Settings";
			// 
			// unlimitedLivesCheckbox
			// 
			this.unlimitedLivesCheckbox.AutoSize = true;
			this.unlimitedLivesCheckbox.Location = new System.Drawing.Point(7, 20);
			this.unlimitedLivesCheckbox.Name = "unlimitedLivesCheckbox";
			this.unlimitedLivesCheckbox.Size = new System.Drawing.Size(93, 17);
			this.unlimitedLivesCheckbox.TabIndex = 0;
			this.unlimitedLivesCheckbox.Text = "Unlimited lives";
			this.unlimitedLivesCheckbox.UseVisualStyleBackColor = true;
			this.unlimitedLivesCheckbox.CheckedChanged += new System.EventHandler(this.unlimitedLivesCheckbox_CheckedChanged);
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.settingsBox);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(279, 313);
			this.settingsBox.ResumeLayout(false);
			this.settingsBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox settingsBox;
		private System.Windows.Forms.CheckBox unlimitedLivesCheckbox;
	}
}
