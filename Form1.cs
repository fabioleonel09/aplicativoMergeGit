using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativoMergeGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrarFormA_Click(object sender, EventArgs e)
        {
            frmFormularioA ffa = new frmFormularioA();
            ffa.Show();
        }
    }
}
