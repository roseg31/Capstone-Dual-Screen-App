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
        public Bitmap primaryScreen;
        public Bitmap secondaryScreen;
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

        public struct Config_Info
        {
            public string Name;
            public int Num_apps;
            public string Description;
        }

        public List<WindowInfo> win_list = new List<WindowInfo>();

        public Form RefToConfig { get; set; }

        public new_config()
        {
            InitializeComponent();
        }

        public void set_primary_disp(Bitmap screenshot)
        {
            this.PrimaryScreenDisp.SizeMode = PictureBoxSizeMode.Zoom;
            PrimaryScreenDisp.Image = screenshot;
        }

        public void set_secondary_disp(Bitmap screenshot)
        {
            this.CompanionScreenDisp.SizeMode = PictureBoxSizeMode.Zoom;
            CompanionScreenDisp.Image = screenshot;
        }

        public void set_process_list_view(String[] row)
        {
            ListViewItem item = new ListViewItem(row);
            proc_list_view.Items.Add(item);
        }

        public void clear_process_list_view()
        {
            proc_list_view.Items.Clear();
            win_list.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cncl_cfg_btn_Click(object sender, EventArgs e)
        {

            cfg_name_box.Clear();
            cfg_desc_box.Clear();
            this.Close();
            RefToConfig.Show();
        }

        private void save_cfg_btn_Click(object sender, EventArgs e)
        {
            if(cfg_name_box.Text != "")
            {
                if (!SqLiteDataAccess.check_table_exists(cfg_name_box.Text))
                {
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

                    string image_path = @".\ConfigScreens\" + new_cfg.Name;
                    System.IO.Directory.CreateDirectory(image_path);
                    string primary_path = "main_" + new_cfg.Name + ".png";
                    string secondary_path = "second_" + new_cfg.Name + ".png";
                    primary_path = System.IO.Path.Combine(image_path, primary_path);
                    secondary_path = System.IO.Path.Combine(image_path, secondary_path);
                    primaryScreen.Save(primary_path);
                    secondaryScreen.Save(secondary_path);
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
    }
}
