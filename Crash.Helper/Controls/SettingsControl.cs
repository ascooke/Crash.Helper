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
	public partial class SettingsControl : UserControl
	{
		private CrashMemory memory;
		private DataControl data;

		private int actualLives = -1;

		public SettingsControl(CrashMemory memory, DataControl data)
		{
			this.memory = memory;
			this.data = data;

			InitializeComponent();
		}

		public bool UnlimitedLives => unlimitedLivesCheckbox.Checked;

		private void unlimitedLivesCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (unlimitedLivesCheckbox.Checked)
			{
				actualLives = memory.Lives.Read();
				data.Lives = -1;

				if (actualLives == 0)
				{
					// If actual lives are zero, then dying would game over and there wouldn't be a chance to correct lives back to
					// their original value.
					memory.Lives.Write(1);
				}
			}
			else
			{
				data.Lives = actualLives;
				actualLives = -1;
			}
		}
	}
}
