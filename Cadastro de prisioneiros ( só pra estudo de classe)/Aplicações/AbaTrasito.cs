using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Aplicações
{
	public partial class AbaTrasito : Form
	{
	    public AbaTrasito()
		{
			InitializeComponent();
		}

		private void Gravar(RelatorioTransito relatorio) //Metodo que faz todo o relatorio ser gravado no txt
		{
			if (File.Exists(@"C:\arquivos\arq1.txt"))
			{
				relatorio.CorCarro = txtCor.Text;
				relatorio.Motivo = txtMotivoAprensãodoCarro.Text;
				relatorio.PlacaCarro = txtPlaca.Text;
				relatorio.Modelo = txtModelo.Text;
				var conteudo = relatorio.ToString();

				File.WriteAllText(@"C:\arquivos\arq1.txt", conteudo);//escreve o conteudo no caminho indicado que leva a um arquivo de bloco de notas txt
			}
		}
		
		private class RelatorioTransito
		{
			public string CorCarro ;
			public string Motivo ;
			public string PlacaCarro ;
			public string Modelo ;
		}
		
		private void BtnVoltarMenu_Click(object sender, EventArgs e)
		{
			Menu_de_inicio MENUA = new Menu_de_inicio();
			MENUA.Show();
			this.Close();
		}

		private void BtnConfirmar_Click(object sender, EventArgs e)
		{
			RelatorioTransito relatorio = new RelatorioTransito();
			Gravar(relatorio);
			
		}

		private void BtnMostrarDados_Click(object sender, EventArgs e)
		{
			if(File.Exists(@"C:\arquivos\arq1.txt"))
			{
				LerArquivo(@"C:\arquivos\arq1.txt");
				void LerArquivo(string nomeArquivo)
				{
					using (StreamReader arquivo = File.OpenText(nomeArquivo))
					{
						string linha;
						while ((linha = arquivo.ReadLine()) != null)
						{
							txtBdSaida.Text += linha + "\r\n";
						}
					}
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			AbaTrasito aba = new AbaTrasito();
			aba.Show();

		}

		private void AbaTrasito_Load(object sender, EventArgs e)
		{

		}

		private void TextBox2_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
