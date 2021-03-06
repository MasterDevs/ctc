﻿using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Ctc.WinApi
{
    [ComImport, Guid(ShellIIDGuid.IPersistFile), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IPersistFile
    {
        UInt32 GetCurFile([Out(), MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile);
        UInt32 IsDirty();
        UInt32 Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.U4)] STGM dwMode);
        UInt32 Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, bool fRemember);
        UInt32 SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);
    }
}