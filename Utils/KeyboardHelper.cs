using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JPRagTools.Utils
{
    internal class KeyboardHelper
    {
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);

        public static bool IsKeyDown(Key key)
        {
            return (GetKeyState((int)key) & 0x8000) != 0;
        }
    }
}