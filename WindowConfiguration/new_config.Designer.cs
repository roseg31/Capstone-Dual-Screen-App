﻿namespace WindowConfiguration
{
    partial class new_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_config));
            this.cfg_name_label = new System.Windows.Forms.Label();
            this.cfg_name_box = new System.Windows.Forms.TextBox();
            this.cfg_desc_label = new System.Windows.Forms.Label();
            this.cfg_desc_box = new System.Windows.Forms.TextBox();
            this.preview_label = new System.Windows.Forms.Label();
            this.proc_list_view = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.process_list_label = new System.Windows.Forms.Label();
            this.new_cfg_err_label = new System.Windows.Forms.Label();
            this.CompanionScreenDisp = new System.Windows.Forms.PictureBox();
            this.PrimaryScreenDisp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save_cfg_btn = new ePOSOne.btnProduct.Button_WOC();
            this.cncl_cfg_btn = new ePOSOne.btnProduct.Button_WOC();
            this.configNameTut = new System.Windows.Forms.RichTextBox();
            this.previewTut = new System.Windows.Forms.RichTextBox();
            this.processesTut = new System.Windows.Forms.RichTextBox();
            this.saveConfigTut = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompanionScreenDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryScreenDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // cfg_name_label
            // 
            this.cfg_name_label.AutoSize = true;
            this.cfg_name_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfg_name_label.Location = new System.Drawing.Point(19, 89);
            this.cfg_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cfg_name_label.Name = "cfg_name_label";
            this.cfg_name_label.Size = new System.Drawing.Size(198, 23);
            this.cfg_name_label.TabIndex = 0;
            this.cfg_name_label.Text = "Configuration Name:";
            // 
            // cfg_name_box
            // 
            this.cfg_name_box.Location = new System.Drawing.Point(24, 125);
            this.cfg_name_box.Margin = new System.Windows.Forms.Padding(2);
            this.cfg_name_box.Name = "cfg_name_box";
            this.cfg_name_box.Size = new System.Drawing.Size(338, 26);
            this.cfg_name_box.TabIndex = 1;
            this.cfg_name_box.TextChanged += new System.EventHandler(this.cfg_name_box_TextChanged);
            // 
            // cfg_desc_label
            // 
            this.cfg_desc_label.AutoSize = true;
            this.cfg_desc_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfg_desc_label.Location = new System.Drawing.Point(19, 162);
            this.cfg_desc_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cfg_desc_label.Name = "cfg_desc_label";
            this.cfg_desc_label.Size = new System.Drawing.Size(182, 23);
            this.cfg_desc_label.TabIndex = 2;
            this.cfg_desc_label.Text = "Config Description:";
            // 
            // cfg_desc_box
            // 
            this.cfg_desc_box.Location = new System.Drawing.Point(24, 200);
            this.cfg_desc_box.Margin = new System.Windows.Forms.Padding(2);
            this.cfg_desc_box.Multiline = true;
            this.cfg_desc_box.Name = "cfg_desc_box";
            this.cfg_desc_box.Size = new System.Drawing.Size(489, 201);
            this.cfg_desc_box.TabIndex = 3;
            // 
            // preview_label
            // 
            this.preview_label.AutoSize = true;
            this.preview_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_label.Location = new System.Drawing.Point(775, 16);
            this.preview_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.preview_label.Name = "preview_label";
            this.preview_label.Size = new System.Drawing.Size(82, 23);
            this.preview_label.TabIndex = 5;
            this.preview_label.Text = "Preview";
            // 
            // proc_list_view
            // 
            this.proc_list_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.LocationHeader,
            this.sizeHeader});
            this.proc_list_view.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proc_list_view.FullRowSelect = true;
            this.proc_list_view.GridLines = true;
            this.proc_list_view.HideSelection = false;
            this.proc_list_view.Location = new System.Drawing.Point(23, 465);
            this.proc_list_view.Margin = new System.Windows.Forms.Padding(2);
            this.proc_list_view.Name = "proc_list_view";
            this.proc_list_view.Size = new System.Drawing.Size(489, 179);
            this.proc_list_view.TabIndex = 9;
            this.proc_list_view.UseCompatibleStateImageBehavior = false;
            this.proc_list_view.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 551;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 150;
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "Size";
            this.sizeHeader.Width = 160;
            // 
            // process_list_label
            // 
            this.process_list_label.AutoSize = true;
            this.process_list_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_list_label.Location = new System.Drawing.Point(20, 422);
            this.process_list_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.process_list_label.Name = "process_list_label";
            this.process_list_label.Size = new System.Drawing.Size(150, 23);
            this.process_list_label.TabIndex = 10;
            this.process_list_label.Text = "Process Listing:";
            this.process_list_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // new_cfg_err_label
            // 
            this.new_cfg_err_label.AutoSize = true;
            this.new_cfg_err_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_cfg_err_label.ForeColor = System.Drawing.Color.Red;
            this.new_cfg_err_label.Location = new System.Drawing.Point(690, 592);
            this.new_cfg_err_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.new_cfg_err_label.Name = "new_cfg_err_label";
            this.new_cfg_err_label.Size = new System.Drawing.Size(241, 23);
            this.new_cfg_err_label.TabIndex = 11;
            this.new_cfg_err_label.Text = "NEW_CFG_ERROR_LABEL";
            this.new_cfg_err_label.Visible = false;
            // 
            // CompanionScreenDisp
            // 
            this.CompanionScreenDisp.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompanionScreenDisp.InitialImage")));
            this.CompanionScreenDisp.Location = new System.Drawing.Point(547, 399);
            this.CompanionScreenDisp.Margin = new System.Windows.Forms.Padding(2);
            this.CompanionScreenDisp.Name = "CompanionScreenDisp";
            this.CompanionScreenDisp.Size = new System.Drawing.Size(497, 179);
            this.CompanionScreenDisp.TabIndex = 12;
            this.CompanionScreenDisp.TabStop = false;
            // 
            // PrimaryScreenDisp
            // 
            this.PrimaryScreenDisp.InitialImage = ((System.Drawing.Image)(resources.GetObject("PrimaryScreenDisp.InitialImage")));
            this.PrimaryScreenDisp.Location = new System.Drawing.Point(547, 45);
            this.PrimaryScreenDisp.Margin = new System.Windows.Forms.Padding(2);
            this.PrimaryScreenDisp.Name = "PrimaryScreenDisp";
            this.PrimaryScreenDisp.Size = new System.Drawing.Size(497, 344);
            this.PrimaryScreenDisp.TabIndex = 13;
            this.PrimaryScreenDisp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Configuration";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // save_cfg_btn
            // 
            this.save_cfg_btn.BorderColor = System.Drawing.Color.Transparent;
            this.save_cfg_btn.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.save_cfg_btn.FlatAppearance.BorderSize = 0;
            this.save_cfg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_cfg_btn.Location = new System.Drawing.Point(547, 616);
            this.save_cfg_btn.Name = "save_cfg_btn";
            this.save_cfg_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.save_cfg_btn.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.save_cfg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.save_cfg_btn.Size = new System.Drawing.Size(153, 49);
            this.save_cfg_btn.TabIndex = 30;
            this.save_cfg_btn.Text = "Save";
            this.save_cfg_btn.TextColor = System.Drawing.Color.White;
            this.save_cfg_btn.UseVisualStyleBackColor = true;
            this.save_cfg_btn.Click += new System.EventHandler(this.save_cfg_btn_Click);
            // 
            // cncl_cfg_btn
            // 
            this.cncl_cfg_btn.BorderColor = System.Drawing.Color.Transparent;
            this.cncl_cfg_btn.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.cncl_cfg_btn.FlatAppearance.BorderSize = 0;
            this.cncl_cfg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cncl_cfg_btn.Location = new System.Drawing.Point(873, 618);
            this.cncl_cfg_btn.Name = "cncl_cfg_btn";
            this.cncl_cfg_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.cncl_cfg_btn.OnHoverButtonColor = System.Drawing.Color.RoyalBlue;
            this.cncl_cfg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.cncl_cfg_btn.Size = new System.Drawing.Size(153, 49);
            this.cncl_cfg_btn.TabIndex = 31;
            this.cncl_cfg_btn.Text = "Cancel";
            this.cncl_cfg_btn.TextColor = System.Drawing.Color.White;
            this.cncl_cfg_btn.UseVisualStyleBackColor = true;
            this.cncl_cfg_btn.Click += new System.EventHandler(this.cncl_cfg_btn_Click);
            // 
            // configNameTut
            // 
            this.configNameTut.BackColor = System.Drawing.Color.Orange;
            this.configNameTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.configNameTut.ForeColor = System.Drawing.Color.White;
            this.configNameTut.Location = new System.Drawing.Point(367, 32);
            this.configNameTut.Name = "configNameTut";
            this.configNameTut.ReadOnly = true;
            this.configNameTut.Size = new System.Drawing.Size(182, 163);
            this.configNameTut.TabIndex = 32;
            this.configNameTut.Text = "Tutorial Step 3:                          These text boxes can be used to name an" +
    "d describe your configuration. Enter a name into the \'Configuration Name\' field!" +
    "";
            // 
            // previewTut
            // 
            this.previewTut.BackColor = System.Drawing.Color.Goldenrod;
            this.previewTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.previewTut.ForeColor = System.Drawing.Color.White;
            this.previewTut.Location = new System.Drawing.Point(731, 350);
            this.previewTut.Name = "previewTut";
            this.previewTut.ReadOnly = true;
            this.previewTut.Size = new System.Drawing.Size(182, 70);
            this.previewTut.TabIndex = 33;
            this.previewTut.Text = "Helpful Tip:                          Here\'s a preview of your screens!";
            // 
            // processesTut
            // 
            this.processesTut.BackColor = System.Drawing.Color.Goldenrod;
            this.processesTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.processesTut.ForeColor = System.Drawing.Color.White;
            this.processesTut.Location = new System.Drawing.Point(345, 390);
            this.processesTut.Name = "processesTut";
            this.processesTut.ReadOnly = true;
            this.processesTut.Size = new System.Drawing.Size(182, 86);
            this.processesTut.TabIndex = 34;
            this.processesTut.Text = "Helpful Tip:                          Here\'s a list of the applications in your c" +
    "onfiguration!";
            // 
            // saveConfigTut
            // 
            this.saveConfigTut.BackColor = System.Drawing.Color.Orange;
            this.saveConfigTut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saveConfigTut.ForeColor = System.Drawing.Color.White;
            this.saveConfigTut.Location = new System.Drawing.Point(503, 540);
            this.saveConfigTut.Name = "saveConfigTut";
            this.saveConfigTut.ReadOnly = true;
            this.saveConfigTut.Size = new System.Drawing.Size(182, 70);
            this.saveConfigTut.TabIndex = 35;
            this.saveConfigTut.Text = "Tutorial Step 4:                          Click \'Save\' to save your new configura" +
    "tion";
            // 
            // new_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 677);
            this.Controls.Add(this.saveConfigTut);
            this.Controls.Add(this.processesTut);
            this.Controls.Add(this.previewTut);
            this.Controls.Add(this.configNameTut);
            this.Controls.Add(this.cncl_cfg_btn);
            this.Controls.Add(this.save_cfg_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrimaryScreenDisp);
            this.Controls.Add(this.CompanionScreenDisp);
            this.Controls.Add(this.new_cfg_err_label);
            this.Controls.Add(this.process_list_label);
            this.Controls.Add(this.proc_list_view);
            this.Controls.Add(this.preview_label);
            this.Controls.Add(this.cfg_desc_box);
            this.Controls.Add(this.cfg_desc_label);
            this.Controls.Add(this.cfg_name_box);
            this.Controls.Add(this.cfg_name_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "new_config";
            this.Text = "new_config";
            ((System.ComponentModel.ISupportInitialize)(this.CompanionScreenDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimaryScreenDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cfg_name_label;
        private System.Windows.Forms.TextBox cfg_name_box;
        private System.Windows.Forms.Label cfg_desc_label;
        private System.Windows.Forms.TextBox cfg_desc_box;
        private System.Windows.Forms.Label preview_label;
        private System.Windows.Forms.ListView proc_list_view;
        private System.Windows.Forms.Label process_list_label;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader sizeHeader;
        private System.Windows.Forms.Label new_cfg_err_label;
        private System.Windows.Forms.PictureBox CompanionScreenDisp;
        private System.Windows.Forms.PictureBox PrimaryScreenDisp;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC save_cfg_btn;
        private ePOSOne.btnProduct.Button_WOC cncl_cfg_btn;
        private System.Windows.Forms.RichTextBox configNameTut;
        private System.Windows.Forms.RichTextBox previewTut;
        private System.Windows.Forms.RichTextBox processesTut;
        private System.Windows.Forms.RichTextBox saveConfigTut;
    }
}