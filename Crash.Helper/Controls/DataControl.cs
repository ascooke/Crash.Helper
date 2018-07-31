﻿using System;
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

        //public void SetMemory(CrashMemory memory)
        //{
        //    this.memory = memory;
        //}

		private void OnLivesChange(int oldLives, int newLives)
		{
			if (freezeLivesCheckbox.Checked)
			{
				memory.Lives.Write(storedLives);
			}
			else
			{
				RefreshLives();
			}
		}

		private void OnMasksChange(int oldMasks, int newMasks)
		{
			RefreshMasks();
		}

		private void livesUpButton_Click(object sender, EventArgs e)
		{
            int currentLives = memory.Lives.Read();
            memory.Lives.Write(currentLives + 1);
		}

		private void livesDownButton_Click(object sender, EventArgs e)
        {
            int currentLives = memory.Lives.Read();
            memory.Lives.Write(currentLives - 1);
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

		private void masksUpButton_Click(object sender, EventArgs e)
        {
            int currentMasks = memory.Masks.Read();
            memory.Masks.Write(currentMasks + 1);
		}

		private void masksDownButton_Click(object sender, EventArgs e)
        {
            int currentMasks = memory.Masks.Read();
            memory.Masks.Write(currentMasks - 1);
		}

		private void FreezeLives()
		{
			storedLives = memory.Lives.Read();
			livesLabel.ForeColor = Color.DodgerBlue;
		}

		private void RefreshLives()
		{
            int lives = memory.Lives.Read();
			livesDownButton.Enabled = lives > 0;
			livesUpButton.Enabled = lives < 999;
			livesLabel.Text = "Lives: " + lives;

			if (storedLives != -1)
			{
				storedLives = lives;
			}
		}

		private void RefreshMasks()
        {
            int masks = memory.Masks.Read();
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
			}
		}
    }
}
