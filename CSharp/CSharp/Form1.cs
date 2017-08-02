using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aludo obj = new aludo();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IMAGEN OBJ = new IMAGEN();
            OBJ.Show();
        }
    }
}
