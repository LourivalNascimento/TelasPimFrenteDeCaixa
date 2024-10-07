namespace TelasPimFrenteDeCaixa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.labelTotalCompra = new System.Windows.Forms.Label();
            this.labelCodProd = new System.Windows.Forms.Label();
            this.labelQTD = new System.Windows.Forms.Label();
            this.labelCodBarras = new System.Windows.Forms.Label();
            this.tbQTD = new System.Windows.Forms.TextBox();
            this.tbCodProd = new System.Windows.Forms.TextBox();
            this.tbCodBarras = new System.Windows.Forms.TextBox();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnEncerrarCompra = new System.Windows.Forms.Button();
            this.labelVisuCod = new System.Windows.Forms.Label();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelVisuQtd = new System.Windows.Forms.Label();
            this.labelValorUnidade = new System.Windows.Forms.Label();
            this.labelValorTotalParcial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.tbUser.Location = new System.Drawing.Point(576, 349);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(216, 26);
            this.tbUser.TabIndex = 7;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSenha
            // 
            this.tbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.tbSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSenha.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.tbSenha.Location = new System.Drawing.Point(576, 426);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(216, 27);
            this.tbSenha.TabIndex = 6;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.btnEntrarNormal;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Location = new System.Drawing.Point(608, 472);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(140, 57);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            this.btnEntrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEntrar_MouseDown);
            this.btnEntrar.MouseLeave += new System.EventHandler(this.btnEntrar_MouseLeave);
            this.btnEntrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEntrar_MouseMove);
            // 
            // btnEsc
            // 
            this.btnEsc.AutoSize = true;
            this.btnEsc.BackColor = System.Drawing.Color.Transparent;
            this.btnEsc.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.btnEsc;
            this.btnEsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsc.FlatAppearance.BorderSize = 0;
            this.btnEsc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsc.Location = new System.Drawing.Point(1211, 61);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(104, 52);
            this.btnEsc.TabIndex = 8;
            this.btnEsc.UseVisualStyleBackColor = false;
            this.btnEsc.Visible = false;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            this.btnEsc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEsc_MouseDown);
            this.btnEsc.MouseLeave += new System.EventHandler(this.btnEsc_MouseLeave);
            this.btnEsc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEsc_MouseMove);
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeUsuario.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelNomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.labelNomeUsuario.Location = new System.Drawing.Point(785, 335);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(69, 26);
            this.labelNomeUsuario.TabIndex = 9;
            this.labelNomeUsuario.Text = "label1";
            this.labelNomeUsuario.Visible = false;
            // 
            // labelTotalCompra
            // 
            this.labelTotalCompra.AutoSize = true;
            this.labelTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalCompra.Font = new System.Drawing.Font("Berlin Sans FB Demi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCompra.Location = new System.Drawing.Point(509, 604);
            this.labelTotalCompra.Name = "labelTotalCompra";
            this.labelTotalCompra.Size = new System.Drawing.Size(110, 31);
            this.labelTotalCompra.TabIndex = 10;
            this.labelTotalCompra.Text = "R$ 0,00";
            this.labelTotalCompra.Visible = false;
            // 
            // labelCodProd
            // 
            this.labelCodProd.AutoSize = true;
            this.labelCodProd.BackColor = System.Drawing.Color.Transparent;
            this.labelCodProd.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.labelCodProd.Location = new System.Drawing.Point(784, 405);
            this.labelCodProd.Name = "labelCodProd";
            this.labelCodProd.Size = new System.Drawing.Size(129, 24);
            this.labelCodProd.TabIndex = 11;
            this.labelCodProd.Text = "COD. PROD.";
            this.labelCodProd.Visible = false;
            // 
            // labelQTD
            // 
            this.labelQTD.AutoSize = true;
            this.labelQTD.BackColor = System.Drawing.Color.Transparent;
            this.labelQTD.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQTD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.labelQTD.Location = new System.Drawing.Point(1104, 405);
            this.labelQTD.Name = "labelQTD";
            this.labelQTD.Size = new System.Drawing.Size(58, 24);
            this.labelQTD.TabIndex = 12;
            this.labelQTD.Text = "QTD.";
            this.labelQTD.Visible = false;
            // 
            // labelCodBarras
            // 
            this.labelCodBarras.AutoSize = true;
            this.labelCodBarras.BackColor = System.Drawing.Color.Transparent;
            this.labelCodBarras.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.labelCodBarras.Location = new System.Drawing.Point(947, 498);
            this.labelCodBarras.Name = "labelCodBarras";
            this.labelCodBarras.Size = new System.Drawing.Size(143, 24);
            this.labelCodBarras.TabIndex = 13;
            this.labelCodBarras.Text = "COD. BARRAS";
            this.labelCodBarras.Visible = false;
            // 
            // tbQTD
            // 
            this.tbQTD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.tbQTD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQTD.Location = new System.Drawing.Point(1104, 456);
            this.tbQTD.Name = "tbQTD";
            this.tbQTD.Size = new System.Drawing.Size(100, 31);
            this.tbQTD.TabIndex = 14;
            this.tbQTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQTD.Visible = false;
            this.tbQTD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQTD_KeyDown);
            // 
            // tbCodProd
            // 
            this.tbCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.tbCodProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodProd.Location = new System.Drawing.Point(796, 456);
            this.tbCodProd.Name = "tbCodProd";
            this.tbCodProd.Size = new System.Drawing.Size(100, 31);
            this.tbCodProd.TabIndex = 14;
            this.tbCodProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodProd.Visible = false;
            this.tbCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodProd_KeyDown);
            // 
            // tbCodBarras
            // 
            this.tbCodBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.tbCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodBarras.Location = new System.Drawing.Point(966, 535);
            this.tbCodBarras.Name = "tbCodBarras";
            this.tbCodBarras.Size = new System.Drawing.Size(100, 31);
            this.tbCodBarras.TabIndex = 16;
            this.tbCodBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCodBarras.Visible = false;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.AutoSize = true;
            this.btnCancelarItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarItem.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.btnCancelarItem.Location = new System.Drawing.Point(772, 589);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(107, 48);
            this.btnCancelarItem.TabIndex = 17;
            this.btnCancelarItem.Text = "CANCELAR\r\nITEM";
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Visible = false;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.AutoSize = true;
            this.btnCancelarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCompra.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.btnCancelarCompra.Location = new System.Drawing.Point(940, 589);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(107, 48);
            this.btnCancelarCompra.TabIndex = 18;
            this.btnCancelarCompra.Text = "CANCELAR\r\nCOMPRA";
            this.btnCancelarCompra.UseVisualStyleBackColor = false;
            this.btnCancelarCompra.Visible = false;
            // 
            // btnEncerrarCompra
            // 
            this.btnEncerrarCompra.AutoSize = true;
            this.btnEncerrarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnEncerrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncerrarCompra.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(65)))), ((int)(((byte)(194)))));
            this.btnEncerrarCompra.Location = new System.Drawing.Point(1104, 590);
            this.btnEncerrarCompra.Name = "btnEncerrarCompra";
            this.btnEncerrarCompra.Size = new System.Drawing.Size(107, 48);
            this.btnEncerrarCompra.TabIndex = 19;
            this.btnEncerrarCompra.Text = "ENCERRAR\r\nCOMPRA";
            this.btnEncerrarCompra.UseVisualStyleBackColor = false;
            this.btnEncerrarCompra.Visible = false;
            // 
            // labelVisuCod
            // 
            this.labelVisuCod.AutoSize = true;
            this.labelVisuCod.BackColor = System.Drawing.Color.Transparent;
            this.labelVisuCod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisuCod.Location = new System.Drawing.Point(54, 162);
            this.labelVisuCod.Name = "labelVisuCod";
            this.labelVisuCod.Size = new System.Drawing.Size(65, 22);
            this.labelVisuCod.TabIndex = 20;
            this.labelVisuCod.Text = "label1";
            this.labelVisuCod.Visible = false;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.BackColor = System.Drawing.Color.Transparent;
            this.labelProduto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(133, 162);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(65, 22);
            this.labelProduto.TabIndex = 21;
            this.labelProduto.Text = "label2";
            this.labelProduto.Visible = false;
            // 
            // labelVisuQtd
            // 
            this.labelVisuQtd.AutoSize = true;
            this.labelVisuQtd.BackColor = System.Drawing.Color.Transparent;
            this.labelVisuQtd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisuQtd.Location = new System.Drawing.Point(409, 162);
            this.labelVisuQtd.Name = "labelVisuQtd";
            this.labelVisuQtd.Size = new System.Drawing.Size(65, 22);
            this.labelVisuQtd.TabIndex = 22;
            this.labelVisuQtd.Text = "label3";
            this.labelVisuQtd.Visible = false;
            // 
            // labelValorUnidade
            // 
            this.labelValorUnidade.AutoSize = true;
            this.labelValorUnidade.BackColor = System.Drawing.Color.Transparent;
            this.labelValorUnidade.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorUnidade.Location = new System.Drawing.Point(491, 162);
            this.labelValorUnidade.Name = "labelValorUnidade";
            this.labelValorUnidade.Size = new System.Drawing.Size(65, 22);
            this.labelValorUnidade.TabIndex = 23;
            this.labelValorUnidade.Text = "label4";
            this.labelValorUnidade.Visible = false;
            // 
            // labelValorTotalParcial
            // 
            this.labelValorTotalParcial.AutoSize = true;
            this.labelValorTotalParcial.BackColor = System.Drawing.Color.Transparent;
            this.labelValorTotalParcial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalParcial.Location = new System.Drawing.Point(575, 162);
            this.labelValorTotalParcial.Name = "labelValorTotalParcial";
            this.labelValorTotalParcial.Size = new System.Drawing.Size(65, 22);
            this.labelValorTotalParcial.TabIndex = 24;
            this.labelValorTotalParcial.Text = "label5";
            this.labelValorTotalParcial.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.VENDAS___CAIXA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 691);
            this.Controls.Add(this.labelValorTotalParcial);
            this.Controls.Add(this.labelValorUnidade);
            this.Controls.Add(this.labelVisuQtd);
            this.Controls.Add(this.labelProduto);
            this.Controls.Add(this.labelVisuCod);
            this.Controls.Add(this.btnEncerrarCompra);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.tbCodBarras);
            this.Controls.Add(this.tbCodProd);
            this.Controls.Add(this.tbQTD);
            this.Controls.Add(this.labelCodBarras);
            this.Controls.Add(this.labelQTD);
            this.Controls.Add(this.labelCodProd);
            this.Controls.Add(this.labelTotalCompra);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.btnEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C A I X A (m o r a n g o l â n d i a)";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.Label labelTotalCompra;
        private System.Windows.Forms.Label labelCodProd;
        private System.Windows.Forms.Label labelQTD;
        private System.Windows.Forms.Label labelCodBarras;
        private System.Windows.Forms.TextBox tbQTD;
        private System.Windows.Forms.TextBox tbCodProd;
        private System.Windows.Forms.TextBox tbCodBarras;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnEncerrarCompra;
        private System.Windows.Forms.Label labelVisuCod;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelVisuQtd;
        private System.Windows.Forms.Label labelValorUnidade;
        private System.Windows.Forms.Label labelValorTotalParcial;
    }
}

