namespace _221047_registros.Views
{
    partial class FrmConsultaVendaCat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaVendaCat));
            this.crt_sales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_endPeriod = new System.Windows.Forms.DateTimePicker();
            this.dtp_startPeriod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_changegraphic = new System.Windows.Forms.Button();
            this.btn_printDocument = new System.Windows.Forms.Button();
            this.dgv_recorderSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.crt_sales)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorderSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crt_sales
            // 
            this.crt_sales.BackColor = System.Drawing.SystemColors.Control;
            this.crt_sales.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.Name = "ChartArea1";
            this.crt_sales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crt_sales.Legends.Add(legend1);
            this.crt_sales.Location = new System.Drawing.Point(407, 55);
            this.crt_sales.Name = "crt_sales";
            this.crt_sales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.crt_sales.Size = new System.Drawing.Size(509, 310);
            this.crt_sales.TabIndex = 0;
            this.crt_sales.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_endPeriod);
            this.groupBox1.Controls.Add(this.dtp_startPeriod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(6, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRAZOS";
            // 
            // dtp_endPeriod
            // 
            this.dtp_endPeriod.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.dtp_endPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_endPeriod.Location = new System.Drawing.Point(221, 22);
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
            this.dtp_startPeriod.Location = new System.Drawing.Point(90, 22);
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
            this.label1.Location = new System.Drawing.Point(198, 24);
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
            this.label8.Location = new System.Drawing.Point(9, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 91;
            this.label8.Text = "PERÍODO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btn_exit.Location = new System.Drawing.Point(780, 371);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(5, 1, 0, 5);
            this.btn_exit.Size = new System.Drawing.Size(136, 37);
            this.btn_exit.TabIndex = 97;
            this.btn_exit.Text = "ENCERRAR";
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_changegraphic
            // 
            this.btn_changegraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(72)))), ((int)(((byte)(138)))));
            this.btn_changegraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_changegraphic.FlatAppearance.BorderSize = 0;
            this.btn_changegraphic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changegraphic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changegraphic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_changegraphic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changegraphic.Location = new System.Drawing.Point(6, 375);
            this.btn_changegraphic.Name = "btn_changegraphic";
            this.btn_changegraphic.Size = new System.Drawing.Size(193, 33);
            this.btn_changegraphic.TabIndex = 98;
            this.btn_changegraphic.Text = "ALTERAR GRÁFICO";
            this.btn_changegraphic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changegraphic.UseVisualStyleBackColor = false;
            this.btn_changegraphic.Click += new System.EventHandler(this.btn_changegraphic_Click);
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
            this.btn_printDocument.Location = new System.Drawing.Point(208, 375);
            this.btn_printDocument.Name = "btn_printDocument";
            this.btn_printDocument.Size = new System.Drawing.Size(193, 33);
            this.btn_printDocument.TabIndex = 99;
            this.btn_printDocument.Text = "IMPRIMIR CONSULTA";
            this.btn_printDocument.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_printDocument.UseVisualStyleBackColor = false;
            this.btn_printDocument.Click += new System.EventHandler(this.btn_printDocument_Click);
            // 
            // dgv_recorderSales
            // 
            this.dgv_recorderSales.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_recorderSales.AllowUserToAddRows = false;
            this.dgv_recorderSales.AllowUserToDeleteRows = false;
            this.dgv_recorderSales.AllowUserToOrderColumns = true;
            this.dgv_recorderSales.AllowUserToResizeColumns = false;
            this.dgv_recorderSales.AllowUserToResizeRows = false;
            this.dgv_recorderSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recorderSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_recorderSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_recorderSales.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_recorderSales.Location = new System.Drawing.Point(6, 108);
            this.dgv_recorderSales.Name = "dgv_recorderSales";
            this.dgv_recorderSales.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_recorderSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_recorderSales.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(97)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_recorderSales.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_recorderSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_recorderSales.Size = new System.Drawing.Size(395, 261);
            this.dgv_recorderSales.TabIndex = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(105)))), ((int)(((byte)(163)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 32);
            this.panel1.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONSULTA - VENDA POR CATEGORIA";
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "relatorio_categorias";
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
            // FrmConsultaVendaCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_recorderSales);
            this.Controls.Add(this.btn_printDocument);
            this.Controls.Add(this.btn_changegraphic);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crt_sales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaVendaCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaVendaCat";
            this.Load += new System.EventHandler(this.FrmConsultaVendaCat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crt_sales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recorderSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.DateTimePicker dtp_endPeriod;
        private System.Windows.Forms.DateTimePicker dtp_startPeriod;
        private System.Windows.Forms.Button btn_changegraphic;
        private System.Windows.Forms.Button btn_printDocument;
        public System.Windows.Forms.DataGridView dgv_recorderSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart crt_sales;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}