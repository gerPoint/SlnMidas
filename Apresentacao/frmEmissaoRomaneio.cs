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
    public partial class frmEmissaoRomaneio : Form
    {
        public frmEmissaoRomaneio()
        {
            InitializeComponent();
        }

        private void frmEmissaoRomaneio_Load(object sender, EventArgs e)
        {

        }


        private void printDocumentImprimir_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(pictureBoxTitulo.Image,294,25, pictureBoxTitulo.Width,pictureBoxTitulo.Height);
            e.Graphics.DrawString(lblCliente.Text, lblCliente.Font, Brushes.Black, new Point(25, 100));
            e.Graphics.DrawString(cpoNomeCliente.Text, cpoNomeCliente.Font, Brushes.Black, new Point(140, 100));
            e.Graphics.DrawString(lblFornecedor.Text, lblFornecedor.Font, Brushes.Black, new Point(25, 120));
            e.Graphics.DrawString(cpoNomeFornecedor.Text, cpoNomeCliente.Font, Brushes.Black, new Point(140, 120));
            e.Graphics.DrawString(lblTransportador.Text, lblTransportador.Font, Brushes.Black, new Point(25, 140));
            e.Graphics.DrawString(cpoNomeTransportador.Text, cpoNomeTransportador.Font, Brushes.Black, new Point(140, 140));
            e.Graphics.DrawString(lblFruta.Text, lblFruta.Font, Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString(cpoNomeFruta.Text, cpoNomeFruta.Font, Brushes.Black, new Point(140, 160));
            //e.Graphics.DrawString(lblCliente.Text, cpoNomeCliente.Font, Brushes.Black, new Point(25, 180));
            //e.Graphics.DrawString(lblCliente.Text, cpoNomeCliente.Font, Brushes.Black, new Point(, 180));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialogImprimir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentImprimir.PrinterSettings = printDialogImprimir.PrinterSettings;
                printDocumentImprimir.Print();
            }
        }

    }
}
