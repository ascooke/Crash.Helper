namespace Crash.Helper.Controls
{
    partial class HotkeyControl
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
            this.zeroLivesDescription = new System.Windows.Forms.Label();
            this.zeroLivesHotkeyLabel = new System.Windows.Forms.Label();
            this.hotkeyBox = new System.Windows.Forms.GroupBox();
            this.enableCheckBox = new System.Windows.Forms.CheckBox();
            this.hotkeyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroLivesDescription
            // 
            this.zeroLivesDescription.AutoSize = true;
            this.zeroLivesDescription.Location = new System.Drawing.Point(7, 37);
            this.zeroLivesDescription.Name = "zeroLivesDescription";
            this.zeroLivesDescription.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.zeroLivesDescription.Size = new System.Drawing.Size(211, 13);
            this.zeroLivesDescription.TabIndex = 1;
            this.zeroLivesDescription.Text = "Does not override \"Freeze Lives\" setting.";
            // 
            // zeroLivesHotkeyLabel
            // 
            this.zeroLivesHotkeyLabel.AutoSize = true;
            this.zeroLivesHotkeyLabel.Location = new System.Drawing.Point(7, 20);
            this.zeroLivesHotkeyLabel.Name = "zeroLivesHotkeyLabel";
            this.zeroLivesHotkeyLabel.Size = new System.Drawing.Size(114, 13);
            this.zeroLivesHotkeyLabel.TabIndex = 0;
            this.zeroLivesHotkeyLabel.Text = "Set lives to zero: Alt+D";
            // 
            // hotkeyBox
            // 
            this.hotkeyBox.Controls.Add(this.zeroLivesDescription);
            this.hotkeyBox.Controls.Add(this.zeroLivesHotkeyLabel);
            this.hotkeyBox.Location = new System.Drawing.Point(4, 25);
            this.hotkeyBox.Name = "hotkeyBox";
            this.hotkeyBox.Size = new System.Drawing.Size(295, 187);
            this.hotkeyBox.TabIndex = 0;
            this.hotkeyBox.TabStop = false;
            this.hotkeyBox.Text = "Hotkeys";
            // 
            // enableCheckBox
            // 
            this.enableCheckBox.AutoSize = true;
            this.enableCheckBox.Checked = true;
            this.enableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckBox.Location = new System.Drawing.Point(4, 3);
            this.enableCheckBox.Name = "enableCheckBox";
            this.enableCheckBox.Size = new System.Drawing.Size(99, 17);
            this.enableCheckBox.TabIndex = 2;
            this.enableCheckBox.Text = "Enable hotkeys";
            this.enableCheckBox.UseVisualStyleBackColor = true;
            this.enableCheckBox.CheckedChanged += new System.EventHandler(this.enableCheckBox_CheckedChanged);
            // 
            // HotkeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.enableCheckBox);
            this.Controls.Add(this.hotkeyBox);
            this.Enabled = false;
            this.Name = "HotkeyControl";
            this.Size = new System.Drawing.Size(302, 215);
            this.hotkeyBox.ResumeLayout(false);
            this.hotkeyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hotkeyBox;
        private System.Windows.Forms.CheckBox enableCheckBox;
        private System.Windows.Forms.Label zeroLivesHotkeyLabel;
        private System.Windows.Forms.Label zeroLivesDescription;
    }
}
