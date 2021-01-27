using System;
using System.Windows.Forms;

namespace CSharpTest
{
	partial class CMarket
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAdm = new System.Windows.Forms.Label();
            this.bSair = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.carregando = new System.Windows.Forms.Label();
            this.LabelSidebar = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.numericPanelEdit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPanelEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bPanelEdit = new System.Windows.Forms.Button();
            this.numeric2PanelEdit = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.PanelDelete = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bPanelDelete = new System.Windows.Forms.Button();
            this.numericPanelDelete = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textPanelAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bPanelAdd = new System.Windows.Forms.Button();
            this.numericPanelAdd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelID = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bPanelID = new System.Windows.Forms.Button();
            this.numericPanelID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.b2PanelLogin = new System.Windows.Forms.Button();
            this.textSenhaPanelLogin = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textUsuarioPanelLogin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bPanelLogin = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.PanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PanelEdit)).BeginInit();
            this.PanelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelDelete)).BeginInit();
            this.PanelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelAdd)).BeginInit();
            this.PanelID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelID)).BeginInit();
            this.PanelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.carregando);
            this.splitContainer1.Panel1.Controls.Add(this.LabelSidebar);
            this.splitContainer1.Panel1.Controls.Add(this.b3);
            this.splitContainer1.Panel1.Controls.Add(this.b5);
            this.splitContainer1.Panel1.Controls.Add(this.b4);
            this.splitContainer1.Panel1.Controls.Add(this.b2);
            this.splitContainer1.Panel1.Controls.Add(this.b1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.PanelEdit);
            this.splitContainer1.Panel2.Controls.Add(this.PanelDelete);
            this.splitContainer1.Panel2.Controls.Add(this.PanelAdd);
            this.splitContainer1.Panel2.Controls.Add(this.PanelID);
            this.splitContainer1.Panel2.Controls.Add(this.PanelLogin);
            this.splitContainer1.Size = new System.Drawing.Size(1344, 802);
            this.splitContainer1.SplitterDistance = 448;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.labelAdm);
            this.panel1.Controls.Add(this.bSair);
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Location = new System.Drawing.Point(0, 745);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 57);
            this.panel1.TabIndex = 15;
            // 
            // labelAdm
            // 
            this.labelAdm.AutoSize = true;
            this.labelAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdm.ForeColor = System.Drawing.Color.Firebrick;
            this.labelAdm.Location = new System.Drawing.Point(136, 21);
            this.labelAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdm.Name = "labelAdm";
            this.labelAdm.Size = new System.Drawing.Size(238, 17);
            this.labelAdm.TabIndex = 15;
            this.labelAdm.Text = "Usuário NÃO ADMINISTRADOR!";
            // 
            // bSair
            // 
            this.bSair.BackColor = System.Drawing.Color.LightCoral;
            this.bSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSair.ForeColor = System.Drawing.Color.Firebrick;
            this.bSair.Location = new System.Drawing.Point(1, 2);
            this.bSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(65, 54);
            this.bSair.TabIndex = 13;
            this.bSair.Text = "🚪";
            this.bSair.UseVisualStyleBackColor = false;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bLogin.Location = new System.Drawing.Point(65, 2);
            this.bLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(64, 54);
            this.bLogin.TabIndex = 14;
            this.bLogin.Text = "👤";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(11, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 36);
            this.label16.TabIndex = 12;
            this.label16.Text = "🔍";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(13, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 36);
            this.label15.TabIndex = 11;
            this.label15.Text = "📃";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Firebrick;
            this.label14.Location = new System.Drawing.Point(13, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 36);
            this.label14.TabIndex = 10;
            this.label14.Text = "✖";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(12, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 46);
            this.label13.TabIndex = 9;
            this.label13.Text = "✎";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Green;
            this.label12.Location = new System.Drawing.Point(13, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 46);
            this.label12.TabIndex = 8;
            this.label12.Text = "✚";
            // 
            // carregando
            // 
            this.carregando.AutoSize = true;
            this.carregando.BackColor = System.Drawing.SystemColors.Desktop;
            this.carregando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carregando.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.carregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carregando.ForeColor = System.Drawing.Color.LimeGreen;
            this.carregando.Location = new System.Drawing.Point(189, 20);
            this.carregando.Name = "carregando";
            this.carregando.Size = new System.Drawing.Size(37, 22);
            this.carregando.TabIndex = 7;
            this.carregando.Text = "OK";
            // 
            // LabelSidebar
            // 
            this.LabelSidebar.AutoSize = true;
            this.LabelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LabelSidebar.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSidebar.Location = new System.Drawing.Point(13, 5);
            this.LabelSidebar.Name = "LabelSidebar";
            this.LabelSidebar.Size = new System.Drawing.Size(170, 46);
            this.LabelSidebar.TabIndex = 6;
            this.LabelSidebar.Text = "C-Market";
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b3.Enabled = false;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(3, 165);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(443, 57);
            this.b3.TabIndex = 5;
            this.b3.Text = "Adicionar Produto";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.bPanelAdd_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b5.Enabled = false;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b5.Location = new System.Drawing.Point(3, 275);
            this.b5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(443, 54);
            this.b5.TabIndex = 4;
            this.b5.Text = "Excluir Produto";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.bPanelDelete_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b4.Enabled = false;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(3, 220);
            this.b4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(443, 57);
            this.b4.TabIndex = 3;
            this.b4.Text = "Editar Produto";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.bPanelEdit_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(3, 110);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(443, 57);
            this.b2.TabIndex = 2;
            this.b2.Text = "Buscar Produto";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.bPanelID_Click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(3, 53);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(443, 58);
            this.b1.TabIndex = 1;
            this.b1.Text = "Listar Produtos";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.listar);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView.Location = new System.Drawing.Point(19, 30);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(703, 607);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // PanelEdit
            // 
            this.PanelEdit.Controls.Add(this.numericPanelEdit);
            this.PanelEdit.Controls.Add(this.label6);
            this.PanelEdit.Controls.Add(this.label7);
            this.PanelEdit.Controls.Add(this.textPanelEdit);
            this.PanelEdit.Controls.Add(this.label8);
            this.PanelEdit.Controls.Add(this.bPanelEdit);
            this.PanelEdit.Controls.Add(this.numeric2PanelEdit);
            this.PanelEdit.Controls.Add(this.label9);
            this.PanelEdit.Location = new System.Drawing.Point(729, 59);
            this.PanelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(531, 508);
            this.PanelEdit.TabIndex = 8;
            this.PanelEdit.Visible = false;
            // 
            // numericPanelEdit
            // 
            this.numericPanelEdit.Location = new System.Drawing.Point(27, 92);
            this.numericPanelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPanelEdit.Name = "numericPanelEdit";
            this.numericPanelEdit.Size = new System.Drawing.Size(184, 22);
            this.numericPanelEdit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Preço (R$):";
            // 
            // textPanelEdit
            // 
            this.textPanelEdit.Location = new System.Drawing.Point(28, 161);
            this.textPanelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPanelEdit.Name = "textPanelEdit";
            this.textPanelEdit.Size = new System.Drawing.Size(380, 22);
            this.textPanelEdit.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descrição:";
            // 
            // bPanelEdit
            // 
            this.bPanelEdit.Location = new System.Drawing.Point(28, 286);
            this.bPanelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPanelEdit.Name = "bPanelEdit";
            this.bPanelEdit.Size = new System.Drawing.Size(80, 32);
            this.bPanelEdit.TabIndex = 3;
            this.bPanelEdit.Text = "Editar";
            this.bPanelEdit.UseVisualStyleBackColor = true;
            this.bPanelEdit.Click += new System.EventHandler(this.editar);
            // 
            // numeric2PanelEdit
            // 
            this.numeric2PanelEdit.DecimalPlaces = 2;
            this.numeric2PanelEdit.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numeric2PanelEdit.Location = new System.Drawing.Point(29, 235);
            this.numeric2PanelEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numeric2PanelEdit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric2PanelEdit.Name = "numeric2PanelEdit";
            this.numeric2PanelEdit.Size = new System.Drawing.Size(187, 22);
            this.numeric2PanelEdit.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Editar Produto";
            // 
            // PanelDelete
            // 
            this.PanelDelete.Controls.Add(this.label10);
            this.PanelDelete.Controls.Add(this.bPanelDelete);
            this.PanelDelete.Controls.Add(this.numericPanelDelete);
            this.PanelDelete.Controls.Add(this.label11);
            this.PanelDelete.Location = new System.Drawing.Point(291, 674);
            this.PanelDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelDelete.Name = "PanelDelete";
            this.PanelDelete.Size = new System.Drawing.Size(257, 508);
            this.PanelDelete.TabIndex = 4;
            this.PanelDelete.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Excluir Produto";
            // 
            // bPanelDelete
            // 
            this.bPanelDelete.Location = new System.Drawing.Point(28, 132);
            this.bPanelDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPanelDelete.Name = "bPanelDelete";
            this.bPanelDelete.Size = new System.Drawing.Size(75, 32);
            this.bPanelDelete.TabIndex = 2;
            this.bPanelDelete.Text = "Excluir";
            this.bPanelDelete.UseVisualStyleBackColor = true;
            this.bPanelDelete.Click += new System.EventHandler(this.excluir);
            // 
            // numericPanelDelete
            // 
            this.numericPanelDelete.Location = new System.Drawing.Point(28, 92);
            this.numericPanelDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPanelDelete.Name = "numericPanelDelete";
            this.numericPanelDelete.Size = new System.Drawing.Size(205, 22);
            this.numericPanelDelete.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Insira o Id do Produto desejado:";
            // 
            // PanelAdd
            // 
            this.PanelAdd.Controls.Add(this.label4);
            this.PanelAdd.Controls.Add(this.textPanelAdd);
            this.PanelAdd.Controls.Add(this.label3);
            this.PanelAdd.Controls.Add(this.bPanelAdd);
            this.PanelAdd.Controls.Add(this.numericPanelAdd);
            this.PanelAdd.Controls.Add(this.label2);
            this.PanelAdd.Location = new System.Drawing.Point(17, 20);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(531, 508);
            this.PanelAdd.TabIndex = 2;
            this.PanelAdd.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Preço (R$):";
            // 
            // textPanelAdd
            // 
            this.textPanelAdd.Location = new System.Drawing.Point(27, 91);
            this.textPanelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPanelAdd.Name = "textPanelAdd";
            this.textPanelAdd.Size = new System.Drawing.Size(380, 22);
            this.textPanelAdd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // bPanelAdd
            // 
            this.bPanelAdd.Location = new System.Drawing.Point(27, 215);
            this.bPanelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPanelAdd.Name = "bPanelAdd";
            this.bPanelAdd.Size = new System.Drawing.Size(95, 32);
            this.bPanelAdd.TabIndex = 3;
            this.bPanelAdd.Text = "Adicionar";
            this.bPanelAdd.UseVisualStyleBackColor = true;
            this.bPanelAdd.Click += new System.EventHandler(this.adicionar);
            // 
            // numericPanelAdd
            // 
            this.numericPanelAdd.DecimalPlaces = 2;
            this.numericPanelAdd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPanelAdd.Location = new System.Drawing.Point(29, 165);
            this.numericPanelAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPanelAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPanelAdd.Name = "numericPanelAdd";
            this.numericPanelAdd.Size = new System.Drawing.Size(187, 22);
            this.numericPanelAdd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Novo Produto";
            // 
            // PanelID
            // 
            this.PanelID.Controls.Add(this.label5);
            this.PanelID.Controls.Add(this.bPanelID);
            this.PanelID.Controls.Add(this.numericPanelID);
            this.PanelID.Controls.Add(this.label1);
            this.PanelID.Location = new System.Drawing.Point(17, 674);
            this.PanelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelID.Name = "PanelID";
            this.PanelID.Size = new System.Drawing.Size(257, 508);
            this.PanelID.TabIndex = 1;
            this.PanelID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Buscar Produto";
            // 
            // bPanelID
            // 
            this.bPanelID.Location = new System.Drawing.Point(28, 132);
            this.bPanelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPanelID.Name = "bPanelID";
            this.bPanelID.Size = new System.Drawing.Size(75, 32);
            this.bPanelID.TabIndex = 2;
            this.bPanelID.Text = "Buscar";
            this.bPanelID.UseVisualStyleBackColor = true;
            this.bPanelID.Click += new System.EventHandler(this.buscarPorId);
            // 
            // numericPanelID
            // 
            this.numericPanelID.Location = new System.Drawing.Point(28, 92);
            this.numericPanelID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericPanelID.Name = "numericPanelID";
            this.numericPanelID.Size = new System.Drawing.Size(205, 22);
            this.numericPanelID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Id do Produto desejado:";
            // 
            // PanelLogin
            // 
            this.PanelLogin.Controls.Add(this.b2PanelLogin);
            this.PanelLogin.Controls.Add(this.textSenhaPanelLogin);
            this.PanelLogin.Controls.Add(this.label17);
            this.PanelLogin.Controls.Add(this.textUsuarioPanelLogin);
            this.PanelLogin.Controls.Add(this.label19);
            this.PanelLogin.Controls.Add(this.bPanelLogin);
            this.PanelLogin.Controls.Add(this.label20);
            this.PanelLogin.Location = new System.Drawing.Point(571, 674);
            this.PanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(375, 508);
            this.PanelLogin.TabIndex = 9;
            this.PanelLogin.Visible = false;
            // 
            // b2PanelLogin
            // 
            this.b2PanelLogin.Enabled = false;
            this.b2PanelLogin.Location = new System.Drawing.Point(161, 209);
            this.b2PanelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.b2PanelLogin.Name = "b2PanelLogin";
            this.b2PanelLogin.Size = new System.Drawing.Size(100, 32);
            this.b2PanelLogin.TabIndex = 7;
            this.b2PanelLogin.Text = "Deslogar";
            this.b2PanelLogin.UseVisualStyleBackColor = true;
            this.b2PanelLogin.Click += new System.EventHandler(this.b2PanelLogin_Click);
            // 
            // textSenhaPanelLogin
            // 
            this.textSenhaPanelLogin.Location = new System.Drawing.Point(28, 159);
            this.textSenhaPanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSenhaPanelLogin.Name = "textSenhaPanelLogin";
            this.textSenhaPanelLogin.PasswordChar = '•';
            this.textSenhaPanelLogin.Size = new System.Drawing.Size(232, 22);
            this.textSenhaPanelLogin.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Usuário:";
            // 
            // textUsuarioPanelLogin
            // 
            this.textUsuarioPanelLogin.Location = new System.Drawing.Point(28, 92);
            this.textUsuarioPanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textUsuarioPanelLogin.Name = "textUsuarioPanelLogin";
            this.textUsuarioPanelLogin.Size = new System.Drawing.Size(232, 22);
            this.textUsuarioPanelLogin.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "Senha:";
            // 
            // bPanelLogin
            // 
            this.bPanelLogin.Location = new System.Drawing.Point(28, 209);
            this.bPanelLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bPanelLogin.Name = "bPanelLogin";
            this.bPanelLogin.Size = new System.Drawing.Size(80, 32);
            this.bPanelLogin.TabIndex = 3;
            this.bPanelLogin.Text = "Logar";
            this.bPanelLogin.UseVisualStyleBackColor = true;
            this.bPanelLogin.Click += new System.EventHandler(this.logar);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Login";
            // 
            // CMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 802);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CMarket";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.PanelEdit.ResumeLayout(false);
            this.PanelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PanelEdit)).EndInit();
            this.PanelDelete.ResumeLayout(false);
            this.PanelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelDelete)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelAdd)).EndInit();
            this.PanelID.ResumeLayout(false);
            this.PanelID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPanelID)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            this.ResumeLayout(false);

		}

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }


        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LabelSidebar;
		private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.DataGridView dataGridView;
        private Label carregando;
        private Panel PanelID;
        private Button bPanelID;
        private NumericUpDown numericPanelID;
        private Label label1;
        private Panel PanelAdd;
        private Label label4;
        private TextBox textPanelAdd;
        private Label label3;
        private Button bPanelAdd;
        private NumericUpDown numericPanelAdd;
        private Label label2;
        private Panel PanelEdit;
        private NumericUpDown numericPanelEdit;
        private Label label6;
        private Label label7;
        private TextBox textPanelEdit;
        private Label label8;
        private Button bPanelEdit;
        private NumericUpDown numeric2PanelEdit;
        private Label label9;
        private Label label5;
        private Panel PanelDelete;
        private Label label10;
        private Button bPanelDelete;
        private NumericUpDown numericPanelDelete;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label15;
        private Button bLogin;
        private Button bSair;
        private Panel PanelLogin;
        private TextBox textSenhaPanelLogin;
        private Label label17;
        private TextBox textUsuarioPanelLogin;
        private Label label19;
        private Button bPanelLogin;
        private Label label20;
        private Panel panel1;
        private Label labelAdm;
        private Button b2PanelLogin;
    }
}

