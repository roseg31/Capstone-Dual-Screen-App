namespace WindowConfiguration
{
    partial class export
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
            this.sel_fol_label = new System.Windows.Forms.Label();
            this.fol_path = new System.Windows.Forms.TextBox();
            this.brwse_btn = new System.Windows.Forms.Button();
            this.exp_accept_btn = new System.Windows.Forms.Button();
            this.cancel_exp_btn = new System.Windows.Forms.Button();
            this.exp_file_label = new System.Windows.Forms.Label();
            this.exp_filename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sel_fol_label
            // 
            this.sel_fol_label.AutoSize = true;
            this.sel_fol_label.Location = new System.Drawing.Point(125, 67);
            this.sel_fol_label.Name = "sel_fol_label";
            this.sel_fol_label.Size = new System.Drawing.Size(214, 32);
            this.sel_fol_label.TabIndex = 0;
            this.sel_fol_label.Text = "Select a Folder:";
            // 
            // fol_path
            // 
            this.fol_path.CausesValidation = false;
            this.fol_path.Location = new System.Drawing.Point(355, 67);
            this.fol_path.Name = "fol_path";
            this.fol_path.Size = new System.Drawing.Size(645, 38);
            this.fol_path.TabIndex = 1;
            // 
            // brwse_btn
            // 
            this.brwse_btn.Location = new System.Drawing.Point(1028, 52);
            this.brwse_btn.Name = "brwse_btn";
            this.brwse_btn.Size = new System.Drawing.Size(213, 61);
            this.brwse_btn.TabIndex = 2;
            this.brwse_btn.Text = "BROWSE";
            this.brwse_btn.UseVisualStyleBackColor = true;
            this.brwse_btn.Click += new System.EventHandler(this.brwse_btn_Click);
            // 
            // exp_accept_btn
            // 
            this.exp_accept_btn.Location = new System.Drawing.Point(803, 257);
            this.exp_accept_btn.Name = "exp_accept_btn";
            this.exp_accept_btn.Size = new System.Drawing.Size(197, 68);
            this.exp_accept_btn.TabIndex = 3;
            this.exp_accept_btn.Text = "EXPORT";
            this.exp_accept_btn.UseVisualStyleBackColor = true;
            this.exp_accept_btn.Click += new System.EventHandler(this.exp_accept_btn_Click);
            // 
            // cancel_exp_btn
            // 
            this.cancel_exp_btn.Location = new System.Drawing.Point(1044, 256);
            this.cancel_exp_btn.Name = "cancel_exp_btn";
            this.cancel_exp_btn.Size = new System.Drawing.Size(197, 71);
            this.cancel_exp_btn.TabIndex = 4;
            this.cancel_exp_btn.Text = "CANCEL";
            this.cancel_exp_btn.UseVisualStyleBackColor = true;
            this.cancel_exp_btn.Click += new System.EventHandler(this.cancel_exp_btn_Click);
            // 
            // exp_file_label
            // 
            this.exp_file_label.AutoSize = true;
            this.exp_file_label.Location = new System.Drawing.Point(98, 157);
            this.exp_file_label.Name = "exp_file_label";
            this.exp_file_label.Size = new System.Drawing.Size(241, 32);
            this.exp_file_label.TabIndex = 5;
            this.exp_file_label.Text = "Export File Name:";
            this.exp_file_label.Click += new System.EventHandler(this.exp_file_label_Click);
            // 
            // exp_filename
            // 
            this.exp_filename.Location = new System.Drawing.Point(355, 151);
            this.exp_filename.Name = "exp_filename";
            this.exp_filename.Size = new System.Drawing.Size(645, 38);
            this.exp_filename.TabIndex = 6;
            // 
            // export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 337);
            this.Controls.Add(this.exp_filename);
            this.Controls.Add(this.exp_file_label);
            this.Controls.Add(this.cancel_exp_btn);
            this.Controls.Add(this.exp_accept_btn);
            this.Controls.Add(this.brwse_btn);
            this.Controls.Add(this.fol_path);
            this.Controls.Add(this.sel_fol_label);
            this.Name = "export";
            this.Text = "export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sel_fol_label;
        private System.Windows.Forms.TextBox fol_path;
        private System.Windows.Forms.Button brwse_btn;
        private System.Windows.Forms.Button exp_accept_btn;
        private System.Windows.Forms.Button cancel_exp_btn;
        private System.Windows.Forms.Label exp_file_label;
        private System.Windows.Forms.TextBox exp_filename;
    }
}