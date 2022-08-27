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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iNFORMAÇÕESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            info frm = new info();
            frm.ShowDialog();
        }

        private void iMAGENSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagem img = new imagem();
            img.ShowDialog();
        }

        private void uRSOPARDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pardo pardo = new pardo();
            pardo.ShowDialog();
        }

        private void uRSOPOLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polar polar = new polar();
            polar.ShowDialog();
        }

        private void uRSOPANDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panda panda = new panda();
            panda.ShowDialog();
        }

        private void uRSONEGROASIÁTICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asiatico asiatico = new asiatico();
            asiatico.ShowDialog();
        }

        private void uRSONEGROAMERICANOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            americano americano = new americano();
            americano.ShowDialog();
        }

        private void uRSOMALAIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            malaio malaio = new malaio();
            malaio.ShowDialog();
        }

        private void uRSODEÓCULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oculos oculos = new oculos();
            oculos.ShowDialog();
        }

        private void uRSOBEIÇUDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beicudo beicudo = new beicudo();
            beicudo.ShowDialog();
        }

        private void cALENDÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendario calendario = new calendario();
            calendario.ShowDialog();
        }

        private void gOOGLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            google web = new google();
            web.ShowDialog();
        }

        private void vÍDEOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
             video video = new video();
            video.ShowDialog();
        }

        private void lISTADETAREFASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista lista = new lista();
            lista.ShowDialog();
        }

        private void tIMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            randomc timer = new randomc();
            timer.ShowDialog();

        }

        private void pAINELDECORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newform painel = new newform();
            painel.ShowDialog();

        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre sobre = new sobre();
            sobre.ShowDialog();
        }
    }
}
