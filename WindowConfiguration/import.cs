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
    public partial class import : Form
    {

        public import()
        {
            InitializeComponent();
            this.Text = "Import";
        }

        // Browse button listener that allows the user to select a particular .db file
        private void imp_browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog import = new OpenFileDialog();
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath.Text = import.FileName;
            }

        }

        // Function that recursively clones a directory to the dest
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
                System.IO.File.Copy(file, System.IO.Path.Combine(dest, System.IO.Path.GetFileName(file)), true);
            }
        }

        // Ok button listener that is used import the .db file and clone the image preview
        private void imp_ok_btn_Click(object sender, EventArgs e)
        {
            if(FilePath.Text != "")
            {
                string ImpDestFileName = "WindowDB.db";
                string ImpDestPath = @".\";
                string ImpDestFile = System.IO.Path.Combine(ImpDestPath, ImpDestFileName);

                // Import the .db file selected by the user and clone the image folder to the root location
                if(System.IO.Path.GetFileName(FilePath.Text).Contains(".db")) {
                    System.IO.File.Copy(FilePath.Text, ImpDestFile, true);
                    string db_location = System.IO.Path.GetDirectoryName(FilePath.Text);
                    if (System.IO.Directory.Exists(db_location + @"\ConfigScreens") && System.IO.Directory.Exists(@".\ConfigScreens"))
                    {
                        CloneDirectory(db_location + @"\ConfigScreens", @".\ConfigScreens");
                    }
                    imp_err_label.Visible = false;
                    FilePath.Clear();
                    this.Close();
                }
                else
                {
                    imp_err_label.Text = "Import file needs to be a .db!";
                    imp_err_label.Visible = true;
                }
            }
            else
            {
                imp_err_label.Text = "Missing File Path!";
                imp_err_label.Visible = true;
            }

        }

        // cancel button listener that closes the import form
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            FilePath.Clear();
            imp_err_label.Visible = false;
            this.Close();
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
