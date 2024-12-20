﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasPimFrenteDeCaixa
{
    public partial class TelaLoginCaixa : Form
    {
        public TelaLoginCaixa()
        {
            InitializeComponent();
        }

        private void AbrirTelaDeVendas()
        {
            Form openForm1 = FormJaAberto(typeof(TelaVendasCaixa));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                TelaVendasCaixa telaVendas = new TelaVendasCaixa();
                //telaVendas.MdiParent = this;
                telaVendas.Show();
            }
        }
        private Form FormJaAberto(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return openForm;
                }
            }
            return null;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AbrirTelaDeVendas();
        }

        private void TelaLoginCaixa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AbrirTelaDeVendas();
            }
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }
    }
}
