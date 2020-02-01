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
        }

        private void imp_browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog import = new OpenFileDialog();
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FilePath.Text = import.FileName;
            }

        }

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

        private void imp_ok_btn_Click(object sender, EventArgs e)
        {
            if(FilePath.Text != "")
            {
                string ImpDestFileName = "WindowDB.db";
                string ImpDestPath = @".\";
                string ImpDestFile = System.IO.Path.Combine(ImpDestPath, ImpDestFileName);
                System.IO.File.Copy(FilePath.Text, ImpDestFile, true);
                string db_location = System.IO.Path.GetDirectoryName(FilePath.Text);
                CloneDirectory(db_location + @"\ConfigScreens", @".\ConfigScreens");
                FilePath.Clear();
                this.Close();
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FilePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
