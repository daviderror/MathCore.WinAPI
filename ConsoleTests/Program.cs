using MathCore.WinAPI.Windows;
using System;
using System.Diagnostics;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var notepad = Process.Start("notepad");
            var main_window_hWnd = notepad.Handle;
            var window = new Window(main_window_hWnd);

            Console.WriteLine("Завершено.");
            Console.ReadLine();

            notepad.CloseMainWindow();
        }
    }
}

