using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crash.Helper.Memory
{
	public class CrashMemory : GameMemory
	{
		public CrashMemory() : base("CrashBandicootNSaneTrilogy")
		{
			Lives = new GamePointer<int>(0x1A08548, 0x38, 0x70, 0x90, 0xA0, 0x748);
			Masks = new GamePointer<int>(0x1A08548, 0xC0, 0X90, 0X738, 0X58, 0X450);
		}

		public GamePointer<int> Lives { get; }
		public GamePointer<int> Masks { get; }

		protected override void OnHook(Process process)
		{
			Lives.Process = process;
			Masks.Process = process;
		}

		protected override void OnUnhook()
		{
			Lives.Process = null;
			Masks.Process = null;
		}

		public void Refresh()
		{
			Lives.Refresh();
			Masks.Refresh();
		}
	}
}
