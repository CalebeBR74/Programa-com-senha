
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources;
using System.Threading;

namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_
{
    public partial class CadastroPrisioneiro : Form
    {
        public CadastroPrisioneiro()
        {
            InitializeComponent();     
        }
       
        
		public class Relatorio //Classe relatorio
		{
			public string Nome;
			public string CPF;
			public string IdadeDetido;
			public string AlturaDetido;
			public string NomePm;
			public string NumeroVTR;
			public string DataApreensao;
			public string HorarioApreensao;

			
		}

		public void Gravar(Relatorio Relatorio) //Metodo que faz todo o relatorio ser gravado no txt
		{
			if (File.Exists(@"C:\arquivos\arq1.txt"))
			{
				string conteudo = Relatorio.CPF + "\r\n" + Relatorio.AlturaDetido + "\r\n" + Relatorio.DataApreensao + "\r\n" + Relatorio.HorarioApreensao + "\r\n" +
					Relatorio.IdadeDetido + "\r\n" + Relatorio.Nome + "\r\n" + Relatorio.NomePm + "\r\n" + Relatorio.NumeroVTR;

				txtBd.Text += Relatorio.Nome + "\t" + Relatorio.IdadeDetido + "\t" + Relatorio.CPF + "\t" + Relatorio.AlturaDetido + "\t"
					+ Relatorio.NomePm + "\t" + Relatorio.NomePm + "\t" + Relatorio.NumeroVTR + "r\n";

				File.WriteAllText(@"C:\arquivos\arq1.txt", conteudo);//escreve o conteudo no caminho indicado que leva a um arquivo de bloco de notas txt
			}
		}


			private void BtnGravar_Click(object sender, EventArgs e) //Botão gravar
		{
			Relatorio novoRelatorio = new Relatorio
			{
				Nome = txtNomeDoDetido.Text, 
				AlturaDetido = txtAlturaDetido.Text,
				CPF = txtCpfDetido.Text,
				DataApreensao = txtDataAprensão.Text,
				HorarioApreensao = txtHorarioAprensão.Text,
				NomePm = txtNomePmAprensão.Text,
				NumeroVTR = txtNumeroVtr.Text,
				IdadeDetido = txtIdadeDetido.Text,
			};
			var c = novoRelatorio;
			Gravar(c);

			Console.WriteLine("Gravado com sucesso!");
		}

		private void Button2_Click(object sender, EventArgs e) //Botão mostrar dados ja feitos
		{
			if (File.Exists(@"C:\arquivos\arq1.txt"))
			{
				LerArquivo(@"C:\arquivos\arq1.txt");
				void LerArquivo(string nomeArquivo)
				{
					using (StreamReader arquivo = File.OpenText(nomeArquivo))
					{
						string linha;
						while ((linha = arquivo.ReadLine()) != null)
						{
							txtBd.Text += linha + "\r\n"; 
						}
					}
				}
			}
		}
		
		private void Button3_Click(object sender, EventArgs e)//Botão de excluir
		{
			txtAlturaDetido.Clear();
			txtCpfDetido.Clear();
			txtDataAprensão.Clear();
			txtHorarioAprensão.Clear();
			txtIdadeDetido.Clear();
			txtMotivoAprensão.Clear();
			txtNomeDoDetido.Clear();
			txtNomePmAprensão.Clear();
			txtNumeroVtr.Clear();
			txtBd.Clear();
			
		}

		private void GroupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void CadastroPrisioneiro_Load(object sender, EventArgs e)
		{

		}
		public Menu_de_inicio menu = new Menu_de_inicio();
		public void Label1_Click(object sender, EventArgs e)
		{
			
		}

		private void label1_Click_1(object sender, EventArgs e)
		{
			this.Close();
			menu.Show();
		}
	}
}