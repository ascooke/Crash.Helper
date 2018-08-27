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
		public Hotkey(string label, KeyModifiers modifier, uint key, Action callback)
		{
			Label = label;
            Modifier = modifier;
            Key = key;
			Callback = callback;
		}

		public KeyModifiers Modifier { get; set; }

		public uint Key { get; set; }
		public string Label { get; }

		public Action Callback { get; }

		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();

			void AppendFunction(object value)
			{
				if (builder.Length > 0)
				{
					builder.Append(" + ");
				}

				builder.Append(value);
			}

			bool alt = (Modifier & KeyModifiers.Alt) > 0;
			bool control = (Modifier & KeyModifiers.Control) > 0;
			bool shift = (Modifier & KeyModifiers.Shift) > 0;

			if (alt)
			{
				AppendFunction("Alt");
			}

			if (control)
			{
				AppendFunction("Ctrl");
			}

			if (control)
			{
				AppendFunction("Shift");
			}

			AppendFunction((char)Key);

			return builder.ToString();
		}
	}
}
