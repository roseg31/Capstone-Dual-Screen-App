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
            this.main_title_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // main_title_label
            // 
            this.main_title_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_title_label.Location = new System.Drawing.Point(133, 60);
            this.main_title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.main_title_label.Name = "main_title_label";
            this.main_title_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_title_label.Size = new System.Drawing.Size(653, 86);
            this.main_title_label.TabIndex = 1;
            this.main_title_label.Text = "Welcome To DuoTech";
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
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Location = new System.Drawing.Point(382, 176);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(152, 57);
            this.button_WOC1.TabIndex = 4;
            this.button_WOC1.Text = "Configuration List";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.cfg_list_btn_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Location = new System.Drawing.Point(342, 255);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(230, 57);
            this.button_WOC2.TabIndex = 5;
            this.button_WOC2.Text = "Help & Documentation";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.tutorial_btn_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.contact_label);
            this.Controls.Add(this.main_title_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "homepage";
            this.Text = "homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label main_title_label;
        private System.Windows.Forms.Label contact_label;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
    }
}