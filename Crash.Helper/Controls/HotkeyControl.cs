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
        private List<Hotkey> hotkeys;

        public HotkeyControl(CrashMemory memory)
        {
            this.memory = memory;
            InitializeHotKeys();
            RegisterHotKeys();

            InitializeComponent();
        }

        public HotkeyControl()
        {
            InitializeComponent();
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

        private void InitializeHotKeys()
        {
            // TODO: Add ability to grab hotkey shortcuts from user settings
            hotkeys = new List<Hotkey>
            {
                new Hotkey("Set zero lives: ", KeyModifiers.Alt, (uint)Keys.D.GetHashCode(), () =>
                {
                    memory.Lives.Write(0);
                })
            };
        }

        public void RegisterHotKeys()
        {
            for (int i = 0; i < hotkeys.Count; i++)
            {
                RegisterHotKey(Handle, 0, (uint)hotkeys[i].Modifier, hotkeys[i].Key);
            }
        }

        public void UnregisterHotKeys()
        {
            for(int i = 0; i < hotkeys.Count; i++)
            {
                UnregisterHotKey(Handle, i);
            }
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // This is slightly more explicit than it needs to be, but it
            // protects against any unexpected race conditions
            if (hotkeyBox.Enabled && !enableCheckBox.Checked)
            {
                UnregisterHotKeys();
            }
            else if (!hotkeyBox.Enabled && enableCheckBox.Checked)
            {
                RegisterHotKeys();
            }

            hotkeyBox.Enabled = enableCheckBox.Checked;
        }
    }
}
