﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryManagementt
{
    using System;
    using System.Runtime.InteropServices;

    public class InteropKeyboard
    {
        /// <summary>Keyboard key actions.</summary>
        /// <remarks>These values should match those expected by the keybd_event native method.</remarks>
        [Flags]
        public enum KeyboardEventFlags : uint
        {
            /// <summary>The keyboard key is in a 'down' or 'pressed' state (KEYEVENTF_EXTENDEDKEY).</summary>
            KeyDown = 0x1,

            /// <summary>The keyboard key is in an 'up' or 'unpressed' state (KEYEVENTF_KEYUP).</summary>
            KeyUp = 0x2,
        }

        /// <summary>Simulate a keyboard keystroke event.</summary>
        /// <remarks>https://msdn.microsoft.com/en-us/library/windows/desktop/ms646304(v=vs.85).aspx</remarks>
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
    }
}
