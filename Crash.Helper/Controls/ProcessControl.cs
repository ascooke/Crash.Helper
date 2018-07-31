using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crash.Helper.Memory;

namespace Crash.Helper.Controls
{
	public partial class ProcessControl : UserControl
	{
		private const int RetryTime = 10;

		private CrashMemory memory;
		private DataControl data;
        private HotkeyControl hotkey;
		private HelperForm parent;
		private Timer processTimer;

		private int retryTimeRemaining;
		private bool scanning;
		private string filler;

		public ProcessControl(CrashMemory memory, DataControl data, HotkeyControl hotkey, HelperForm parent)
		{
			this.memory = memory;
			this.data = data;
            this.hotkey = hotkey;
			this.parent = parent;

			InitializeComponent();

			processTimer = new Timer();
			processTimer.Interval = 1000;
			processTimer.Tick += (sender, e) =>
			{
				retryTimeRemaining--;

				if (retryTimeRemaining == 0)
				{
					Rescan();
				}
				else
				{
					processLabel.Text = $"Process {filler}. Retrying in {retryTimeRemaining}...";
				}
			};

			filler = "not found";
		}

		public void Rescan(bool skipFirstCheck = false)
		{
			if (!skipFirstCheck && memory.HookProcess())
			{
				processLabel.Text = "Process attached.";
				processLabel.ForeColor = Color.ForestGreen;
				processTimer?.Stop();

				data.Enabled = true;
                hotkey.Enabled = true;
				parent.RefreshEnabled = true;
				scanning = false;
			}
			else
			{
				retryTimeRemaining = RetryTime;
				processLabel.Text = $"Process {filler}. Retrying in {RetryTime}...";
				processTimer.Start();
				scanning = true;
			}
		}

		public void OnUnhook()
		{
			filler = "lost";
			processLabel.ForeColor = SystemColors.ControlDarkDark;
			Rescan(true);
		}

		private void helperCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (helperCheckbox.Checked)
			{
				filler = "not found";
				Rescan();
			}
			else
			{
				processLabel.Text = "Helper is disabled.";
				processLabel.ForeColor = SystemColors.ControlDarkDark;

				if (scanning)
				{
					processTimer.Stop();
					scanning = false;
				}
			}

			bool isReady = helperCheckbox.Checked && memory.ProcessHooked;

			data.Enabled = isReady;
            hotkey.Enabled = isReady;
			parent.RefreshEnabled = isReady;
		}
	}
}
