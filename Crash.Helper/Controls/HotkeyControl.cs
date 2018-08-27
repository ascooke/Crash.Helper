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

        public HotkeyControl(CrashMemory memory, DataControl data)
        {
            this.memory = memory;
	        this.data = data;

	        hotkeys = new []
	        {
		        new Hotkey("Set zero lives: ", KeyModifiers.Alt, (uint)Keys.D, () =>
		        {
			        memory.Lives.Write(0);
			        data.Lives = 0;
		        })
	        };

            InitializeComponent();
	        RegisterHotkeys();

	        labels = new []
	        {
				zeroLivesLabel,
				zeroLivesHotkeyLabel
	        };

	        zeroLivesHotkeyLabel.Text = hotkeys[0].ToString();
	        zeroLivesHotkeyLabel.ForeColor = Color.ForestGreen;
        }

	    public void RegisterHotkeys()
	    {
		    foreach (Hotkey hotkey in hotkeys)
		    {
			    RegisterHotKey(Handle, 0, (uint)hotkey.Modifier, hotkey.Key);
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
    }
}
