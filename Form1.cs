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
            labelProduto.Visible = true;
            labelVisuCod.Visible = true;
            labelVisuQtd.Visible = true;
            labelValorUnidade.Visible = true;
            labelValorTotalParcial.Visible = true;
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
            btnEntrar.Hide();
            tbUser.Hide();
            tbSenha.Hide();
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
            Close();
        }
    }
}
