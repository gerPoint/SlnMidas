using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AcessoDados;
using Negocio;
using ObjTransferencia;

namespace Apresentacao
{
    public partial class frmSelecionarCliente : Form
    {

        public frmSelecionarCliente()
        {
            InitializeComponent();
        }

        private void FrmSelecionarCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'midasDataSetcliente.tblCliente' table. You can move, or remove it, as needed.
           // this.tblClienteTableAdapter.Fill(this.midasDataSetcliente.tblCliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
           
        }



        private void dgwSelCliente_DoubleClick(object sender, EventArgs e)
        {


   //         Cliente cliente = (dgwSelCliente.SelectedRows[0].DataBoundItem as Cliente);
    //        cpoIDCliente.Text = dgwSelCliente.SelectedRows[0].Cells[0].Value.ToString();
    //        cpoCliente.Text = dgwSelCliente.SelectedRows[0].Cells[1].Value.ToString();

   //         frmRomaneio outroform = new frmRomaneio();
   //         outroform.Show();
        }
    }
}
