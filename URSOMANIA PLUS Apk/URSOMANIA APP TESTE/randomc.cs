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
    public partial class randomc : Form
    {     
        int tempo = 0;
        int minuto = 0;
        int segundo = 0;

        public randomc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt16(textBox2.Text);
            if(tempo>=60)
            {
                minuto = tempo / 60;
                segundo = tempo % 60;
            }
            else
            {
                minuto = 0;
                segundo = tempo;
            }
            label4.Text = minuto + ":" + segundo;
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo = segundo - 1;
            if(minuto>0)
            {
                if(segundo<0)
                {
                    segundo = 59;
                    minuto = minuto - 1;
                }
            }
            label4.Text = minuto + ":" + segundo;
            if(minuto==0 && segundo==0)
            {
                timer1.Enabled = false;
            }
        }
    }
}
