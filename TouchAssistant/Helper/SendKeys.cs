namespace TouchAssistant
{
    using System;
    using System.Linq;
    using System.Runtime.InteropServices;

    internal class SendKeys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Remain windows API name", Scope = "member")]
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

        public static void Send(VirtualKeys key)
        {
            const uint KEYEVENTF_EXTENDEDKEY = 0x0001;
            keybd_event((byte)key, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
        }
    }
}