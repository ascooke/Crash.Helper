namespace Crash.Helper
{
    partial class HelperForm
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
            this.foundLabel = new System.Windows.Forms.Label();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foundLabel
            // 
            this.foundLabel.AutoSize = true;
            this.foundLabel.Location = new System.Drawing.Point(13, 13);
            this.foundLabel.Name = "foundLabel";
            this.foundLabel.Size = new System.Drawing.Size(99, 13);
            this.foundLabel.TabIndex = 0;
            this.foundLabel.Text = "[Address not found]";
            this.foundLabel.Click += new System.EventHandler(this.foundLabel_Click);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(13, 30);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(108, 13);
            this.hotkeyLabel.TabIndex = 1;
            this.hotkeyLabel.Text = "Listening for hotkey...";
            this.hotkeyLabel.Click += new System.EventHandler(this.hotkeyLabel_Click);
            // 
            // HelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 185);
            this.Controls.Add(this.hotkeyLabel);
            this.Controls.Add(this.foundLabel);
            this.Name = "HelperForm";
            this.Text = "Crash Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.HelperForm_Load);
            this.VisibleChanged += new System.EventHandler(this.HelperForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label foundLabel;
		private System.Windows.Forms.Label hotkeyLabel;
	}
}

