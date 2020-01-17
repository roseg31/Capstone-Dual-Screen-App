using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections;

namespace WindowConfiguration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        /// Need these auxillary functions to pull in some window information
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        //Struct passed into the window handler section which gives us the window position and size (after calculation)
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        [STAThread]
        static void Main()
        {
            // Get some information about all the screens
            Console.WriteLine("\n");
            foreach (var screen in Screen.AllScreens)
            {
                Console.WriteLine("Device Name: " + screen.DeviceName);
                Console.WriteLine("Bounds: " + screen.Bounds.ToString());
                Console.WriteLine("Type: " + screen.GetType().ToString());
                Console.WriteLine("Working Area: " + screen.WorkingArea.ToString());
                Console.WriteLine("Primary Screen: " + screen.Primary.ToString());
            }
            Console.WriteLine("\n");


            Process[] processes = Process.GetProcesses();
            var count = 0;
            RECT rect = new RECT();
            IntPtr hWnd;

            // Loop through all the currently running processes and get some diagnostic information for each window
            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                {
                    Console.WriteLine(++count + ".");
                    Console.WriteLine("Process Name: " + proc.ProcessName);
                    Console.WriteLine("Process Title: " + proc.MainWindowTitle);
                    Console.WriteLine("Process ID: " + proc.Id);
                    hWnd = FindWindow(null, proc.MainWindowTitle);
                    GetWindowRect(hWnd, out rect);
                    Console.WriteLine("Window Location - Top left (x,y): " + rect.Left + "," + rect.Top);
                    Console.WriteLine("Window Location - Bottom Right (x, y): " + rect.Right + "," + rect.Bottom);
                    Console.WriteLine("Window Width: " + Math.Abs((rect.Left) - (rect.Right)));
                    Console.WriteLine("Window Height: " + Math.Abs((rect.Top) - (rect.Bottom)));
                    Console.WriteLine("\n");

                    // Change window position and size of all foreground window applications to the top left.
                    // SetWindowPos(hWnd, 0, 0, 0, 500, 500, 0);
                }

            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
