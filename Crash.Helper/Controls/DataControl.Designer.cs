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
			this.processLabel = new System.Windows.Forms.Label();
			this.livesLabel = new System.Windows.Forms.Label();
			this.dataBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataBox
			// 
			this.dataBox.Controls.Add(this.livesLabel);
			this.dataBox.Controls.Add(this.processLabel);
			this.dataBox.Location = new System.Drawing.Point(4, 4);
			this.dataBox.Name = "dataBox";
			this.dataBox.Size = new System.Drawing.Size(191, 233);
			this.dataBox.TabIndex = 0;
			this.dataBox.TabStop = false;
			this.dataBox.Text = "Data";
			// 
			// processLabel
			// 
			this.processLabel.AutoSize = true;
			this.processLabel.Location = new System.Drawing.Point(6, 21);
			this.processLabel.Name = "processLabel";
			this.processLabel.Size = new System.Drawing.Size(45, 13);
			this.processLabel.TabIndex = 0;
			this.processLabel.Text = "Process";
			// 
			// livesLabel
			// 
			this.livesLabel.AutoSize = true;
			this.livesLabel.Location = new System.Drawing.Point(6, 38);
			this.livesLabel.Name = "livesLabel";
			this.livesLabel.Size = new System.Drawing.Size(50, 13);
			this.livesLabel.TabIndex = 1;
			this.livesLabel.Text = "Lives: 99";
			// 
			// DataControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataBox);
			this.Name = "DataControl";
			this.Size = new System.Drawing.Size(200, 242);
			this.dataBox.ResumeLayout(false);
			this.dataBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox dataBox;
		private System.Windows.Forms.Label livesLabel;
		private System.Windows.Forms.Label processLabel;
	}
}
