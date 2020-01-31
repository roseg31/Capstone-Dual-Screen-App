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

        private void imp_ok_btn_Click(object sender, EventArgs e)
        {
            if(FilePath.Text != "")
            {
                string ImpDestFileName = "WindowDB.db";
                string ImpDestPath = @".\";
                string ImpDestFile = System.IO.Path.Combine(ImpDestPath, ImpDestFileName);
                System.IO.File.Copy(FilePath.Text, ImpDestFile, true);
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
