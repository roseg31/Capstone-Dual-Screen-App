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
        }

        private void brwse_btn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog export = new FolderBrowserDialog();
            if (export.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fol_path.Text = export.SelectedPath;
            }

        }

        private void cancel_exp_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exp_accept_btn_Click(object sender, EventArgs e)
        {
            //Export vars and create export directory
            string ExpOriginFileName = "WindowDB.db";
            string ExpFileName = "CopyWindowDB.db";
            string ExpSourcePath = @".\";
            string ExpSourceFile = System.IO.Path.Combine(ExpSourcePath, ExpOriginFileName);
            string ExpDestFile;

            // Get the export folder path from the user by using file explorer
            if(fol_path.Text != "")
            {
                if (exp_filename.Text != "")
                {
                    ExpFileName = exp_filename.Text + ".db";
                }
                ExpDestFile = System.IO.Path.Combine(fol_path.Text, ExpFileName);
                System.IO.File.Copy(ExpSourceFile, ExpDestFile, true);
                fol_path.Clear();
                exp_filename.Clear();
                this.Hide();
            }

        }
    }
}
