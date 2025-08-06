namespace ConFert_app
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.lblOutputFolder = new System.Windows.Forms.Label();
            this.txtOutputFolder = new System.Windows.Forms.TextBox();
            this.btnBrowseFolder = new System.Windows.Forms.Button();
            this.chkPlaySound = new System.Windows.Forms.CheckBox();
            this.rbAutoRename = new System.Windows.Forms.RadioButton();
            this.rbOverwrite = new System.Windows.Forms.RadioButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lblOutputFolder
            // 
            this.lblOutputFolder.AutoSize = true;
            this.lblOutputFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputFolder.Location = new System.Drawing.Point(35, 82);
            this.lblOutputFolder.Name = "lblOutputFolder";
            this.lblOutputFolder.Size = new System.Drawing.Size(223, 25);
            this.lblOutputFolder.TabIndex = 0;
            this.lblOutputFolder.Text = "Default Output Folder    :";
            // 
            // txtOutputFolder
            // 
            this.txtOutputFolder.Location = new System.Drawing.Point(279, 85);
            this.txtOutputFolder.Name = "txtOutputFolder";
            this.txtOutputFolder.Size = new System.Drawing.Size(330, 22);
            this.txtOutputFolder.TabIndex = 1;
            // 
            // btnBrowseFolder
            // 
            this.btnBrowseFolder.Location = new System.Drawing.Point(629, 86);
            this.btnBrowseFolder.Name = "btnBrowseFolder";
            this.btnBrowseFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFolder.TabIndex = 2;
            this.btnBrowseFolder.Text = "browse";
            this.btnBrowseFolder.UseVisualStyleBackColor = true;
            this.btnBrowseFolder.Click += new System.EventHandler(this.btnBrowseFolder_Click);
            // 
            // chkPlaySound
            // 
            this.chkPlaySound.AutoSize = true;
            this.chkPlaySound.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPlaySound.Location = new System.Drawing.Point(40, 125);
            this.chkPlaySound.Name = "chkPlaySound";
            this.chkPlaySound.Size = new System.Drawing.Size(268, 30);
            this.chkPlaySound.TabIndex = 3;
            this.chkPlaySound.Text = "Play sound after convert";
            this.chkPlaySound.UseVisualStyleBackColor = true;
            // 
            // rbAutoRename
            // 
            this.rbAutoRename.AutoSize = true;
            this.rbAutoRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAutoRename.Location = new System.Drawing.Point(40, 167);
            this.rbAutoRename.Name = "rbAutoRename";
            this.rbAutoRename.Size = new System.Drawing.Size(292, 30);
            this.rbAutoRename.TabIndex = 4;
            this.rbAutoRename.TabStop = true;
            this.rbAutoRename.Text = "Auto Rename : _converted";
            this.rbAutoRename.UseVisualStyleBackColor = true;
            // 
            // rbOverwrite
            // 
            this.rbOverwrite.AutoSize = true;
            this.rbOverwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOverwrite.Location = new System.Drawing.Point(40, 206);
            this.rbOverwrite.Name = "rbOverwrite";
            this.rbOverwrite.Size = new System.Drawing.Size(251, 30);
            this.rbOverwrite.TabIndex = 5;
            this.rbOverwrite.TabStop = true;
            this.rbOverwrite.Text = "Overwrite existing files";
            this.rbOverwrite.UseVisualStyleBackColor = true;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.LightGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(40, 334);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(135, 48);
            this.bunifuThinButton21.TabIndex = 6;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Cancel";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(50)))), ((int)(((byte)(59)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.LightGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(206, 334);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(135, 48);
            this.bunifuThinButton22.TabIndex = 7;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.rbOverwrite);
            this.Controls.Add(this.rbAutoRename);
            this.Controls.Add(this.chkPlaySound);
            this.Controls.Add(this.btnBrowseFolder);
            this.Controls.Add(this.txtOutputFolder);
            this.Controls.Add(this.lblOutputFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSettings";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutputFolder;
        private System.Windows.Forms.TextBox txtOutputFolder;
        private System.Windows.Forms.Button btnBrowseFolder;
        private System.Windows.Forms.CheckBox chkPlaySound;
        private System.Windows.Forms.RadioButton rbAutoRename;
        private System.Windows.Forms.RadioButton rbOverwrite;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}