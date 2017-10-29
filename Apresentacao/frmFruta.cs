using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmFruta : Form
    {
        public frmFruta()
        {
            InitializeComponent();
        }

        private void frmFruta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSet1.tblFruta' table. You can move, or remove it, as needed.
            this.tblFrutaTableAdapter.Fill(this.midasDataSet1.tblFruta);

        }
    }
}
