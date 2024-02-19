namespace _221047_registros.Views
{
    partial class FrmVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_query = new System.Windows.Forms.GroupBox();
            this.dgv_recorder = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incluido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_selectedClient = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_uf = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_clientCpf = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_clientIncome = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grb_infoClient = new System.Windows.Forms.GroupBox();
            this.cmb_clients = new System.Windows.Forms.ComboBox();
            this.btn_addClient = new System.Windows.Forms.Button();
            this.btn_defaultClient = new System.Windows.Forms.Button();
            this.txt_clientName = new System.Windows.Forms.TextBox();
            this.btn_clientSearch = new System.Windows.Forms.Button();
            this.msk_clientBirthday = new System.Windows.Forms.MaskedTextBox();
            this.txt_clientCity = new System.Windows.Forms.TextBox();
            this.btn_confirmClient = new System.Windows.Forms.Button();
            this.img_clientBlock = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.cmb_products = new System.Windows.Forms.ComboBox();
            this.btn_productSearch = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.txt_productInventory = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pic_selectedProduct = new System.Windows.Forms.PictureBox();
            this.txt_productSellvalue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_productQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_productBrand = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_productCategory = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_summation = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_recorder = new System.Windows.Forms.Button();
            this.grb_query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectedClient)).BeginInit();
            this.grb_infoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_clientBlock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectedProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_query
            // 
            this.grb_query.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grb_query.Controls.Add(this.dgv_recorder);
            this.grb_query.Controls.Add(this.btn_removeProduct);
            this.grb_query.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.grb_query.Location = new System.Drawing.Point(13, 463);
            this.grb_query.Name = "grb_query";
            this.grb_query.Size = new System.Drawing.Size(862, 192);
            this.grb_query.TabIndex = 51;
            this.grb_query.TabStop = false;
            // 
            // dgv_recorder
            // 
            this.dgv_recorder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_recorder.AllowUserToAddRows = false;
            this.dgv_recorder.AllowUserToDeleteRows = false;
            this.dgv_recorder.AllowUserToOrderColumns = true;
            this.dgv_recorder.AllowUserToResizeColumns = false;
            this.dgv_recorder.AllowUserToResizeRows = false;
            this.dgv_recorder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recorder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_recorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_recorder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_recorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recorder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descricao,
            this.sellvalue,
            this.quantidade,
            this.incluido});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recorder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recorder.Location = new System.Drawing.Point(11, 58);
            this.dgv_recorder.Name = "dgv_recorder";
            this.dgv_recorder.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recorder.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_recorder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_recorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recorder.Size = new System.Drawing.Size(840, 121);
            this.dgv_recorder.TabIndex = 11;
            this.dgv_recorder.SelectionChanged += new System.EventHandler(this.dgv_recorder_SelectionChanged);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // sellvalue
            // 
            this.sellvalue.HeaderText = "Valor Unit.";
            this.sellvalue.Name = "sellvalue";
            this.sellvalue.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // incluido
            // 
            this.incluido.HeaderText = "Incluido";
            this.incluido.Name = "incluido";
            this.incluido.ReadOnly = true;
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(54)))));
            this.btn_removeProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeProduct.Enabled = false;
            this.btn_removeProduct.FlatAppearance.BorderSize = 0;
            this.btn_removeProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_removeProduct.Image = global::_221047_registros.Properties.Resources.delete;
            this.btn_removeProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeProduct.Location = new System.Drawing.Point(12, 15);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_removeProduct.Size = new System.Drawing.Size(244, 37);
            this.btn_removeProduct.TabIndex = 10;
            this.btn_removeProduct.Text = "REMOVER";
            this.btn_removeProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_removeProduct.UseVisualStyleBackColor = false;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 32);
            this.panel1.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO DE VENDAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.pic_selectedClient);
            this.panel2.Location = new System.Drawing.Point(670, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 160);
            this.panel2.TabIndex = 52;
            // 
            // pic_selectedClient
            // 
            this.pic_selectedClient.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_selectedClient.Image = global::_221047_registros.Properties.Resources.default_user;
            this.pic_selectedClient.Location = new System.Drawing.Point(5, 5);
            this.pic_selectedClient.Name = "pic_selectedClient";
            this.pic_selectedClient.Size = new System.Drawing.Size(150, 150);
            this.pic_selectedClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_selectedClient.TabIndex = 29;
            this.pic_selectedClient.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(527, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "BLOQUEADO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 55;
            this.label7.Text = "NOME:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "CIDADE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(223, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "UF:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_uf
            // 
            this.lbl_uf.AutoSize = true;
            this.lbl_uf.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(89)))), ((int)(((byte)(156)))));
            this.lbl_uf.Location = new System.Drawing.Point(252, 100);
            this.lbl_uf.Name = "lbl_uf";
            this.lbl_uf.Size = new System.Drawing.Size(32, 31);
            this.lbl_uf.TabIndex = 63;
            this.lbl_uf.Text = "XX";
            this.lbl_uf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 64;
            this.label9.Text = "CPF:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(271, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 65;
            this.label10.Text = "DAT. NASC:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msk_clientCpf
            // 
            this.msk_clientCpf.BackColor = System.Drawing.SystemColors.Window;
            this.msk_clientCpf.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.msk_clientCpf.Location = new System.Drawing.Point(50, 20);
            this.msk_clientCpf.Mask = "999,999,999-99";
            this.msk_clientCpf.Name = "msk_clientCpf";
            this.msk_clientCpf.Size = new System.Drawing.Size(136, 23);
            this.msk_clientCpf.TabIndex = 1;
            this.msk_clientCpf.TextChanged += new System.EventHandler(this.txt_clientCpf_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(302, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 66;
            this.label11.Text = "RENDA:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_clientIncome
            // 
            this.txt_clientIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_clientIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clientIncome.Enabled = false;
            this.txt_clientIncome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clientIncome.Location = new System.Drawing.Point(368, 106);
            this.txt_clientIncome.MaxLength = 10;
            this.txt_clientIncome.Name = "txt_clientIncome";
            this.txt_clientIncome.Size = new System.Drawing.Size(142, 23);
            this.txt_clientIncome.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(10, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 2);
            this.panel3.TabIndex = 67;
            // 
            // grb_infoClient
            // 
            this.grb_infoClient.Controls.Add(this.cmb_clients);
            this.grb_infoClient.Controls.Add(this.btn_addClient);
            this.grb_infoClient.Controls.Add(this.btn_defaultClient);
            this.grb_infoClient.Controls.Add(this.txt_clientName);
            this.grb_infoClient.Controls.Add(this.btn_clientSearch);
            this.grb_infoClient.Controls.Add(this.msk_clientBirthday);
            this.grb_infoClient.Controls.Add(this.txt_clientCity);
            this.grb_infoClient.Controls.Add(this.btn_confirmClient);
            this.grb_infoClient.Controls.Add(this.panel3);
            this.grb_infoClient.Controls.Add(this.txt_clientIncome);
            this.grb_infoClient.Controls.Add(this.label11);
            this.grb_infoClient.Controls.Add(this.msk_clientCpf);
            this.grb_infoClient.Controls.Add(this.label10);
            this.grb_infoClient.Controls.Add(this.label9);
            this.grb_infoClient.Controls.Add(this.lbl_uf);
            this.grb_infoClient.Controls.Add(this.label4);
            this.grb_infoClient.Controls.Add(this.label3);
            this.grb_infoClient.Controls.Add(this.label7);
            this.grb_infoClient.Controls.Add(this.img_clientBlock);
            this.grb_infoClient.Controls.Add(this.label5);
            this.grb_infoClient.Controls.Add(this.panel2);
            this.grb_infoClient.Location = new System.Drawing.Point(13, 36);
            this.grb_infoClient.Name = "grb_infoClient";
            this.grb_infoClient.Size = new System.Drawing.Size(862, 200);
            this.grb_infoClient.TabIndex = 68;
            this.grb_infoClient.TabStop = false;
            // 
            // cmb_clients
            // 
            this.cmb_clients.FormattingEnabled = true;
            this.cmb_clients.Location = new System.Drawing.Point(512, 20);
            this.cmb_clients.Name = "cmb_clients";
            this.cmb_clients.Size = new System.Drawing.Size(121, 21);
            this.cmb_clients.TabIndex = 88;
            this.cmb_clients.Visible = false;
            // 
            // btn_addClient
            // 
            this.btn_addClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(97)))));
            this.btn_addClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addClient.FlatAppearance.BorderSize = 0;
            this.btn_addClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addClient.Image = global::_221047_registros.Properties.Resources.add;
            this.btn_addClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addClient.Location = new System.Drawing.Point(294, 152);
            this.btn_addClient.Name = "btn_addClient";
            this.btn_addClient.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_addClient.Size = new System.Drawing.Size(136, 37);
            this.btn_addClient.TabIndex = 5;
            this.btn_addClient.Text = "ADIC. CLI.";
            this.btn_addClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addClient.UseVisualStyleBackColor = false;
            this.btn_addClient.Click += new System.EventHandler(this.btn_addClient_Click);
            // 
            // btn_defaultClient
            // 
            this.btn_defaultClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(167)))), ((int)(((byte)(232)))));
            this.btn_defaultClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_defaultClient.FlatAppearance.BorderSize = 0;
            this.btn_defaultClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_defaultClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_defaultClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_defaultClient.Image = global::_221047_registros.Properties.Resources.edit;
            this.btn_defaultClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_defaultClient.Location = new System.Drawing.Point(152, 152);
            this.btn_defaultClient.Name = "btn_defaultClient";
            this.btn_defaultClient.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_defaultClient.Size = new System.Drawing.Size(136, 37);
            this.btn_defaultClient.TabIndex = 4;
            this.btn_defaultClient.Text = "CLI. GENER.";
            this.btn_defaultClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_defaultClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_defaultClient.UseVisualStyleBackColor = false;
            this.btn_defaultClient.Click += new System.EventHandler(this.btn_defaultClient_Click);
            // 
            // txt_clientName
            // 
            this.txt_clientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_clientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clientName.Enabled = false;
            this.txt_clientName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clientName.Location = new System.Drawing.Point(65, 59);
            this.txt_clientName.MaxLength = 10;
            this.txt_clientName.Name = "txt_clientName";
            this.txt_clientName.Size = new System.Drawing.Size(300, 23);
            this.txt_clientName.TabIndex = 84;
            // 
            // btn_clientSearch
            // 
            this.btn_clientSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_clientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clientSearch.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_clientSearch.FlatAppearance.BorderSize = 0;
            this.btn_clientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clientSearch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clientSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_clientSearch.Image = global::_221047_registros.Properties.Resources.magnifying_glass;
            this.btn_clientSearch.Location = new System.Drawing.Point(191, 20);
            this.btn_clientSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btn_clientSearch.Name = "btn_clientSearch";
            this.btn_clientSearch.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.btn_clientSearch.Size = new System.Drawing.Size(28, 24);
            this.btn_clientSearch.TabIndex = 2;
            this.btn_clientSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clientSearch.UseVisualStyleBackColor = false;
            this.btn_clientSearch.Click += new System.EventHandler(this.btn_clientSearch_Click);
            // 
            // msk_clientBirthday
            // 
            this.msk_clientBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msk_clientBirthday.Enabled = false;
            this.msk_clientBirthday.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.msk_clientBirthday.Location = new System.Drawing.Point(363, 20);
            this.msk_clientBirthday.Mask = "00/00/0000";
            this.msk_clientBirthday.Name = "msk_clientBirthday";
            this.msk_clientBirthday.Size = new System.Drawing.Size(124, 23);
            this.msk_clientBirthday.TabIndex = 81;
            this.msk_clientBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // txt_clientCity
            // 
            this.txt_clientCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_clientCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clientCity.Enabled = false;
            this.txt_clientCity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clientCity.Location = new System.Drawing.Point(78, 106);
            this.txt_clientCity.MaxLength = 40;
            this.txt_clientCity.Name = "txt_clientCity";
            this.txt_clientCity.Size = new System.Drawing.Size(141, 23);
            this.txt_clientCity.TabIndex = 80;
            // 
            // btn_confirmClient
            // 
            this.btn_confirmClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(72)))), ((int)(((byte)(138)))));
            this.btn_confirmClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmClient.FlatAppearance.BorderSize = 0;
            this.btn_confirmClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmClient.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirmClient.Image = global::_221047_registros.Properties.Resources.edit;
            this.btn_confirmClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmClient.Location = new System.Drawing.Point(10, 152);
            this.btn_confirmClient.Name = "btn_confirmClient";
            this.btn_confirmClient.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_confirmClient.Size = new System.Drawing.Size(136, 37);
            this.btn_confirmClient.TabIndex = 3;
            this.btn_confirmClient.Text = "CONFIRMAR";
            this.btn_confirmClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_confirmClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmClient.UseVisualStyleBackColor = false;
            this.btn_confirmClient.Click += new System.EventHandler(this.btn_confirmClient_Click);
            // 
            // img_clientBlock
            // 
            this.img_clientBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.img_clientBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_clientBlock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.img_clientBlock.Location = new System.Drawing.Point(498, 151);
            this.img_clientBlock.Name = "img_clientBlock";
            this.img_clientBlock.Size = new System.Drawing.Size(28, 28);
            this.img_clientBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_clientBlock.TabIndex = 54;
            this.img_clientBlock.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_productId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_productName);
            this.groupBox2.Controls.Add(this.cmb_products);
            this.groupBox2.Controls.Add(this.btn_productSearch);
            this.groupBox2.Controls.Add(this.btn_addProduct);
            this.groupBox2.Controls.Add(this.txt_productInventory);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txt_productSellvalue);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txt_productQuantity);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.txt_productBrand);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_productCategory);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 228);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // txt_productId
            // 
            this.txt_productId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productId.Location = new System.Drawing.Point(81, 24);
            this.txt_productId.MaxLength = 40;
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(56, 23);
            this.txt_productId.TabIndex = 6;
            this.txt_productId.TextChanged += new System.EventHandler(this.txt_productId_TextChanged);
            this.txt_productId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productId_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "CÓDIGO:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_productName
            // 
            this.txt_productName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productName.Enabled = false;
            this.txt_productName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productName.Location = new System.Drawing.Point(294, 24);
            this.txt_productName.MaxLength = 40;
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(181, 23);
            this.txt_productName.TabIndex = 90;
            // 
            // cmb_products
            // 
            this.cmb_products.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.cmb_products.FormattingEnabled = true;
            this.cmb_products.Location = new System.Drawing.Point(480, 153);
            this.cmb_products.Name = "cmb_products";
            this.cmb_products.Size = new System.Drawing.Size(121, 23);
            this.cmb_products.TabIndex = 89;
            this.cmb_products.Visible = false;
            // 
            // btn_productSearch
            // 
            this.btn_productSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_productSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productSearch.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btn_productSearch.FlatAppearance.BorderSize = 0;
            this.btn_productSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productSearch.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_productSearch.Image = global::_221047_registros.Properties.Resources.magnifying_glass;
            this.btn_productSearch.Location = new System.Drawing.Point(142, 24);
            this.btn_productSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btn_productSearch.Name = "btn_productSearch";
            this.btn_productSearch.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.btn_productSearch.Size = new System.Drawing.Size(28, 24);
            this.btn_productSearch.TabIndex = 7;
            this.btn_productSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_productSearch.UseVisualStyleBackColor = false;
            this.btn_productSearch.Click += new System.EventHandler(this.btn_productSearch_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(97)))));
            this.btn_addProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addProduct.FlatAppearance.BorderSize = 0;
            this.btn_addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addProduct.Image = global::_221047_registros.Properties.Resources.add;
            this.btn_addProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addProduct.Location = new System.Drawing.Point(10, 180);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_addProduct.Size = new System.Drawing.Size(246, 37);
            this.btn_addProduct.TabIndex = 9;
            this.btn_addProduct.Text = "INCLUIR";
            this.btn_addProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addProduct.UseVisualStyleBackColor = false;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // txt_productInventory
            // 
            this.txt_productInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_productInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productInventory.Enabled = false;
            this.txt_productInventory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productInventory.Location = new System.Drawing.Point(693, 22);
            this.txt_productInventory.MaxLength = 40;
            this.txt_productInventory.Name = "txt_productInventory";
            this.txt_productInventory.Size = new System.Drawing.Size(137, 23);
            this.txt_productInventory.TabIndex = 79;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(606, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 19);
            this.label16.TabIndex = 78;
            this.label16.Text = "ESTOQUE:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.pic_selectedProduct);
            this.panel5.Location = new System.Drawing.Point(622, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 160);
            this.panel5.TabIndex = 53;
            // 
            // pic_selectedProduct
            // 
            this.pic_selectedProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic_selectedProduct.Image = global::_221047_registros.Properties.Resources.default_prod;
            this.pic_selectedProduct.Location = new System.Drawing.Point(5, 5);
            this.pic_selectedProduct.Name = "pic_selectedProduct";
            this.pic_selectedProduct.Size = new System.Drawing.Size(200, 150);
            this.pic_selectedProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_selectedProduct.TabIndex = 29;
            this.pic_selectedProduct.TabStop = false;
            // 
            // txt_productSellvalue
            // 
            this.txt_productSellvalue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_productSellvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productSellvalue.Enabled = false;
            this.txt_productSellvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productSellvalue.Location = new System.Drawing.Point(370, 114);
            this.txt_productSellvalue.MaxLength = 40;
            this.txt_productSellvalue.Name = "txt_productSellvalue";
            this.txt_productSellvalue.Size = new System.Drawing.Size(105, 23);
            this.txt_productSellvalue.TabIndex = 77;
            this.txt_productSellvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productSellvalue_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(263, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 19);
            this.label15.TabIndex = 76;
            this.label15.Text = "VALOR UNIT.:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_productQuantity
            // 
            this.txt_productQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productQuantity.Location = new System.Drawing.Point(124, 114);
            this.txt_productQuantity.MaxLength = 40;
            this.txt_productQuantity.Name = "txt_productQuantity";
            this.txt_productQuantity.Size = new System.Drawing.Size(132, 23);
            this.txt_productQuantity.TabIndex = 8;
            this.txt_productQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_productQuantity_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(8, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 19);
            this.label14.TabIndex = 74;
            this.label14.Text = "QUANTIDADE:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(12, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(488, 2);
            this.panel4.TabIndex = 68;
            // 
            // txt_productBrand
            // 
            this.txt_productBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_productBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productBrand.Enabled = false;
            this.txt_productBrand.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productBrand.Location = new System.Drawing.Point(325, 62);
            this.txt_productBrand.MaxLength = 40;
            this.txt_productBrand.Name = "txt_productBrand";
            this.txt_productBrand.Size = new System.Drawing.Size(149, 23);
            this.txt_productBrand.TabIndex = 73;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(258, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 72;
            this.label13.Text = "MARCA:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_productCategory
            // 
            this.txt_productCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_productCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_productCategory.Enabled = false;
            this.txt_productCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productCategory.Location = new System.Drawing.Point(107, 61);
            this.txt_productCategory.MaxLength = 40;
            this.txt_productCategory.Name = "txt_productCategory";
            this.txt_productCategory.Size = new System.Drawing.Size(149, 23);
            this.txt_productCategory.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(7, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 19);
            this.label12.TabIndex = 70;
            this.label12.Text = "CATEGORIA:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(206, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 68;
            this.label8.Text = "PRODUTO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(15, 673);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 19);
            this.label17.TabIndex = 80;
            this.label17.Text = "TOTAL:";
            // 
            // lbl_summation
            // 
            this.lbl_summation.AutoSize = true;
            this.lbl_summation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_summation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(78)))), ((int)(((byte)(125)))));
            this.lbl_summation.Location = new System.Drawing.Point(73, 658);
            this.lbl_summation.Name = "lbl_summation";
            this.lbl_summation.Size = new System.Drawing.Size(110, 42);
            this.lbl_summation.TabIndex = 81;
            this.lbl_summation.Text = "R$ 0,00";
            this.lbl_summation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Image = global::_221047_registros.Properties.Resources.botao;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.Location = new System.Drawing.Point(739, 661);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5, 1, 0, 5);
            this.btn_exit.Size = new System.Drawing.Size(136, 37);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "ENCERRAR";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(168)))), ((int)(((byte)(12)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Image = global::_221047_registros.Properties.Resources.back;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(596, 661);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_cancel.Size = new System.Drawing.Size(136, 37);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "CANCELAR";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_recorder
            // 
            this.btn_recorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(97)))));
            this.btn_recorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_recorder.FlatAppearance.BorderSize = 0;
            this.btn_recorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recorder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recorder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_recorder.Image = global::_221047_registros.Properties.Resources.carrinho;
            this.btn_recorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_recorder.Location = new System.Drawing.Point(453, 661);
            this.btn_recorder.Name = "btn_recorder";
            this.btn_recorder.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_recorder.Size = new System.Drawing.Size(136, 37);
            this.btn_recorder.TabIndex = 12;
            this.btn_recorder.Text = "FINALIZAR";
            this.btn_recorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_recorder.UseVisualStyleBackColor = false;
            this.btn_recorder.Click += new System.EventHandler(this.btn_recorder_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 705);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_summation);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.grb_infoClient);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.grb_query);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_recorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.grb_query.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectedClient)).EndInit();
            this.grb_infoClient.ResumeLayout(false);
            this.grb_infoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_clientBlock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_selectedProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_clientBlock;
        private System.Windows.Forms.GroupBox grb_query;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_selectedClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_uf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox msk_clientCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_clientIncome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grb_infoClient;
        private System.Windows.Forms.Button btn_recorder;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_productBrand;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_productCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_productQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pic_selectedProduct;
        private System.Windows.Forms.TextBox txt_productSellvalue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_productInventory;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_confirmClient;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_summation;
        private System.Windows.Forms.TextBox txt_clientCity;
        private System.Windows.Forms.MaskedTextBox msk_clientBirthday;
        private System.Windows.Forms.Button btn_clientSearch;
        private System.Windows.Forms.TextBox txt_clientName;
        private System.Windows.Forms.Button btn_defaultClient;
        private System.Windows.Forms.Button btn_addClient;
        private System.Windows.Forms.ComboBox cmb_clients;
        private System.Windows.Forms.Button btn_productSearch;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.ComboBox cmb_products;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgv_recorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn incluido;
    }
}