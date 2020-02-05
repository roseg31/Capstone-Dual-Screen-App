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
        public static extern bool IsIconic(IntPtr handle);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        // This struct is used to get the top left and bottom right coordinates of a window
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public struct Config_Info
        {
            public string Name;
            public int Num_apps;
            public string Description;
        }

        public struct WindowInfo
        {
            public string Process_Name;
            public string Process_Title;
            public string Exe_Path;
            public int Process_ID;
            public int Left;
            public int Right;
            public int Top;
            public int Bottom;
            public int Width;
            public int Height;
        }

        private export export_page = new export();
        private import import_page = new import();
        private new_config new_config_page = new new_config();

        public Form RefToHompage { get; set; }

        // Initialize some windows form stuff, VSS does this for us. Don't need to change
        public windowconfig()
        {
            InitializeComponent();
        }

        private void windowconfig_Load(object sender, EventArgs e)
        {
            display_window_config();
        }

        public void display_window_config()
        {
            cfg_display.Items.Clear();
            List<Config_Info> cfg_list = new List<Config_Info>();
            cfg_list = SqLiteDataAccess.LoadConfigInfo();
            foreach (var cfg in cfg_list)
            {
                String[] row = { cfg.Name, cfg.Num_apps.ToString(), cfg.Description };
                ListViewItem item = new ListViewItem(row);
                cfg_display.Items.Add(item);
            }
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefToHompage.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exp_btn_Click(object sender, EventArgs e)
        {
            export_page.ShowDialog();
        }

        public static bool IsAppWindow(IntPtr hWnd)
        {
            int style = GetWindowLong(hWnd, -16);
            return (style & 0x10C00000) == 0x10C00000;
        }

        private void capture_screens()
        {
            int screen_count = 0;
            new_config_page.RefToConfig = this;
            this.Hide();
            foreach (var screen in Screen.AllScreens)
            {
                Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics memoryGraphics = Graphics.FromImage(screenshot);
                memoryGraphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size, CopyPixelOperation.SourceCopy);
                if (screen_count == 0)
                {
                    new_config_page.set_primary_disp(screenshot);
                    new_config_page.primaryScreen = screenshot;
                    screen_count++;
                }
                else
                {
                    new_config_page.set_secondary_disp(screenshot);
                    new_config_page.secondaryScreen = screenshot;
                }
            }
            this.Show();
        }

        private int get_processes()
        {
            var processes = Process.GetProcesses().Where(pr => pr.MainWindowHandle != IntPtr.Zero);
            RECT rect = new RECT();
            IntPtr hWnd;
            var process_count = 0;

            new_config_page.clear_process_list_view();
            // Loop through all the currently running processes and get some diagnostic information for each window. You can also insert into the DB and move the window (uncomment last few statements)
            foreach (var proc in processes)
            {
                if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                {
                    // Print out some diagnostic information
                    new_config.WindowInfo window = new new_config.WindowInfo();
                    hWnd = FindWindow(null, proc.MainWindowTitle);
                    GetWindowRect(hWnd, out rect);

                    if (IsIconic(hWnd) == false && IsAppWindow(hWnd) && proc.ProcessName != "WindowConfiguration")
                    {
                        process_count++;
                        string topleftcoord = "(" + rect.Left + "," + rect.Top + "), ";
                        string bottomrightcoord = "(" + rect.Right + "," + rect.Bottom + ")";
                        string location = topleftcoord + bottomrightcoord;
                        int width = Math.Abs((rect.Left) - (rect.Right));
                        int height = Math.Abs((rect.Top) - (rect.Bottom));
                        string size = width.ToString() + " x " + height.ToString();

                        String[] row = { proc.MainWindowTitle, location, size };
                        new_config_page.set_process_list_view(row);

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
                        window.Exe_Path = proc.MainModule.FileName;
                        new_config_page.win_list.Add(window);


                    }
                }
            }
            return process_count;
        }


        private void new_cfg_btn_Click(object sender, EventArgs e)
        {
            if (get_processes() != 0)
            {
                capture_screens();
                cfg_err_label.Visible = false;
                new_config_page.ShowDialog();
                display_window_config();
            }
            else
            {
                cfg_err_label.Text = "No Windows to Manage!";
                cfg_err_label.Visible = true;
            }

        }

        private void imp_btn_Click(object sender, EventArgs e)
        {

            import_page.ShowDialog();
            display_window_config();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            if(cfg_display.SelectedItems.Count > 0)
            {
                SqLiteDataAccess.RemoveConfigData(cfg_display.SelectedItems[0].Text);
                preview_cfg_prim.Image = null;
                preview_cfg_companion.Image = null;
                cfg_err_label.Visible = false;
                if (System.IO.Directory.Exists(@".\ConfigScreens\" + cfg_display.SelectedItems[0].Text)){
                    System.IO.Directory.Delete(@".\ConfigScreens\" + cfg_display.SelectedItems[0].Text, true);
                }
                display_window_config();
            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to Delete!";
                cfg_err_label.Visible = true;
            }

        }


        private void cfg_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cfg_display.SelectedItems.Count > 0)
            {
                this.preview_cfg_prim.SizeMode = PictureBoxSizeMode.Zoom;
                this.preview_cfg_companion.SizeMode = PictureBoxSizeMode.Zoom;
                string config_name = cfg_display.SelectedItems[0].Text;
                string image_folder = @".\ConfigScreens\" + config_name;
                string primary_image_file = "main_" + config_name + ".png";
                string secondary_image_file = "second_" + config_name + ".png";
                string primary_image_path = System.IO.Path.Combine(image_folder, primary_image_file);
                string secondary_image_path = System.IO.Path.Combine(image_folder, secondary_image_file);
                string no_preview_image_path = @".\ConfigScreens\no-preview.jpg";

                if (System.IO.File.Exists(primary_image_path) && System.IO.File.Exists(secondary_image_path))
                {
                    using (var bmpTemp = new Bitmap(primary_image_path))
                    {
                        preview_cfg_prim.Image = new Bitmap(bmpTemp);
                    }
                    using (var bmpTemp = new Bitmap(secondary_image_path))
                    {
                        preview_cfg_companion.Image = new Bitmap(bmpTemp);
                    }
                }
                else
                {
                    using (var bmpTemp = new Bitmap(no_preview_image_path))
                    {
                        preview_cfg_prim.Image = new Bitmap(bmpTemp);
                        preview_cfg_companion.Image = new Bitmap(bmpTemp);
                    }
                }



            }
        }

        private void configure_btn_Click(object sender, EventArgs e)
        {
            if (cfg_display.SelectedItems.Count > 0)
            {
                List<windowconfig.WindowInfo> windows = new List<windowconfig.WindowInfo>();
                windows = SqLiteDataAccess.LoadWindow(cfg_display.SelectedItems[0].Text);
                var processes = Process.GetProcesses().Where(pr => pr.MainWindowHandle != IntPtr.Zero);
                RECT rect = new RECT();
                IntPtr hWnd;
                cfg_err_label.Visible = false;
                foreach (var window in windows)
                {
                    foreach (var proc in processes)
                    {
                        if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                        {
                            // Print out some diagnostic information
                            hWnd = FindWindow(null, proc.MainWindowTitle);
                            GetWindowRect(hWnd, out rect);

                            if (IsIconic(hWnd) == false && IsAppWindow(hWnd) && proc.ProcessName != "WindowConfiguration")
                            {
                                if(window.Process_Name == proc.ProcessName)
                                {
                                    SetWindowPos(hWnd, IntPtr.Zero, window.Left, window.Top, window.Width, window.Height, 0x0200);
                                    SetWindowPos(hWnd, IntPtr.Zero, window.Left, window.Top, window.Width, window.Height, 0x0200);
                                }
                            }
                        }
                    }

                }
            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to Configure!";
                cfg_err_label.Visible = true;
            }

        }

        private void preview_cfg_prim_Click(object sender, EventArgs e)
        {

        }
    }
}
