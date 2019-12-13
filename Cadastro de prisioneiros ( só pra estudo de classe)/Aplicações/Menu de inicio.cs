using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Aplicações;
using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources;
namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources
{
	public partial class Menu_de_inicio : Form
	{

		public Menu_de_inicio()
		{
			InitializeComponent();
		}

		private void Button6_Click(object sender, EventArgs e)
		{
			CadastroPrisioneiro AprendidosDetidos = new CadastroPrisioneiro();
			AprendidosDetidos.Show();
			this.Visible = false;
		}

		private void Menu_de_inicio_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			AbaTrasito aba = new AbaTrasito();
			aba.Show();

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			PM_RP_ RPABA = new PM_RP_();
			RPABA.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.Visible = false;
			PM_GrpAE_ GRPAEABA = new PM_GrpAE_();
			GRPAEABA.Show();
		}
	}
}
