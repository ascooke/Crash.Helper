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
		private HelperForm parent;
		private Timer processTimer;

		private int retryTimeRemaining;

		private bool scanning;

		public ProcessControl(CrashMemory memory,DataControl data, HelperForm parent)
		{
			this.memory = memory;
			this.data = data;
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
					processLabel.Text = $"Process not found. Retrying in {retryTimeRemaining}...";
				}
			};
		}

		public void Rescan()
		{
			if (memory.HookProcess())
			{
				processLabel.Text = "Process attached.";
				processLabel.ForeColor = Color.ForestGreen;
				processTimer?.Stop();

				data.Enabled = true;
				parent.RefreshEnabled = true;
				scanning = false;
			}
			else
			{
				retryTimeRemaining = RetryTime;
				processLabel.Text = $"Process not found. Retrying in {RetryTime}...";
				processTimer.Start();
				scanning = true;
			}
		}

		private void helperCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (helperCheckbox.Checked)
			{
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

			bool ready = helperCheckbox.Checked && memory.ProcessHooked;

			data.Enabled = ready;
			parent.RefreshEnabled = ready;
		}
	}
}
