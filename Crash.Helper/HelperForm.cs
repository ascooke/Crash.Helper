using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Crash.Helper.Controls;
using Crash.Helper.Memory;
using Timer = System.Windows.Forms.Timer;

namespace Crash.Helper
{
	public partial class HelperForm : Form
	{
		[Flags]
		public enum KeyModifiers
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

		private CrashMemory memory;
		private SettingsControl settings;
		private Timer refreshTimer;

		public HelperForm()
		{
			InitializeComponent();

			memory = new CrashMemory();
			memory.HookProcess();
			memory.Lives.OnValueChange += OnLivesChanged;

			settings = new SettingsControl(memory, data)
			{
				Location = new Point(data.Bounds.Right + 6, data.Bounds.Top)
			};

			Controls.Add(settings);

			refreshTimer = new Timer();
			refreshTimer.Interval = (int)(1000f / 30);
			refreshTimer.Tick += (sender, e) =>
			{
				memory.Refresh();
			};

			refreshTimer.Start();

			RegisterHotKey(Handle, 0, (uint)KeyModifiers.Alt, (uint)Keys.D.GetHashCode());
		}

		private void OnLivesChanged(int oldLives, int newLives)
		{
			if (settings.UnlimitedLives)
			{
				memory.Lives.Write(oldLives);
			}
			else
			{
				data.Lives = newLives.ToString();
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

			if (id == 0)
			{
				memory.Lives.Write(0);
			}
		}

		private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(Handle, 0);
		}
	}
}
