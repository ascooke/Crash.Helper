using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crash.Helper.Controls;
using Crash.Helper.Memory;

namespace Crash.Helper
{
	public partial class HelperForm : Form
	{
		private const int Framerate = 10;

		// See https://stackoverflow.com/questions/2450373/set-global-hotkeys-using-c-sharp.
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		private CrashMemory memory;
		private DataControl dataControl;
		private ProcessControl processControl;
		private List<Hotkey> hotkeys;
		private Timer refreshTimer;

		public HelperForm()
		{
			InitializeComponent();

			memory = new CrashMemory();

			dataControl = new DataControl(memory);
			processControl = new ProcessControl(memory, dataControl, this);
			processControl.Location = new Point(7, 7);
			dataControl.Location = new Point(7, processControl.Bounds.Bottom + 2);

			Controls.Add(processControl);
			Controls.Add(dataControl);

			refreshTimer = new Timer();
			refreshTimer.Interval = (int)(1000f / Framerate);
			refreshTimer.Tick += (sender, e) =>
			{
				memory.Refresh();
			};

			processControl.Rescan();

			hotkeys = new List<Hotkey>();
			hotkeys.Add(new Hotkey("Set zero lives: ", () =>
			{
				memory.Lives.Write(0);
			}));

			RegisterHotKey(Handle, 0, (uint)KeyModifiers.Alt, (uint)Keys.D.GetHashCode());
		}

		public bool RefreshEnabled
		{
			set
			{
				if (value)
				{
					refreshTimer.Start();
				}
				else
				{
					refreshTimer.Stop();
				}
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

		private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			UnregisterHotKey(Handle, 0);
		}
	}
}
