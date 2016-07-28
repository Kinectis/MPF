﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MPF.Interop
{
    [Guid("B0FDA70A-53E1-419C-934C-F3588B722F32")]
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IRenderCommandBuffer
    {
        void DrawGeometry([MarshalAs(UnmanagedType.Interface), In]IResource geometry, [MarshalAs(UnmanagedType.Interface), In] IResource pen);
    }
}