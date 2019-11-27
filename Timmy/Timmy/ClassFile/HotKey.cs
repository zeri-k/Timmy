using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Timmy.ClassFile
{
    static class HotKey
    {
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookExA(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandleA(string lpModuleName);
        
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        static HotKey()
        {

        }

        // 훅 정의
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if ((Keys)vkCode == Keys.F2)
                {
                    ((MainForm)Singleton.getMainInstance()).speechStart();
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        // 훅 시작
        public static void HookStart()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                _hookID = SetWindowsHookExA(WH_KEYBOARD_LL, _proc, GetModuleHandleA(curModule.ModuleName), 0);
            }
        }
        //훅 종료
        public static void HookEnd()
        {
            UnhookWindowsHookEx(_hookID);
        }
        
    }
}
