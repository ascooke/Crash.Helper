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
            this.components = new System.ComponentModel.Container();
            this.zeroLivesLabel = new System.Windows.Forms.Label();
            this.hotkeyBox = new System.Windows.Forms.GroupBox();
            this.giveMaskHotkeyTextbox = new System.Windows.Forms.TextBox();
            this.zeroLivesHotkeyTextbox = new System.Windows.Forms.TextBox();
            this.giveMaskHotkeyLabel = new System.Windows.Forms.Label();
            this.giveMaskLabel = new System.Windows.Forms.Label();
            this.zeroLivesHotkeyLabel = new System.Windows.Forms.Label();
            this.enabledCheckbox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.hotkeyBox.Controls.Add(this.giveMaskHotkeyTextbox);
            this.hotkeyBox.Controls.Add(this.zeroLivesHotkeyTextbox);
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
            // giveMaskHotkeyTextbox
            // 
            this.giveMaskHotkeyTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.giveMaskHotkeyTextbox.Location = new System.Drawing.Point(97, 59);
            this.giveMaskHotkeyTextbox.MaxLength = 1;
            this.giveMaskHotkeyTextbox.Name = "giveMaskHotkeyTextbox";
            this.giveMaskHotkeyTextbox.ShortcutsEnabled = false;
            this.giveMaskHotkeyTextbox.Size = new System.Drawing.Size(20, 20);
            this.giveMaskHotkeyTextbox.TabIndex = 7;
            this.giveMaskHotkeyTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.giveMaskHotkeyTextbox.Visible = false;
            this.giveMaskHotkeyTextbox.TextChanged += new System.EventHandler(this.hotkeyTextboxChanged);
            // 
            // zeroLivesHotkeyTextbox
            // 
            this.zeroLivesHotkeyTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.zeroLivesHotkeyTextbox.Location = new System.Drawing.Point(97, 40);
            this.zeroLivesHotkeyTextbox.MaxLength = 1;
            this.zeroLivesHotkeyTextbox.Name = "zeroLivesHotkeyTextbox";
            this.zeroLivesHotkeyTextbox.ShortcutsEnabled = false;
            this.zeroLivesHotkeyTextbox.Size = new System.Drawing.Size(20, 20);
            this.zeroLivesHotkeyTextbox.TabIndex = 6;
            this.zeroLivesHotkeyTextbox.Visible = false;
            this.zeroLivesHotkeyTextbox.TextChanged += new System.EventHandler(this.hotkeyTextboxChanged);
            // 
            // giveMaskHotkeyLabel
            // 
            this.giveMaskHotkeyLabel.AutoSize = true;
            this.giveMaskHotkeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.giveMaskHotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giveMaskHotkeyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giveMaskHotkeyLabel.Location = new System.Drawing.Point(97, 62);
            this.giveMaskHotkeyLabel.Name = "giveMaskHotkeyLabel";
            this.giveMaskHotkeyLabel.Size = new System.Drawing.Size(43, 15);
            this.giveMaskHotkeyLabel.TabIndex = 5;
            this.giveMaskHotkeyLabel.Text = "Hotkey";
            this.giveMaskHotkeyLabel.Click += new System.EventHandler(this.hotkeyLabelClicked);
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
            // zeroLivesHotkeyLabel
            // 
            this.zeroLivesHotkeyLabel.AutoSize = true;
            this.zeroLivesHotkeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.zeroLivesHotkeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroLivesHotkeyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zeroLivesHotkeyLabel.Location = new System.Drawing.Point(97, 43);
            this.zeroLivesHotkeyLabel.Name = "zeroLivesHotkeyLabel";
            this.zeroLivesHotkeyLabel.Size = new System.Drawing.Size(43, 15);
            this.zeroLivesHotkeyLabel.TabIndex = 3;
            this.zeroLivesHotkeyLabel.Text = "Hotkey";
            this.zeroLivesHotkeyLabel.Click += new System.EventHandler(this.hotkeyLabelClicked);
            // 
            // enabledCheckbox
            // 
            this.enabledCheckbox.AutoSize = true;
            this.enabledCheckbox.Checked = true;
            this.enabledCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckbox.Location = new System.Drawing.Point(10, 16);
            this.enabledCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.enabledCheckbox.Name = "enabledCheckbox";
            this.enabledCheckbox.Size = new System.Drawing.Size(106, 17);
            this.enabledCheckbox.TabIndex = 2;
            this.enabledCheckbox.Text = "Hotkeys enabled";
            this.enabledCheckbox.UseVisualStyleBackColor = true;
            this.enabledCheckbox.CheckedChanged += new System.EventHandler(this.enabledCheckbox_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
        private System.Windows.Forms.TextBox giveMaskHotkeyTextbox;
        private System.Windows.Forms.TextBox zeroLivesHotkeyTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
