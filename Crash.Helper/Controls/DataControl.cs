﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crash.Helper.Controls
{
	public partial class DataControl : UserControl
	{
		public DataControl()
		{
			InitializeComponent();
		}

		public int Lives
		{
			set => livesLabel.Text = "Lives: " + (value == -1 ? "Unlimited" : value.ToString());
		}
	}
}
