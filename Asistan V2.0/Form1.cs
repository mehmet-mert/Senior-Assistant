using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asistan_V2._0
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            anasayfa1.Show();
            information1.Hide();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            information1.Show();
            anasayfa1.Hide();
        }
    }
}
