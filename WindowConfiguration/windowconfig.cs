using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowConfiguration
{
    public partial class windowconfig : Form
    {
        /// Since the standard C# library omits these window handler functions need to use import statements
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        // THis struct is used to get the top left and bottom right coordinates of a window
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        // This struct is used to compile window information into an object for easy parameter passing
        public struct WindowInfo
        {
            public string Process_Name;
            public string Process_Title;
            public int Process_ID;
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
            public int Width;
            public int Height;
        }

        // holds window information about the current processes that are running
        List<WindowInfo> window_list = new List<WindowInfo>();

        // Initialize some windows form stuff, VSS does this for us. Don't need to change
        public windowconfig()
        {
            InitializeComponent();
        }

        // This will display all the tables in the DB. Each table is associated with a custom window configuration
        private void winconfigbtn_Click(object sender, EventArgs e)
        {
            windowconfigdisp.Items.Clear();
            List<string> window_config_names = new List<string>();

            // Query the table names from the DB and display their names
            window_config_names = SqLiteDataAccess.LoadTable();
            foreach (var win_name in window_config_names)
            {
                if (win_name != "sqlite_sequence")
                {
                    windowconfigdisp.Items.Add(win_name);
                }
            }
        }

        private void windowconfigdisp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // This will capture the current processes that are running in the system and display them
        private void caplayoutbtn_Click(object sender, EventArgs e)
        {
            processdisplay.Items.Clear();
            window_list.Clear();
            // Some helper variables to get the process information and setting up rect/window handler
            Process[] processes = Process.GetProcesses();
            var count = 0;
            RECT rect = new RECT();
            IntPtr hWnd;

            // Loop through all the currently running processes and get some diagnostic information for each window. You can also insert into the DB and move the window (uncomment last few statements)
            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                {
                    // Print out some diagnostic information
                    WindowInfo window = new WindowInfo();
                    hWnd = FindWindow(null, proc.MainWindowTitle);
                    GetWindowRect(hWnd, out rect);

                    string topleftcoord = "(" + rect.Left + "," + rect.Top + "), ";
                    string bottomrightcoord = "(" + rect.Right + "," + rect.Bottom + ")";
                    string coord = topleftcoord + bottomrightcoord;
                    int width = Math.Abs((rect.Left) - (rect.Right));
                    int height = Math.Abs((rect.Top) - (rect.Bottom));

                    String[] row = { proc.MainWindowTitle, coord, width.ToString(), height.ToString(), count.ToString()};
                    ListViewItem item = new ListViewItem(row);
                    processdisplay.Items.Add(item);
                    count++;

                    // Fill window struct in order to easily send an object to the sql insert function
                    window.Process_Name = proc.ProcessName.ToString();
                    window.Left = rect.Left;
                    window.Right = rect.Right;
                    window.Top = rect.Top;
                    window.Bottom = rect.Bottom;
                    window.Width = Math.Abs((rect.Left) - (rect.Right));
                    window.Height = Math.Abs((rect.Top) - (rect.Bottom));
                    window.Process_Title = proc.MainWindowTitle;
                    window.Process_ID = proc.Id;
                    window_list.Add(window);

                    // Uncomment the line below to move window handlers. NOTE: this only works for windows that are not minimized as far as I can tell.
                    /*if(proc.ProcessName != "devenv")
                    {
                        SetWindowPos(hWnd, 0, -7, 1227, 2208, 642, 0);
                    }*/

                }
            }


        }

        private void windowconfig_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // This will create a custom window configuration based on the user input
        private void add_win_cfg_btn_Click(object sender, EventArgs e)
        {
            // If user input isn't empty then add table to the DB
            if (add_win_cfg_inp_box.Text != ""){
                SqLiteDataAccess.CreateWindowTable(add_win_cfg_inp_box.Text);
                // Reset custom window configuration name display b/c we added a new table.
                add_win_cfg_inp_box.Clear();
                windowconfigdisp.Items.Clear();
                List<string> window_config_names = new List<string>();
                window_config_names = SqLiteDataAccess.LoadTable();
                foreach (var win_name in window_config_names)
                {
                    if (win_name != "sqlite_sequence")
                    {
                        windowconfigdisp.Items.Add(win_name);
                    }
                }
            }




        }

        // This will add window information to a specific custom window configuration based on check marks
        private void add_to_wnd_config_btn_Click(object sender, EventArgs e)
        {
            // Loop through all checked custom configurations and add the checked windows to their table in DB
            foreach (ListViewItem configitem in windowconfigdisp.CheckedItems)
            {
                string SelectedConfig = configitem.SubItems[0].Text;
                foreach (ListViewItem procitem in processdisplay.CheckedItems)
                {
                    string SelectedProc = procitem.SubItems[4].Text;
                    SqLiteDataAccess.SaveWindow(window_list[int.Parse(SelectedProc)], SelectedConfig);
                }
            }
        }

        // This allows users to export their entire DB to a specific folder
        private void export_win_cfg_btn_Click(object sender, EventArgs e)
        {
            //Export vars and create export directory
            string ExpOriginFileName = "WindowDB.db";
            string ExpFileName = "CopyWindowDB.db";
            string ExpSourcePath = @".\";
            string ExpSourceFile = System.IO.Path.Combine(ExpSourcePath, ExpOriginFileName);
            string ExpDestFile;

            // Get the export folder path from the user by using file explorer
            if(export_name_txt_box.Text != "")
            {
                ExpFileName = export_name_txt_box.Text + ".db";
            }
            FolderBrowserDialog export = new FolderBrowserDialog();
            if(export.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ExpDestFile = System.IO.Path.Combine(export.SelectedPath, ExpFileName);
                System.IO.File.Copy(ExpSourceFile, ExpDestFile, true);
            }
            export_name_txt_box.Clear();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // This allows users to import a DB
        private void Imp_win_cfg_btn_Click(object sender, EventArgs e)
        {
            string ImpDestFileName = "WindowDB.db";
            string ImpDestPath = @".\";
            string ImpDestFile = System.IO.Path.Combine(ImpDestPath, ImpDestFileName);
            OpenFileDialog import = new OpenFileDialog();

            // Allow users to pick the DB to import from file explorer
            if(import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.Copy(import.FileName, ImpDestFile, true);
            }
            add_win_cfg_inp_box.Clear();
            export_name_txt_box.Clear();
            processdisplay.Items.Clear();
            windowconfigdisp.Items.Clear();
            win_cfg_proc_dis.Items.Clear();
        }

        // This will display all the processes associated with a custom window configuration that has been selected (check mark)
        private void win_cfg_proc_disp_Click(object sender, EventArgs e)
        {
            win_cfg_proc_dis.Items.Clear();

            // Loop through all the checked custom window configurations and add their processes to the display
            foreach (ListViewItem configitem in windowconfigdisp.CheckedItems)
            {
                string SelectedConfig = configitem.SubItems[0].Text;
                List<WindowInfo> config_proc_lst = new List<WindowInfo>();
                config_proc_lst = SqLiteDataAccess.LoadWindow(SelectedConfig);
                foreach (var window in config_proc_lst)
                {
                    string topleftcoord = "(" + window.Left + "," + window.Top + "), ";
                    string bottomrightcoord = "(" + window.Right + "," + window.Bottom + ")";
                    string coord = topleftcoord + bottomrightcoord;

                    String[] row = { SelectedConfig, window.Process_Title, coord, window.Width.ToString(), window.Height.ToString()};
                    ListViewItem item = new ListViewItem(row);
                    win_cfg_proc_dis.Items.Add(item);
                }
                win_cfg_proc_dis.Items.Add("");

            }

        }
    }
}
