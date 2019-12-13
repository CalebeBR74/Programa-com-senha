﻿using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Aplicações.Classes;
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

namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Aplicações
{
	public partial class PM_GrpAE_ : Form
	{
		public PM_GrpAE_()
		{
			InitializeComponent();
		}
		private void Gravar(Policial_Grpae_ PoGrpae)
		{
			if (File.Exists(@"C:\arquivos\arq1.txt"))
			{
				PoGrpae.Patente = txtPatente.Text;
				PoGrpae.Nome = txtNome.Text;
				PoGrpae.CPF = txtCPF.Text;
				PoGrpae.Viatura = txtViatura.Text;

				var conteudo = PoGrpae.ToString();
				File.WriteAllText(@"C:\arquivos\arq1.txt", conteudo);//escreve o conteudo no caminho indicado que leva a um arquivo de bloco de notas txt
			}
		}
		private void btnGravar_Click(object sender, EventArgs e)
		{
			Policial_Grpae_ a = new Policial_Grpae_();
			Gravar(a);
		}

		private void button1_Click(object sender, EventArgs e)
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
							txtBdRP.Text += linha + "\r\n";
						}
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Menu_de_inicio MENUA = new Menu_de_inicio();
			MENUA.Show();
			this.Close();
		}
	}
}
