namespace TelasPimFrenteDeCaixa
{
    partial class TelaVendasCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEsc = new System.Windows.Forms.Panel();
            this.btnEsc = new System.Windows.Forms.Button();
            this.pictureTextEsc = new System.Windows.Forms.PictureBox();
            this.panelFundoAtendente = new System.Windows.Forms.Panel();
            this.labelData = new System.Windows.Forms.Label();
            this.labelNomeAtendente = new System.Windows.Forms.Label();
            this.pictureAtendente = new System.Windows.Forms.PictureBox();
            this.panelFundoCaixaAberto = new System.Windows.Forms.Panel();
            this.pictureTextoCaixaAberto = new System.Windows.Forms.PictureBox();
            this.pictureLogoMorangolandiaVendas = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.panelCodQtdCodBarra = new System.Windows.Forms.Panel();
            this.panelEsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextEsc)).BeginInit();
            this.panelFundoAtendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAtendente)).BeginInit();
            this.panelFundoCaixaAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextoCaixaAberto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandiaVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEsc
            // 
            this.panelEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEsc.Controls.Add(this.btnEsc);
            this.panelEsc.Controls.Add(this.pictureTextEsc);
            this.panelEsc.Location = new System.Drawing.Point(1219, 41);
            this.panelEsc.Name = "panelEsc";
            this.panelEsc.Size = new System.Drawing.Size(101, 50);
            this.panelEsc.TabIndex = 3;
            // 
            // btnEsc
            // 
            this.btnEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsc.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.esc_logo;
            this.btnEsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEsc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEsc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsc.ForeColor = System.Drawing.Color.Transparent;
            this.btnEsc.Location = new System.Drawing.Point(50, 2);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(47, 45);
            this.btnEsc.TabIndex = 1;
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // pictureTextEsc
            // 
            this.pictureTextEsc.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.texto_esc;
            this.pictureTextEsc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTextEsc.Location = new System.Drawing.Point(3, 17);
            this.pictureTextEsc.Name = "pictureTextEsc";
            this.pictureTextEsc.Size = new System.Drawing.Size(44, 18);
            this.pictureTextEsc.TabIndex = 0;
            this.pictureTextEsc.TabStop = false;
            // 
            // panelFundoAtendente
            // 
            this.panelFundoAtendente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundoAtendente.BackColor = System.Drawing.Color.Transparent;
            this.panelFundoAtendente.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.fundo_atendende;
            this.panelFundoAtendente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundoAtendente.Controls.Add(this.labelHora);
            this.panelFundoAtendente.Controls.Add(this.labelData);
            this.panelFundoAtendente.Controls.Add(this.labelNomeAtendente);
            this.panelFundoAtendente.Controls.Add(this.pictureAtendente);
            this.panelFundoAtendente.Location = new System.Drawing.Point(775, 347);
            this.panelFundoAtendente.Name = "panelFundoAtendente";
            this.panelFundoAtendente.Size = new System.Drawing.Size(545, 96);
            this.panelFundoAtendente.TabIndex = 4;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelData.Location = new System.Drawing.Point(386, 26);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(142, 24);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data: 00/00/0000\r\n";
            // 
            // labelNomeAtendente
            // 
            this.labelNomeAtendente.AutoSize = true;
            this.labelNomeAtendente.Font = new System.Drawing.Font("Tw Cen MT Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAtendente.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelNomeAtendente.Location = new System.Drawing.Point(106, 29);
            this.labelNomeAtendente.Name = "labelNomeAtendente";
            this.labelNomeAtendente.Size = new System.Drawing.Size(212, 41);
            this.labelNomeAtendente.TabIndex = 1;
            this.labelNomeAtendente.Text = "\"ola atendente\"";
            // 
            // pictureAtendente
            // 
            this.pictureAtendente.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.logo_atendente;
            this.pictureAtendente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureAtendente.Location = new System.Drawing.Point(18, 23);
            this.pictureAtendente.Name = "pictureAtendente";
            this.pictureAtendente.Size = new System.Drawing.Size(64, 56);
            this.pictureAtendente.TabIndex = 0;
            this.pictureAtendente.TabStop = false;
            // 
            // panelFundoCaixaAberto
            // 
            this.panelFundoCaixaAberto.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.caixa_aberto_fundo_roxo;
            this.panelFundoCaixaAberto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundoCaixaAberto.Controls.Add(this.pictureTextoCaixaAberto);
            this.panelFundoCaixaAberto.Location = new System.Drawing.Point(394, 17);
            this.panelFundoCaixaAberto.Name = "panelFundoCaixaAberto";
            this.panelFundoCaixaAberto.Size = new System.Drawing.Size(558, 100);
            this.panelFundoCaixaAberto.TabIndex = 2;
            // 
            // pictureTextoCaixaAberto
            // 
            this.pictureTextoCaixaAberto.BackColor = System.Drawing.Color.Transparent;
            this.pictureTextoCaixaAberto.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.caixa_aberto_texto;
            this.pictureTextoCaixaAberto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureTextoCaixaAberto.Location = new System.Drawing.Point(22, 19);
            this.pictureTextoCaixaAberto.Name = "pictureTextoCaixaAberto";
            this.pictureTextoCaixaAberto.Size = new System.Drawing.Size(516, 65);
            this.pictureTextoCaixaAberto.TabIndex = 0;
            this.pictureTextoCaixaAberto.TabStop = false;
            // 
            // pictureLogoMorangolandiaVendas
            // 
            this.pictureLogoMorangolandiaVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogoMorangolandiaVendas.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogoMorangolandiaVendas.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.morangolandia_logo;
            this.pictureLogoMorangolandiaVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogoMorangolandiaVendas.Location = new System.Drawing.Point(871, 132);
            this.pictureLogoMorangolandiaVendas.Name = "pictureLogoMorangolandiaVendas";
            this.pictureLogoMorangolandiaVendas.Size = new System.Drawing.Size(360, 193);
            this.pictureLogoMorangolandiaVendas.TabIndex = 1;
            this.pictureLogoMorangolandiaVendas.TabStop = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DarkOrchid;
            this.labelHora.Location = new System.Drawing.Point(386, 50);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(97, 24);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "Hora: 00:00";
            // 
            // panelCodQtdCodBarra
            // 
            this.panelCodQtdCodBarra.Location = new System.Drawing.Point(775, 526);
            this.panelCodQtdCodBarra.Name = "panelCodQtdCodBarra";
            this.panelCodQtdCodBarra.Size = new System.Drawing.Size(545, 260);
            this.panelCodQtdCodBarra.TabIndex = 5;
            // 
            // TelaVendasCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 784);
            this.Controls.Add(this.panelCodQtdCodBarra);
            this.Controls.Add(this.panelFundoAtendente);
            this.Controls.Add(this.panelEsc);
            this.Controls.Add(this.panelFundoCaixaAberto);
            this.Controls.Add(this.pictureLogoMorangolandiaVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaVendasCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVendasCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaVendasCaixa_Load);
            this.panelEsc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextEsc)).EndInit();
            this.panelFundoAtendente.ResumeLayout(false);
            this.panelFundoAtendente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAtendente)).EndInit();
            this.panelFundoCaixaAberto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextoCaixaAberto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandiaVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureLogoMorangolandiaVendas;
        private System.Windows.Forms.Panel panelFundoCaixaAberto;
        private System.Windows.Forms.PictureBox pictureTextoCaixaAberto;
        private System.Windows.Forms.Panel panelEsc;
        private System.Windows.Forms.PictureBox pictureTextEsc;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Panel panelFundoAtendente;
        private System.Windows.Forms.PictureBox pictureAtendente;
        private System.Windows.Forms.Label labelNomeAtendente;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panelCodQtdCodBarra;
    }
}