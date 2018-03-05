﻿using System;
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
            
            e.Graphics.DrawImage(pictureBoxTitulo.Image,30,15, pictureBoxTitulo.Width,pictureBoxTitulo.Height);
            e.Graphics.DrawString(lblCliente.Text, lblCliente.Font, Brushes.Black, new Point(75, 100));
            e.Graphics.DrawString(cpoNomeCliente.Text, cpoNomeCliente.Font, Brushes.Black, new Point(140, 100));
            e.Graphics.DrawString(lblFornecedor.Text, lblFornecedor.Font, Brushes.Black, new Point(50, 120));
            e.Graphics.DrawString(cpoNomeFornecedor.Text, cpoNomeCliente.Font, Brushes.Black, new Point(140, 120));
            e.Graphics.DrawString(lblTransportador.Text, lblTransportador.Font, Brushes.Black, new Point(35, 140));
            e.Graphics.DrawString(cpoNomeTransportador.Text, cpoNomeTransportador.Font, Brushes.Black, new Point(139, 140));
            e.Graphics.DrawString(lblFruta.Text, lblFruta.Font, Brushes.Black, new Point(84, 160));
            e.Graphics.DrawString(cpoNomeFruta.Text, cpoNomeFruta.Font, Brushes.Black, new Point(140, 160));
            e.Graphics.DrawString(lblUnidMedida.Text, lblUnidMedida.Font, Brushes.Black, new Point(25, 180));
            e.Graphics.DrawString(cpoUnidMedida.Text, cpoUnidMedida.Font, Brushes.Black, new Point(140, 180));
            e.Graphics.DrawString(lblComissao.Text, lblComissao.Font, Brushes.Black, new Point(400, 100));
            e.Graphics.DrawString(cpoValorComissao.Text, cpoValorComissao.Font, Brushes.Black, new Point(500, 100));
            e.Graphics.DrawString(lblFormaPagamento.Text, lblFormaPagamento.Font, Brushes.Black, new Point());
            e.Graphics.DrawString(cpoFormaPagamento.Text, cpoFormaPagamento.Font, Brushes.Black, new Point());


            //e.Graphics.DrawString(lblCustoCarreg.Text, lblCustoCarreg.Font, Brushes.Black, new Point(,240));
            //e.Graphics.DrawString(cpoCustoCarreg.Text, cpoCustoCarreg.Font, Brushes.Black, new Point(,240));
            //e.Graphics.DrawString(lblAdiantFretMot.Text, lblAdiantFretMot.Font, Brushes.Black, new Point(,260));
            //e.Graphics.DrawString(cpoAdiantFretMot.Text, cpoAdiantFretMot.Font, Brushes.Black, new Point(,260));
            //e.Graphics.DrawString(lblFrete.Text, lblFrete.Font, Brushes.Black, new Point(,280));
            //e.Graphics.DrawString(cpoValorFrete.Text, cpoValorFrete.Font, Brushes.Black, new Point(,280));
            //e.Graphics.DrawString(lblTaxaNf.Text, lblTaxaNf.Font, Brushes.Black, new Point(,300));
            //e.Graphics.DrawString(cpoTaxaNf.Text, cpoTaxaNf.Font, Brushes.Black, new Point(,300));
            //e.Graphics.DrawString(lblSeguro.Text, lblSeguro.Font, Brushes.Black, new Point(,320));
            //e.Graphics.DrawString(cpoSeguro.Text, cpoSeguro.Font, Brushes.Black, new Point(,320));
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (printDialogImprimir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocumentImprimir.PrinterSettings = printDialogImprimir.PrinterSettings;
                printDocumentImprimir.Print();
            }
        }

        private void cpoFormaPagamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
