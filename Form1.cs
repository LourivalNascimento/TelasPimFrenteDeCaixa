using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelasPimFrenteDeCaixa
{
    public partial class Form1 : Form
    {
        private bool BtnEntrarAtivo{ get; set; }
        public Form1()
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
        public void OcultarElementosLogin()
        {
            BackgroundImage = Properties.Resources.telaVendas;
            tbUser.Text = null;
            tbSenha.Text = null;
            btnEntrar.Hide();
            tbUser.Hide();
            tbSenha.Hide();
        }
        public void VisualizarElementosLogin()
        {
            BackgroundImage = Properties.Resources.telaLogin;
            btnEntrar.Visible = true;
            tbUser.Visible = true;
            tbSenha.Visible = true;

        }
        public void OcultarElementosVendas()
        {
            BackgroundImage = Properties.Resources.telaLogin;
            //botões
            btnEsc.Hide();
            btnCancelarCompra.Hide();
            btnCancelarItem.Hide();
            btnEncerrarCompra.Hide();
            //textBox
            tbCodBarras = null;
            tbCodProd = null;
            tbQTD = null;
            tbCodBarras.Hide();
            tbCodProd.Hide();
            tbQTD.Hide();
            //label
            labelNomeUsuario.Hide();
            labelCodBarras.Hide();
            labelCodProd.Hide();
            labelQTD.Hide();
            labelTotalCompra.Hide();
            labelNomeUsuario.Hide();
        }
        public void VisualizarElementosVendas()
        {
            //Trocando para tela de fundo de vendas
            BackgroundImage = Properties.Resources.telaVendas;
            //Elemento de vendas visível
            //botões
            btnEsc.Visible = true;
            btnCancelarCompra.Visible = true;
            btnCancelarItem.Visible = true;
            btnEncerrarCompra.Visible = true;
            //textBox
            tbCodBarras.Visible = true;
            tbCodProd.Visible = true;
            tbQTD.Visible = true;
            //label
            labelNomeUsuario.Visible = true;
            labelCodBarras.Visible = true;
            labelCodProd.Visible = true;
            labelQTD.Visible = true;
            labelTotalCompra.Visible = true;
            labelNomeUsuario.Text = "Olá " + tbUser.Text + "!";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //LOGIN 576; 349
            //Chamando imagem de fundo de login
            BackgroundImage = Properties.Resources.telaLogin;
            tbUser.Location = new Point(576, 349);
            tbSenha.Location = new Point(576, 426);
            btnEntrar.Location = new Point(608, 472);
            //VENDAS
            btnEsc.Location = new Point(1211, 61);
            labelNomeUsuario.Location = new Point(785, 335);

        }

        //LOGIN
        private void btnEntrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnEntrar.BackgroundImage = Properties.Resources.btnEntrarNormalEscuro;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.BackgroundImage = Properties.Resources.btnEntrarNormal;
        }

        private void btnEntrar_MouseDown(object sender, MouseEventArgs e)
        {
            btnEntrar.BackgroundImage = Properties.Resources.btnEntrarNormal;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Ocultando os elementos de login após logar
            OcultarElementosLogin();
            VisualizarElementosVendas();    
        }

        //VENDAS
        private void btnEsc_MouseMove(object sender, MouseEventArgs e)
        {
            btnEsc.BackgroundImage = Properties.Resources.btnEscEscuro;
        }
        private void btnEsc_MouseLeave(object sender, EventArgs e)
        {
            btnEsc.BackgroundImage = Properties.Resources.btnEsc;
        }
        private void btnEsc_MouseDown(object sender, MouseEventArgs e)
        {
            btnEsc.BackgroundImage = Properties.Resources.btnEsc;
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            OcultarElementosVendas();
            VisualizarElementosLogin();
        }

        private void tbCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                labelVisuCod.Visible = true;
                labelVisuCod.Text = tbCodProd.Text;
            }
        }

        private void tbQTD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelVisuQtd.Visible = true;
                labelVisuQtd.Text = tbQTD.Text;
            }
        }

        private void btnEncerrarCompra_Click(object sender, EventArgs e)
        {
            

            Form openForm1 = FormJaAberto(typeof(PopUpEncerramento));
            PopUpEncerramento popUp = new PopUpEncerramento();

            popUp.Location = new Point(520, 149);

            if (openForm1 != null)
            {
                openForm1.Focus();
            }
            else
            {
                popUp.Show();
            }
        }
    }
}
