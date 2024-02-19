using _221047_registros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _221047_registros.Views
{
    public partial class FrmConsultaVendaCat : Form
    {
        public Consulta query_reference;
        public int total = 0;
        public FrmConsultaVendaCat()
        {
            InitializeComponent();
        }

        public void load_grid(DateTime start_date, DateTime final_date)
        {

            query_reference = new Consulta()
            {
                query_startDate = start_date,
                query_finalDate = final_date
            };
            dgv_recorderSales.DataSource = query_reference.OpenQueryByCategory();


            crt_sales.Series.Clear();
            crt_sales.Series.Add("Categorias");

            foreach (DataGridViewRow row in dgv_recorderSales.Rows)
            {
                string categoria = Convert.ToString(row.Cells["Categoria"].Value);
                int valor = Convert.ToInt32(row.Cells["Valor"].Value);
                total += valor;
                crt_sales.Series["Categorias"].Points.AddXY(categoria, valor);
            }


        }

        private void FrmConsultaVendaCat_Load(object sender, EventArgs e)
        {
            load_grid(dtp_startPeriod.Value, dtp_endPeriod.Value);
        }

        private void btn_changegraphic_Click(object sender, EventArgs e)
        {
            foreach (Series series in crt_sales.Series)
            {

                if (series.ChartType == SeriesChartType.Column)
                    series.ChartType = SeriesChartType.Pie;
                else
                    series.ChartType = SeriesChartType.Column;
            }
        }

        private void btn_printDocument_Click(object sender, EventArgs e)
        {
            btn_printDocument.Enabled = false;
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("relatorio_categorias", 700, 700);

            printPreviewDialog1.Show();
            btn_printDocument.Enabled = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_startPeriod_ValueChanged(object sender, EventArgs e)
        {
            load_grid(dtp_startPeriod.Value, dtp_endPeriod.Value);
        }

        private void dtp_endPeriod_ValueChanged(object sender, EventArgs e)
        {
            load_grid(dtp_startPeriod.Value, dtp_endPeriod.Value);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("RELATÓRIO - VENDAS EM CATEGORIAS", new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(5, 20));
            e.Graphics.DrawLine(new Pen(Color.DarkSlateGray, 2), new Point(5, 75), new Point(695, 75));
            e.Graphics.DrawString($"TOTAL DE VENDAS: {total}  |  DE: {dtp_startPeriod.Text} À: {dtp_endPeriod.Text}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(5, 80));
            e.Graphics.DrawLine(new Pen(Color.DarkSlateGray, 2), new Point(5, 108), new Point(695, 107));

            foreach (DataGridViewRow row in dgv_recorderSales.Rows)
            {
                string category = Convert.ToString(row.Cells["Categoria"].Value);
                string value = Convert.ToString(row.Cells["Valor"].Value);

                e.Graphics.DrawString(category.ToUpper(), new Font("Arial", 12), Brushes.Black, new Point(5, 120 + (40*(row.Index+1))));
                e.Graphics.DrawString(value, new Font("Arial", 12, FontStyle.Italic), Brushes.DarkGray, new Point(550, 120 + (40 * (row.Index + 1))));
            }

            e.Graphics.DrawString($"EMITIDO EM: {DateTime.Now:dd/MM/yyyy - hh:mm:ss}", new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic), Brushes.Gray, new Point(360, 670));
        }
    }
}
