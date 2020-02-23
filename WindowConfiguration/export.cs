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
    public partial class export : Form
    {
        public export()
        {
            InitializeComponent();
            this.Text = "Export";
        }

        // Browse button listener that allows the user to browse a folder to save the user's DB
        private void brwse_btn_Click(object sender, EventArgs e)
        {

        }

        // Clone a directory to a dest directory
        private static void CloneDirectory(string root, string dest)
        {
            foreach (var directory in System.IO.Directory.GetDirectories(root))
            {
                string dirName = System.IO.Path.GetFileName(directory);
                if (!System.IO.Directory.Exists(System.IO.Path.Combine(dest, dirName)))
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(dest, dirName));
                }
                CloneDirectory(directory, System.IO.Path.Combine(dest, dirName));
            }

            foreach (var file in System.IO.Directory.GetFiles(root))
            {
                System.IO.File.Copy(file, System.IO.Path.Combine(dest, System.IO.Path.GetFileName(file)));
            }
        }

        // Cancel button listener that closes the export form
        private void cancel_exp_btn_Click(object sender, EventArgs e)
        {
            fol_path.Clear();
            exp_filename.Clear();
            exp_err_label.Visible = false;
            this.Hide();
        }

        // Accept button listener that saves the current user's DB and image previews to a folder
        private void exp_accept_btn_Click(object sender, EventArgs e)
        {

        }

        private void exp_file_label_Click(object sender, EventArgs e)
        {

        }
    }
}
