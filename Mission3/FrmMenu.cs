using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3
{
  
    public partial class Menu : Form
    {
        private Gsb2023Entities1 mesDonnesGSB;
        public Menu()
        {
            InitializeComponent();
            this.mesDonnesGSB = new Gsb2023Entities1();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAdresse a   =   new lblAdresse(this.mesDonnesGSB);
            a.MdiParent = this;
            a.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {

           FrmVisualiser visualiser = new FrmVisualiser(this.mesDonnesGSB);
            visualiser.MdiParent = this;
            visualiser.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmModifier modif = new FrmModifier(this.mesDonnesGSB);
            modif.MdiParent = this;
            modif.Show();
        }
    }
}
