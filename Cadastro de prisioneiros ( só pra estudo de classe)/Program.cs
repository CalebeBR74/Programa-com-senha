using Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_
{
	
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		 
		static void Main()
		{
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(true);

			Menu_de_inicio MENUA = new Menu_de_inicio();
			Application.Run(MENUA);
			
			

		
		}
	}
}
