using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBinding_Banque
{
    public partial class GestionBanque : Form
    {
        public GestionBanque()
        {
            InitializeComponent();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Compte());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            this.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
