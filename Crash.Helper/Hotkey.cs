using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crash.Helper.Controls;
using Crash.Helper.Memory;

namespace Crash.Helper
{
	[Flags]
	public enum KeyModifiers
	{
		None = 0,
		Alt = 1,
		Control = 2,
		Shift = 4,
		Win = 8
	}

	public class Hotkey
	{
		public Hotkey(string label, Action callback)
		{
			Label = label;
			Callback = callback;
		}

		public KeyModifiers Modifier { get; set; }

		public uint Key { get; set; }
		public string Label { get; }

		public Action Callback { get; }
	}
}
