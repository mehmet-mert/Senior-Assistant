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
    public partial class information : UserControl
    {
        public information()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mehmet-mert");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hilmiAkkaya");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fatih51");
        }
    }
}
