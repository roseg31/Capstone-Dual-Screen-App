namespace WindowConfiguration
{
    partial class new_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_config));
            this.cfg_name_label = new System.Windows.Forms.Label();
            this.cfg_name_box = new System.Windows.Forms.TextBox();
            this.cfg_desc_label = new System.Windows.Forms.Label();
            this.cfg_desc_box = new System.Windows.Forms.TextBox();
            this.preview_label = new System.Windows.Forms.Label();
            this.save_cfg_btn = new System.Windows.Forms.Button();
            this.cncl_cfg_btn = new System.Windows.Forms.Button();
            this.proc_list_view = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.process_list_label = new System.Windows.Forms.Label();
            this.new_cfg_err_label = new System.Windows.Forms.Label();
            this.CompanionScreenDisp = new System.Windows.Forms.PictureBox();
            this.PrimaryScreenDisp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryScreenDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanionScreenDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // cfg_name_label
            // 
            this.cfg_name_label.AutoSize = true;
            this.cfg_name_label.Location = new System.Drawing.Point(35, 70);
            this.cfg_name_label.Name = "cfg_name_label";
            this.cfg_name_label.Size = new System.Drawing.Size(276, 32);
            this.cfg_name_label.TabIndex = 0;
            this.cfg_name_label.Text = "Configuration Name:";
            // 
            // cfg_name_box
            // 
            this.cfg_name_box.Location = new System.Drawing.Point(310, 70);
            this.cfg_name_box.Name = "cfg_name_box";
            this.cfg_name_box.Size = new System.Drawing.Size(598, 38);
            this.cfg_name_box.TabIndex = 1;
            // 
            // cfg_desc_label
            // 
            this.cfg_desc_label.AutoSize = true;
            this.cfg_desc_label.Location = new System.Drawing.Point(35, 148);
            this.cfg_desc_label.Name = "cfg_desc_label";
            this.cfg_desc_label.Size = new System.Drawing.Size(256, 32);
            this.cfg_desc_label.TabIndex = 2;
            this.cfg_desc_label.Text = "Config Description:";
            // 
            // cfg_desc_box
            // 
            this.cfg_desc_box.Location = new System.Drawing.Point(41, 195);
            this.cfg_desc_box.Multiline = true;
            this.cfg_desc_box.Name = "cfg_desc_box";
            this.cfg_desc_box.Size = new System.Drawing.Size(867, 520);
            this.cfg_desc_box.TabIndex = 3;
            // 
            // preview_label
            // 
            this.preview_label.AutoSize = true;
            this.preview_label.Location = new System.Drawing.Point(1378, 25);
            this.preview_label.Name = "preview_label";
            this.preview_label.Size = new System.Drawing.Size(116, 32);
            this.preview_label.TabIndex = 5;
            this.preview_label.Text = "Preview";
            // 
            // save_cfg_btn
            // 
            this.save_cfg_btn.Location = new System.Drawing.Point(972, 972);
            this.save_cfg_btn.Name = "save_cfg_btn";
            this.save_cfg_btn.Size = new System.Drawing.Size(270, 77);
            this.save_cfg_btn.TabIndex = 7;
            this.save_cfg_btn.Text = "Save";
            this.save_cfg_btn.UseVisualStyleBackColor = true;
            this.save_cfg_btn.Click += new System.EventHandler(this.save_cfg_btn_Click);
            // 
            // cncl_cfg_btn
            // 
            this.cncl_cfg_btn.Location = new System.Drawing.Point(1585, 972);
            this.cncl_cfg_btn.Name = "cncl_cfg_btn";
            this.cncl_cfg_btn.Size = new System.Drawing.Size(270, 77);
            this.cncl_cfg_btn.TabIndex = 8;
            this.cncl_cfg_btn.Text = "Cancel";
            this.cncl_cfg_btn.UseVisualStyleBackColor = true;
            this.cncl_cfg_btn.Click += new System.EventHandler(this.cncl_cfg_btn_Click);
            // 
            // proc_list_view
            // 
            this.proc_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.LocationHeader,
            this.sizeHeader});
            this.proc_list_view.FullRowSelect = true;
            this.proc_list_view.GridLines = true;
            this.proc_list_view.HideSelection = false;
            this.proc_list_view.Location = new System.Drawing.Point(41, 784);
            this.proc_list_view.Name = "proc_list_view";
            this.proc_list_view.Size = new System.Drawing.Size(867, 276);
            this.proc_list_view.TabIndex = 9;
            this.proc_list_view.UseCompatibleStateImageBehavior = false;
            this.proc_list_view.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 551;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 150;
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "Size";
            this.sizeHeader.Width = 160;
            // 
            // process_list_label
            // 
            this.process_list_label.AutoSize = true;
            this.process_list_label.Location = new System.Drawing.Point(35, 739);
            this.process_list_label.Name = "process_list_label";
            this.process_list_label.Size = new System.Drawing.Size(216, 32);
            this.process_list_label.TabIndex = 10;
            this.process_list_label.Text = "Process Listing:";
            this.process_list_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_cfg_err_label
            // 
            this.new_cfg_err_label.AutoSize = true;
            this.new_cfg_err_label.ForeColor = System.Drawing.Color.Red;
            this.new_cfg_err_label.Location = new System.Drawing.Point(1226, 918);
            this.new_cfg_err_label.Name = "new_cfg_err_label";
            this.new_cfg_err_label.Size = new System.Drawing.Size(374, 32);
            this.new_cfg_err_label.TabIndex = 11;
            this.new_cfg_err_label.Text = "NEW_CFG_ERROR_LABEL";
            this.new_cfg_err_label.Visible = false;
            // 
            // CompanionScreenDisp
            // 
            this.CompanionScreenDisp.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompanionScreenDisp.InitialImage")));
            this.CompanionScreenDisp.Location = new System.Drawing.Point(972, 619);
            this.CompanionScreenDisp.Name = "CompanionScreenDisp";
            this.CompanionScreenDisp.Size = new System.Drawing.Size(883, 278);
            this.CompanionScreenDisp.TabIndex = 12;
            this.CompanionScreenDisp.TabStop = false;
            // 
            // PrimaryScreenDisp
            // 
            this.PrimaryScreenDisp.InitialImage = ((System.Drawing.Image)(resources.GetObject("PrimaryScreenDisp.InitialImage")));
            this.PrimaryScreenDisp.Location = new System.Drawing.Point(972, 70);
            this.PrimaryScreenDisp.Name = "PrimaryScreenDisp";
            this.PrimaryScreenDisp.Size = new System.Drawing.Size(883, 533);
            this.PrimaryScreenDisp.TabIndex = 13;
            this.PrimaryScreenDisp.TabStop = false;
            // 
            // new_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1072);
            this.Controls.Add(this.PrimaryScreenDisp);
            this.Controls.Add(this.CompanionScreenDisp);
            this.Controls.Add(this.new_cfg_err_label);
            this.Controls.Add(this.process_list_label);
            this.Controls.Add(this.proc_list_view);
            this.Controls.Add(this.cncl_cfg_btn);
            this.Controls.Add(this.save_cfg_btn);
            this.Controls.Add(this.preview_label);
            this.Controls.Add(this.cfg_desc_box);
            this.Controls.Add(this.cfg_desc_label);
            this.Controls.Add(this.cfg_name_box);
            this.Controls.Add(this.cfg_name_label);
            this.Name = "new_config";
            this.Text = "new_config";
            ((System.ComponentModel.ISupportInitialize)(this.CompanionScreenDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryScreenDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cfg_name_label;
        private System.Windows.Forms.TextBox cfg_name_box;
        private System.Windows.Forms.Label cfg_desc_label;
        private System.Windows.Forms.TextBox cfg_desc_box;
        private System.Windows.Forms.Label preview_label;
        private System.Windows.Forms.Button save_cfg_btn;
        private System.Windows.Forms.Button cncl_cfg_btn;
        private System.Windows.Forms.ListView proc_list_view;
        private System.Windows.Forms.Label process_list_label;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader sizeHeader;
        private System.Windows.Forms.Label new_cfg_err_label;
        private System.Windows.Forms.PictureBox CompanionScreenDisp;
        private System.Windows.Forms.PictureBox PrimaryScreenDisp;
    }
}