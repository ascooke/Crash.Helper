using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash.Helper.Memory
{
	public abstract class GameMemory
	{
		private Process process;

		private string processName;

		protected GameMemory(string processName)
		{
			this.processName = processName;
		}

		protected abstract void OnHook(Process process);
		protected abstract void OnUnhook();

		public bool ProcessHooked => process != null && !process.HasExited;

		public bool HookProcess()
		{
			if (process != null && process.HasExited)
			{
				process = null;
				OnUnhook();

				return false;
			}

			if (process == null)
			{
				Process[] processes = Process.GetProcessesByName(processName);
				process = processes.Length == 0 ? null : processes[0];

				if (process == null || process.HasExited)
				{
					return false;
				}

				MemoryReader.Update64Bit(process);

				OnHook(process);
			}

			return process != null;
		}
	}
}
