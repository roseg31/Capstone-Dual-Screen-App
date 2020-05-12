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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tutorialRun = new System.Windows.Forms.CheckBox();
            this.endTutorial = new System.Windows.Forms.RichTextBox();
            this.docuTip = new System.Windows.Forms.RichTextBox();
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Orange;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(203, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(182, 70);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "Tutorial Step 1:                          Click \'Configuration List\' to get start" +
    "ed! →";
            // 
            // tutorialRun
            // 
            this.tutorialRun.AutoSize = true;
            this.tutorialRun.Location = new System.Drawing.Point(399, 355);
            this.tutorialRun.Name = "tutorialRun";
            this.tutorialRun.Size = new System.Drawing.Size(121, 24);
            this.tutorialRun.TabIndex = 7;
            this.tutorialRun.Text = "Run Tutorial";
            this.tutorialRun.UseVisualStyleBackColor = true;
            this.tutorialRun.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // endTutorial
            // 
            this.endTutorial.BackColor = System.Drawing.Color.Orange;
            this.endTutorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.endTutorial.ForeColor = System.Drawing.Color.White;
            this.endTutorial.Location = new System.Drawing.Point(121, 318);
            this.endTutorial.Name = "endTutorial";
            this.endTutorial.ReadOnly = true;
            this.endTutorial.Size = new System.Drawing.Size(244, 88);
            this.endTutorial.TabIndex = 43;
            this.endTutorial.Text = "Toggle Tutorial:                                                            When " +
    "you\'re done with the tutorial, you can uncheck this box to exit it!";
            // 
            // docuTip
            // 
            this.docuTip.BackColor = System.Drawing.Color.Goldenrod;
            this.docuTip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.docuTip.ForeColor = System.Drawing.Color.White;
            this.docuTip.Location = new System.Drawing.Point(578, 224);
            this.docuTip.Name = "docuTip";
            this.docuTip.ReadOnly = true;
            this.docuTip.Size = new System.Drawing.Size(182, 129);
            this.docuTip.TabIndex = 44;
            this.docuTip.Text = "Helpful tip:                          If you have questions or want to see the do" +
    "cumentation for this app, this button will take you to our GitHub!";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.docuTip);
            this.Controls.Add(this.endTutorial);
            this.Controls.Add(this.tutorialRun);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox tutorialRun;
        private System.Windows.Forms.RichTextBox endTutorial;
        private System.Windows.Forms.RichTextBox docuTip;
    }
}