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
    public partial class frmPrincipal : Form
    {

        string pasta_images = "";
        Image img_fundo;
        public frmPrincipal()
           
        {
            InitializeComponent();

            pasta_images = Application.StartupPath + @"\images\";
            img_fundo = Image.FromFile(pasta_images + @"abacaxi.jpg");
            this.BackgroundImage = img_fundo;

        }


        private void romaneioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void romaneioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRomaneio OutroForm = new frmRomaneio();
            OutroForm.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente OutroForm = new frmCliente();
            OutroForm.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedor OutroForm = new frmFornecedor();
            OutroForm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void filialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFilial OutroForm = new frmFilial();
            OutroForm.ShowDialog();
        }

        private void frutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFruta OutroForm = new frmFruta();
            OutroForm.ShowDialog();

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario OutroForm = new frmFuncionario();
            OutroForm.ShowDialog();
        }

        private void transportadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransportador OutroFrm = new frmTransportador();
            OutroFrm.ShowDialog();        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario OutroForm = new frmUsuario();
            OutroForm.ShowDialog();
        }

 

        private void formaDePagamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFormaPagamento OutroForm = new frmFormaPagamento();
            OutroForm.ShowDialog();
        }
        
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
          
        }

        private void romaneioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVisualizarRomaneio OutroForm = new frmVisualizarRomaneio();
            OutroForm.ShowDialog();
        }


 
        private void planoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    pictureBoxPerfil.ImageLocation = openFileDialog1.FileName;
            //    pictureBoxPerfil.Load();
            //    lblCaminho.Text = "Caminho do Arquivo: " + openFileDialog1.FileName;
            //}
            //OpenFileDialog TrocarImagem = new OpenFileDialog();



            OpenFileDialog TrocarImagem = new OpenFileDialog();
            TrocarImagem.Filter = "imagens (*.jpg, *.bmp, *.png, *.gif, *.tiff)|*.jpg; *.bmp; *.png; *.gif; *.tiff)";

            if (TrocarImagem.ShowDialog() == DialogResult.OK)
            {

               pictureBoxPerfil.ImageLocation = TrocarImagem.FileName;


            }


        }

        private void pictureBoxPerfil_Click(object sender, EventArgs e)
        {

        }

        private void romaneioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEmissaoRomaneio outroForm = new frmEmissaoRomaneio();
            outroForm.Show();
        }
    }
}
