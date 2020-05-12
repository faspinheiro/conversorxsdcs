using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Conversor_XSD
{
    public partial class FormConversor : Form
    {
        private List<String> arquivosSelecionados = new List<String>();        
        private String diretorioSaida = "X";
        private String caminhoExecXSD = @"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.7.2 Tools\xsd.exe";

        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnAdicionarXSD_Click(Object sender, EventArgs e)
        {
            
            ofdArquivosXSD.Multiselect = false;
            ofdArquivosXSD.Title = "Escolha um arquivo XSD:";
            ofdArquivosXSD.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            ofdArquivosXSD.DefaultExt = "xsd";
            ofdArquivosXSD.Filter = "XML Schema (*.XSD)|*.XSD|All files(*.*)|*.*";
            ofdArquivosXSD.CheckFileExists = true;
            ofdArquivosXSD.CheckPathExists = true;
            ofdArquivosXSD.FilterIndex = 1;
            ofdArquivosXSD.RestoreDirectory = true;
            ofdArquivosXSD.ReadOnlyChecked = true;
            ofdArquivosXSD.ShowReadOnly = true;

            DialogResult dr = ofdArquivosXSD.ShowDialog();

            if(dr == DialogResult.OK)
            {

                textBoxArquivosSelecionados.AppendText(ofdArquivosXSD.FileName + "\r\n");
                arquivosSelecionados.Add(ofdArquivosXSD.FileName);
                textBoxTotalArquivos.Text = arquivosSelecionados.Count.ToString();
            }

        }

        private void btnSelecionarDiretorio_Click(Object sender, EventArgs e)
        {

            selecionarDiretorio.Description = "Escolha o diretório para salvar a classe:";
            selecionarDiretorio.RootFolder = Environment.SpecialFolder.MyComputer;            
            selecionarDiretorio.ShowNewFolderButton = true;            

            DialogResult dr = selecionarDiretorio.ShowDialog();

            if (dr == DialogResult.OK)
            {

                diretorioSaida = selecionarDiretorio.SelectedPath;
                textSaida.Text = diretorioSaida;
            }

        }

        private void btnExecutar_click(Object sender, EventArgs e)
        {

            String argumento = "";

            if(arquivosSelecionados.Count < 1 || diretorioSaida == "X")
            {
                MessageBox.Show("Você deve escolher pelo menos um arquivo XSD e o diretório para salvar as classes.");
            }
            else
            {
                foreach (String nome in arquivosSelecionados)
                {
                    argumento += "\"" + nome + "\" ";
                }

                argumento += "/c /l:CS /o:\"" + diretorioSaida + "\"";
                argumento += "";

                ProcessStartInfo infoProcesso = new ProcessStartInfo(caminhoExecXSD, argumento);
                Process processo = Process.Start(infoProcesso);
                textBoxResultado.Text = processo.ExitCode.ToString();
                textBoxResultado.Visible = true;
            }
            
        }

    }


}
