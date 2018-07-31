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

		private CrashMemory memory;
		private DataControl dataControl;
        private HotkeyControl hotkeyControl;
		private ProcessControl processControl;
		private Timer refreshTimer;

		public HelperForm()
		{
			InitializeComponent();

			memory = new CrashMemory();

            dataControl = new DataControl(memory);
            hotkeyControl = new HotkeyControl(memory);
            processControl = new ProcessControl(memory, dataControl, hotkeyControl, this)
            {
                Location = new Point(0, 0)
            };
			dataControl.Location = new Point(0, processControl.Bounds.Bottom);
            hotkeyControl.Location = new Point(0, dataControl.Bounds.Bottom);

			flowLayoutPanel.Controls.Add(processControl);
			flowLayoutPanel.Controls.Add(dataControl);
            flowLayoutPanel.Controls.Add(hotkeyControl);

			refreshTimer = new Timer
            {
                Interval = (int)(1000f / Framerate),
            };
            refreshTimer.Tick += (sender, e) => { RefreshHelper(); };


            processControl.Rescan();
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

		private void RefreshHelper()
		{
			if (!memory.HookProcess())
			{
				refreshTimer.Stop();
				processControl.OnUnhook();
				dataControl.Enabled = false;
                hotkeyControl.Enabled = false;

				return;
			}

			memory.Refresh();
		}

		private void HelperForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			hotkeyControl.UnregisterHotKeys();
		}
	}
}
