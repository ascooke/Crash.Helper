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
			this.data = new Crash.Helper.Controls.DataControl();
			this.SuspendLayout();
			// 
			// data
			// 
			this.data.Location = new System.Drawing.Point(13, 13);
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(200, 242);
			this.data.TabIndex = 4;
			// 
			// HelperForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 292);
			this.Controls.Add(this.data);
			this.Name = "HelperForm";
			this.Text = "Crash Helper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelperForm_FormClosing);
			this.ResumeLayout(false);

        }

		#endregion
		private Controls.DataControl data;
	}
}

