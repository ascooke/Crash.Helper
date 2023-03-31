using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crash.Helper.Memory;

namespace Crash.Helper.Controls
{
    public partial class HotkeyControl : UserControl
    {
        // See https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp.
        [DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private CrashMemory memory;
        private DataControl data;
        private Hotkey[] hotkeys;
	    private Label[] labels;
		private Label[] hotkeyLabels;
		private TextBox[] textboxes;

        public HotkeyControl(CrashMemory memory, DataControl data)
        {
            this.memory = memory;
	        this.data = data;

	        hotkeys = new []
	        {
		        new Hotkey("Set zero lives: ", 0, (uint)Keys.O, () =>
		        {
			        memory.Lives.Write(0);
					data.Lives = 0;
		        }),
				new Hotkey("Give one mask: ", 0, (uint)Keys.P,() =>
				{
					int masks = memory.Masks.Read() + 1;
					if(masks > 2) return;
					memory.Masks.Write(masks);
					data.Masks = masks;
				})
	        };

            InitializeComponent();
	        RegisterHotkeys();

			//Keep these ordered
	        labels = new []
	        {
				zeroLivesLabel,
				giveMaskLabel
	        };

			hotkeyLabels = new[]
			{
				zeroLivesHotkeyLabel,
				giveMaskHotkeyLabel
			};

			textboxes = new []
			{
				zeroLivesHotkeyTextbox,
				giveMaskHotkeyTextbox
			};
			
	        zeroLivesHotkeyLabel.Text = hotkeys[0].ToString();
	        zeroLivesHotkeyLabel.ForeColor = Color.ForestGreen;
			giveMaskHotkeyLabel.Text = hotkeys[1].ToString();
			giveMaskHotkeyLabel.ForeColor = Color.ForestGreen;
        }

	    public void RegisterHotkeys()
	    {
			int keyCount = 0;
		    foreach (Hotkey hotkey in hotkeys)
		    {
				RegisterHotKey(Handle, keyCount++, (uint)hotkey.Modifier, hotkey.Key);
		    }
		}

	    public void UnregisterHotkeys()
	    {
		    for (int i = 0; i < hotkeys.Length; i++)
		    {
			    UnregisterHotKey(Handle, i);
		    }
	    }

		protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg != 0x0312)
            {
                return;
            }

            Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
            KeyModifiers modifier = (KeyModifiers)((int)m.LParam & 0xFFFF);

            int id = m.WParam.ToInt32();

            hotkeys[id].Callback();
        }

        private void enabledCheckbox_CheckedChanged(object sender, EventArgs e)
        {
	        if (enabledCheckbox.Checked)
	        {
		        RegisterHotkeys();
	        }
			else if (!enabledCheckbox.Checked)
			{
				UnregisterHotkeys();
			}

			foreach (Label label in labels)
			{
				label.Enabled = enabledCheckbox.Checked;
			}
        }

		private void hotkeyLabelClicked(object sender, EventArgs e)
		{
			int j;
			for (int i = 0; i < textboxes.Length; i++)
			{
				textboxes[i].Visible = false;
			}
			for (j = 0; hotkeyLabels[j] != (Label) sender; j++){ }
			textboxes[j].Visible = true;
			textboxes[j].Focus();
		}

        private void hotkeyTextbox_TextChanged(object sender, EventArgs e)
        {
			TextBox changedTextBox = (TextBox)sender;
			if(changedTextBox.Text == "")
			{
				changedTextBox.Visible = false;
				return;
			}

			char newHotkey = char.ToUpper(changedTextBox.Text[0]);

			int i;
            for (i = 0; textboxes[i] != changedTextBox; i++) { }
            
			hotkeys[i].Key = newHotkey;
			UnregisterHotkeys();
			RegisterHotkeys();

			hotkeyLabels[i].Text = ((char) hotkeys[i].Key).ToString();
			textboxes[i].Visible = false;
			textboxes[i].Text = "";
        }
    }
}
