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
			this.dataBox = new System.Windows.Forms.GroupBox();
			this.masksLabel = new System.Windows.Forms.Label();
			this.livesLabel = new System.Windows.Forms.Label();
			this.freezeLivesCheckbox = new System.Windows.Forms.CheckBox();
			this.livesDownButton = new System.Windows.Forms.Button();
			this.livesUpButton = new System.Windows.Forms.Button();
			this.masksUpButton = new System.Windows.Forms.Button();
			this.masksDownButton = new System.Windows.Forms.Button();
			this.dataBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataBox
			// 
			this.dataBox.Controls.Add(this.masksLabel);
			this.dataBox.Controls.Add(this.livesLabel);
			this.dataBox.Controls.Add(this.freezeLivesCheckbox);
			this.dataBox.Controls.Add(this.livesDownButton);
			this.dataBox.Controls.Add(this.livesUpButton);
			this.dataBox.Controls.Add(this.masksUpButton);
			this.dataBox.Controls.Add(this.masksDownButton);
			this.dataBox.Location = new System.Drawing.Point(4, 4);
			this.dataBox.Name = "dataBox";
			this.dataBox.Size = new System.Drawing.Size(295, 187);
			this.dataBox.TabIndex = 0;
			this.dataBox.TabStop = false;
			this.dataBox.Text = "Data";
			// 
			// masksLabel
			// 
			this.masksLabel.AutoSize = true;
			this.masksLabel.Location = new System.Drawing.Point(6, 52);
			this.masksLabel.Name = "masksLabel";
			this.masksLabel.Size = new System.Drawing.Size(53, 13);
			this.masksLabel.TabIndex = 14;
			this.masksLabel.Text = "Masks (2)";
			// 
			// livesLabel
			// 
			this.livesLabel.AutoSize = true;
			this.livesLabel.Location = new System.Drawing.Point(6, 28);
			this.livesLabel.Name = "livesLabel";
			this.livesLabel.Size = new System.Drawing.Size(53, 13);
			this.livesLabel.TabIndex = 13;
			this.livesLabel.Text = "Lives (99)";
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
			// 
			// livesDownButton
			// 
			this.livesDownButton.Image = global::Crash.Helper.Properties.Resources.Subtract;
			this.livesDownButton.Location = new System.Drawing.Point(62, 19);
			this.livesDownButton.Name = "livesDownButton";
			this.livesDownButton.Size = new System.Drawing.Size(28, 28);
			this.livesDownButton.TabIndex = 8;
			this.livesDownButton.UseVisualStyleBackColor = true;
			// 
			// livesUpButton
			// 
			this.livesUpButton.Image = global::Crash.Helper.Properties.Resources.Add;
			this.livesUpButton.Location = new System.Drawing.Point(91, 19);
			this.livesUpButton.Name = "livesUpButton";
			this.livesUpButton.Size = new System.Drawing.Size(28, 28);
			this.livesUpButton.TabIndex = 9;
			this.livesUpButton.UseVisualStyleBackColor = true;
			// 
			// masksUpButton
			// 
			this.masksUpButton.Image = global::Crash.Helper.Properties.Resources.Add;
			this.masksUpButton.Location = new System.Drawing.Point(91, 48);
			this.masksUpButton.Name = "masksUpButton";
			this.masksUpButton.Size = new System.Drawing.Size(28, 28);
			this.masksUpButton.TabIndex = 11;
			this.masksUpButton.UseVisualStyleBackColor = true;
			// 
			// masksDownButton
			// 
			this.masksDownButton.Image = global::Crash.Helper.Properties.Resources.Subtract;
			this.masksDownButton.Location = new System.Drawing.Point(62, 48);
			this.masksDownButton.Name = "masksDownButton";
			this.masksDownButton.Size = new System.Drawing.Size(28, 28);
			this.masksDownButton.TabIndex = 10;
			this.masksDownButton.UseVisualStyleBackColor = true;
			// 
			// DataControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataBox);
			this.Enabled = false;
			this.Name = "DataControl";
			this.Size = new System.Drawing.Size(302, 219);
			this.dataBox.ResumeLayout(false);
			this.dataBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dataBox;
		private System.Windows.Forms.CheckBox freezeLivesCheckbox;
		private System.Windows.Forms.Button livesDownButton;
		private System.Windows.Forms.Button livesUpButton;
		private System.Windows.Forms.Button masksUpButton;
		private System.Windows.Forms.Button masksDownButton;
		private System.Windows.Forms.Label masksLabel;
		private System.Windows.Forms.Label livesLabel;
	}
}
