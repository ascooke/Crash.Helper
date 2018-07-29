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

		public DataControl(CrashMemory memory)
		{
			this.memory = memory;

			InitializeComponent();
		}

		public void Refresh()
		{
		}
	}
}
