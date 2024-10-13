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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureLogoMorangolandiaVendas = new System.Windows.Forms.PictureBox();
            this.panelFundoCaixaAberto = new System.Windows.Forms.Panel();
            this.pictureTextoCaixaAberto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandiaVendas)).BeginInit();
            this.panelFundoCaixaAberto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextoCaixaAberto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.button1.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.esc_logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1267, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 56);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureLogoMorangolandiaVendas
            // 
            this.pictureLogoMorangolandiaVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureLogoMorangolandiaVendas.BackColor = System.Drawing.Color.Transparent;
            this.pictureLogoMorangolandiaVendas.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.morangolandia_logo;
            this.pictureLogoMorangolandiaVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogoMorangolandiaVendas.Location = new System.Drawing.Point(893, 213);
            this.pictureLogoMorangolandiaVendas.Name = "pictureLogoMorangolandiaVendas";
            this.pictureLogoMorangolandiaVendas.Size = new System.Drawing.Size(380, 171);
            this.pictureLogoMorangolandiaVendas.TabIndex = 1;
            this.pictureLogoMorangolandiaVendas.TabStop = false;
            // 
            // panelFundoCaixaAberto
            // 
            this.panelFundoCaixaAberto.BackgroundImage = global::TelasPimFrenteDeCaixa.Properties.Resources.caixa_aberto_fundo_roxo;
            this.panelFundoCaixaAberto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFundoCaixaAberto.Controls.Add(this.pictureTextoCaixaAberto);
            this.panelFundoCaixaAberto.Location = new System.Drawing.Point(394, 59);
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
            // TelaVendasCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(251)))), ((int)(((byte)(231)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 784);
            this.Controls.Add(this.panelFundoCaixaAberto);
            this.Controls.Add(this.pictureLogoMorangolandiaVendas);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaVendasCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaVendasCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaVendasCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoMorangolandiaVendas)).EndInit();
            this.panelFundoCaixaAberto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTextoCaixaAberto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureLogoMorangolandiaVendas;
        private System.Windows.Forms.Panel panelFundoCaixaAberto;
        private System.Windows.Forms.PictureBox pictureTextoCaixaAberto;
    }
}