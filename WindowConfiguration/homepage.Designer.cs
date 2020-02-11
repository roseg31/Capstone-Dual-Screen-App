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
            this.cfg_list_btn.Location = new System.Drawing.Point(299, 172);
            this.cfg_list_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cfg_list_btn.Name = "cfg_list_btn";
            this.cfg_list_btn.Size = new System.Drawing.Size(287, 107);
            this.cfg_list_btn.TabIndex = 0;
            this.cfg_list_btn.Text = "Configuration List";
            this.cfg_list_btn.UseVisualStyleBackColor = true;
            this.cfg_list_btn.Click += new System.EventHandler(this.cfg_list_btn_Click);
            // 
            // main_title_label
            // 
            this.main_title_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title_label.Location = new System.Drawing.Point(246, 60);
            this.main_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_title_label.Size = new System.Drawing.Size(433, 86);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "TechDuo (Logo)\r\n";
            this.main_title_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.main_title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.Location = new System.Drawing.Point(717, 445);
            this.contact_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(207, 112);
            this.contact_label.TabIndex = 2;
            this.contact_label.Text = "Bugs or questions? Email us at:\r\nSakthisa@oregonstate.edu\r\nKieftd@oregonstate.edu" +
    "\r\nGarciros@oregonstate.edu\r\nFerchlam@oregonstate.edu \r\n\r\n\r\n";
            this.contact_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tutorial_btn
            // 
            this.tutorial_btn.Location = new System.Drawing.Point(342, 324);
            this.tutorial_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutorial_btn.Name = "tutorial_btn";
            this.tutorial_btn.Size = new System.Drawing.Size(191, 62);
            this.tutorial_btn.TabIndex = 3;
            this.tutorial_btn.Text = "Tutorial";
            this.tutorial_btn.UseVisualStyleBackColor = true;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.tutorial_btn);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.main_title_label);
            this.Controls.Add(this.cfg_list_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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