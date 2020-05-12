using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowConfiguration
{
    public partial class new_config : Form
    {
        // Reference to the screenshot list
        public List<Bitmap> screenshotlist = new List<Bitmap>();

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

        // Object to hold configuration metadata. Useful for passing an object to the SQLite functions.
        public struct Config_Info
        {
            public string Name;
            public int Num_apps;
            public string Description;
        }

        // Holds a list of windows and their fields based on the struct above
        public List<WindowInfo> win_list = new List<WindowInfo>();

        // Reference to the windowconfig form for back navigation
        public Form RefToConfig { get; set; }
        
        // Initialize some windows form stuff, VSS does this for us. Don't need to change
        public new_config()
        {
            InitializeComponent();
            this.Text = "New Configuration";
            configNameTut.Visible = false;
            saveConfigTut.Visible = false;
            update_newconfig_tutorial();
        }

        //Handles updating tutorial elements for new config page
        public void update_newconfig_tutorial()
        {
            //If tutorial is running, show appropriate tutorial elements

            if (Properties.Settings.Default.runTutorial == true)
            {
                if (Properties.Settings.Default.configNameTut == true)
                {
                    configNameTut.Visible = true;
                    processesTut.Visible = true;
                    previewTut.Visible = true;
                }
                else
                {
                    configNameTut.Visible = false;
                    
                }

                if (Properties.Settings.Default.configSaveTut == true)
                {
                    saveConfigTut.Visible = true;
                    processesTut.Visible = true;
                    previewTut.Visible = true;
                }
                else
                {
                    saveConfigTut.Visible = false;
                }
            }
            else
            {
                configNameTut.Visible = false;
                processesTut.Visible = false;
                previewTut.Visible = false;
                saveConfigTut.Visible = false;
            }
        }

        // Set screenshot for displays
        public void set_disp()
        {
            int i = 0;
            foreach (var pb in this.Controls.OfType<PictureBox>())
            {
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                if(i < screenshotlist.Count())
                {
                    pb.Image = screenshotlist[i];
                }
                i++;
            }
        }

        // Add a row to the listview based on a passed in process
        public void set_process_list_view(String[] row)
        {
            ListViewItem item = new ListViewItem(row);
            proc_list_view.Items.Add(item);
        }

        // Clear the process listview
        public void clear_process_list_view()
        {
            proc_list_view.Items.Clear();
            win_list.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Cancel button listener to close the new_config form
        private void cncl_cfg_btn_Click(object sender, EventArgs e)
        {

            cfg_name_box.Clear();
            cfg_desc_box.Clear();
            this.Close();
            RefToConfig.Show();
        }

        // Save button listener and store new configuration info into the DB
        private void save_cfg_btn_Click(object sender, EventArgs e)
        {
            if(cfg_name_box.Text != "")
            {
                if (!SqLiteDataAccess.check_table_exists(cfg_name_box.Text))
                {
                    //If tutorial is running, update setting and tutorial elements
                    if (Properties.Settings.Default.runTutorial == true &&
                         Properties.Settings.Default.configSaveTut == true)
                    {
                        Properties.Settings.Default.configSaveTut = false;
                    }
                    update_newconfig_tutorial();

                    // Add configuration metadata, configuration table and windows to the DB
                    Config_Info new_cfg = new Config_Info();
                    new_cfg.Name = cfg_name_box.Text;
                    new_cfg.Description = cfg_desc_box.Text;
                    new_cfg.Num_apps = win_list.Count();
                    SqLiteDataAccess.AddConfigInfo(new_cfg);
                    SqLiteDataAccess.CreateConfigTable(new_cfg.Name);
                    foreach (var window in win_list)
                    {
                        SqLiteDataAccess.SaveWindow(window, new_cfg.Name);
                    }

                    // Save image previews to ConfigScreens folder for later previewing in windowconfig form
                    string image_path = @".\ConfigScreens\" + new_cfg.Name;
                    System.IO.Directory.CreateDirectory(image_path);
                    string screen_image_file;
                    string screen_image_path;
                    for(int i = 0; i < screenshotlist.Count(); i++)
                    {
                        screen_image_file = (i + 1).ToString() + new_cfg.Name + ".png";
                        screen_image_path = System.IO.Path.Combine(image_path, screen_image_file);
                        screenshotlist[i].Save(screen_image_path);
                    }
                    new_cfg_err_label.Visible = false;
                    cfg_name_box.Clear();
                    cfg_desc_box.Clear();
                    proc_list_view.Items.Clear();
                    this.Close();
                }
                else
                {
                    new_cfg_err_label.Text = "Configuration already exists!";
                    new_cfg_err_label.Visible = true;
                }

            }
            else
            {
                new_cfg_err_label.Text = "Config Name can't be Empty!";
                new_cfg_err_label.Visible = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cfg_name_box_TextChanged(object sender, EventArgs e)
        {
            //If tutorial is running, update settings to go to next step
            if (cfg_name_box.Text != "")
            {
                if (Properties.Settings.Default.runTutorial == true &&
                Properties.Settings.Default.configNameTut == true)
                {
                    Properties.Settings.Default.configNameTut = false;
                    Properties.Settings.Default.configSaveTut = true;
                }
                update_newconfig_tutorial();
            }
        }
    }
}
