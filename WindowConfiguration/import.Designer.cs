namespace WindowConfiguration
{
    partial class import
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
            this.filename_label = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.imp_browse_btn = new System.Windows.Forms.Button();
            this.imp_ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.imp_err_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filename_label.Location = new System.Drawing.Point(11, 85);
            this.filename_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(127, 23);
            this.filename_label.TabIndex = 0;
            this.filename_label.Text = "Select a File:";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(136, 85);
            this.FilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(422, 26);
            this.FilePath.TabIndex = 1;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // imp_browse_btn
            // 
            this.imp_browse_btn.Location = new System.Drawing.Point(590, 77);
            this.imp_browse_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imp_browse_btn.Name = "imp_browse_btn";
            this.imp_browse_btn.Size = new System.Drawing.Size(127, 41);
            this.imp_browse_btn.TabIndex = 2;
            this.imp_browse_btn.Text = "BROWSE";
            this.imp_browse_btn.UseVisualStyleBackColor = true;
            this.imp_browse_btn.Click += new System.EventHandler(this.imp_browse_btn_Click);
            // 
            // imp_ok_btn
            // 
            this.imp_ok_btn.Location = new System.Drawing.Point(424, 180);
            this.imp_ok_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imp_ok_btn.Name = "imp_ok_btn";
            this.imp_ok_btn.Size = new System.Drawing.Size(127, 48);
            this.imp_ok_btn.TabIndex = 3;
            this.imp_ok_btn.Text = "IMPORT";
            this.imp_ok_btn.UseVisualStyleBackColor = true;
            this.imp_ok_btn.Click += new System.EventHandler(this.imp_ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(590, 180);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(127, 48);
            this.cancel_btn.TabIndex = 4;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // imp_err_label
            // 
            this.imp_err_label.AutoSize = true;
            this.imp_err_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imp_err_label.ForeColor = System.Drawing.Color.Red;
            this.imp_err_label.Location = new System.Drawing.Point(181, 194);
            this.imp_err_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imp_err_label.Name = "imp_err_label";
            this.imp_err_label.Size = new System.Drawing.Size(223, 23);
            this.imp_err_label.TabIndex = 5;
            this.imp_err_label.Text = "IMPORT_ERROR_LABEL";
            this.imp_err_label.Visible = false;
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 235);
            this.Controls.Add(this.imp_err_label);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.imp_ok_btn);
            this.Controls.Add(this.imp_browse_btn);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.filename_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Button imp_browse_btn;
        private System.Windows.Forms.Button imp_ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label imp_err_label;
    }
}