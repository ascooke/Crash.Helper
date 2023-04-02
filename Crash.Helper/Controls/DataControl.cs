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

		private int storedLives = 1;

		public DataControl(CrashMemory memory)
		{
			this.memory = memory;

			memory.Lives.OnValueChange += OnLivesChange;
			memory.Masks.OnValueChange += OnMasksChange;

			InitializeComponent();
        }

        public DataControl()
        {
            InitializeComponent();
        }

		public int Lives
		{
			set => RefreshLives(value);
		}

		public int Masks
		{
			set => RefreshMasks(value);
		}

		private void OnLivesChange(int oldLives, int newLives)
		{
			if (freezeLivesCheckbox.Checked)
			{
				memory.Lives.Write(storedLives);
				RefreshMasks(2);
			}
			else
			{
				RefreshLives();
			}
		}

		private void OnMasksChange(int oldMasks, int newMasks)
		{
			if (freezeMasksCheckbox.Checked)
			{
				FreezeMasks();
			} 
			else
			{
				RefreshMasks();
			}
		}

		private void livesUpButton_Click(object sender, EventArgs e)
		{
			int newLives = memory.Lives.Read() + 1;

            memory.Lives.Write(newLives);
			RefreshLives(newLives);
		}

		private void livesDownButton_Click(object sender, EventArgs e)
		{
			int newLives = memory.Lives.Read() - 1;

            memory.Lives.Write(newLives);
			RefreshLives(newLives);
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

        private void freezeMasksCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (freezeMasksCheckbox.Checked)
            {
                FreezeMasks();
            }
            else
            {
                masksLabel.ForeColor = Color.Black;
            }
        }

        private void masksUpButton_Click(object sender, EventArgs e)
		{
			int newMasks = memory.Masks.Read() + 1;

            memory.Masks.Write(newMasks);
			RefreshMasks(newMasks);
		}

		private void masksDownButton_Click(object sender, EventArgs e)
		{
			int newMasks = memory.Masks.Read() - 1;

			memory.Masks.Write(newMasks);
			RefreshMasks(newMasks);
		}

		private void FreezeLives()
		{
			storedLives = memory.Lives.Read();
			livesLabel.ForeColor = Color.DodgerBlue;
		}

		private void FreezeMasks()
		{
			if (memory.Masks.Read() != 0)
			{
                memory.Masks.Write(2);
                RefreshMasks(2);
                masksLabel.ForeColor = Color.DodgerBlue;
            }
		}

		private void RefreshLives(int newLives = -1)
		{
            int lives = newLives != -1 ? newLives : memory.Lives.Read();

			livesDownButton.Enabled = lives > 0;
			livesUpButton.Enabled = lives < 999;
			livesLabel.Text = "Lives: " + lives;

			if (storedLives != -1)
			{
				storedLives = lives;
			}
		}

		private void RefreshMasks(int newMasks = -1)
        {
            int masks = newMasks != -1 ? newMasks : memory.Masks.Read();

            masksLabel.Text = "Masks: " + masks;
			masksDownButton.Enabled = masks > 0;
			masksUpButton.Enabled = masks < 2;
		}

		private void dataBox_EnabledChanged(object sender, EventArgs e)
		{
			if (Enabled)
			{
				RefreshLives();
				RefreshMasks();

				if (freezeLivesCheckbox.Checked)
				{
					FreezeLives();
				}
				if (freezeMasksCheckbox.Checked)
				{
					FreezeMasks();
				}
			}
		}
    }
}
