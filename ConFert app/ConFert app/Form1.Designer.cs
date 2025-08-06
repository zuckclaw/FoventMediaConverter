namespace ConFert_app
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listFiles = new System.Windows.Forms.ListBox();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddF = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.listFiles.Enabled = false;
            this.listFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFiles.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 20;
            this.listFiles.Location = new System.Drawing.Point(71, 102);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(832, 444);
            this.listFiles.TabIndex = 3;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            this.listFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listFiles_DragDrop);
            this.listFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listFiles_DragEnter);
            // 
            // cmbFormat
            // 
            this.cmbFormat.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(612, 54);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(99, 24);
            this.cmbFormat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Output";
            this.label2.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ConFert_app.Properties.Resources.setting;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(847, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 28);
            this.pictureBox6.TabIndex = 26;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ConFert_app.Properties.Resources.minus;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(888, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 28);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ConFert_app.Properties.Resources.close;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(928, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Violet;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Clear List";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(430, 31);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(145, 50);
            this.bunifuThinButton23.TabIndex = 15;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // btnAddF
            // 
            this.btnAddF.ActiveBorderThickness = 1;
            this.btnAddF.ActiveCornerRadius = 20;
            this.btnAddF.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnAddF.ActiveForecolor = System.Drawing.Color.Violet;
            this.btnAddF.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddF.BackgroundImage")));
            this.btnAddF.ButtonText = "Add Folder";
            this.btnAddF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddF.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddF.IdleBorderThickness = 1;
            this.btnAddF.IdleCornerRadius = 20;
            this.btnAddF.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnAddF.IdleForecolor = System.Drawing.Color.White;
            this.btnAddF.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddF.Location = new System.Drawing.Point(266, 31);
            this.btnAddF.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddF.Name = "btnAddF";
            this.btnAddF.Size = new System.Drawing.Size(145, 51);
            this.btnAddF.TabIndex = 14;
            this.btnAddF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddF.Click += new System.EventHandler(this.btnAddF_Click_1);
            // 
            // btnAddi
            // 
            this.btnAddi.ActiveBorderThickness = 1;
            this.btnAddi.ActiveCornerRadius = 20;
            this.btnAddi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnAddi.ActiveForecolor = System.Drawing.Color.Violet;
            this.btnAddi.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddi.BackgroundImage")));
            this.btnAddi.ButtonText = "Add Image";
            this.btnAddi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddi.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddi.IdleBorderThickness = 1;
            this.btnAddi.IdleCornerRadius = 20;
            this.btnAddi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.btnAddi.IdleForecolor = System.Drawing.Color.White;
            this.btnAddi.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddi.Location = new System.Drawing.Point(101, 31);
            this.btnAddi.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddi.Name = "btnAddi";
            this.btnAddi.Size = new System.Drawing.Size(145, 51);
            this.btnAddi.TabIndex = 13;
            this.btnAddi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddi.Click += new System.EventHandler(this.btnAddi_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::ConFert_app.Properties.Resources.SC;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(367, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 66);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(976, 655);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.btnAddF);
            this.Controls.Add(this.btnAddi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.listFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOVENT - Image Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddi;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddF;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

