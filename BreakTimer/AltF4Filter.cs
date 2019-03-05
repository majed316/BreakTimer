using System;
using System.Windows.Forms;

namespace BreakTimer
{
    public class AltF4Filter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_SYSKEYDOWN = 0x0104;
            const int WM_SYSKEYUP = 0x0105;
            //const int WM_SYSKEYDOWN = 0x0104;
            if (m.Msg == WM_SYSKEYDOWN || m.Msg == WM_SYSKEYUP)
            {
                //bool alt = ((int)m.LParam & 0x20000000) != 0;
                //if (alt && (m.WParam == new IntPtr((int)Keys.F4)))
                    return true; // eat it!
            }
            return false;
        }

    }
}