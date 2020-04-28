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
using IWshRuntimeLibrary;

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

        // Object to hold configuration metadata. Useful for passing an object to the SQLite functions.

        public struct Config_Info
        {
            public string Name;
            public int Num_apps;
            public string Description;
        }

        // Struct to hold window handler information. Useful for passing an object to the SQLite functions.
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

        // Get some references to the export,import and new_config_page forms
        private export export_page = new export();
        private import import_page = new import();
        private new_config new_config_page = new new_config();

        // Get the screen count to manage images
        private int screen_count = Screen.AllScreens.Count(); 

        // Get reference to homepage for 'back' functionality
        public Form RefToHompage { get; set; }

        // Initialize some windows form stuff, VSS does this for us. Don't need to change
        public windowconfig()
        {
            InitializeComponent();
            this.Text = "Configuration List";
        }

        // When we load the windowconfig form, we want to display all the user's configurations on the listview
        private void windowconfig_Load(object sender, EventArgs e)
        {
            display_window_config();
        }

        // Get the configuration metadata information from the DB and display it on the listview
        public void display_window_config()
        {
            // Use SQLite function to query for the configuration metadata from the DB
            cfg_display.Items.Clear();
            List<Config_Info> cfg_list = new List<Config_Info>();
            cfg_list = SqLiteDataAccess.LoadConfigInfo();

            // Loop through each configuration and insert it in the listview
            foreach (var cfg in cfg_list)
            {
                String[] row = { cfg.Name, cfg.Num_apps.ToString(), cfg.Description };
                ListViewItem item = new ListViewItem(row);
                cfg_display.Items.Add(item);
            }
        }

        // Back button click listener that will use the reference from the homepage form to go back to the homepage
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.RefToHompage.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // export button listener to open up the export form
        private void exp_btn_Click(object sender, EventArgs e)
        {
            if (cfg_display.SelectedItems.Count > 0)
            {
                export_page.ShowDialog();
            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to Export!";
                cfg_err_label.Visible = true;
            }
        }

        // Check if a window actually has a UI (Don't want to get background apps)
        public static bool IsAppWindow(IntPtr hWnd)
        {
            int style = GetWindowLong(hWnd, -16);
            return (style & 0x10C00000) == 0x10C00000;
        }

        // Loop through all monitors and take a screenshot of each monitor
        private void capture_screens()
        {
            
            new_config_page.RefToConfig = this;
            this.Hide();
            new_config_page.screenshotlist.Clear();
            // For each screen take a screenshot of their display
            foreach (var screen in Screen.AllScreens)
            {
                Bitmap screenshot = new Bitmap(screen.Bounds.Width, screen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics memoryGraphics = Graphics.FromImage(screenshot);
                memoryGraphics.CopyFromScreen(screen.Bounds.X, screen.Bounds.Y, 0, 0, screen.Bounds.Size, CopyPixelOperation.SourceCopy);
                new_config_page.screenshotlist.Add(screenshot);
            }
            new_config_page.set_disp();
            this.Show();
        }

        // Get all the foreground processes and display them in a listview in thew new_config form
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
                        // Get mainwindowtitle, location, size and display them in the listview for the new_config form
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


        // new config button listener to open up the new_config form
        private void new_cfg_btn_Click(object sender, EventArgs e)
        {
            // Capture the screens and foreground processes and display them in the new_config form
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

        // Import button listener to open up the import form
        private void imp_btn_Click(object sender, EventArgs e)
        {

            import_page.ShowDialog();
            display_window_config();
        }

        // Delete button listener to delete the selected configuration in the listview
        private void del_btn_Click(object sender, EventArgs e)
        {
            if(cfg_display.SelectedItems.Count > 0)
            {
                // Remove configuration metadata and window information from the DB
                int idx = cfg_display.SelectedItems.Count - 1;
                while (idx >= 0) {
                    SqLiteDataAccess.RemoveConfigData(cfg_display.SelectedItems[idx].Text);
                    cfg_err_label.Visible = false;

                    if (System.IO.Directory.Exists(@".\ConfigScreens\" + cfg_display.SelectedItems[idx].Text))
                    {
                        System.IO.Directory.Delete(@".\ConfigScreens\" + cfg_display.SelectedItems[idx].Text, true);
                    }
                    idx--;
                }

                // Remove stored pictures for the currently selected configuration
                
                display_window_config();
            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to Delete!";
                cfg_err_label.Visible = true;
            }

        }

        // When you change the selected item in the listview, import the preview image for the selected configuration
        private void cfg_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the image preview stored in the ConfigScreens folder and display them to user
            if (cfg_display.SelectedItems.Count > 0)
            {
                //Ungrey the buttons
                exp_btn.ButtonColor = Color.CornflowerBlue;
                exp_btn.OnHoverButtonColor = Color.RoyalBlue;

                del_btn.ButtonColor = Color.CornflowerBlue;
                del_btn.OnHoverButtonColor = Color.RoyalBlue;

                button_WOC1.ButtonColor = Color.CornflowerBlue;
                button_WOC1.OnHoverButtonColor = Color.RoyalBlue;

                configure_btn.ButtonColor = Color.CornflowerBlue;
                configure_btn.OnHoverButtonColor = Color.RoyalBlue;

                int j = 0;
                string config_name = cfg_display.SelectedItems[0].Text;
                string image_folder = @".\ConfigScreens\" + config_name;
                string no_preview_image_path = @".\ConfigScreens\no-preview.jpg";
                string screen_image_file;
                List <string> screen_image_path = new List<string>();
                for (int i = 0; i < screen_count; i++)
                {
                    screen_image_file = (i + 1).ToString() + config_name + ".png";
                    screen_image_path.Add(System.IO.Path.Combine(image_folder, screen_image_file));
                }

                foreach (var pb in this.Controls.OfType<PictureBox>())
                {
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    if (j < screen_count && System.IO.File.Exists(screen_image_path[j])){
                        using(var bmpTemp = new Bitmap(screen_image_path[j]))
                        {
                            pb.Image = new Bitmap(bmpTemp);
                        }
                    }
                    else
                    {
                        using (var bmpTemp = new Bitmap(no_preview_image_path))
                        {
                            pb.Image = new Bitmap(bmpTemp);
                        }
                    }
                    j++;
                }
            } else
            {
                //re-grey the buttons
                exp_btn.ButtonColor = Color.LightSlateGray;
                exp_btn.OnHoverButtonColor = Color.LightSlateGray;

                del_btn.ButtonColor = Color.LightSlateGray;
                del_btn.OnHoverButtonColor = Color.LightSlateGray;

                button_WOC1.ButtonColor = Color.LightSlateGray;
                button_WOC1.OnHoverButtonColor = Color.LightSlateGray;

                configure_btn.ButtonColor = Color.LightSlateGray;
                configure_btn.OnHoverButtonColor = Color.LightSlateGray;
            }
        }

        // Configure button listener to move and resize windows based on the selected configuration
        private void configure_btn_Click(object sender, EventArgs e)
        {
            if (cfg_display.SelectedItems.Count > 0)
            {
                string name = cfg_display.SelectedItems[0].Text;
                run_config(name);

            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to Configure!";
                cfg_err_label.Visible = true;
            }
        }

        public void run_config(string name)
        {
            List<windowconfig.WindowInfo> windows = new List<windowconfig.WindowInfo>();
            windows = SqLiteDataAccess.LoadWindow(name);
            //var processes = Process.GetProcesses().Where(pr => pr.MainWindowHandle != IntPtr.Zero);
            //RECT rect = new RECT();
            IntPtr hWnd;
            cfg_err_label.Visible = false;

            // Match window handler with process. When there is a match, resize and move window handler to right position
            foreach (var window in windows)
            {
                hWnd = IntPtr.Zero;
                //foreach (var proc in processes)
                //{
                //if (!string.IsNullOrEmpty(proc.MainWindowTitle))
                //{
                // Print out some diagnostic information
                Process[] processes = Process.GetProcessesByName(window.Process_Name);
                foreach (Process p in processes)
                {
                    hWnd = p.MainWindowHandle;
                    if (hWnd != null && hWnd != IntPtr.Zero)
                    {
                        break;
                    }
                }
                if (hWnd == null || hWnd == IntPtr.Zero)
                {
                    hWnd = FindWindow(null, window.Process_Title);
                }
                if (hWnd == null || hWnd == IntPtr.Zero)
                {
                    hWnd = FindWindow(null, window.Process_Name);
                }

                if ((hWnd == null || hWnd == IntPtr.Zero) && window.Process_Name != "WindowConfiguration")
                {
                    Process.Start(window.Exe_Path);
                    //Console.WriteLine(window.Process_Name);
                    processes = Process.GetProcessesByName(window.Process_Name);
                    foreach (Process p in processes)
                    {
                        //Console.WriteLine(p.MainModule.ModuleName);
                        hWnd = p.MainWindowHandle;
                        while (hWnd == null || hWnd == IntPtr.Zero)
                        {
                            Process p2 = Process.GetProcessById(p.Id);
                            hWnd = p2.MainWindowHandle;
                        }
                        break;
                    }
                    //hWnd = Process.GetProcessesByName(window.Process_Name).First().MainWindowHandle;

                    //hWnd = FindWindow(null, window.Process_Title);
                }
                //GetWindowRect(hWnd, out rect);

                if (IsIconic(hWnd) == false && IsAppWindow(hWnd) && window.Process_Name != "WindowConfiguration")
                {
                    //if(window.Process_Name == proc.ProcessName)
                    //{
                    SetWindowPos(hWnd, IntPtr.Zero, window.Left, window.Top, window.Width, window.Height, 0x0200);
                    SetWindowPos(hWnd, IntPtr.Zero, window.Left, window.Top, window.Width, window.Height, 0x0200);
                    //}
                }
                //}
                //}

            }
        }

        private void preview_cfg_prim_Click(object sender, EventArgs e)
        {

        }

        private void publish_config_Click(object sender, EventArgs e)
        {
            if (cfg_display.SelectedItems.Count > 0)
            {
                for (int i = 0; i < cfg_display.SelectedItems.Count; i++)
                {
                    object shDesktop = (object)"Desktop";
                    string name = cfg_display.SelectedItems[i].Text;
                    WshShell shell = new WshShell();
                    string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\Run_" + name + ".lnk";
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                    shortcut.Description = "Run configuration: " + name;
                    shortcut.TargetPath = Environment.CurrentDirectory + @"\WindowConfiguration.exe ";
                    shortcut.WorkingDirectory = Environment.CurrentDirectory;
                    shortcut.Arguments = name;
                    shortcut.Save();
                }
            }
            else
            {
                cfg_err_label.Text = "Select a Configuration to create a Desktop shortcut for!";
                cfg_err_label.Visible = true;
            }
        }
    }
}
