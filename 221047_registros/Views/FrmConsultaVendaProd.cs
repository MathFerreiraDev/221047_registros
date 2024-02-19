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

namespace _221047_registros.Views
{
    public partial class FrmConsultaVendaProd : Form
    {
        public Produto product_reference;
        public Consulta query_reference;
        public int total = 0;

        public FrmConsultaVendaProd()
        {
            InitializeComponent();
        }

        public void load_grid(DateTime start_date, DateTime final_date)
        {
            if (cmb_productOptions.Items.Count > 0) {
                query_reference = new Consulta()
                {
                    query_startDate = start_date,
                    query_finalDate = final_date
                };
                dgv_recorderProductSales.DataSource = query_reference.OpenQueryByProductSales(cmb_productOptions.SelectedValue.ToString());

                total = 0;

                foreach (DataGridViewRow row in dgv_recorderProductSales.Rows)
                {
                    total += Convert.ToInt32(row.Cells[3].Value);
                }

                lbl_summation.Text = total.ToString();
            }
        }

        private void FrmConsultaVendaProd_Load(object sender, EventArgs e)
        {
            

            product_reference = new Produto();
            cmb_productOptions.DataSource = product_reference.OpenQuery();
            cmb_productOptions.DisplayMember = "descricao";
            cmb_productOptions.ValueMember = "id";

            dtp_startPeriod.Value = DateTime.Now.AddDays(-7);
            dtp_endPeriod.Value = DateTime.Now;
        }

        private void cmb_productOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_grid(dtp_startPeriod.Value, dtp_endPeriod.Value);

        }

        private void btn_printDocument_Click(object sender, EventArgs e)
        {
            btn_printDocument.Enabled = false;
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("relatorio_produtosvendidos", 700, 700);

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
            int summation_sales = 0;
            e.Graphics.DrawString("RELATÓRIO - VENDAS POR PRODUTO", new Font("Arial", 24, FontStyle.Bold | FontStyle.Italic), Brushes.Black, new Point(5, 20));
            e.Graphics.DrawLine(new Pen(Color.DarkSlateGray, 2), new Point(5, 75), new Point(695, 75));
            // e.Graphics de total, após a soma dos valores
            e.Graphics.DrawLine(new Pen(Color.DarkSlateGray, 2), new Point(5, 108), new Point(695, 107));

            DataTable reference = query_reference.OpenQueryAllSalesProducts();
            foreach (DataRow row in reference.Rows)
            {
                string product = Convert.ToString(row["Produto"]);
                string sales = Convert.ToString(row["Soma"]);

                summation_sales += int.Parse(sales);
                e.Graphics.DrawString(product.ToUpper(), new Font("Arial", 12), Brushes.Black, new Point(5, 120 + (40 * (reference.Rows.IndexOf(row) + 1))));
                e.Graphics.DrawString(sales, new Font("Arial", 12, FontStyle.Italic), Brushes.DarkGray, new Point(550, 120 + (40 * (reference.Rows.IndexOf(row) + 1))));      
            }
            e.Graphics.DrawString($"TOTAL DE VENDAS: {summation_sales}  |  DE: {dtp_startPeriod.Text} À: {dtp_endPeriod.Text}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(5, 80));

            e.Graphics.DrawString($"EMITIDO EM: {DateTime.Now:dd/MM/yyyy - hh:mm:ss}", new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic), Brushes.Gray, new Point(360, 670));
        }

        
    }
}
