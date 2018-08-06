using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash.Helper.Memory
{
	public class GamePointer<T> where T : struct
	{
		private int[] offsets;
		private T currentValue;

		public GamePointer(params int[] offsets)
		{
			this.offsets = offsets;
		}
		
		// Setting the process publicly is easier than passing it into functions repeatedly.
		public Process Process { get; set; }
		public event Action<T, T> OnValueChange;

		public T Read()
		{
			return Process.Read<T>(Process.MainModule.BaseAddress, offsets);
		}

		public void Write(T value)
		{
			Process.Write(Process.MainModule.BaseAddress, value, offsets);
		}

		public void Refresh()
		{
			T newValue = Read();

			if (!newValue.Equals(currentValue))
			{
				OnValueChange?.Invoke(currentValue, newValue);
				currentValue = newValue;
			}
		}
	}
}
