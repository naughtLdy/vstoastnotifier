﻿using System;
using System.Runtime.InteropServices;

namespace Company.ToastNotifier.Interop
{
    static class Shell32
    {
        [DllImport("Shell32.dll")]
        public static extern IntPtr GetCurrentProcessExplicitAppUserModelID(out IntPtr AppID);

        public static string GetCurrentProcessExplicitAppUserModelID()
        {
            IntPtr pv;
            GetCurrentProcessExplicitAppUserModelID(out pv);
            if (pv == null) return null;
            var s = Marshal.PtrToStringAuto(pv);
            Ole32.CoTaskMemFree(pv);
            return s;
        }
    }
}
