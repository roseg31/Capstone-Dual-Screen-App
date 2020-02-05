namespace WindowConfiguration
{
    partial class homepage
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
            this.cfg_list_btn = new System.Windows.Forms.Button();
            this.main_title_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.tutorial_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cfg_list_btn
            // 
            this.cfg_list_btn.Location = new System.Drawing.Point(546, 380);
            this.cfg_list_btn.Name = "cfg_list_btn";
            this.cfg_list_btn.Size = new System.Drawing.Size(511, 166);
            this.cfg_list_btn.TabIndex = 0;
            this.cfg_list_btn.Text = "Configuration List";
            this.cfg_list_btn.UseVisualStyleBackColor = true;
            this.cfg_list_btn.Click += new System.EventHandler(this.cfg_list_btn_Click);
            // 
            // main_title_label
            // 
            this.main_title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title_label.Location = new System.Drawing.Point(287, 88);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_title_label.Size = new System.Drawing.Size(1042, 133);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "TechDuo (Add Logo?)\r\n";
            this.main_title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(1221, 700);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(413, 224);
            this.contact_label.TabIndex = 2;
            this.contact_label.Text = "Bugs or questions? Email us at:\r\nSakthisa@oregonstate.edu\r\nKieftd@oregonstate.edu" +
    "\r\nGarciros@oregonstate.edu\r\nFerchlam@oregonstate.edu \r\n\r\n\r\n";
            // 
            // tutorial_btn
            // 
            this.tutorial_btn.Location = new System.Drawing.Point(31, 748);
            this.tutorial_btn.Name = "tutorial_btn";
            this.tutorial_btn.Size = new System.Drawing.Size(339, 96);
            this.tutorial_btn.TabIndex = 3;
            this.tutorial_btn.Text = "Tutorial";
            this.tutorial_btn.UseVisualStyleBackColor = true;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 877);
            this.Controls.Add(this.tutorial_btn);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.main_title_label);
            this.Controls.Add(this.cfg_list_btn);
            this.Name = "homepage";
            this.Text = "homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cfg_list_btn;
        private System.Windows.Forms.Label main_title_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Button tutorial_btn;
    }
}