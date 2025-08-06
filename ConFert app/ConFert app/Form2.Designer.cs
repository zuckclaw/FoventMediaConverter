namespace ConFert_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackgroundImage = global::ConFert_app.Properties.Resources.Fovent_Logo2;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPreview.Location = new System.Drawing.Point(457, 186);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(333, 340);
            this.picPreview.TabIndex = 9;
            this.picPreview.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(313, 548);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(686, 47);
            this.bunifuCustomLabel1.TabIndex = 28;
            this.bunifuCustomLabel1.Text = "\"Smart Image Conversion Starts with Fovent.\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1247, 736);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.picPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}