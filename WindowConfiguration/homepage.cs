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
    public partial class homepage : Form
    {
        private windowconfig win_cfg_list = new windowconfig();

        // WinForms generates a constructor for each form, don't need to change anything here
        public homepage()
        {
            Properties.Settings.Default.runTutorial = false;
            Properties.Settings.Default.Save();
            InitializeComponent();
            this.Text = "Home - Welcome to DuoTech";
            richTextBox1.Visible = false;
            endTutorial.Visible = false;
            docuTip.Visible = false;
            
            update_homepage_tutorial();
        }

        //Handles updating tutorial elements for homepage
        private void update_homepage_tutorial()
        {
            //If tutorial is running, show tutorial elements
            if (Properties.Settings.Default.runTutorial == true)
            {
                if(Properties.Settings.Default.endingHomeTut == true)
                {
                    richTextBox1.Visible = true;
                    docuTip.Visible = true;
                    endTutorial.Visible = true;

                } else if (tutorialRun.Checked)
                {
                    richTextBox1.Visible = true;
                    docuTip.Visible = true;
                    endTutorial.Visible = true;
                    Properties.Settings.Default.createConfigTut = true;
                }
            } else
            {
                richTextBox1.Visible = false;
                endTutorial.Visible = false;
                docuTip.Visible = false;
                Properties.Settings.Default.createConfigTut = false;
                Properties.Settings.Default.endingHomeTut = false;
            }
        }

        // This is a button click handler. When the user clicks the button they are transferred to the windowconfig form
        private void cfg_list_btn_Click(object sender, EventArgs e)
        {
            // Giving a reference to the hompage the windowconfig form b/c want to go back to this form when we hit the 'back' button
            win_cfg_list.RefToHompage = this;
            this.Visible = false;

            // Display the windowconfig form
            win_cfg_list.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tutorial_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/roseg31/Capstone-Dual-Screen-App/blob/master/HELP.md");
        }

        //Get input from tutorial check box and change settings accordingly
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tutorialRun.Checked)
            {
                Properties.Settings.Default.runTutorial = true;
                Properties.Settings.Default.createConfigTut = true;
                Properties.Settings.Default.selectConfigTut = false;
                Properties.Settings.Default.runConfigTut = false;
                Properties.Settings.Default.wrapupTut = false;
            }
            else
            {
                Properties.Settings.Default.createConfigTut = false;
                Properties.Settings.Default.runTutorial = false;
            }
            update_homepage_tutorial();
            win_cfg_list.update_configlist_tutorial();
        }
    }
}