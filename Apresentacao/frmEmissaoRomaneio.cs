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
            e.Graphics.DrawString(cpoNomeCliente.Text, cpoNomeCliente.Font, Brushes.Black, new Point (25,100));
            e.Graphics.DrawImage(pictureBoxTitulo.Image,294,25, pictureBoxTitulo.Width,pictureBoxTitulo.Height);
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
