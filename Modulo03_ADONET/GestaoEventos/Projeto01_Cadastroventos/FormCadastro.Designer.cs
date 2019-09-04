namespace Projeto01_Cadastroventos
{
	partial class FormCadastro
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.incluirEventobutton = new System.Windows.Forms.Button();
			this.descTextBox = new System.Windows.Forms.TextBox();
			this.valorTextBox = new System.Windows.Forms.TextBox();
			this.respTextBox = new System.Windows.Forms.TextBox();
			this.dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.incluirConvidadobutton = new System.Windows.Forms.Button();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.cpfTextBox = new System.Windows.Forms.TextBox();
			this.telefoneTextBox = new System.Windows.Forms.TextBox();
			this.nomeTextBoxC = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.eventosComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buscarConvidadosButton = new System.Windows.Forms.Button();
			this.convidadosDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.incluirEventobutton);
			this.groupBox1.Controls.Add(this.descTextBox);
			this.groupBox1.Controls.Add(this.valorTextBox);
			this.groupBox1.Controls.Add(this.respTextBox);
			this.groupBox1.Controls.Add(this.dataMaskedTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(16, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 305);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados do Evento";
			// 
			// incluirEventobutton
			// 
			this.incluirEventobutton.Location = new System.Drawing.Point(9, 145);
			this.incluirEventobutton.Name = "incluirEventobutton";
			this.incluirEventobutton.Size = new System.Drawing.Size(80, 28);
			this.incluirEventobutton.TabIndex = 4;
			this.incluirEventobutton.Text = "Incluir Evento";
			this.incluirEventobutton.UseVisualStyleBackColor = true;
			this.incluirEventobutton.Click += new System.EventHandler(this.incluirEventobutton_Click);
			// 
			// descTextBox
			// 
			this.descTextBox.Location = new System.Drawing.Point(86, 19);
			this.descTextBox.Name = "descTextBox";
			this.descTextBox.Size = new System.Drawing.Size(197, 20);
			this.descTextBox.TabIndex = 0;
			// 
			// valorTextBox
			// 
			this.valorTextBox.Location = new System.Drawing.Point(86, 111);
			this.valorTextBox.Name = "valorTextBox";
			this.valorTextBox.Size = new System.Drawing.Size(60, 20);
			this.valorTextBox.TabIndex = 3;
			// 
			// respTextBox
			// 
			this.respTextBox.Location = new System.Drawing.Point(86, 51);
			this.respTextBox.Name = "respTextBox";
			this.respTextBox.Size = new System.Drawing.Size(197, 20);
			this.respTextBox.TabIndex = 1;
			// 
			// dataMaskedTextBox
			// 
			this.dataMaskedTextBox.Location = new System.Drawing.Point(86, 82);
			this.dataMaskedTextBox.Mask = "00/00/0000";
			this.dataMaskedTextBox.Name = "dataMaskedTextBox";
			this.dataMaskedTextBox.Size = new System.Drawing.Size(60, 20);
			this.dataMaskedTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Valor:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Data:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Responsavel:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Descrição:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.convidadosDataGridView);
			this.groupBox2.Controls.Add(this.buscarConvidadosButton);
			this.groupBox2.Controls.Add(this.incluirConvidadobutton);
			this.groupBox2.Controls.Add(this.emailTextBox);
			this.groupBox2.Controls.Add(this.cpfTextBox);
			this.groupBox2.Controls.Add(this.telefoneTextBox);
			this.groupBox2.Controls.Add(this.nomeTextBoxC);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.eventosComboBox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(326, 53);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(328, 445);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Dados do Convidado";
			// 
			// incluirConvidadobutton
			// 
			this.incluirConvidadobutton.Location = new System.Drawing.Point(17, 182);
			this.incluirConvidadobutton.Name = "incluirConvidadobutton";
			this.incluirConvidadobutton.Size = new System.Drawing.Size(103, 28);
			this.incluirConvidadobutton.TabIndex = 13;
			this.incluirConvidadobutton.Text = "Incluir Convidado";
			this.incluirConvidadobutton.UseVisualStyleBackColor = true;
			this.incluirConvidadobutton.Click += new System.EventHandler(this.incluirConvidadobutton_Click);
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(72, 156);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(197, 20);
			this.emailTextBox.TabIndex = 12;
			// 
			// cpfTextBox
			// 
			this.cpfTextBox.Location = new System.Drawing.Point(72, 78);
			this.cpfTextBox.Name = "cpfTextBox";
			this.cpfTextBox.Size = new System.Drawing.Size(92, 20);
			this.cpfTextBox.TabIndex = 11;
			// 
			// telefoneTextBox
			// 
			this.telefoneTextBox.Location = new System.Drawing.Point(72, 130);
			this.telefoneTextBox.Name = "telefoneTextBox";
			this.telefoneTextBox.Size = new System.Drawing.Size(92, 20);
			this.telefoneTextBox.TabIndex = 10;
			// 
			// nomeTextBoxC
			// 
			this.nomeTextBoxC.Location = new System.Drawing.Point(72, 104);
			this.nomeTextBoxC.Name = "nomeTextBoxC";
			this.nomeTextBoxC.Size = new System.Drawing.Size(197, 20);
			this.nomeTextBoxC.TabIndex = 9;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(15, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(35, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Telefone:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 107);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Nome:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "CPF:";
			// 
			// eventosComboBox
			// 
			this.eventosComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.eventosComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.eventosComboBox.FormattingEnabled = true;
			this.eventosComboBox.Location = new System.Drawing.Point(73, 20);
			this.eventosComboBox.Name = "eventosComboBox";
			this.eventosComboBox.Size = new System.Drawing.Size(166, 21);
			this.eventosComboBox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Eventos: ";
			// 
			// buscarConvidadosButton
			// 
			this.buscarConvidadosButton.Location = new System.Drawing.Point(242, 19);
			this.buscarConvidadosButton.Name = "buscarConvidadosButton";
			this.buscarConvidadosButton.Size = new System.Drawing.Size(63, 22);
			this.buscarConvidadosButton.TabIndex = 14;
			this.buscarConvidadosButton.Text = "Buscar";
			this.buscarConvidadosButton.UseVisualStyleBackColor = true;
			this.buscarConvidadosButton.Click += new System.EventHandler(this.buscarConvidadosButton_Click);
			// 
			// convidadosDataGridView
			// 
			this.convidadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.convidadosDataGridView.Location = new System.Drawing.Point(11, 228);
			this.convidadosDataGridView.Name = "convidadosDataGridView";
			this.convidadosDataGridView.Size = new System.Drawing.Size(294, 211);
			this.convidadosDataGridView.TabIndex = 15;
			// 
			// FormCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 510);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormCadastro";
			this.Text = "Cadastro de Eventos e Convidados";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.convidadosDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button incluirEventobutton;
		private System.Windows.Forms.TextBox descTextBox;
		private System.Windows.Forms.TextBox valorTextBox;
		private System.Windows.Forms.TextBox respTextBox;
		private System.Windows.Forms.MaskedTextBox dataMaskedTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox eventosComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button incluirConvidadobutton;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox cpfTextBox;
		private System.Windows.Forms.TextBox telefoneTextBox;
		private System.Windows.Forms.TextBox nomeTextBoxC;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView convidadosDataGridView;
		private System.Windows.Forms.Button buscarConvidadosButton;
	}
}

