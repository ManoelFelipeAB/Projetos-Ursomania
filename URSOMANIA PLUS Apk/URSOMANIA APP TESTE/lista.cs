using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URSOMANIA_APP_TESTE
{
    public partial class lista : Form
    {
        public lista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "") ;
            {
                listBox1.Items.Add(this.textBox1.Text);
                this.textBox1.Focus();
                this.textBox1.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
