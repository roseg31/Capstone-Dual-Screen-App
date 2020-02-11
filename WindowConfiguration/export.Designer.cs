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
            this.exp_err_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sel_fol_label
            // 
            this.sel_fol_label.AutoSize = true;
            this.sel_fol_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_fol_label.Location = new System.Drawing.Point(44, 43);
            this.sel_fol_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sel_fol_label.Name = "sel_fol_label";
            this.sel_fol_label.Size = new System.Drawing.Size(152, 23);
            this.sel_fol_label.TabIndex = 0;
            this.sel_fol_label.Text = "Select a Folder:";
            // 
            // fol_path
            // 
            this.fol_path.CausesValidation = false;
            this.fol_path.Location = new System.Drawing.Point(200, 43);
            this.fol_path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fol_path.Name = "fol_path";
            this.fol_path.Size = new System.Drawing.Size(365, 26);
            this.fol_path.TabIndex = 1;
            // 
            // brwse_btn
            // 
            this.brwse_btn.Location = new System.Drawing.Point(578, 34);
            this.brwse_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brwse_btn.Name = "brwse_btn";
            this.brwse_btn.Size = new System.Drawing.Size(120, 39);
            this.brwse_btn.TabIndex = 2;
            this.brwse_btn.Text = "BROWSE";
            this.brwse_btn.UseVisualStyleBackColor = true;
            this.brwse_btn.Click += new System.EventHandler(this.brwse_btn_Click);
            // 
            // exp_accept_btn
            // 
            this.exp_accept_btn.Location = new System.Drawing.Point(452, 166);
            this.exp_accept_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exp_accept_btn.Name = "exp_accept_btn";
            this.exp_accept_btn.Size = new System.Drawing.Size(111, 44);
            this.exp_accept_btn.TabIndex = 3;
            this.exp_accept_btn.Text = "EXPORT";
            this.exp_accept_btn.UseVisualStyleBackColor = true;
            this.exp_accept_btn.Click += new System.EventHandler(this.exp_accept_btn_Click);
            // 
            // cancel_exp_btn
            // 
            this.cancel_exp_btn.Location = new System.Drawing.Point(587, 165);
            this.cancel_exp_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_exp_btn.Name = "cancel_exp_btn";
            this.cancel_exp_btn.Size = new System.Drawing.Size(111, 46);
            this.cancel_exp_btn.TabIndex = 4;
            this.cancel_exp_btn.Text = "CANCEL";
            this.cancel_exp_btn.UseVisualStyleBackColor = true;
            this.cancel_exp_btn.Click += new System.EventHandler(this.cancel_exp_btn_Click);
            // 
            // exp_file_label
            // 
            this.exp_file_label.AutoSize = true;
            this.exp_file_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_file_label.Location = new System.Drawing.Point(23, 97);
            this.exp_file_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exp_file_label.Name = "exp_file_label";
            this.exp_file_label.Size = new System.Drawing.Size(173, 23);
            this.exp_file_label.TabIndex = 5;
            this.exp_file_label.Text = "Export File Name:";
            this.exp_file_label.Click += new System.EventHandler(this.exp_file_label_Click);
            // 
            // exp_filename
            // 
            this.exp_filename.Location = new System.Drawing.Point(200, 97);
            this.exp_filename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exp_filename.Name = "exp_filename";
            this.exp_filename.Size = new System.Drawing.Size(365, 26);
            this.exp_filename.TabIndex = 6;
            // 
            // exp_err_label
            // 
            this.exp_err_label.AutoSize = true;
            this.exp_err_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_err_label.ForeColor = System.Drawing.Color.Red;
            this.exp_err_label.Location = new System.Drawing.Point(196, 178);
            this.exp_err_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exp_err_label.Name = "exp_err_label";
            this.exp_err_label.Size = new System.Drawing.Size(223, 23);
            this.exp_err_label.TabIndex = 7;
            this.exp_err_label.Text = "EXPORT_ERROR_LABEL";
            this.exp_err_label.Visible = false;
            // 
            // export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(728, 217);
            this.Controls.Add(this.exp_err_label);
            this.Controls.Add(this.exp_filename);
            this.Controls.Add(this.exp_file_label);
            this.Controls.Add(this.cancel_exp_btn);
            this.Controls.Add(this.exp_accept_btn);
            this.Controls.Add(this.brwse_btn);
            this.Controls.Add(this.fol_path);
            this.Controls.Add(this.sel_fol_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label exp_err_label;
    }
}