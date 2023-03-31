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
            this.zeroLivesLabel = new System.Windows.Forms.Label();
            this.hotkeyBox = new System.Windows.Forms.GroupBox();
            this.zeroLivesHotkeyLabel = new System.Windows.Forms.Label();
            this.enabledCheckbox = new System.Windows.Forms.CheckBox();
            this.giveMaskLabel = new System.Windows.Forms.Label();
            this.giveMaskHotkeyLabel = new System.Windows.Forms.Label();
            this.hotkeyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // zeroLivesLabel
            // 
            this.zeroLivesLabel.AutoSize = true;
            this.zeroLivesLabel.Location = new System.Drawing.Point(7, 43);
            this.zeroLivesLabel.Name = "zeroLivesLabel";
            this.zeroLivesLabel.Size = new System.Drawing.Size(94, 13);
            this.zeroLivesLabel.TabIndex = 0;
            this.zeroLivesLabel.Text = "• Set lives to zero:";
            // 
            // hotkeyBox
            // 
            this.hotkeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hotkeyBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hotkeyBox.Controls.Add(this.giveMaskHotkeyLabel);
            this.hotkeyBox.Controls.Add(this.giveMaskLabel);
            this.hotkeyBox.Controls.Add(this.zeroLivesHotkeyLabel);
            this.hotkeyBox.Controls.Add(this.enabledCheckbox);
            this.hotkeyBox.Controls.Add(this.zeroLivesLabel);
            this.hotkeyBox.Location = new System.Drawing.Point(0, 0);
            this.hotkeyBox.Margin = new System.Windows.Forms.Padding(0);
            this.hotkeyBox.MinimumSize = new System.Drawing.Size(250, 0);
            this.hotkeyBox.Name = "hotkeyBox";
            this.hotkeyBox.Size = new System.Drawing.Size(285, 81);
            this.hotkeyBox.TabIndex = 0;
            this.hotkeyBox.TabStop = false;
            this.hotkeyBox.Text = "Hotkeys";
            // 
            // zeroLivesHotkeyLabel
            // 
            this.zeroLivesHotkeyLabel.AutoSize = true;
            this.zeroLivesHotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroLivesHotkeyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zeroLivesHotkeyLabel.Location = new System.Drawing.Point(97, 43);
            this.zeroLivesHotkeyLabel.Name = "zeroLivesHotkeyLabel";
            this.zeroLivesHotkeyLabel.Size = new System.Drawing.Size(41, 13);
            this.zeroLivesHotkeyLabel.TabIndex = 3;
            this.zeroLivesHotkeyLabel.Text = "Hotkey";
            // 
            // enabledCheckbox
            // 
            this.enabledCheckbox.AutoSize = true;
            this.enabledCheckbox.Checked = true;
            this.enabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckbox.Location = new System.Drawing.Point(7, 20);
            this.enabledCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.enabledCheckbox.Name = "enabledCheckbox";
            this.enabledCheckbox.Size = new System.Drawing.Size(106, 17);
            this.enabledCheckbox.TabIndex = 2;
            this.enabledCheckbox.Text = "Hotkeys enabled";
            this.enabledCheckbox.UseVisualStyleBackColor = true;
            this.enabledCheckbox.CheckedChanged += new System.EventHandler(this.enabledCheckbox_CheckedChanged);
            // 
            // giveMaskLabel
            // 
            this.giveMaskLabel.AutoSize = true;
            this.giveMaskLabel.Location = new System.Drawing.Point(7, 61);
            this.giveMaskLabel.Name = "giveMaskLabel";
            this.giveMaskLabel.Size = new System.Drawing.Size(90, 13);
            this.giveMaskLabel.TabIndex = 4;
            this.giveMaskLabel.Text = "• Give one mask:";
            // 
            // giveMaskHotkeyLabel
            // 
            this.giveMaskHotkeyLabel.AutoSize = true;
            this.giveMaskHotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveMaskHotkeyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giveMaskHotkeyLabel.Location = new System.Drawing.Point(97, 62);
            this.giveMaskHotkeyLabel.Name = "giveMaskHotkeyLabel";
            this.giveMaskHotkeyLabel.Size = new System.Drawing.Size(41, 13);
            this.giveMaskHotkeyLabel.TabIndex = 5;
            this.giveMaskHotkeyLabel.Text = "Hotkey";
            // 
            // HotkeyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.hotkeyBox);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Name = "HotkeyControl";
            this.Size = new System.Drawing.Size(285, 81);
            this.hotkeyBox.ResumeLayout(false);
            this.hotkeyBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox hotkeyBox;
        private System.Windows.Forms.CheckBox enabledCheckbox;
        private System.Windows.Forms.Label zeroLivesLabel;
		private System.Windows.Forms.Label zeroLivesHotkeyLabel;
        private System.Windows.Forms.Label giveMaskHotkeyLabel;
        private System.Windows.Forms.Label giveMaskLabel;
    }
}
