namespace DovahkiinLounge.Hooks
{
    using System;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.InteropServices;

        public static class DialogHook
        {
            [DllImport("kernel32.dll")]
            private static extern uint GetCurrentThreadId();

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern bool UnhookWindowsHookEx(int idHook);

            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

            [DllImport("user32.dll")]
            private static extern bool SetDlgItemText(IntPtr hWnd, int nIDDlgItem, string lpString);

            private delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

            private const int WH_CBT = 5;
            private const int HCBT_ACTIVATE = 5;

            private const int ID_BUT_OK = 1;
            private const int ID_BUT_CANCEL = 2;
            private const int ID_BUT_ABORT = 3;
            private const int ID_BUT_RETRY = 4;
            private const int ID_BUT_IGNORE = 5;
            private const int ID_BUT_YES = 6;
            private const int ID_BUT_NO = 7;

            private static int _hook = 0;
            private static HookProc dlgHookProc;

            public static void StartHook()
            {
                if (_hook == 0)
                {
                    IntPtr hInstance = Marshal.GetHINSTANCE(typeof(DialogHook).Assembly.GetModules()[0]);
                    _hook = SetWindowsHookEx(WH_CBT, new HookProc(DialogHookProc), hInstance, (int)GetCurrentThreadId());
                }
            }

            public static void StopHook()
            {
                if (_hook != 0)
                {
                    UnhookWindowsHookEx(_hook);
                    _hook = 0;
                }
            }

            private static int DialogHookProc(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0 && nCode == HCBT_ACTIVATE)
                {
                CultureInfo lang = CultureInfo.CurrentCulture;
                ResourceManager rm = new ResourceManager("DovahkiinLounge.Functions.Language.Functions", typeof(DialogHook).Assembly);

                SetDlgItemText(wParam, ID_BUT_OK, rm.GetString("BUT_OK", lang));
                SetDlgItemText(wParam, ID_BUT_CANCEL, rm.GetString("BUT_CANCEL", lang));
                SetDlgItemText(wParam, ID_BUT_ABORT, rm.GetString("BUT_ABORT", lang));
                SetDlgItemText(wParam, ID_BUT_RETRY, rm.GetString("BUT_RETRY", lang));
                SetDlgItemText(wParam, ID_BUT_IGNORE, rm.GetString("BUT_IGNORE", lang));
                SetDlgItemText(wParam, ID_BUT_YES, rm.GetString("BUT_YES", lang));
                SetDlgItemText(wParam, ID_BUT_NO, rm.GetString("BUT_NO", lang));
            }

                return CallNextHookEx(_hook, nCode, wParam, lParam);
            }
        }
    }
