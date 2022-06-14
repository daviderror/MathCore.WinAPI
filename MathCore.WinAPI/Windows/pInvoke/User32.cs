using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MathCore.WinAPI.Windows.pInvoke
{
    public static class User32
    {
        public const string FileName = "user32.dll";

        [DllImport(FileName,CharSet = CharSet.Auto, SetLastError =true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, unit nMaxCount);
    }
}
