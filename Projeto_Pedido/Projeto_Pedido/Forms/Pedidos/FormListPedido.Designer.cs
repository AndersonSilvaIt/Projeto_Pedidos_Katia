namespace Projeto_Pedido.Forms.Pedidos {
	partial class FormListPedido {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.btnRefresh = new FontAwesome.Sharp.IconButton();
			this.grdPedido = new System.Windows.Forms.DataGridView();
			this.btnAdd = new FontAwesome.Sharp.IconButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtHoraPedidoFim = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDataPedidoFim = new System.Windows.Forms.MaskedTextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtHoraPedidoInicio = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDataPedidoInicio = new System.Windows.Forms.MaskedTextBox();
			this.ddlCliente = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ddlTipoPagamento = new System.Windows.Forms.ComboBox();
			this.ddlStatus = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSearch = new FontAwesome.Sharp.IconButton();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ObterEstadoPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NovoEnderecoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EnderecoEntregaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EnderecoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoraPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClienteString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItensPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItensPedidoDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataToString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoPagamentoString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalBrutoToString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalDescontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalLiquidoToString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._StatusString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPedido)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(299, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 19);
			this.label5.TabIndex = 11;
			this.label5.Text = "Listagem";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnPrint);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btnRefresh);
			this.groupBox2.Controls.Add(this.grdPedido);
			this.groupBox2.Controls.Add(this.btnAdd);
			this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(14, 230);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(885, 296);
			this.groupBox2.TabIndex = 90;
			this.groupBox2.TabStop = false;
			// 
			// btnPrint
			// 
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
			this.btnPrint.IconColor = System.Drawing.Color.LightGray;
			this.btnPrint.IconSize = 20;
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPrint.Location = new System.Drawing.Point(774, 14);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Rotation = 0D;
			this.btnPrint.Size = new System.Drawing.Size(35, 29);
			this.btnPrint.TabIndex = 11;
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Visible = false;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
			this.btnRefresh.IconColor = System.Drawing.Color.Blue;
			this.btnRefresh.IconSize = 20;
			this.btnRefresh.Location = new System.Drawing.Point(826, 14);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Rotation = 0D;
			this.btnRefresh.Size = new System.Drawing.Size(35, 29);
			this.btnRefresh.TabIndex = 12;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// grdPedido
			// 
			this.grdPedido.AllowUserToAddRows = false;
			this.grdPedido.AllowUserToDeleteRows = false;
			this.grdPedido.AllowUserToResizeColumns = false;
			this.grdPedido.AllowUserToResizeRows = false;
			this.grdPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdPedido.BackgroundColor = System.Drawing.Color.White;
			this.grdPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ObterEstadoPedido,
            this.NovoEnderecoEntrega,
            this.EnderecoEntregaId,
            this.EnderecoEntrega,
            this.DataPedido,
            this.HoraPedido,
            this.Numero,
            this.ClienteString,
            this.ClienteId,
            this.Status,
            this.TipoPagamento,
            this.Desconto,
            this.Entrada,
            this.TotalBruto,
            this.TotalLiquido,
            this.Observacao,
            this.Cliente,
            this.ItensPedido,
            this.ItensPedidoDelete,
            this.CadasterDate,
            this.DataToString,
            this.TipoPagamentoString,
            this.TotalBrutoToString,
            this.TotalDescontos,
            this._Desconto,
            this.TotalLiquidoToString,
            this._StatusString});
			this.grdPedido.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdPedido.Location = new System.Drawing.Point(20, 49);
			this.grdPedido.MultiSelect = false;
			this.grdPedido.Name = "grdPedido";
			this.grdPedido.ReadOnly = true;
			this.grdPedido.RowHeadersVisible = false;
			this.grdPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPedido.ShowCellErrors = false;
			this.grdPedido.ShowCellToolTips = false;
			this.grdPedido.ShowEditingIcon = false;
			this.grdPedido.ShowRowErrors = false;
			this.grdPedido.Size = new System.Drawing.Size(841, 225);
			this.grdPedido.TabIndex = 100;
			this.grdPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedido_CellDoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdd.IconColor = System.Drawing.Color.Green;
			this.btnAdd.IconSize = 20;
			this.btnAdd.Location = new System.Drawing.Point(20, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Rotation = 0D;
			this.btnAdd.Size = new System.Drawing.Size(35, 29);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txtHoraPedidoFim);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtDataPedidoFim);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtHoraPedidoInicio);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtDataPedidoInicio);
			this.groupBox1.Controls.Add(this.ddlCliente);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.ddlTipoPagamento);
			this.groupBox1.Controls.Add(this.ddlStatus);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNumero);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(887, 189);
			this.groupBox1.TabIndex = 70;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(349, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 18);
			this.label11.TabIndex = 61;
			this.label11.Text = "Fim";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(48, 105);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 18);
			this.label10.TabIndex = 60;
			this.label10.Text = "Início";
			// 
			// txtHoraPedidoFim
			// 
			this.txtHoraPedidoFim.Location = new System.Drawing.Point(484, 103);
			this.txtHoraPedidoFim.Mask = "00:00";
			this.txtHoraPedidoFim.Name = "txtHoraPedidoFim";
			this.txtHoraPedidoFim.Size = new System.Drawing.Size(47, 24);
			this.txtHoraPedidoFim.TabIndex = 7;
			this.txtHoraPedidoFim.ValidatingType = typeof(System.DateTime);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(381, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 18);
			this.label7.TabIndex = 56;
			this.label7.Text = "Data";
			// 
			// txtDataPedidoFim
			// 
			this.txtDataPedidoFim.Location = new System.Drawing.Point(384, 103);
			this.txtDataPedidoFim.Mask = "00/00/0000";
			this.txtDataPedidoFim.Name = "txtDataPedidoFim";
			this.txtDataPedidoFim.Size = new System.Drawing.Size(94, 24);
			this.txtDataPedidoFim.TabIndex = 6;
			this.txtDataPedidoFim.ValidatingType = typeof(System.DateTime);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(480, 82);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 18);
			this.label9.TabIndex = 57;
			this.label9.Text = "Hora";
			// 
			// txtHoraPedidoInicio
			// 
			this.txtHoraPedidoInicio.Location = new System.Drawing.Point(198, 103);
			this.txtHoraPedidoInicio.Mask = "00:00";
			this.txtHoraPedidoInicio.Name = "txtHoraPedidoInicio";
			this.txtHoraPedidoInicio.Size = new System.Drawing.Size(47, 24);
			this.txtHoraPedidoInicio.TabIndex = 5;
			this.txtHoraPedidoInicio.ValidatingType = typeof(System.DateTime);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(95, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 18);
			this.label3.TabIndex = 48;
			this.label3.Text = "Data";
			// 
			// txtDataPedidoInicio
			// 
			this.txtDataPedidoInicio.Location = new System.Drawing.Point(98, 103);
			this.txtDataPedidoInicio.Mask = "00/00/0000";
			this.txtDataPedidoInicio.Name = "txtDataPedidoInicio";
			this.txtDataPedidoInicio.Size = new System.Drawing.Size(94, 24);
			this.txtDataPedidoInicio.TabIndex = 4;
			this.txtDataPedidoInicio.ValidatingType = typeof(System.DateTime);
			// 
			// ddlCliente
			// 
			this.ddlCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlCliente.FormattingEnabled = true;
			this.ddlCliente.Location = new System.Drawing.Point(339, 31);
			this.ddlCliente.Name = "ddlCliente";
			this.ddlCliente.Size = new System.Drawing.Size(216, 25);
			this.ddlCliente.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(195, 84);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 18);
			this.label6.TabIndex = 50;
			this.label6.Text = "Hora";
			// 
			// ddlTipoPagamento
			// 
			this.ddlTipoPagamento.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlTipoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlTipoPagamento.FormattingEnabled = true;
			this.ddlTipoPagamento.Location = new System.Drawing.Point(702, 105);
			this.ddlTipoPagamento.Name = "ddlTipoPagamento";
			this.ddlTipoPagamento.Size = new System.Drawing.Size(109, 25);
			this.ddlTipoPagamento.TabIndex = 8;
			// 
			// ddlStatus
			// 
			this.ddlStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ddlStatus.FormattingEnabled = true;
			this.ddlStatus.ItemHeight = 17;
			this.ddlStatus.Location = new System.Drawing.Point(702, 33);
			this.ddlStatus.Name = "ddlStatus";
			this.ddlStatus.Size = new System.Drawing.Size(109, 25);
			this.ddlStatus.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(649, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 18);
			this.label8.TabIndex = 40;
			this.label8.Text = "Status";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(594, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 18);
			this.label4.TabIndex = 12;
			this.label4.Text = "Tipo Pagamento";
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.btnSearch.IconColor = System.Drawing.Color.White;
			this.btnSearch.IconSize = 20;
			this.btnSearch.Location = new System.Drawing.Point(98, 146);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Rotation = 0D;
			this.btnSearch.Size = new System.Drawing.Size(83, 29);
			this.btnSearch.TabIndex = 9;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(288, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 18);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cliente";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(106, 33);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(94, 26);
			this.txtNumero.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Número";
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.ReadOnly = true;
			this.Id.Visible = false;
			// 
			// ObterEstadoPedido
			// 
			this.ObterEstadoPedido.DataPropertyName = "ObterEstadoPedido";
			this.ObterEstadoPedido.HeaderText = "ObterEstadoPedido";
			this.ObterEstadoPedido.Name = "ObterEstadoPedido";
			this.ObterEstadoPedido.ReadOnly = true;
			this.ObterEstadoPedido.Visible = false;
			// 
			// NovoEnderecoEntrega
			// 
			this.NovoEnderecoEntrega.DataPropertyName = "NovoEnderecoEntrega";
			this.NovoEnderecoEntrega.HeaderText = "NovoEnderecoEntrega";
			this.NovoEnderecoEntrega.Name = "NovoEnderecoEntrega";
			this.NovoEnderecoEntrega.ReadOnly = true;
			this.NovoEnderecoEntrega.Visible = false;
			// 
			// EnderecoEntregaId
			// 
			this.EnderecoEntregaId.DataPropertyName = "EnderecoEntregaId";
			this.EnderecoEntregaId.HeaderText = "EnderecoEntregaId";
			this.EnderecoEntregaId.Name = "EnderecoEntregaId";
			this.EnderecoEntregaId.ReadOnly = true;
			this.EnderecoEntregaId.Visible = false;
			// 
			// EnderecoEntrega
			// 
			this.EnderecoEntrega.DataPropertyName = "EnderecoEntrega";
			this.EnderecoEntrega.HeaderText = "EnderecoEntrega";
			this.EnderecoEntrega.Name = "EnderecoEntrega";
			this.EnderecoEntrega.ReadOnly = true;
			this.EnderecoEntrega.Visible = false;
			// 
			// DataPedido
			// 
			this.DataPedido.DataPropertyName = "DataPedido";
			this.DataPedido.FillWeight = 120F;
			this.DataPedido.HeaderText = "DataPedido";
			this.DataPedido.Name = "DataPedido";
			this.DataPedido.ReadOnly = true;
			this.DataPedido.Visible = false;
			// 
			// HoraPedido
			// 
			this.HoraPedido.DataPropertyName = "HoraPedido";
			this.HoraPedido.HeaderText = "HoraPedido";
			this.HoraPedido.Name = "HoraPedido";
			this.HoraPedido.ReadOnly = true;
			this.HoraPedido.Visible = false;
			// 
			// Numero
			// 
			this.Numero.DataPropertyName = "Numero";
			this.Numero.FillWeight = 50F;
			this.Numero.HeaderText = "Núm.";
			this.Numero.Name = "Numero";
			this.Numero.ReadOnly = true;
			// 
			// ClienteString
			// 
			this.ClienteString.DataPropertyName = "ClienteString";
			this.ClienteString.FillWeight = 150F;
			this.ClienteString.HeaderText = "Cliente";
			this.ClienteString.Name = "ClienteString";
			this.ClienteString.ReadOnly = true;
			// 
			// ClienteId
			// 
			this.ClienteId.DataPropertyName = "ClienteId";
			this.ClienteId.HeaderText = "ClienteId";
			this.ClienteId.Name = "ClienteId";
			this.ClienteId.ReadOnly = true;
			this.ClienteId.Visible = false;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Visible = false;
			// 
			// TipoPagamento
			// 
			this.TipoPagamento.DataPropertyName = "TipoPagamento";
			this.TipoPagamento.HeaderText = "TipoPagamento";
			this.TipoPagamento.Name = "TipoPagamento";
			this.TipoPagamento.ReadOnly = true;
			this.TipoPagamento.Visible = false;
			// 
			// Desconto
			// 
			this.Desconto.DataPropertyName = "ValorDesconto";
			this.Desconto.HeaderText = "Desconto";
			this.Desconto.Name = "Desconto";
			this.Desconto.ReadOnly = true;
			this.Desconto.Visible = false;
			// 
			// Entrada
			// 
			this.Entrada.DataPropertyName = "Entrada";
			this.Entrada.HeaderText = "Entrada";
			this.Entrada.Name = "Entrada";
			this.Entrada.ReadOnly = true;
			this.Entrada.Visible = false;
			// 
			// TotalBruto
			// 
			this.TotalBruto.DataPropertyName = "TotalBruto";
			this.TotalBruto.HeaderText = "Total Bruto";
			this.TotalBruto.Name = "TotalBruto";
			this.TotalBruto.ReadOnly = true;
			this.TotalBruto.Visible = false;
			// 
			// TotalLiquido
			// 
			this.TotalLiquido.DataPropertyName = "TotalLiquido";
			this.TotalLiquido.HeaderText = "Total Líquido";
			this.TotalLiquido.Name = "TotalLiquido";
			this.TotalLiquido.ReadOnly = true;
			this.TotalLiquido.Visible = false;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observacao";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Visible = false;
			// 
			// Cliente
			// 
			this.Cliente.DataPropertyName = "Cliente";
			this.Cliente.HeaderText = "Cliente";
			this.Cliente.Name = "Cliente";
			this.Cliente.ReadOnly = true;
			this.Cliente.Visible = false;
			// 
			// ItensPedido
			// 
			this.ItensPedido.DataPropertyName = "ItensPedido";
			this.ItensPedido.HeaderText = "ItensPedido";
			this.ItensPedido.Name = "ItensPedido";
			this.ItensPedido.ReadOnly = true;
			this.ItensPedido.Visible = false;
			// 
			// ItensPedidoDelete
			// 
			this.ItensPedidoDelete.DataPropertyName = "ItensPedidoDelete";
			this.ItensPedidoDelete.HeaderText = "ItensPedidoDelete";
			this.ItensPedidoDelete.Name = "ItensPedidoDelete";
			this.ItensPedidoDelete.ReadOnly = true;
			this.ItensPedidoDelete.Visible = false;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.ReadOnly = true;
			this.CadasterDate.Visible = false;
			// 
			// DataToString
			// 
			this.DataToString.DataPropertyName = "DataToString";
			this.DataToString.FillWeight = 120F;
			this.DataToString.HeaderText = "Data";
			this.DataToString.Name = "DataToString";
			this.DataToString.ReadOnly = true;
			// 
			// TipoPagamentoString
			// 
			this.TipoPagamentoString.DataPropertyName = "TipoPagamentoString";
			this.TipoPagamentoString.FillWeight = 90F;
			this.TipoPagamentoString.HeaderText = "Pagamento";
			this.TipoPagamentoString.Name = "TipoPagamentoString";
			this.TipoPagamentoString.ReadOnly = true;
			// 
			// TotalBrutoToString
			// 
			this.TotalBrutoToString.DataPropertyName = "TotalBrutoToString";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.TotalBrutoToString.DefaultCellStyle = dataGridViewCellStyle1;
			this.TotalBrutoToString.FillWeight = 80F;
			this.TotalBrutoToString.HeaderText = "Bruto";
			this.TotalBrutoToString.Name = "TotalBrutoToString";
			this.TotalBrutoToString.ReadOnly = true;
			// 
			// TotalDescontos
			// 
			this.TotalDescontos.DataPropertyName = "TotalDescontos";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.TotalDescontos.DefaultCellStyle = dataGridViewCellStyle2;
			this.TotalDescontos.FillWeight = 60F;
			this.TotalDescontos.HeaderText = "Desconto";
			this.TotalDescontos.Name = "TotalDescontos";
			this.TotalDescontos.ReadOnly = true;
			// 
			// _Desconto
			// 
			this._Desconto.DataPropertyName = "Desconto";
			this._Desconto.HeaderText = "_Desconto";
			this._Desconto.Name = "_Desconto";
			this._Desconto.ReadOnly = true;
			this._Desconto.Visible = false;
			// 
			// TotalLiquidoToString
			// 
			this.TotalLiquidoToString.DataPropertyName = "TotalLiquidoToString";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.TotalLiquidoToString.DefaultCellStyle = dataGridViewCellStyle3;
			this.TotalLiquidoToString.FillWeight = 80F;
			this.TotalLiquidoToString.HeaderText = "Líquido";
			this.TotalLiquidoToString.Name = "TotalLiquidoToString";
			this.TotalLiquidoToString.ReadOnly = true;
			// 
			// _StatusString
			// 
			this._StatusString.DataPropertyName = "_StatusString";
			this._StatusString.FillWeight = 60F;
			this._StatusString.HeaderText = "Status";
			this._StatusString.Name = "_StatusString";
			this._StatusString.ReadOnly = true;
			// 
			// FormListPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(188)))), ((int)(((byte)(246)))));
			this.ClientSize = new System.Drawing.Size(916, 560);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormListPedido";
			this.Text = "Lista de Pedidos";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdPedido)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox2;
		private FontAwesome.Sharp.IconButton btnRefresh;
		private System.Windows.Forms.DataGridView grdPedido;
		private FontAwesome.Sharp.IconButton btnAdd;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox ddlStatus;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private FontAwesome.Sharp.IconButton btnSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox ddlTipoPagamento;
		private System.Windows.Forms.ComboBox ddlCliente;
		private System.Windows.Forms.MaskedTextBox txtHoraPedidoInicio;
		private System.Windows.Forms.MaskedTextBox txtDataPedidoInicio;
		private System.Windows.Forms.MaskedTextBox txtHoraPedidoFim;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtDataPedidoFim;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private FontAwesome.Sharp.IconButton btnPrint;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn ObterEstadoPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn NovoEnderecoEntrega;
		private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoEntregaId;
		private System.Windows.Forms.DataGridViewTextBoxColumn EnderecoEntrega;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoraPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClienteString;
		private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalBruto;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItensPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItensPedidoDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataToString;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagamentoString;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalBrutoToString;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalDescontos;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Desconto;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquidoToString;
		private System.Windows.Forms.DataGridViewTextBoxColumn _StatusString;
	}
}