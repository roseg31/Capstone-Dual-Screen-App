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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(windowconfig));
            this.back_btn = new System.Windows.Forms.Button();
            this.cfg_display = new System.Windows.Forms.ListView();
            this.nameheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numappheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionheader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cfg_label = new System.Windows.Forms.Label();
            this.new_cfg_btn = new System.Windows.Forms.Button();
            this.imp_btn = new System.Windows.Forms.Button();
            this.exp_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.preview_cfg_prim = new System.Windows.Forms.PictureBox();
            this.preview_cfg_companion = new System.Windows.Forms.PictureBox();
            this.preview_label = new System.Windows.Forms.Label();
            this.configure_btn = new System.Windows.Forms.Button();
            this.cfg_err_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preview_cfg_prim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_cfg_companion)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(1560, 922);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(183, 73);
            this.back_btn.TabIndex = 17;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // cfg_display
            // 
            this.cfg_display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameheader,
            this.numappheader,
            this.descriptionheader});
            this.cfg_display.FullRowSelect = true;
            this.cfg_display.GridLines = true;
            this.cfg_display.HideSelection = false;
            this.cfg_display.Location = new System.Drawing.Point(96, 104);
            this.cfg_display.Name = "cfg_display";
            this.cfg_display.Size = new System.Drawing.Size(1647, 622);
            this.cfg_display.TabIndex = 18;
            this.cfg_display.UseCompatibleStateImageBehavior = false;
            this.cfg_display.View = System.Windows.Forms.View.Details;
            this.cfg_display.SelectedIndexChanged += new System.EventHandler(this.cfg_display_SelectedIndexChanged);
            // 
            // nameheader
            // 
            this.nameheader.Text = "Name";
            this.nameheader.Width = 451;
            // 
            // numappheader
            // 
            this.numappheader.Text = "Number of Apps";
            this.numappheader.Width = 585;
            // 
            // descriptionheader
            // 
            this.descriptionheader.Text = "Description";
            this.descriptionheader.Width = 602;
            // 
            // cfg_label
            // 
            this.cfg_label.AutoSize = true;
            this.cfg_label.Location = new System.Drawing.Point(101, 46);
            this.cfg_label.Name = "cfg_label";
            this.cfg_label.Size = new System.Drawing.Size(267, 32);
            this.cfg_label.TabIndex = 19;
            this.cfg_label.Text = "CONFIGURATIONS";
            this.cfg_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_cfg_btn
            // 
            this.new_cfg_btn.Location = new System.Drawing.Point(96, 773);
            this.new_cfg_btn.Name = "new_cfg_btn";
            this.new_cfg_btn.Size = new System.Drawing.Size(272, 76);
            this.new_cfg_btn.TabIndex = 20;
            this.new_cfg_btn.Text = "NEW CONFIG";
            this.new_cfg_btn.UseVisualStyleBackColor = true;
            this.new_cfg_btn.Click += new System.EventHandler(this.new_cfg_btn_Click);
            // 
            // imp_btn
            // 
            this.imp_btn.Location = new System.Drawing.Point(418, 773);
            this.imp_btn.Name = "imp_btn";
            this.imp_btn.Size = new System.Drawing.Size(272, 76);
            this.imp_btn.TabIndex = 21;
            this.imp_btn.Text = "IMPORT";
            this.imp_btn.UseVisualStyleBackColor = true;
            this.imp_btn.Click += new System.EventHandler(this.imp_btn_Click);
            // 
            // exp_btn
            // 
            this.exp_btn.Location = new System.Drawing.Point(747, 773);
            this.exp_btn.Name = "exp_btn";
            this.exp_btn.Size = new System.Drawing.Size(272, 76);
            this.exp_btn.TabIndex = 22;
            this.exp_btn.Text = "EXPORT";
            this.exp_btn.UseVisualStyleBackColor = true;
            this.exp_btn.Click += new System.EventHandler(this.exp_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(1089, 773);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(272, 76);
            this.del_btn.TabIndex = 23;
            this.del_btn.Text = "DELETE";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // preview_cfg_prim
            // 
            this.preview_cfg_prim.InitialImage = ((System.Drawing.Image)(resources.GetObject("preview_cfg_prim.InitialImage")));
            this.preview_cfg_prim.Location = new System.Drawing.Point(1782, 104);
            this.preview_cfg_prim.Name = "preview_cfg_prim";
            this.preview_cfg_prim.Size = new System.Drawing.Size(839, 486);
            this.preview_cfg_prim.TabIndex = 24;
            this.preview_cfg_prim.TabStop = false;
            this.preview_cfg_prim.Click += new System.EventHandler(this.preview_cfg_prim_Click);
            // 
            // preview_cfg_companion
            // 
            this.preview_cfg_companion.InitialImage = ((System.Drawing.Image)(resources.GetObject("preview_cfg_companion.InitialImage")));
            this.preview_cfg_companion.Location = new System.Drawing.Point(1782, 625);
            this.preview_cfg_companion.Name = "preview_cfg_companion";
            this.preview_cfg_companion.Size = new System.Drawing.Size(839, 237);
            this.preview_cfg_companion.TabIndex = 25;
            this.preview_cfg_companion.TabStop = false;
            // 
            // preview_label
            // 
            this.preview_label.AutoSize = true;
            this.preview_label.Location = new System.Drawing.Point(2145, 46);
            this.preview_label.Name = "preview_label";
            this.preview_label.Size = new System.Drawing.Size(116, 32);
            this.preview_label.TabIndex = 26;
            this.preview_label.Text = "Preview";
            // 
            // configure_btn
            // 
            this.configure_btn.Location = new System.Drawing.Point(2050, 922);
            this.configure_btn.Name = "configure_btn";
            this.configure_btn.Size = new System.Drawing.Size(338, 73);
            this.configure_btn.TabIndex = 27;
            this.configure_btn.Text = "Configure";
            this.configure_btn.UseVisualStyleBackColor = true;
            this.configure_btn.Click += new System.EventHandler(this.configure_btn_Click);
            // 
            // cfg_err_label
            // 
            this.cfg_err_label.AutoSize = true;
            this.cfg_err_label.ForeColor = System.Drawing.Color.Red;
            this.cfg_err_label.Location = new System.Drawing.Point(536, 922);
            this.cfg_err_label.Name = "cfg_err_label";
            this.cfg_err_label.Size = new System.Drawing.Size(343, 32);
            this.cfg_err_label.TabIndex = 28;
            this.cfg_err_label.Text = "CONFIG_ERROR_LABEL";
            this.cfg_err_label.Visible = false;
            // 
            // windowconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2665, 1039);
            this.Controls.Add(this.cfg_err_label);
            this.Controls.Add(this.configure_btn);
            this.Controls.Add(this.preview_label);
            this.Controls.Add(this.preview_cfg_prim);
            this.Controls.Add(this.preview_cfg_companion);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.exp_btn);
            this.Controls.Add(this.imp_btn);
            this.Controls.Add(this.new_cfg_btn);
            this.Controls.Add(this.cfg_label);
            this.Controls.Add(this.cfg_display);
            this.Controls.Add(this.back_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "windowconfig";
            this.Text = "DuoTech";
            this.Load += new System.EventHandler(this.windowconfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.preview_cfg_prim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview_cfg_companion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ListView cfg_display;
        private System.Windows.Forms.Label cfg_label;
        private System.Windows.Forms.ColumnHeader nameheader;
        private System.Windows.Forms.ColumnHeader numappheader;
        private System.Windows.Forms.ColumnHeader descriptionheader;
        private System.Windows.Forms.Button new_cfg_btn;
        private System.Windows.Forms.Button imp_btn;
        private System.Windows.Forms.Button exp_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.PictureBox preview_cfg_prim;
        private System.Windows.Forms.PictureBox preview_cfg_companion;
        private System.Windows.Forms.Label preview_label;
        private System.Windows.Forms.Button configure_btn;
        private System.Windows.Forms.Label cfg_err_label;
    }
}

