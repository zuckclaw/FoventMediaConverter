using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFert_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 5000; // 2 detik
            timer.Tick += (s, ev) =>
            {
                timer.Stop();
                this.Hide();
                Form1 mainForm = new Form1();
                mainForm.Show();
            };
            timer.Start();
        }
    }
}
