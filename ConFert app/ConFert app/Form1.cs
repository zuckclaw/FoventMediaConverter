using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFert_app
{

    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        public Form1()
        {
            InitializeComponent();
        }

       


        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.heic;*.webp;*.ico";
            //pictureBox2.Visible = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!listFiles.Items.Contains(file))
                        listFiles.Items.Add(file);
                }
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    foreach (string file in files)
                    {
                        if (!listFiles.Items.Contains(file))
                            listFiles.Items.Add(file);
                    }
                }
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
            //pictureBox2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFiles.AllowDrop = true;

            // Pasang event handler drag
            listFiles.DragEnter += listFiles_DragEnter;
            listFiles.DragDrop += listFiles_DragDrop;
            listFiles.DragLeave += listFiles_DragLeave;

            cmbFormat.Items.AddRange(new string[] { "JPG", "PNG", "BMP", "GIF", "ICO" });
            cmbFormat.SelectedIndex = 0;

            //trQuality.MinimumValue = 10;
            //trQuality.MaximumValue = 100;
            //trQuality.Value = 90;
            //lblQualityValue.Text = "90";
        }

        private void trkQuality_Scroll(object sender, EventArgs e)
        {
            //lblQualityValue.Text = trQuality.Value.ToString();
        }

        private void btnStartConvert_Click(object sender, EventArgs e)
        {
           
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listFiles_DragEnter(object sender, DragEventArgs e)
        {
            //pictureBox2.Visible=false;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;

            //listFiles.BackColor = Color.Gray;

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void listFiles_DragDrop(object sender, DragEventArgs e)
        {
            //pictureBox2.Visible = false;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif" || ext == ".ico")
                    {
                        if (!listFiles.Items.Contains(file))
                            listFiles.Items.Add(file);
                    }
                }
            }
        }

        private void listFiles_DragLeave(object sender, EventArgs e)
        {
            listFiles.BackColor = SystemColors.Window;
            //pictureBox2.Visible= false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listFiles.Items.Count == 0)
            {
                MessageBox.Show("Please add images first.");
                return;
            }

            string format = cmbFormat.SelectedItem.ToString();
            ImageFormat imgFormat = ImageFormat.Png;

            switch (format)
            {
                case "JPG": imgFormat = ImageFormat.Jpeg; break;
                case "PNG": imgFormat = ImageFormat.Png; break;
                case "BMP": imgFormat = ImageFormat.Bmp; break;
                case "GIF": imgFormat = ImageFormat.Gif; break;
                case "ICO": imgFormat = ImageFormat.Icon; break;
            }

            string outputFolder = Properties.Settings.Default.OutputFolder;
            if (string.IsNullOrWhiteSpace(outputFolder) || !Directory.Exists(outputFolder))
            {
                MessageBox.Show("Please set a valid output folder in Settings.");
                return;
            }

            foreach (string path in listFiles.Items)
            {
                try
                {
                    using (Image img = Image.FromFile(path))
                    {
                        string filename = Path.GetFileNameWithoutExtension(path);
                        string newPath = Path.Combine(outputFolder, filename + "." + format.ToLower());

                        if (Properties.Settings.Default.Rename)
                        {
                            newPath = Path.Combine(outputFolder, filename + "_converted." + format.ToLower());
                        }

                        if (imgFormat == ImageFormat.Jpeg)
                        {
                            using (Bitmap bmp = new Bitmap(img.Width, img.Height))
                            {
                                using (Graphics g = Graphics.FromImage(bmp))
                                {
                                    g.Clear(Color.White); // Ubah transparan jadi putih
                                    g.DrawImage(img, 0, 0);
                                }

                                // Set kualitas JPEG
                                EncoderParameters eps = new EncoderParameters(1);
                                eps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 90L);
                                ImageCodecInfo jpgEncoder = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
                                bmp.Save(newPath, jpgEncoder, eps);
                            }
                        }
                        else if (format == "ICO")
                        {
                            using (Bitmap resized = new Bitmap(32, 32))
                            {
                                using (Graphics g = Graphics.FromImage(resized))
                                {
                                    g.Clear(Color.Transparent);
                                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                    g.DrawImage(img, 0, 0, 32, 32);
                                }

                                IntPtr hIcon = resized.GetHicon();
                                using (Icon icon = Icon.FromHandle(hIcon))
                                {
                                    using (FileStream fs = new FileStream(newPath, FileMode.Create))
                                    {
                                        icon.Save(fs);
                                    }
                                }

                                // Lepaskan resource icon dari memory (optional tapi disarankan)
                                DestroyIcon(hIcon);
                            }
                        }
                        else
                        {
                            img.Save(newPath, imgFormat);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error converting " + path + ":\n" + ex.Message);
                }
            }

            if (Properties.Settings.Default.PlaySound)
            {
                System.Media.SystemSounds.Asterisk.Play();
            }

            MessageBox.Show("Conversion complete!");
        }


        private void btnAddi_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.heic;*.webp;*.ico";
            //pictureBox2.Visible = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!listFiles.Items.Contains(file))
                        listFiles.Items.Add(file);
                }
            }
        }

        private void btnAddF_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    foreach (string file in files)
                    {
                        if (!listFiles.Items.Contains(file))
                            listFiles.Items.Add(file);
                    }
                }
            }
        }

        private void btnClearL_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
            //pictureBox2.Visible = true;
        }


        private void btnAddi_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff;*.heic;*.webp;*.ico";
            //pictureBox2.Visible = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!listFiles.Items.Contains(file))
                        listFiles.Items.Add(file);
                }
            }
        }

        private void btnAddF_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                                    f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    foreach (string file in files)
                    {
                        if (!listFiles.Items.Contains(file))
                            listFiles.Items.Add(file);
                    }
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            listFiles.Items.Clear();
            //pictureBox2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
        }

        
    }
}
