namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Resources
{
	partial class Menu_de_inicio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_de_inicio));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnAprendidosDetidos = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.button1, "button1");
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.button4, "button4");
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.button5, "button5");
			this.button5.Name = "button5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// btnAprendidosDetidos
			// 
			this.btnAprendidosDetidos.BackColor = System.Drawing.Color.Snow;
			this.btnAprendidosDetidos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAprendidosDetidos.FlatAppearance.BorderSize = 2;
			resources.ApplyResources(this.btnAprendidosDetidos, "btnAprendidosDetidos");
			this.btnAprendidosDetidos.Name = "btnAprendidosDetidos";
			this.btnAprendidosDetidos.UseVisualStyleBackColor = false;
			this.btnAprendidosDetidos.Click += new System.EventHandler(this.Button6_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Snow;
			resources.ApplyResources(this.button3, "button3");
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.panel1.Controls.Add(this.btnAprendidosDetidos);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// Menu_de_inicio
			// 
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Menu_de_inicio";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.SystemColors.Desktop;
			this.Load += new System.EventHandler(this.Menu_de_inicio_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnAprendidosDetidos;
		private System.Windows.Forms.Panel panel1;
	}
}