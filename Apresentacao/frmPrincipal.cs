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
using System.IO;



namespace Apresentacao
{
    public partial class frmPrincipal : Form
    {

       
        public frmPrincipal()
           
        {
            InitializeComponent();

            //pasta_images = Application.StartupPath + @"\images\";
            //img_fundo = Image.FromFile(pasta_images + @"abacaxi.jpg");
            //this.BackgroundImage = img_fundo;

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
            
                
                var Local1 = ("c:/Logo/planodefundo.png");
                var Local2 = ("c:/Logo/planodefundo.bmp");
                var Local3 = ("c:/Logo/planodefundo.jpg");
                var Local4 = ("c:/Logo/planodefundo.gif");
                var Local5 = ("c:/Logo/planodefundo.tiff");

            FileInfo file1 = new FileInfo(Local1);
            FileInfo file2 = new FileInfo(Local2);
            FileInfo file3 = new FileInfo(Local3);
            FileInfo file4 = new FileInfo(Local4);
            FileInfo file5 = new FileInfo(Local5);

            if (file1.Exists)
                {
                    pictureBoxPerfil.ImageLocation = Local1;
                    pictureBoxPerfil.Load();
                }

                if (file2.Exists)
                {
                    pictureBoxPerfil.ImageLocation = Local2;
                    pictureBoxPerfil.Load();
                }


                if (file3.Exists)
                {
                    pictureBoxPerfil.ImageLocation = Local3;
                    pictureBoxPerfil.Load();
                }


                if (file4.Exists)
                {
                    pictureBoxPerfil.ImageLocation = Local4;
                    pictureBoxPerfil.Load();
                }


                if (file5.Exists)
                {
                    pictureBoxPerfil.ImageLocation = Local5;
                    pictureBoxPerfil.Load();
                }


                // ESSE DA CERTO também
                //pictureBoxPerfil.ImageLocation = "c:/teste/planodefundo.png";  
                //pictureBoxPerfil.Load();          

        }

        private void romaneioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmVisualizarRomaneio OutroForm = new frmVisualizarRomaneio();
            OutroForm.ShowDialog();
        }


 
        private void planoDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void imagemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnFundo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cpoCaminhoImage.Text = openFileDialog1.FileName;
                pictureBoxPerfil.ImageLocation = openFileDialog1.FileName;

                pictureBoxPerfil.Load();

            }
        }
    }
}
