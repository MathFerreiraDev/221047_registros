using _221047_registros.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Banco.CreateData();
        }

        private void registrarCidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades newform = new FrmCidades();
            newform.Show();
        }

        private void registrarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarcas newform = new FrmMarcas();
            newform.Show();
        }

        private void registrarCAtegoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias newform = new FrmCategorias();
            newform.Show();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes newform = new FrmClientes();
            newform.Show();
        }

        private void registrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos newform = new FrmProdutos();
            newform.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas newform = new FrmVendas();
            newform.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVendaCat newform = new FrmConsultaVendaCat();
            newform.Show();
        }

        private void consultaVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVendaProd newform = new FrmConsultaVendaProd();
            newform.Show();
        }
    }
}
