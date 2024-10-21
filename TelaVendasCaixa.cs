using System;
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
    public partial class TelaVendasCaixa : Form
    {
        public TelaVendasCaixa()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelaVendasCaixa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            Form openForm1 = FormJaAberto(typeof(PopUpEncerramento));

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                PopUpEncerramento popUpEncerramento = new PopUpEncerramento();
                //telaVendas.MdiParent = this;
                popUpEncerramento.Show();
            }
        }
    }
}
