using System;

namespace Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Aplicações
{
	partial class AbaTrasito
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
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.txtCor = new System.Windows.Forms.TextBox();
			this.txtMotivoAprensãodoCarro = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBdSaida = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnMostrarDados = new System.Windows.Forms.Button();
			this.btnVoltarMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.Location = new System.Drawing.Point(12, 378);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(257, 60);
			this.btnConfirmar.TabIndex = 0;
			this.btnConfirmar.Text = "Salvar";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
			// 
			// txtPlaca
			// 
			this.txtPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPlaca.Location = new System.Drawing.Point(12, 30);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(247, 26);
			this.txtPlaca.TabIndex = 1;
			// 
			// txtModelo
			// 
			this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModelo.Location = new System.Drawing.Point(12, 80);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(247, 26);
			this.txtModelo.TabIndex = 1;
			this.txtModelo.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
			// 
			// txtCor
			// 
			this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCor.Location = new System.Drawing.Point(12, 130);
			this.txtCor.Name = "txtCor";
			this.txtCor.Size = new System.Drawing.Size(247, 26);
			this.txtCor.TabIndex = 1;
			// 
			// txtMotivoAprensãodoCarro
			// 
			this.txtMotivoAprensãodoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMotivoAprensãodoCarro.Location = new System.Drawing.Point(14, 180);
			this.txtMotivoAprensãodoCarro.Multiline = true;
			this.txtMotivoAprensãodoCarro.Name = "txtMotivoAprensãodoCarro";
			this.txtMotivoAprensãodoCarro.Size = new System.Drawing.Size(246, 192);
			this.txtMotivoAprensãodoCarro.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Placa do carro";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Modelo do carro";
			this.label2.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Cor do carro";
			this.label3.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtBdSaida
			// 
			this.txtBdSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBdSaida.Location = new System.Drawing.Point(529, 80);
			this.txtBdSaida.Multiline = true;
			this.txtBdSaida.Name = "txtBdSaida";
			this.txtBdSaida.Size = new System.Drawing.Size(268, 292);
			this.txtBdSaida.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(523, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 31);
			this.label4.TabIndex = 2;
			this.label4.Text = "Banco de dados";
			this.label4.Click += new System.EventHandler(this.label1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(119, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "Motivo aprensão";
			this.label5.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnMostrarDados
			// 
			this.btnMostrarDados.BackgroundImage = global::Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Properties.Resources.BtnAtualizar;
			this.btnMostrarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMostrarDados.Location = new System.Drawing.Point(738, 48);
			this.btnMostrarDados.Name = "btnMostrarDados";
			this.btnMostrarDados.Size = new System.Drawing.Size(39, 33);
			this.btnMostrarDados.TabIndex = 0;
			this.btnMostrarDados.UseVisualStyleBackColor = true;
			this.btnMostrarDados.Click += new System.EventHandler(this.BtnMostrarDados_Click);
			// 
			// btnVoltarMenu
			// 
			this.btnVoltarMenu.BackgroundImage = global::Cadastro_de_prisioneiros___só_pra_estudo_de_classe_.Properties.Resources.btnHome1;
			this.btnVoltarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarMenu.Location = new System.Drawing.Point(278, 378);
			this.btnVoltarMenu.Name = "btnVoltarMenu";
			this.btnVoltarMenu.Size = new System.Drawing.Size(90, 60);
			this.btnVoltarMenu.TabIndex = 0;
			this.btnVoltarMenu.UseVisualStyleBackColor = true;
			this.btnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
			// 
			// AbaTrasito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBdSaida);
			this.Controls.Add(this.txtMotivoAprensãodoCarro);
			this.Controls.Add(this.txtCor);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.txtPlaca);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.btnMostrarDados);
			this.Controls.Add(this.btnVoltarMenu);
			this.Name = "AbaTrasito";
			this.Text = "AbaTrasito";
			this.Load += new System.EventHandler(this.AbaTrasito_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void label1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.Button btnVoltarMenu;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.TextBox txtPlaca;
		private System.Windows.Forms.TextBox txtModelo;
		private System.Windows.Forms.TextBox txtCor;
		private System.Windows.Forms.TextBox txtMotivoAprensãodoCarro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBdSaida;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnMostrarDados;
	}
}