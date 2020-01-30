namespace WindowConfiguration
{
    partial class windowconfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.winconfigbtn = new System.Windows.Forms.Button();
            this.windowconfigdisp = new System.Windows.Forms.ListView();
            this.nameheader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.caplayoutbtn = new System.Windows.Forms.Button();
            this.processdisplay = new System.Windows.Forms.ListView();
            this.windowcnfgnamelabel = new System.Windows.Forms.Label();
            this.processdisplaylabel = new System.Windows.Forms.Label();
            this.add_win_cfg_inp_box = new System.Windows.Forms.TextBox();
            this.add_win_cfg_btn = new System.Windows.Forms.Button();
            this.add_to_wnd_config_btn = new System.Windows.Forms.Button();
            this.identifierheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WidthHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeightHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.export_win_cfg_btn = new System.Windows.Forms.Button();
            this.new_win_cfg_label = new System.Windows.Forms.Label();
            this.export_name_txt_box = new System.Windows.Forms.TextBox();
            this.exp_name_label = new System.Windows.Forms.Label();
            this.Imp_win_cfg_btn = new System.Windows.Forms.Button();
            this.win_cfg_proc_dis = new System.Windows.Forms.ListView();
            this.winConfigHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WidthHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HeightHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.win_cfg_proc_label = new System.Windows.Forms.Label();
            this.win_cfg_proc_disp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winconfigbtn
            // 
            this.winconfigbtn.Location = new System.Drawing.Point(12, 913);
            this.winconfigbtn.Name = "winconfigbtn";
            this.winconfigbtn.Size = new System.Drawing.Size(380, 85);
            this.winconfigbtn.TabIndex = 0;
            this.winconfigbtn.Text = "Display Window Config";
            this.winconfigbtn.UseVisualStyleBackColor = true;
            this.winconfigbtn.Click += new System.EventHandler(this.winconfigbtn_Click);
            // 
            // windowconfigdisp
            // 
            this.windowconfigdisp.CheckBoxes = true;
            this.windowconfigdisp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameheader2});
            this.windowconfigdisp.FullRowSelect = true;
            this.windowconfigdisp.GridLines = true;
            this.windowconfigdisp.HideSelection = false;
            this.windowconfigdisp.Location = new System.Drawing.Point(12, 607);
            this.windowconfigdisp.Name = "windowconfigdisp";
            this.windowconfigdisp.Size = new System.Drawing.Size(380, 278);
            this.windowconfigdisp.TabIndex = 1;
            this.windowconfigdisp.UseCompatibleStateImageBehavior = false;
            this.windowconfigdisp.View = System.Windows.Forms.View.Details;
            this.windowconfigdisp.SelectedIndexChanged += new System.EventHandler(this.windowconfigdisp_SelectedIndexChanged);
            // 
            // nameheader2
            // 
            this.nameheader2.Text = "Name";
            this.nameheader2.Width = 376;
            // 
            // caplayoutbtn
            // 
            this.caplayoutbtn.Location = new System.Drawing.Point(12, 462);
            this.caplayoutbtn.Name = "caplayoutbtn";
            this.caplayoutbtn.Size = new System.Drawing.Size(392, 71);
            this.caplayoutbtn.TabIndex = 2;
            this.caplayoutbtn.Text = "Capture Screen Layout";
            this.caplayoutbtn.UseVisualStyleBackColor = true;
            this.caplayoutbtn.Click += new System.EventHandler(this.caplayoutbtn_Click);
            // 
            // processdisplay
            // 
            this.processdisplay.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.processdisplay.CheckBoxes = true;
            this.processdisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.LocationHeader,
            this.WidthHeader,
            this.HeightHeader,
            this.identifierheader});
            this.processdisplay.FullRowSelect = true;
            this.processdisplay.GridLines = true;
            this.processdisplay.HideSelection = false;
            this.processdisplay.Location = new System.Drawing.Point(12, 56);
            this.processdisplay.Name = "processdisplay";
            this.processdisplay.Size = new System.Drawing.Size(1278, 374);
            this.processdisplay.TabIndex = 3;
            this.processdisplay.UseCompatibleStateImageBehavior = false;
            this.processdisplay.View = System.Windows.Forms.View.Details;
            // 
            // windowcnfgnamelabel
            // 
            this.windowcnfgnamelabel.AutoSize = true;
            this.windowcnfgnamelabel.Location = new System.Drawing.Point(16, 559);
            this.windowcnfgnamelabel.Name = "windowcnfgnamelabel";
            this.windowcnfgnamelabel.Size = new System.Drawing.Size(376, 32);
            this.windowcnfgnamelabel.TabIndex = 4;
            this.windowcnfgnamelabel.Text = "Window Configuration Name";
            // 
            // processdisplaylabel
            // 
            this.processdisplaylabel.AutoSize = true;
            this.processdisplaylabel.Location = new System.Drawing.Point(538, 9);
            this.processdisplaylabel.Name = "processdisplaylabel";
            this.processdisplaylabel.Size = new System.Drawing.Size(218, 32);
            this.processdisplaylabel.TabIndex = 5;
            this.processdisplaylabel.Text = "Process Display";
            // 
            // add_win_cfg_inp_box
            // 
            this.add_win_cfg_inp_box.Location = new System.Drawing.Point(415, 807);
            this.add_win_cfg_inp_box.Multiline = true;
            this.add_win_cfg_inp_box.Name = "add_win_cfg_inp_box";
            this.add_win_cfg_inp_box.Size = new System.Drawing.Size(411, 78);
            this.add_win_cfg_inp_box.TabIndex = 6;
            this.add_win_cfg_inp_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // add_win_cfg_btn
            // 
            this.add_win_cfg_btn.Location = new System.Drawing.Point(415, 913);
            this.add_win_cfg_btn.Name = "add_win_cfg_btn";
            this.add_win_cfg_btn.Size = new System.Drawing.Size(411, 85);
            this.add_win_cfg_btn.TabIndex = 7;
            this.add_win_cfg_btn.Text = "Add Window Config";
            this.add_win_cfg_btn.UseVisualStyleBackColor = true;
            this.add_win_cfg_btn.Click += new System.EventHandler(this.add_win_cfg_btn_Click);
            // 
            // add_to_wnd_config_btn
            // 
            this.add_to_wnd_config_btn.Location = new System.Drawing.Point(879, 462);
            this.add_to_wnd_config_btn.Name = "add_to_wnd_config_btn";
            this.add_to_wnd_config_btn.Size = new System.Drawing.Size(411, 71);
            this.add_to_wnd_config_btn.TabIndex = 8;
            this.add_to_wnd_config_btn.Text = "Add to Window Config";
            this.add_to_wnd_config_btn.UseVisualStyleBackColor = true;
            this.add_to_wnd_config_btn.Click += new System.EventHandler(this.add_to_wnd_config_btn_Click);
            // 
            // identifierheader
            // 
            this.identifierheader.Text = "ID";
            this.identifierheader.Width = 90;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 557;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 347;
            // 
            // WidthHeader
            // 
            this.WidthHeader.Text = "Width";
            this.WidthHeader.Width = 365;
            // 
            // HeightHeader
            // 
            this.HeightHeader.Text = "Height";
            this.HeightHeader.Width = 420;
            // 
            // export_win_cfg_btn
            // 
            this.export_win_cfg_btn.Location = new System.Drawing.Point(854, 913);
            this.export_win_cfg_btn.Name = "export_win_cfg_btn";
            this.export_win_cfg_btn.Size = new System.Drawing.Size(342, 85);
            this.export_win_cfg_btn.TabIndex = 9;
            this.export_win_cfg_btn.Text = "Export Window Config";
            this.export_win_cfg_btn.UseVisualStyleBackColor = true;
            this.export_win_cfg_btn.Click += new System.EventHandler(this.export_win_cfg_btn_Click);
            // 
            // new_win_cfg_label
            // 
            this.new_win_cfg_label.AutoSize = true;
            this.new_win_cfg_label.Location = new System.Drawing.Point(487, 763);
            this.new_win_cfg_label.Name = "new_win_cfg_label";
            this.new_win_cfg_label.Size = new System.Drawing.Size(269, 32);
            this.new_win_cfg_label.TabIndex = 10;
            this.new_win_cfg_label.Text = "New Window Config";
            // 
            // export_name_txt_box
            // 
            this.export_name_txt_box.Location = new System.Drawing.Point(854, 807);
            this.export_name_txt_box.Multiline = true;
            this.export_name_txt_box.Name = "export_name_txt_box";
            this.export_name_txt_box.Size = new System.Drawing.Size(343, 78);
            this.export_name_txt_box.TabIndex = 11;
            // 
            // exp_name_label
            // 
            this.exp_name_label.AutoSize = true;
            this.exp_name_label.Location = new System.Drawing.Point(933, 763);
            this.exp_name_label.Name = "exp_name_label";
            this.exp_name_label.Size = new System.Drawing.Size(179, 32);
            this.exp_name_label.TabIndex = 12;
            this.exp_name_label.Text = "Export Name";
            this.exp_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Imp_win_cfg_btn
            // 
            this.Imp_win_cfg_btn.Location = new System.Drawing.Point(1226, 913);
            this.Imp_win_cfg_btn.Name = "Imp_win_cfg_btn";
            this.Imp_win_cfg_btn.Size = new System.Drawing.Size(398, 85);
            this.Imp_win_cfg_btn.TabIndex = 13;
            this.Imp_win_cfg_btn.Text = "Import Window Config";
            this.Imp_win_cfg_btn.UseVisualStyleBackColor = true;
            this.Imp_win_cfg_btn.Click += new System.EventHandler(this.Imp_win_cfg_btn_Click);
            // 
            // win_cfg_proc_dis
            // 
            this.win_cfg_proc_dis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.winConfigHeader,
            this.NameHeader3,
            this.LocationHeader2,
            this.WidthHeader2,
            this.HeightHeader2});
            this.win_cfg_proc_dis.FullRowSelect = true;
            this.win_cfg_proc_dis.GridLines = true;
            this.win_cfg_proc_dis.HideSelection = false;
            this.win_cfg_proc_dis.Location = new System.Drawing.Point(1323, 56);
            this.win_cfg_proc_dis.Name = "win_cfg_proc_dis";
            this.win_cfg_proc_dis.Size = new System.Drawing.Size(1325, 374);
            this.win_cfg_proc_dis.TabIndex = 14;
            this.win_cfg_proc_dis.UseCompatibleStateImageBehavior = false;
            this.win_cfg_proc_dis.View = System.Windows.Forms.View.Details;
            // 
            // winConfigHeader
            // 
            this.winConfigHeader.Text = "Config Name";
            this.winConfigHeader.Width = 260;
            // 
            // NameHeader3
            // 
            this.NameHeader3.Text = "Name";
            this.NameHeader3.Width = 348;
            // 
            // LocationHeader2
            // 
            this.LocationHeader2.Text = "Location";
            this.LocationHeader2.Width = 306;
            // 
            // WidthHeader2
            // 
            this.WidthHeader2.Text = "Width";
            this.WidthHeader2.Width = 277;
            // 
            // HeightHeader2
            // 
            this.HeightHeader2.Text = "Height";
            this.HeightHeader2.Width = 201;
            // 
            // win_cfg_proc_label
            // 
            this.win_cfg_proc_label.AutoSize = true;
            this.win_cfg_proc_label.Location = new System.Drawing.Point(1863, 9);
            this.win_cfg_proc_label.Name = "win_cfg_proc_label";
            this.win_cfg_proc_label.Size = new System.Drawing.Size(416, 32);
            this.win_cfg_proc_label.TabIndex = 15;
            this.win_cfg_proc_label.Text = "Window Config Process Display";
            // 
            // win_cfg_proc_disp
            // 
            this.win_cfg_proc_disp.Location = new System.Drawing.Point(1751, 462);
            this.win_cfg_proc_disp.Name = "win_cfg_proc_disp";
            this.win_cfg_proc_disp.Size = new System.Drawing.Size(461, 71);
            this.win_cfg_proc_disp.TabIndex = 16;
            this.win_cfg_proc_disp.Text = "Display Window Config Process";
            this.win_cfg_proc_disp.UseVisualStyleBackColor = true;
            this.win_cfg_proc_disp.Click += new System.EventHandler(this.win_cfg_proc_disp_Click);
            // 
            // windowconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2660, 1039);
            this.Controls.Add(this.win_cfg_proc_disp);
            this.Controls.Add(this.win_cfg_proc_label);
            this.Controls.Add(this.win_cfg_proc_dis);
            this.Controls.Add(this.Imp_win_cfg_btn);
            this.Controls.Add(this.exp_name_label);
            this.Controls.Add(this.export_name_txt_box);
            this.Controls.Add(this.new_win_cfg_label);
            this.Controls.Add(this.export_win_cfg_btn);
            this.Controls.Add(this.add_to_wnd_config_btn);
            this.Controls.Add(this.add_win_cfg_btn);
            this.Controls.Add(this.add_win_cfg_inp_box);
            this.Controls.Add(this.processdisplaylabel);
            this.Controls.Add(this.windowcnfgnamelabel);
            this.Controls.Add(this.processdisplay);
            this.Controls.Add(this.caplayoutbtn);
            this.Controls.Add(this.windowconfigdisp);
            this.Controls.Add(this.winconfigbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "windowconfig";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.windowconfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button winconfigbtn;
        private System.Windows.Forms.ListView windowconfigdisp;
        private System.Windows.Forms.Button caplayoutbtn;
        private System.Windows.Forms.ListView processdisplay;
        private System.Windows.Forms.Label windowcnfgnamelabel;
        private System.Windows.Forms.Label processdisplaylabel;
        private System.Windows.Forms.TextBox add_win_cfg_inp_box;
        private System.Windows.Forms.Button add_win_cfg_btn;
        private System.Windows.Forms.ColumnHeader nameheader2;
        private System.Windows.Forms.Button add_to_wnd_config_btn;
        private System.Windows.Forms.ColumnHeader identifierheader;
        private System.Windows.Forms.ColumnHeader NameHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader WidthHeader;
        private System.Windows.Forms.ColumnHeader HeightHeader;
        private System.Windows.Forms.Button export_win_cfg_btn;
        private System.Windows.Forms.Label new_win_cfg_label;
        private System.Windows.Forms.TextBox export_name_txt_box;
        private System.Windows.Forms.Label exp_name_label;
        private System.Windows.Forms.Button Imp_win_cfg_btn;
        private System.Windows.Forms.ListView win_cfg_proc_dis;
        private System.Windows.Forms.ColumnHeader winConfigHeader;
        private System.Windows.Forms.ColumnHeader NameHeader3;
        private System.Windows.Forms.ColumnHeader LocationHeader2;
        private System.Windows.Forms.ColumnHeader WidthHeader2;
        private System.Windows.Forms.ColumnHeader HeightHeader2;
        private System.Windows.Forms.Label win_cfg_proc_label;
        private System.Windows.Forms.Button win_cfg_proc_disp;
    }
}

