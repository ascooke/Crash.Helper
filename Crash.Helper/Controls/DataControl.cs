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
	public partial class DataControl : UserControl
	{
		private CrashMemory memory;

		private int lives;
		private int storedLives = 1;

		public DataControl(CrashMemory memory)
		{
			this.memory = memory;

			memory.Lives.OnValueChange += OnLivesChange;

			InitializeComponent();
		}

		private void OnLivesChange(int oldLives, int newLives)
		{
			if (freezeLivesCheckbox.Checked)
			{
				memory.Lives.Write(storedLives);
			}
			else
			{
				livesLabel.Text = "Lives: " + newLives;
			}
		}

		private void livesUpButton_Click(object sender, EventArgs e)
		{
			lives++;
			memory.Lives.Write(lives);
			RefreshLives();
		}

		private void livesDownButton_Click(object sender, EventArgs e)
		{
			lives--;
			memory.Lives.Write(lives);
			RefreshLives();
		}

		private void freezeLivesCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (freezeLivesCheckbox.Checked)
			{
				FreezeLives();
			}
			else
			{
				storedLives = -1;
				livesLabel.ForeColor = Color.Black;
			}
		}

		private void FreezeLives()
		{
			storedLives = memory.Lives.Read();
			livesLabel.ForeColor = Color.DodgerBlue;
		}

		private void RefreshLives()
		{
			livesDownButton.Enabled = lives > 0;
			livesUpButton.Enabled = lives < 999;
			livesLabel.Text = "Lives: " + lives;

			if (storedLives != -1)
			{
				storedLives = lives;
			}
		}

		private void dataBox_EnabledChanged(object sender, EventArgs e)
		{
			if (Enabled)
			{
				lives = memory.Lives.Read();
				livesLabel.Text = "Lives: " + lives;
				livesDownButton.Enabled = lives > 0;
				livesUpButton.Enabled = lives < 999;

				if (freezeLivesCheckbox.Checked)
				{
					FreezeLives();
				}
			}
		}
	}
}
