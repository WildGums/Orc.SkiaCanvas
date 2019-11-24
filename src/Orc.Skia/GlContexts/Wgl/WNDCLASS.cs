﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WNDCLASS.cs" company="WildGums">
//   Copyright (c) 2008 - 2019 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Skia
{
    using System;
    using System.Runtime.InteropServices;

    internal delegate IntPtr WNDPROC(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

    [StructLayout(LayoutKind.Sequential)]
    internal struct WNDCLASS
    {
        public uint style;
        [MarshalAs(UnmanagedType.FunctionPtr)] public WNDPROC lpfnWndProc;
        public int cbClsExtra;
        public int cbWndExtra;
        public IntPtr hInstance;
        public IntPtr hIcon;
        public IntPtr hCursor;
        public IntPtr hbrBackground;
        [MarshalAs(UnmanagedType.LPTStr)] public string lpszMenuName;
        [MarshalAs(UnmanagedType.LPTStr)] public string lpszClassName;
    }
}
