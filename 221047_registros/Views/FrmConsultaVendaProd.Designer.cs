namespace _221047_registros.Views
{
    partial class FrmConsultaVendaProd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaVendaProd));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_recorderProductSales = new System.Windows.Forms.DataGridView();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_productOptions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_endPeriod = new System.Windows.Forms.DateTimePicker();
            this.dtp_startPeriod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_summation = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorderProductSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 32);
            this.panel1.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONSULTA - VENDA POR PRODUTO";
            // 
            // dgv_recorderProductSales
            // 
            this.dgv_recorderProductSales.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_recorderProductSales.AllowUserToAddRows = false;
            this.dgv_recorderProductSales.AllowUserToDeleteRows = false;
            this.dgv_recorderProductSales.AllowUserToOrderColumns = true;
            this.dgv_recorderProductSales.AllowUserToResizeColumns = false;
            this.dgv_recorderProductSales.AllowUserToResizeRows = false;
            this.dgv_recorderProductSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recorderProductSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_recorderProductSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recorderProductSales.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_recorderProductSales.Location = new System.Drawing.Point(6, 156);
            this.dgv_recorderProductSales.Name = "dgv_recorderProductSales";
            this.dgv_recorderProductSales.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recorderProductSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_recorderProductSales.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_recorderProductSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recorderProductSales.Size = new System.Drawing.Size(646, 228);
            this.dgv_recorderProductSales.TabIndex = 107;
            this.dgv_recorderProductSales.TabStop = false;
            // 
            // btn_printDocument
            // 
            this.btn_printDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(156)))), ((int)(((byte)(97)))));
            this.btn_printDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_printDocument.FlatAppearance.BorderSize = 0;
            this.btn_printDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printDocument.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printDocument.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_printDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_printDocument.Location = new System.Drawing.Point(192, 401);
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.Size = new System.Drawing.Size(193, 33);
            this.btn_printDocument.TabIndex = 106;
            this.btn_printDocument.Text = "IMPRIMIR CONSULTA";
            this.btn_printDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_printDocument.UseVisualStyleBackColor = false;
            this.btn_printDocument.Click += new System.EventHandler(this.btn_printDocument_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(566, 397);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5, 1, 0, 5);
            this.btn_exit.Size = new System.Drawing.Size(136, 37);
            this.btn_exit.TabIndex = 104;
            this.btn_exit.Text = "ENCERRAR";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_productOptions);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_endPeriod);
            this.groupBox1.Controls.Add(this.dtp_startPeriod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 107);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRAZOS";
            // 
            // cmb_productOptions
            // 
            this.cmb_productOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_productOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productOptions.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmb_productOptions.FormattingEnabled = true;
            this.cmb_productOptions.IntegralHeight = false;
            this.cmb_productOptions.Items.AddRange(new object[] {
            "Á Vista",
            "Cartão - Cred/Deb",
            "PIX",
            "Cheque",
            "Boleto"});
            this.cmb_productOptions.Location = new System.Drawing.Point(97, 24);
            this.cmb_productOptions.Name = "cmb_productOptions";
            this.cmb_productOptions.Size = new System.Drawing.Size(362, 27);
            this.cmb_productOptions.TabIndex = 101;
            this.cmb_productOptions.SelectedIndexChanged += new System.EventHandler(this.cmb_productOptions_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "PRODUTO:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_endPeriod
            // 
            this.dtp_endPeriod.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtp_endPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endPeriod.Location = new System.Drawing.Point(221, 65);
            this.dtp_endPeriod.Name = "dtp_endPeriod";
            this.dtp_endPeriod.Size = new System.Drawing.Size(106, 23);
            this.dtp_endPeriod.TabIndex = 99;
            this.dtp_endPeriod.Value = new System.DateTime(2024, 1, 23, 0, 0, 0, 0);
            this.dtp_endPeriod.ValueChanged += new System.EventHandler(this.dtp_endPeriod_ValueChanged);
            // 
            // dtp_startPeriod
            // 
            this.dtp_startPeriod.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtp_startPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_startPeriod.Location = new System.Drawing.Point(90, 65);
            this.dtp_startPeriod.Name = "dtp_startPeriod";
            this.dtp_startPeriod.Size = new System.Drawing.Size(106, 23);
            this.dtp_startPeriod.TabIndex = 98;
            this.dtp_startPeriod.Value = new System.DateTime(2024, 1, 23, 0, 0, 0, 0);
            this.dtp_startPeriod.ValueChanged += new System.EventHandler(this.dtp_startPeriod_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 93;
            this.label1.Text = "À:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "PERÍODO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "VENDAS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_summation
            // 
            this.lbl_summation.AutoSize = true;
            this.lbl_summation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_summation.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_summation.ForeColor = System.Drawing.Color.CadetBlue;
            this.lbl_summation.Location = new System.Drawing.Point(76, 397);
            this.lbl_summation.Name = "lbl_summation";
            this.lbl_summation.Size = new System.Drawing.Size(50, 42);
            this.lbl_summation.TabIndex = 109;
            this.lbl_summation.Text = "00";
            this.lbl_summation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "relatorio_produtos";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmConsultaVendaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 447);
            this.Controls.Add(this.lbl_summation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_recorderProductSales);
            this.Controls.Add(this.btn_printDocument);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaVendaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaVendaProd";
            this.Load += new System.EventHandler(this.FrmConsultaVendaProd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorderProductSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgv_recorderProductSales;
        private System.Windows.Forms.Button btn_printDocument;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_endPeriod;
        private System.Windows.Forms.DateTimePicker dtp_startPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_productOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_summation;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}