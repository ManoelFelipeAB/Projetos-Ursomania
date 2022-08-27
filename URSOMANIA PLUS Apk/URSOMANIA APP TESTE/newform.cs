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
    public partial class newform : Form
    {
        public newform()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult colorResult = colorDialog1.ShowDialog();

            if(colorResult == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;

            }
        }
    }
}
