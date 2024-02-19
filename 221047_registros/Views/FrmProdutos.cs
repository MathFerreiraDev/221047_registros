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
    public partial class FrmProdutos : Form
    {
        public Marca brand_reference;
        public Categoria category_reference;
        public Produto product_reference;
        public int max = 0;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        public void clearAll()
        {


            txt_name.Clear();
            txt_filter.Clear();
            txt_inventory.Clear();
            txt_sellvalue.Clear();

            if (cmb_brands.Items.Count > 0)
                cmb_brands.SelectedIndex = -1;

            if (cmb_categories.Items.Count > 0)
                cmb_categories.SelectedIndex = -1;

            pic_product.Image = Properties.Resources.default_2;
            pic_product.ImageLocation = null;

            btn_edit.Enabled = false;
            btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#425f87");

            btn_remove.Enabled = false;
            btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#802436");

            btn_add.Enabled = true;
            btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");


            lbl_id.Text = max.ToString();

            lbl_id.ForeColor = System.Drawing.ColorTranslator.FromHtml("#20bd86");

            dgv_products.ClearSelection();
            txt_name.Select();

        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            brand_reference = new Marca();
            cmb_brands.DataSource = brand_reference.OpenQuery();
            cmb_brands.DisplayMember = "marca";
            cmb_brands.ValueMember = "id";

            category_reference = new Categoria();
            cmb_categories.DataSource = category_reference.OpenQuery();
            cmb_categories.DisplayMember = "categoria";
            cmb_categories.ValueMember = "id";

            load_grid("");


            if (dgv_products.RowCount > 0)
            {
                max = (dgv_products.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
            }
            else
            {
                max = 1;
            }

            clearAll();

            dgv_products.Columns["idCategoria"].Visible = false;
            dgv_products.Columns["idMarca"].Visible = false;
            dgv_products.Columns["foto"].Visible = false;

        }

        private void pic_product_Click(object sender, EventArgs e)
        {
            openFile.InitialDirectory = "D:/fotos/clientes/";
            openFile.FileName = "";
            dynamic dialog = openFile.ShowDialog();
            pic_product.ImageLocation = openFile.FileName;


            if (dialog == DialogResult.Cancel)
            {
                pic_product.Image = Properties.Resources.default_2;
                pic_product.ImageLocation = null;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((txt_name.Text != String.Empty || txt_name.Text != " ") &&
               (txt_inventory.Text != String.Empty || txt_inventory.Text != " ") && (txt_sellvalue.Text != String.Empty || txt_sellvalue.Text != " ") &&  
               pic_product.ImageLocation != null && cmb_brands.Text != String.Empty && cmb_categories.Text != String.Empty)
            {

                Produto product = new Produto()
                {
                    product_id = int.Parse(lbl_id.Text),
                    product_name = txt_name.Text,
                    product_categoryid = (int)cmb_categories.SelectedValue,
                    product_brandid = (int)cmb_brands.SelectedValue,
                    product_inventory = int.Parse(txt_inventory.Text),
                    product_sellvalue = double.Parse(txt_sellvalue.Text),
                    product_picture = pic_product.ImageLocation
                };

                product.Incluide();

                max++;
                load_grid("");
                clearAll();

            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao adicionar o produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ((txt_name.Text != String.Empty || txt_name.Text != " ") &&
               (txt_inventory.Text != String.Empty || txt_inventory.Text != " ") && (txt_sellvalue.Text != String.Empty || txt_sellvalue.Text != " ") &&
               pic_product.ImageLocation != null && cmb_brands.Text != String.Empty && cmb_categories.Text != String.Empty)
            {
                Produto product = new Produto()
                {
                    product_id = int.Parse(lbl_id.Text),
                    product_name = txt_name.Text,
                    product_categoryid = (int)cmb_categories.SelectedValue,
                    product_brandid = (int)cmb_brands.SelectedValue,
                    product_inventory = int.Parse(txt_inventory.Text),
                    product_sellvalue = double.Parse(txt_sellvalue.Text),
                    product_picture = pic_product.ImageLocation
                };

                product.Edit();


                load_grid("");
                clearAll();
            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao salvar alterações", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            load_grid("");
            clearAll();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o produto " + txt_name.Text + " do registro?", "CONFIRMAÇÃO",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Produto product = new Produto()
                {
                    product_id = int.Parse(lbl_id.Text)
                };

                product.Remove();



                load_grid("");

                if (dgv_products.RowCount > 0)
                {
                    max = (dgv_products.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
                }
                else
                {
                    max = 1;
                }

                clearAll();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void load_grid(string search)
        {
            product_reference = new Produto()
            {
                product_name = search
            };
            dgv_products.DataSource = product_reference.OpenQuery();

        }

        public void section()
        {
            if (dgv_products.RowCount > 0)
            {
                lbl_id.ForeColor = Color.Teal;
                lbl_id.Text = dgv_products.CurrentRow.Cells["id"].Value.ToString();
                txt_name.Text = dgv_products.CurrentRow.Cells["descricao"].Value.ToString();
                txt_inventory.Text = dgv_products.CurrentRow.Cells["estoque"].Value.ToString();
                txt_sellvalue.Text = dgv_products.CurrentRow.Cells["valorVenda"].Value.ToString();

                cmb_brands.Text = dgv_products.CurrentRow.Cells["marca"].Value.ToString();
                cmb_categories.Text = dgv_products.CurrentRow.Cells["categoria"].Value.ToString();

                pic_product.ImageLocation = dgv_products.CurrentRow.Cells["foto"].Value.ToString();

                btn_edit.Enabled = true;
                btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#149cdb");
                btn_remove.Enabled = true;
                btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#c20632");

                btn_add.Enabled = false;
                btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");
            }
        }

        private void dgv_products_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            section();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_grid(txt_filter.Text);

            if (dgv_products.RowCount != 0)
            {
                dgv_products.Rows[0].Selected = true;
                section();
            }
            else
            {
                MessageBox.Show("Não foram encontrados resultados para: " + txt_filter.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grid("");

            }
        }

        public void keys(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == ','))
            {
                if (txt_sellvalue.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_sellvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys(e);
        }

        private void txt_inventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
