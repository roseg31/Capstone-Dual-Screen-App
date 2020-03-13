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
            InitializeComponent();
            this.Text = "Home - Welcome to TechDuo?DuoTech? Who are we?";
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
    }
}