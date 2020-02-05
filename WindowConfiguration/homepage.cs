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

        public homepage()
        {
            InitializeComponent();
        }

        private void cfg_list_btn_Click(object sender, EventArgs e)
        {
            win_cfg_list.RefToHompage = this;
            this.Visible = false;
            win_cfg_list.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}