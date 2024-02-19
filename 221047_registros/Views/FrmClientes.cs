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
    public partial class FrmClientes : Form
    {
        public Cliente client_reference;
        public int max = 0;
        public bool block_client_condition = false;
        
        public FrmClientes()
        {
            InitializeComponent();

        }

        public void clearAll()
        {


            txt_name.Clear();
            txt_filter.Clear();
            txt_income.Clear();
            lbl_uf.Text = "XX";
            if (cmb_city.Items.Count > 0)
            {
                cmb_city.SelectedIndex = 0;
                DataRowView reg = (DataRowView)cmb_city.SelectedItem;
                lbl_uf.Text = reg["uf"].ToString();
            }
            msk_cpf.Clear();
            dtp_birthday.Value = DateTime.Now;
            pic_client.Image = Properties.Resources._default;
            pic_client.ImageLocation = null;
            img_optionblock.Image = null;

            block_client_condition = false;

            btn_edit.Enabled = false;
            btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#425f87");

            btn_remove.Enabled = false;
            btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#802436");

            btn_add.Enabled = true;
            btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");


            lbl_id.Text = max.ToString();

            lbl_id.ForeColor = System.Drawing.ColorTranslator.FromHtml("#20bd86");

            dgv_clients.ClearSelection();
            txt_name.Select();

        }


        private void img_optionblock_Click(object sender, EventArgs e)
        {
            if (block_client_condition)
            {
                
                img_optionblock.Image = null;
                block_client_condition = false;
            }
            else
            {
                
                img_optionblock.Image = Properties.Resources.check_mark;
                block_client_condition = true;
            }
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {            
            DataTable city_reference = new Cidade().OpenQuery();
            city_reference.Rows.RemoveAt(0);

            cmb_city.DataSource = city_reference;
            cmb_city.DisplayMember = "nome";
            cmb_city.ValueMember = "id";



            load_grid("");
            

            if (dgv_clients.RowCount > 0)
            {
                max = (dgv_clients.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
            }
            else
            {
                max = 1;
            }

            clearAll();

            dgv_clients.Columns["idCidade"].Visible = false;
            dgv_clients.Columns["foto"].Visible = false;


            


        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_city.Items.Count > 0)
            {
                DataRowView reg = (DataRowView)cmb_city.SelectedItem;
                lbl_uf.Text = reg["uf"].ToString();
            }


        }

        private void pic_client_Click(object sender, EventArgs e)
        {
            

            openFile.InitialDirectory = "D:/fotos/clientes/";
            openFile.FileName = "";
            dynamic dialog = openFile.ShowDialog();
            pic_client.ImageLocation = openFile.FileName;
            

            if (dialog == DialogResult.Cancel)
            {
                pic_client.Image = Properties.Resources._default;
                pic_client.ImageLocation = null;
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if ((txt_name.Text != String.Empty || txt_name.Text != " ") &&
                (msk_cpf.Text.Length == 14) && (txt_income.Text != String.Empty || txt_income.Text != " ") && pic_client.ImageLocation != null && cmb_city.Text != String.Empty)
            {

                Cliente client = new Cliente()
                {
                    client_id = int.Parse(lbl_id.Text),
                    client_name = txt_name.Text,
                    client_cityid = (int)cmb_city.SelectedValue,
                    client_birthday = dtp_birthday.Value,
                    client_income = double.Parse(txt_income.Text),
                    client_cpf = msk_cpf.Text,
                    client_picture = pic_client.ImageLocation,
                    client_block = block_client_condition
                };

                client.Incluide();

                max++;
                load_grid("");
                clearAll();

            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao adicionar o cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if ((txt_name.Text != String.Empty || txt_name.Text != " ") &&
                (msk_cpf.Text.Length == 14) && (txt_income.Text != String.Empty || txt_income.Text != " ") && pic_client.ImageLocation != null && cmb_city.Text != String.Empty)
            {
                Cliente client = new Cliente()
                {
                    client_id = int.Parse(lbl_id.Text),
                    client_name = txt_name.Text,
                    client_cityid = (int)cmb_city.SelectedValue,
                    client_birthday = dtp_birthday.Value,
                    client_income = double.Parse(txt_income.Text),
                    client_cpf = msk_cpf.Text,
                    client_picture = pic_client.ImageLocation,
                    client_block = block_client_condition
                };

                client.Edit();


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
            if (MessageBox.Show("Deseja excluir o cliente " + txt_name.Text + " do registro?", "CONFIRMAÇÃO",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente client = new Cliente()
                {
                    client_id = int.Parse(lbl_id.Text)
                };

                client.Remove();



                load_grid("");

                if (dgv_clients.RowCount > 0)
                {
                    max = (dgv_clients.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
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
            client_reference = new Cliente()
            {
                client_name = search
            };
            dgv_clients.DataSource = client_reference.OpenQuery();
            dgv_clients.Rows.RemoveAt(0);
        }

        public void section()
        {
            if (dgv_clients.RowCount > 0)
            {
                lbl_id.ForeColor = Color.Teal;
                lbl_id.Text = dgv_clients.CurrentRow.Cells["id"].Value.ToString();
                txt_name.Text = dgv_clients.CurrentRow.Cells["nome"].Value.ToString();
                cmb_city.Text = dgv_clients.CurrentRow.Cells["cidade"].Value.ToString();
                lbl_uf.Text = dgv_clients.CurrentRow.Cells["uf"].Value.ToString();
                block_client_condition = (bool)dgv_clients.CurrentRow.Cells["venda"].Value;
                msk_cpf.Text = dgv_clients.CurrentRow.Cells["cpf"].Value.ToString();
                dtp_birthday.Text = dgv_clients.CurrentRow.Cells["dataNasc"].Value.ToString();
                txt_income.Text = dgv_clients.CurrentRow.Cells["renda"].Value.ToString();
                pic_client.ImageLocation = dgv_clients.CurrentRow.Cells["foto"].Value.ToString();

                if (block_client_condition)
                {
                    block_client_condition = true;
                    img_optionblock.Image = Properties.Resources.check_mark;
                }
                else
                {
                    block_client_condition = false;
                    img_optionblock.Image = null;
                }


                btn_edit.Enabled = true;
                btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#149cdb");
                btn_remove.Enabled = true;
                btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#c20632");

                btn_add.Enabled = false;
                btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");
            }
            }

        private void dgv_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            section();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_grid(txt_filter.Text);

            if (dgv_clients.RowCount != 0)
            {
                dgv_clients.Rows[0].Selected = true;
                section();
            }
            else
            {
                MessageBox.Show("Não foram encontrados resultados para: " + txt_filter.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grid("");
                
            }
        }

        private void txt_income_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == ','))
            {
                if (txt_income.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

        }
    }
}
