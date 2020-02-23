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
            this.imp_err_label = new System.Windows.Forms.Label();
            this.imp_ok_btn = new ePOSOne.btnProduct.Button_WOC();
            this.cancel_btn = new ePOSOne.btnProduct.Button_WOC();
            this.imp_browse_btn = new ePOSOne.btnProduct.Button_WOC();
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
            this.FilePath.Margin = new System.Windows.Forms.Padding(2);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(422, 26);
            this.FilePath.TabIndex = 1;
            this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
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
            // imp_ok_btn
            // 
            this.imp_ok_btn.BorderColor = System.Drawing.Color.Transparent;
            this.imp_ok_btn.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.imp_ok_btn.FlatAppearance.BorderSize = 0;
            this.imp_ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imp_ok_btn.Location = new System.Drawing.Point(407, 179);
            this.imp_ok_btn.Name = "imp_ok_btn";
            this.imp_ok_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.imp_ok_btn.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.imp_ok_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.imp_ok_btn.Size = new System.Drawing.Size(132, 49);
            this.imp_ok_btn.TabIndex = 30;
            this.imp_ok_btn.Text = "Import";
            this.imp_ok_btn.TextColor = System.Drawing.Color.White;
            this.imp_ok_btn.UseVisualStyleBackColor = true;
            this.imp_ok_btn.Click += new System.EventHandler(this.imp_ok_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.BorderColor = System.Drawing.Color.Transparent;
            this.cancel_btn.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.cancel_btn.FlatAppearance.BorderSize = 0;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Location = new System.Drawing.Point(545, 179);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.cancel_btn.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.cancel_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel_btn.Size = new System.Drawing.Size(123, 49);
            this.cancel_btn.TabIndex = 31;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.TextColor = System.Drawing.Color.White;
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // imp_browse_btn
            // 
            this.imp_browse_btn.BorderColor = System.Drawing.Color.Transparent;
            this.imp_browse_btn.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.imp_browse_btn.FlatAppearance.BorderSize = 0;
            this.imp_browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imp_browse_btn.Location = new System.Drawing.Point(580, 76);
            this.imp_browse_btn.Name = "imp_browse_btn";
            this.imp_browse_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.imp_browse_btn.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.imp_browse_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.imp_browse_btn.Size = new System.Drawing.Size(117, 44);
            this.imp_browse_btn.TabIndex = 32;
            this.imp_browse_btn.Text = "Browse";
            this.imp_browse_btn.TextColor = System.Drawing.Color.White;
            this.imp_browse_btn.UseVisualStyleBackColor = true;
            this.imp_browse_btn.Click += new System.EventHandler(this.imp_browse_btn_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 235);
            this.Controls.Add(this.imp_browse_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.imp_ok_btn);
            this.Controls.Add(this.imp_err_label);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.filename_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label imp_err_label;
        private ePOSOne.btnProduct.Button_WOC imp_ok_btn;
        private ePOSOne.btnProduct.Button_WOC cancel_btn;
        private ePOSOne.btnProduct.Button_WOC imp_browse_btn;
    }
}