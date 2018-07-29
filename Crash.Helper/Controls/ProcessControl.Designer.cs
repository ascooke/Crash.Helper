namespace Crash.Helper.Controls
{
	partial class ProcessControl
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
			this.processBox = new System.Windows.Forms.GroupBox();
			this.helperCheckbox = new System.Windows.Forms.CheckBox();
			this.processLabel = new System.Windows.Forms.Label();
			this.processBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// processBox
			// 
			this.processBox.Controls.Add(this.helperCheckbox);
			this.processBox.Controls.Add(this.processLabel);
			this.processBox.Location = new System.Drawing.Point(4, 4);
			this.processBox.Name = "processBox";
			this.processBox.Size = new System.Drawing.Size(295, 42);
			this.processBox.TabIndex = 0;
			this.processBox.TabStop = false;
			this.processBox.Text = "Process";
			// 
			// helperCheckbox
			// 
			this.helperCheckbox.AutoSize = true;
			this.helperCheckbox.Checked = true;
			this.helperCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.helperCheckbox.Location = new System.Drawing.Point(7, 20);
			this.helperCheckbox.Name = "helperCheckbox";
			this.helperCheckbox.Size = new System.Drawing.Size(98, 17);
			this.helperCheckbox.TabIndex = 1;
			this.helperCheckbox.Text = "Helper enabled";
			this.helperCheckbox.UseVisualStyleBackColor = true;
			this.helperCheckbox.CheckedChanged += new System.EventHandler(this.helperCheckbox_CheckedChanged);
			// 
			// processLabel
			// 
			this.processLabel.AutoSize = true;
			this.processLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.processLabel.Location = new System.Drawing.Point(107, 21);
			this.processLabel.Name = "processLabel";
			this.processLabel.Size = new System.Drawing.Size(51, 13);
			this.processLabel.TabIndex = 0;
			this.processLabel.Text = "[Process]";
			// 
			// ProcessControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.processBox);
			this.Name = "ProcessControl";
			this.Size = new System.Drawing.Size(302, 48);
			this.processBox.ResumeLayout(false);
			this.processBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox processBox;
		private System.Windows.Forms.CheckBox helperCheckbox;
		private System.Windows.Forms.Label processLabel;
	}
}
