using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;//need the processing
using System.ComponentModel;
using System.Windows.Forms;

/*http://www.geoffchappell.com/studies/windows/win32/kernel32/api/ */
namespace ConsoleApp1
{
	class Hooking : HandledEventArgs
	{
		#region
		//https://msdn.microsoft.com/en-us/library/windows/desktop/ms644985(v=vs.85).aspx
		//Learn Later
		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
		#endregion


		#region Hooks dll's
		//from this dll we get the console window.
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		//from this dll we show/hide the window.
		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		//
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook,
		LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		//
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);
		//for HookCallBack
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
		IntPtr wParam, IntPtr lParam);

		//The hook procedure can be in the state of being called by another thread even after UnhookWindowsHookEx returns.
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);
		#endregion

		#region Veriables
		protected static IntPtr hookID = IntPtr.Zero; //CLS complient object
		private const int WM_KEYDOWN = 0x0100; //variable c++ const to a key down event. 
		private const int WH_KEYBOARD_LL = 13; //number for SetHook()
		private static LowLevelKeyboardProc proc = HookCallBack; // HookCallBack
		
		#endregion

		//must be static to refrense the dll librarys
		private static IntPtr SetHook(LowLevelKeyboardProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule)
			{
				//WH_KEYBOARD_LL installs a hook procedure that monitors, low-level keyboard input events.
				return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
					GetModuleHandle(curModule.ModuleName), 0);
			}
		}
		private static IntPtr HookCallBack(
		int nCode, IntPtr wParam, IntPtr lParam)
		{
			return CallNextHookEx(hookID, nCode, wParam, lParam);
		}

		//protected Hooking()
		//{   

		//}
		public static void Run()
		{
			//Retrieves the window handle used by the console associated with the calling process.
			//IntPtr handle = GetConsoleWindow();
			//make 0 to hide window
			//ShowWindow(handle, 5);

			hookID = SetHook(proc);
			//return proc;
			//UnhookWindowsHookEx(hookID);

		}
		//public Hooking.LowLevelKeyboardProc GetHook => proc;
		//public Hooking.LowLevelKeyboardProc GetHook
		//{
		//	get
		//	{
		//		return proc;
		//	}
		//}
	}
}
