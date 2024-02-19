namespace _221047_registros.Views
{
    partial class FrmCaixa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_payOptions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_saleSummation = new System.Windows.Forms.Label();
            this.grb_cashOption = new System.Windows.Forms.GroupBox();
            this.btn_confirmCash = new System.Windows.Forms.Button();
            this.lbl_changeCashValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cashPayValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_finishPay = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_clientCpf = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_clientId = new System.Windows.Forms.Label();
            this.grb_cardaccountOption = new System.Windows.Forms.GroupBox();
            this.prb_load = new System.Windows.Forms.ProgressBar();
            this.btn_confirmCardaccount = new System.Windows.Forms.Button();
            this.txt_cardaccountPayValue = new System.Windows.Forms.TextBox();
            this.btn_cardaccountRequest = new System.Windows.Forms.Button();
            this.lbl_optionmessage = new System.Windows.Forms.Label();
            this.grb_bankdraftOption = new System.Windows.Forms.GroupBox();
            this.btn_confirmBankdraft = new System.Windows.Forms.Button();
            this.txt_bankdraftPayValue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_bankslipOption = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbl_bankslipAccount = new System.Windows.Forms.Label();
            this.btn_downloadBankslip = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_remaining = new System.Windows.Forms.Label();
            this.grb_remaining = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grb_cashOption.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grb_cardaccountOption.SuspendLayout();
            this.grb_bankdraftOption.SuspendLayout();
            this.grb_bankslipOption.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grb_remaining.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 32);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CAIXA - EFETUAR PAGAMENTO DE COMPRA";
            // 
            // cmb_payOptions
            // 
            this.cmb_payOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_payOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_payOptions.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmb_payOptions.FormattingEnabled = true;
            this.cmb_payOptions.IntegralHeight = false;
            this.cmb_payOptions.Items.AddRange(new object[] {
            "Á Vista",
            "Cartão - Cred/Deb",
            "PIX",
            "Cheque",
            "Boleto"});
            this.cmb_payOptions.Location = new System.Drawing.Point(56, 133);
            this.cmb_payOptions.Name = "cmb_payOptions";
            this.cmb_payOptions.Size = new System.Drawing.Size(232, 27);
            this.cmb_payOptions.TabIndex = 8;
            this.cmb_payOptions.SelectedIndexChanged += new System.EventHandler(this.cmb_payOptions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "MEIO:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(5, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 19);
            this.label17.TabIndex = 82;
            this.label17.Text = "TOTAL:";
            // 
            // lbl_saleSummation
            // 
            this.lbl_saleSummation.AutoSize = true;
            this.lbl_saleSummation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_saleSummation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saleSummation.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_saleSummation.Location = new System.Drawing.Point(63, 80);
            this.lbl_saleSummation.Name = "lbl_saleSummation";
            this.lbl_saleSummation.Size = new System.Drawing.Size(110, 42);
            this.lbl_saleSummation.TabIndex = 83;
            this.lbl_saleSummation.Text = "R$ 0,00";
            this.lbl_saleSummation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grb_cashOption
            // 
            this.grb_cashOption.Controls.Add(this.btn_confirmCash);
            this.grb_cashOption.Controls.Add(this.lbl_changeCashValue);
            this.grb_cashOption.Controls.Add(this.label3);
            this.grb_cashOption.Controls.Add(this.txt_cashPayValue);
            this.grb_cashOption.Controls.Add(this.label2);
            this.grb_cashOption.Location = new System.Drawing.Point(12, 162);
            this.grb_cashOption.Name = "grb_cashOption";
            this.grb_cashOption.Size = new System.Drawing.Size(384, 179);
            this.grb_cashOption.TabIndex = 84;
            this.grb_cashOption.TabStop = false;
            this.grb_cashOption.Visible = false;
            // 
            // btn_confirmCash
            // 
            this.btn_confirmCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btn_confirmCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmCash.FlatAppearance.BorderSize = 0;
            this.btn_confirmCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmCash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmCash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirmCash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmCash.Location = new System.Drawing.Point(236, 39);
            this.btn_confirmCash.Name = "btn_confirmCash";
            this.btn_confirmCash.Size = new System.Drawing.Size(133, 27);
            this.btn_confirmCash.TabIndex = 97;
            this.btn_confirmCash.Text = "CONFIRMAR";
            this.btn_confirmCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmCash.UseVisualStyleBackColor = false;
            this.btn_confirmCash.Click += new System.EventHandler(this.btn_confirmCash_Click);
            // 
            // lbl_changeCashValue
            // 
            this.lbl_changeCashValue.AutoSize = true;
            this.lbl_changeCashValue.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changeCashValue.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbl_changeCashValue.Location = new System.Drawing.Point(66, 80);
            this.lbl_changeCashValue.Name = "lbl_changeCashValue";
            this.lbl_changeCashValue.Size = new System.Drawing.Size(90, 31);
            this.lbl_changeCashValue.TabIndex = 89;
            this.lbl_changeCashValue.Text = "R$ 0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "TROCO:";
            // 
            // txt_cashPayValue
            // 
            this.txt_cashPayValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cashPayValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cashPayValue.Location = new System.Drawing.Point(10, 39);
            this.txt_cashPayValue.MaxLength = 40;
            this.txt_cashPayValue.Name = "txt_cashPayValue";
            this.txt_cashPayValue.Size = new System.Drawing.Size(229, 27);
            this.txt_cashPayValue.TabIndex = 86;
            this.txt_cashPayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cashPayValue_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "FORNECIDO:";
            // 
            // btn_finishPay
            // 
            this.btn_finishPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_finishPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finishPay.Enabled = false;
            this.btn_finishPay.FlatAppearance.BorderSize = 0;
            this.btn_finishPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finishPay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finishPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_finishPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finishPay.Location = new System.Drawing.Point(193, 357);
            this.btn_finishPay.Name = "btn_finishPay";
            this.btn_finishPay.Size = new System.Drawing.Size(203, 45);
            this.btn_finishPay.TabIndex = 90;
            this.btn_finishPay.Text = "FINALIZAR PAGAMENTO";
            this.btn_finishPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_finishPay.UseVisualStyleBackColor = false;
            this.btn_finishPay.Click += new System.EventHandler(this.btn_finishPay_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 91;
            this.label6.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_clientCpf);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_clientId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(11, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 42);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            // 
            // lbl_clientCpf
            // 
            this.lbl_clientCpf.AutoSize = true;
            this.lbl_clientCpf.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientCpf.Location = new System.Drawing.Point(265, 14);
            this.lbl_clientCpf.Name = "lbl_clientCpf";
            this.lbl_clientCpf.Size = new System.Drawing.Size(112, 20);
            this.lbl_clientCpf.TabIndex = 92;
            this.lbl_clientCpf.Text = "999.999.999-99";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 93;
            this.label9.Text = "CPF:";
            // 
            // lbl_clientId
            // 
            this.lbl_clientId.AutoSize = true;
            this.lbl_clientId.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clientId.Location = new System.Drawing.Point(53, 14);
            this.lbl_clientId.Name = "lbl_clientId";
            this.lbl_clientId.Size = new System.Drawing.Size(17, 20);
            this.lbl_clientId.TabIndex = 90;
            this.lbl_clientId.Text = "0";
            // 
            // grb_cardaccountOption
            // 
            this.grb_cardaccountOption.Controls.Add(this.prb_load);
            this.grb_cardaccountOption.Controls.Add(this.btn_confirmCardaccount);
            this.grb_cardaccountOption.Controls.Add(this.txt_cardaccountPayValue);
            this.grb_cardaccountOption.Controls.Add(this.btn_cardaccountRequest);
            this.grb_cardaccountOption.Controls.Add(this.lbl_optionmessage);
            this.grb_cardaccountOption.Location = new System.Drawing.Point(12, 162);
            this.grb_cardaccountOption.Name = "grb_cardaccountOption";
            this.grb_cardaccountOption.Size = new System.Drawing.Size(384, 179);
            this.grb_cardaccountOption.TabIndex = 90;
            this.grb_cardaccountOption.TabStop = false;
            this.grb_cardaccountOption.Visible = false;
            // 
            // prb_load
            // 
            this.prb_load.Location = new System.Drawing.Point(10, 73);
            this.prb_load.Name = "prb_load";
            this.prb_load.Size = new System.Drawing.Size(358, 14);
            this.prb_load.Step = 1;
            this.prb_load.TabIndex = 96;
            this.prb_load.Visible = false;
            // 
            // btn_confirmCardaccount
            // 
            this.btn_confirmCardaccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btn_confirmCardaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmCardaccount.FlatAppearance.BorderSize = 0;
            this.btn_confirmCardaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmCardaccount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmCardaccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirmCardaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmCardaccount.Location = new System.Drawing.Point(236, 40);
            this.btn_confirmCardaccount.Name = "btn_confirmCardaccount";
            this.btn_confirmCardaccount.Size = new System.Drawing.Size(133, 27);
            this.btn_confirmCardaccount.TabIndex = 95;
            this.btn_confirmCardaccount.Text = "CONFIRMAR";
            this.btn_confirmCardaccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmCardaccount.UseVisualStyleBackColor = false;
            this.btn_confirmCardaccount.Click += new System.EventHandler(this.btn_confirmCardaccount_Click);
            // 
            // txt_cardaccountPayValue
            // 
            this.txt_cardaccountPayValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cardaccountPayValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cardaccountPayValue.Location = new System.Drawing.Point(10, 40);
            this.txt_cardaccountPayValue.MaxLength = 40;
            this.txt_cardaccountPayValue.Name = "txt_cardaccountPayValue";
            this.txt_cardaccountPayValue.Size = new System.Drawing.Size(229, 27);
            this.txt_cardaccountPayValue.TabIndex = 94;
            this.txt_cardaccountPayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cardaccountPayValue_KeyPress);
            // 
            // btn_cardaccountRequest
            // 
            this.btn_cardaccountRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(130)))), ((int)(((byte)(5)))));
            this.btn_cardaccountRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cardaccountRequest.Enabled = false;
            this.btn_cardaccountRequest.FlatAppearance.BorderSize = 0;
            this.btn_cardaccountRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cardaccountRequest.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cardaccountRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(120)))));
            this.btn_cardaccountRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cardaccountRequest.Location = new System.Drawing.Point(22, 92);
            this.btn_cardaccountRequest.Name = "btn_cardaccountRequest";
            this.btn_cardaccountRequest.Padding = new System.Windows.Forms.Padding(20, 2, 20, 0);
            this.btn_cardaccountRequest.Size = new System.Drawing.Size(339, 63);
            this.btn_cardaccountRequest.TabIndex = 87;
            this.btn_cardaccountRequest.Text = "CARTÃO REQUISITADO NA MÁQUINA";
            this.btn_cardaccountRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cardaccountRequest.UseVisualStyleBackColor = false;
            this.btn_cardaccountRequest.Visible = false;
            // 
            // lbl_optionmessage
            // 
            this.lbl_optionmessage.AutoSize = true;
            this.lbl_optionmessage.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_optionmessage.Location = new System.Drawing.Point(6, 16);
            this.lbl_optionmessage.Name = "lbl_optionmessage";
            this.lbl_optionmessage.Size = new System.Drawing.Size(212, 20);
            this.lbl_optionmessage.TabIndex = 85;
            this.lbl_optionmessage.Text = "SOLICITAÇÃO VIA MÁQUINA:";
            // 
            // grb_bankdraftOption
            // 
            this.grb_bankdraftOption.Controls.Add(this.btn_confirmBankdraft);
            this.grb_bankdraftOption.Controls.Add(this.txt_bankdraftPayValue);
            this.grb_bankdraftOption.Controls.Add(this.label15);
            this.grb_bankdraftOption.Controls.Add(this.label14);
            this.grb_bankdraftOption.Controls.Add(this.label13);
            this.grb_bankdraftOption.Controls.Add(this.label11);
            this.grb_bankdraftOption.Controls.Add(this.label10);
            this.grb_bankdraftOption.Location = new System.Drawing.Point(12, 162);
            this.grb_bankdraftOption.Name = "grb_bankdraftOption";
            this.grb_bankdraftOption.Size = new System.Drawing.Size(384, 179);
            this.grb_bankdraftOption.TabIndex = 93;
            this.grb_bankdraftOption.TabStop = false;
            this.grb_bankdraftOption.Visible = false;
            // 
            // btn_confirmBankdraft
            // 
            this.btn_confirmBankdraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btn_confirmBankdraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmBankdraft.FlatAppearance.BorderSize = 0;
            this.btn_confirmBankdraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmBankdraft.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmBankdraft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_confirmBankdraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_confirmBankdraft.Location = new System.Drawing.Point(236, 137);
            this.btn_confirmBankdraft.Name = "btn_confirmBankdraft";
            this.btn_confirmBankdraft.Size = new System.Drawing.Size(133, 27);
            this.btn_confirmBankdraft.TabIndex = 93;
            this.btn_confirmBankdraft.Text = "CONFIRMAR";
            this.btn_confirmBankdraft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_confirmBankdraft.UseVisualStyleBackColor = false;
            this.btn_confirmBankdraft.Click += new System.EventHandler(this.btn_confirmBankdraft_Click);
            // 
            // txt_bankdraftPayValue
            // 
            this.txt_bankdraftPayValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_bankdraftPayValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bankdraftPayValue.Location = new System.Drawing.Point(10, 137);
            this.txt_bankdraftPayValue.MaxLength = 40;
            this.txt_bankdraftPayValue.Name = "txt_bankdraftPayValue";
            this.txt_bankdraftPayValue.Size = new System.Drawing.Size(229, 27);
            this.txt_bankdraftPayValue.TabIndex = 90;
            this.txt_bankdraftPayValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_bankdraftPayValue_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 89;
            this.label15.Text = "FORNECIDO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.label14.Location = new System.Drawing.Point(6, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(323, 20);
            this.label14.TabIndex = 88;
            this.label14.Text = "* Cheques são geralmente sucetiveis a golpes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.label13.Location = new System.Drawing.Point(6, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(363, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "* O cartão deve possuir o selo do banco em questão";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(37)))), ((int)(((byte)(26)))));
            this.label11.Location = new System.Drawing.Point(6, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 20);
            this.label11.TabIndex = 86;
            this.label11.Text = "* Sempre verifique a veracidade do cheque";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 85;
            this.label10.Text = "SOBRE CHEQUE:";
            // 
            // grb_bankslipOption
            // 
            this.grb_bankslipOption.Controls.Add(this.groupBox6);
            this.grb_bankslipOption.Controls.Add(this.btn_downloadBankslip);
            this.grb_bankslipOption.Controls.Add(this.label20);
            this.grb_bankslipOption.Location = new System.Drawing.Point(12, 162);
            this.grb_bankslipOption.Name = "grb_bankslipOption";
            this.grb_bankslipOption.Size = new System.Drawing.Size(384, 179);
            this.grb_bankslipOption.TabIndex = 90;
            this.grb_bankslipOption.TabStop = false;
            this.grb_bankslipOption.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbl_bankslipAccount);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(19, 39);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 77);
            this.groupBox6.TabIndex = 90;
            this.groupBox6.TabStop = false;
            // 
            // lbl_bankslipAccount
            // 
            this.lbl_bankslipAccount.AutoSize = true;
            this.lbl_bankslipAccount.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bankslipAccount.Location = new System.Drawing.Point(67, 30);
            this.lbl_bankslipAccount.Name = "lbl_bankslipAccount";
            this.lbl_bankslipAccount.Size = new System.Drawing.Size(269, 25);
            this.lbl_bankslipAccount.TabIndex = 89;
            this.lbl_bankslipAccount.Text = "XXX.XXX.XXX-XX|01012004";
            // 
            // btn_downloadBankslip
            // 
            this.btn_downloadBankslip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.btn_downloadBankslip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_downloadBankslip.FlatAppearance.BorderSize = 0;
            this.btn_downloadBankslip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_downloadBankslip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadBankslip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_downloadBankslip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_downloadBankslip.Location = new System.Drawing.Point(47, 131);
            this.btn_downloadBankslip.Name = "btn_downloadBankslip";
            this.btn_downloadBankslip.Size = new System.Drawing.Size(291, 37);
            this.btn_downloadBankslip.TabIndex = 87;
            this.btn_downloadBankslip.Text = "DOWNLOAD E IMPRIMIR";
            this.btn_downloadBankslip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_downloadBankslip.UseVisualStyleBackColor = false;
            this.btn_downloadBankslip.Click += new System.EventHandler(this.btn_downloadBankslip_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 20);
            this.label20.TabIndex = 85;
            this.label20.Text = "BOLETO IMPRESSO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "FALTAM:";
            // 
            // lbl_remaining
            // 
            this.lbl_remaining.AutoSize = true;
            this.lbl_remaining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_remaining.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remaining.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_remaining.Location = new System.Drawing.Point(72, 16);
            this.lbl_remaining.Name = "lbl_remaining";
            this.lbl_remaining.Size = new System.Drawing.Size(64, 25);
            this.lbl_remaining.TabIndex = 100;
            this.lbl_remaining.Text = "R$ 0,00";
            this.lbl_remaining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grb_remaining
            // 
            this.grb_remaining.AutoSize = true;
            this.grb_remaining.Controls.Add(this.label7);
            this.grb_remaining.Controls.Add(this.lbl_remaining);
            this.grb_remaining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_remaining.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_remaining.Location = new System.Drawing.Point(12, 350);
            this.grb_remaining.Margin = new System.Windows.Forms.Padding(0);
            this.grb_remaining.Name = "grb_remaining";
            this.grb_remaining.Padding = new System.Windows.Forms.Padding(0);
            this.grb_remaining.Size = new System.Drawing.Size(152, 54);
            this.grb_remaining.TabIndex = 101;
            this.grb_remaining.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_221047_registros.Properties.Resources.fatura;
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 411);
            this.Controls.Add(this.grb_remaining);
            this.Controls.Add(this.grb_bankslipOption);
            this.Controls.Add(this.grb_bankdraftOption);
            this.Controls.Add(this.grb_cardaccountOption);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_finishPay);
            this.Controls.Add(this.grb_cashOption);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_saleSummation);
            this.Controls.Add(this.cmb_payOptions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grb_cashOption.ResumeLayout(false);
            this.grb_cashOption.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grb_cardaccountOption.ResumeLayout(false);
            this.grb_cardaccountOption.PerformLayout();
            this.grb_bankdraftOption.ResumeLayout(false);
            this.grb_bankdraftOption.PerformLayout();
            this.grb_bankslipOption.ResumeLayout(false);
            this.grb_bankslipOption.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grb_remaining.ResumeLayout(false);
            this.grb_remaining.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_payOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_saleSummation;
        private System.Windows.Forms.GroupBox grb_cashOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cashPayValue;
        private System.Windows.Forms.Label lbl_changeCashValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_finishPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_clientCpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_clientId;
        private System.Windows.Forms.GroupBox grb_cardaccountOption;
        private System.Windows.Forms.Button btn_cardaccountRequest;
        private System.Windows.Forms.Label lbl_optionmessage;
        private System.Windows.Forms.Button btn_confirmCardaccount;
        private System.Windows.Forms.TextBox txt_cardaccountPayValue;
        private System.Windows.Forms.GroupBox grb_bankdraftOption;
        private System.Windows.Forms.Button btn_confirmBankdraft;
        private System.Windows.Forms.TextBox txt_bankdraftPayValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_confirmCash;
        private System.Windows.Forms.GroupBox grb_bankslipOption;
        private System.Windows.Forms.Button btn_downloadBankslip;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_bankslipAccount;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ProgressBar prb_load;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_remaining;
        private System.Windows.Forms.GroupBox grb_remaining;
    }
}