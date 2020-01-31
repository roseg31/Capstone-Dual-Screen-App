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
            this.app_list_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cfg_list_btn
            // 
            this.cfg_list_btn.Location = new System.Drawing.Point(932, 352);
            this.cfg_list_btn.Name = "cfg_list_btn";
            this.cfg_list_btn.Size = new System.Drawing.Size(344, 97);
            this.cfg_list_btn.TabIndex = 0;
            this.cfg_list_btn.Text = "Configuration List";
            this.cfg_list_btn.UseVisualStyleBackColor = true;
            this.cfg_list_btn.Click += new System.EventHandler(this.cfg_list_btn_Click);
            // 
            // app_list_btn
            // 
            this.app_list_btn.Location = new System.Drawing.Point(318, 352);
            this.app_list_btn.Name = "app_list_btn";
            this.app_list_btn.Size = new System.Drawing.Size(347, 97);
            this.app_list_btn.TabIndex = 1;
            this.app_list_btn.Text = "Applications List";
            this.app_list_btn.UseVisualStyleBackColor = true;
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 877);
            this.Controls.Add(this.app_list_btn);
            this.Controls.Add(this.cfg_list_btn);
            this.Name = "homepage";
            this.Text = "homepage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cfg_list_btn;
        private System.Windows.Forms.Button app_list_btn;
    }
}