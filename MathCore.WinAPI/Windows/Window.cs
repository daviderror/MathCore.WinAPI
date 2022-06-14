using System;

namespace MathCore.WinAPI.Windows
{
    public class Window
    {
        public IntPtr Handle { get; set; }
        public string Text 
        {
            get => GetWindowText();
            set
            {
                throw new NotImplementedException();
            }
        }
        public Window(IntPtr Handle) => this.Handle = Handle;
        private string GetWindowText()
        {

        }
    }
}
