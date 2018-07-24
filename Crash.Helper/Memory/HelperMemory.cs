using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash.Helper.Memory
{
	public class HelperMemory
	{
		private Process process;
		private IntPtr address;

		private int offset;

		public bool HookProcess()
		{
			if (process == null || process.HasExited)
			{
				Process[] processes = Process.GetProcessesByName("CrashBandicootNSaneTrilogy");
				process = processes.Length == 0 ? null : processes[0];

				if (processes.Length == 0 || process.HasExited)
				{
					return false;
				}

				MemoryReader.Update64Bit(process);

				address = process.MainModule.BaseAddress;
				offset = process.OffsetAddress(ref address, 0x1A08548, 0x38, 0x70, 0x90, 0xA0, 0x748);

				return true;
			}

			return true;
		}

		public bool LivesFound => offset != 0;
		public int Lives => process.Read<int>(address, offset);

		public void SetZeroLives()
		{
			process.Write(address, 0, offset);
		}

		private class ProgramPointer
		{
			private string signature;
			private int offset;
			private int resultIndex;

			public ProgramPointer(string signature, int offset, int resultIndex = 0)
			{
				this.signature = signature;
				this.offset = offset;
				this.resultIndex = resultIndex;
			}

			public IntPtr Pointer { get; set; }

			public T Get<T>(Process process) where T : struct
			{
				// Both the process and pointer are assumed valid when calling this function.
				return process.Read<T>(Pointer, offset);
			}

			public void Write<T>(Process process, T value) where T : struct
			{
				process.Write(Pointer, value, offset);
			}

			public void AcquirePointer(Process process)
			{
				if (Pointer != IntPtr.Zero)
				{
					return;
				}

				MemorySearcher searcher = new MemorySearcher
				{
					MemoryFilter = info =>
						(info.State & 0x1000) != 0 &&
						(info.Protect & 0x04) != 0
				};

				switch (resultIndex)
				{
					case -1:
						List<IntPtr> list1 = searcher.FindSignatures(process, signature);

						if (list1.Count == 0)
						{
							return;
						}

						Pointer = list1.Last();

						break;

					case 0:
						Pointer = searcher.FindSignature(process, signature);
						break;

					default:
						List<IntPtr> list2 = searcher.FindSignatures(process, signature);

						if (list2.Count == 0)
						{
							return;
						}

						Pointer = list2[resultIndex];

						break;
				}
			}
		}
	}
}
