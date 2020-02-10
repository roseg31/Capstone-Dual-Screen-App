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

        // Browse button listener that allows the user to browse a folder to save the user's DB
        private void brwse_btn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog export = new FolderBrowserDialog();
            if (export.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fol_path.Text = export.SelectedPath;
            }

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
            //Export vars and create export directory
            string ExpOriginFileName = "WindowDB.db";
            string ExpFileName;
            string ExpSourcePath = @".\";
            string ExpSourceFile = System.IO.Path.Combine(ExpSourcePath, ExpOriginFileName);
            string ExpDestFile;

            // Get the export folder path from the user by using file explorer
            if(fol_path.Text != "")
            {
                if (exp_filename.Text != "")
                {
                    if (!exp_filename.Text.Contains(".db"))
                    {
                        if (System.IO.Directory.Exists(fol_path.Text))
                        {
                            // Save the .db DB and the image previews to the selected folder
                            ExpFileName = exp_filename.Text + ".db";
                            System.IO.Directory.CreateDirectory(fol_path.Text + @"\" + exp_filename.Text);
                            System.IO.Directory.CreateDirectory(fol_path.Text + @"\" + exp_filename.Text + @"\ConfigScreens");
                            if (System.IO.Directory.Exists(@".\ConfigScreens"))
                            {
                                CloneDirectory(@".\ConfigScreens", fol_path.Text + @"\" + exp_filename.Text + @"\ConfigScreens");
                            }
                            ExpDestFile = System.IO.Path.Combine(fol_path.Text + @"\" + exp_filename.Text, ExpFileName);
                            System.IO.File.Copy(ExpSourceFile, ExpDestFile, true);
                            exp_err_label.Visible = false;
                            fol_path.Clear();
                            exp_filename.Clear();
                            this.Hide();
                        }
                        else
                        {
                            exp_err_label.Text = "Folder Path doesn't Exist!";
                            exp_err_label.Visible = true;
                        }

                    }
                    else
                    {
                        exp_err_label.Text = "Remove .db from Export File Name!";
                        exp_err_label.Visible = true;
                    }

                }
                else
                {
                    exp_err_label.Text = "Missing Export File Name!";
                    exp_err_label.Visible = true;
                }
            }
            else
            {
                exp_err_label.Text = "Missing Folder Path!";
                exp_err_label.Visible = true;
            }

        }

        private void exp_file_label_Click(object sender, EventArgs e)
        {

        }
    }
}
