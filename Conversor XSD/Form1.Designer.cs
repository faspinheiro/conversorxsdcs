namespace Conversor_XSD
{
    partial class FormConversor
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
            this.ofdArquivosXSD = new System.Windows.Forms.OpenFileDialog();
            this.btnAdicionarXSD = new System.Windows.Forms.Button();
            this.textSaida = new System.Windows.Forms.TextBox();
            this.btnSelecionarDiretorio = new System.Windows.Forms.Button();
            this.labelTotalArquivos = new System.Windows.Forms.Label();
            this.textBoxTotalArquivos = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.textBoxArquivosSelecionados = new System.Windows.Forms.TextBox();
            this.selecionarDiretorio = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // ofdArquivosXSD
            // 
            this.ofdArquivosXSD.FileName = "openFileDialog1";
            // 
            // btnAdicionarXSD
            // 
            this.btnAdicionarXSD.Location = new System.Drawing.Point(12, 34);
            this.btnAdicionarXSD.Name = "btnAdicionarXSD";
            this.btnAdicionarXSD.Size = new System.Drawing.Size(397, 23);
            this.btnAdicionarXSD.TabIndex = 1;
            this.btnAdicionarXSD.Text = "Adicionar XSDs";
            this.btnAdicionarXSD.UseVisualStyleBackColor = true;
            this.btnAdicionarXSD.Click += new System.EventHandler(this.btnAdicionarXSD_Click);
            // 
            // textSaida
            // 
            this.textSaida.Location = new System.Drawing.Point(202, 370);
            this.textSaida.Name = "textSaida";
            this.textSaida.Size = new System.Drawing.Size(207, 20);
            this.textSaida.TabIndex = 3;
            // 
            // btnSelecionarDiretorio
            // 
            this.btnSelecionarDiretorio.Location = new System.Drawing.Point(16, 370);
            this.btnSelecionarDiretorio.Name = "btnSelecionarDiretorio";
            this.btnSelecionarDiretorio.Size = new System.Drawing.Size(163, 23);
            this.btnSelecionarDiretorio.TabIndex = 4;
            this.btnSelecionarDiretorio.Text = "Selecionar diretório das classes";
            this.btnSelecionarDiretorio.UseVisualStyleBackColor = true;
            this.btnSelecionarDiretorio.Click += new System.EventHandler(this.btnSelecionarDiretorio_Click);
            // 
            // labelTotalArquivos
            // 
            this.labelTotalArquivos.AutoSize = true;
            this.labelTotalArquivos.Location = new System.Drawing.Point(13, 328);
            this.labelTotalArquivos.Name = "labelTotalArquivos";
            this.labelTotalArquivos.Size = new System.Drawing.Size(90, 13);
            this.labelTotalArquivos.TabIndex = 5;
            this.labelTotalArquivos.Text = "Total de Arquivos";
            // 
            // textBoxTotalArquivos
            // 
            this.textBoxTotalArquivos.Location = new System.Drawing.Point(134, 325);
            this.textBoxTotalArquivos.Name = "textBoxTotalArquivos";
            this.textBoxTotalArquivos.Size = new System.Drawing.Size(45, 20);
            this.textBoxTotalArquivos.TabIndex = 6;
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.Green;
            this.btnExecutar.Location = new System.Drawing.Point(16, 423);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(202, 325);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(207, 20);
            this.textBoxResultado.TabIndex = 9;
            this.textBoxResultado.Visible = false;
            // 
            // textBoxArquivosSelecionados
            // 
            this.textBoxArquivosSelecionados.Location = new System.Drawing.Point(16, 73);
            this.textBoxArquivosSelecionados.Multiline = true;
            this.textBoxArquivosSelecionados.Name = "textBoxArquivosSelecionados";
            this.textBoxArquivosSelecionados.ReadOnly = true;
            this.textBoxArquivosSelecionados.Size = new System.Drawing.Size(393, 246);
            this.textBoxArquivosSelecionados.TabIndex = 10;
            // 
            // FormConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 494);
            this.Controls.Add(this.textBoxArquivosSelecionados);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.textBoxTotalArquivos);
            this.Controls.Add(this.labelTotalArquivos);
            this.Controls.Add(this.btnSelecionarDiretorio);
            this.Controls.Add(this.textSaida);
            this.Controls.Add(this.btnAdicionarXSD);
            this.Name = "FormConversor";
            this.Text = "Conversor XSD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdArquivosXSD;
        private System.Windows.Forms.Button btnAdicionarXSD;
        private System.Windows.Forms.TextBox textSaida;
        private System.Windows.Forms.Button btnSelecionarDiretorio;
        private System.Windows.Forms.Label labelTotalArquivos;
        private System.Windows.Forms.TextBox textBoxTotalArquivos;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.TextBox textBoxArquivosSelecionados;
        private System.Windows.Forms.FolderBrowserDialog selecionarDiretorio;
    }
}

