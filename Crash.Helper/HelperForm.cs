using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Crash.Helper.Memory;
using Timer = System.Timers.Timer;

namespace Crash.Helper
{
    public partial class HelperForm : Form
	{
		[Flags]
		public enum Modifiers : uint
		{
			Alt = 1,
			Control = 2,
			Shift = 4,
			Win = 8
		}

		// See https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp.
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		private HelperMemory memory;

		public HelperForm()
		{
			InitializeComponent();
	        RegisterHotKey(Handle, 0, (int)Modifiers.Alt, (uint)Keys.D.GetHashCode());
		}

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			if (m.Msg != 0x0312)
			{
				return;
			}

			Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
			Modifiers modifier = (Modifiers)((int)m.LParam & 0xFFFF);
			int id = m.WParam.ToInt32();

			if (id == 0)
			{
				hotkeyLabel.Text = "[Hotkey pressed]";
				memory.SetZeroLives();
			}
		}

		private class KeyPressedEventArgs : EventArgs
	    {
		    public KeyPressedEventArgs(Modifiers modifier, Keys key)
		    {
			    Modifier = modifier;
			    Key = key;
		    }

		    public Modifiers Modifier { get; }
		    public Keys Key { get; }
	    }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(Handle, 0);
		}

		private void HelperForm_Load(object sender, EventArgs e)
		{
		}

		private void HelperForm_VisibleChanged(object sender, EventArgs e)
		{
			memory = new HelperMemory();
			memory.HookProcess();

			if (memory.LivesFound)
			{
				int lives = memory.Lives;

				foundLabel.Text = $"[Address found! ({lives} {(lives == 1 ? "life" : "lives")})]";
			}
		}
	}
}
