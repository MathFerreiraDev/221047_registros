using _221047_registros.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _221047_registros.Views
{
    public partial class FrmVendas : Form
    {
        public Cliente client_reference;
        public Produto product_reference;
        public VendaGravada recorder_reference;
        public VendaDetalhada details_reference;
        public double total;

        public FrmVendas()
        {
            InitializeComponent();
        }

        public void clearAllClient()
        {
            cmb_products.SelectedIndex = -1;
            msk_clientCpf.Clear();
            txt_clientName.Text = String.Empty;
            msk_clientBirthday.Clear();
            txt_clientCity.Clear();
            txt_clientIncome.Clear();
            pic_selectedClient.Image = Properties.Resources.default_user;
            pic_selectedClient.ImageLocation = null;
            lbl_uf.Text = "XX"; 

            img_clientBlock.Image = null;

            btn_clientSearch.Enabled = true;
            btn_clientSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#3cb371");

            btn_confirmClient.Enabled = false;
            btn_confirmClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#22374d");

            btn_defaultClient.Enabled = true;
            btn_defaultClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#38a7e8");

            btn_addClient.Enabled = true;
            btn_addClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");

            grb_infoClient.Enabled = true;
            grb_infoClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#F0F0F0");
            
        }

        public void clearAllProduct()
        {
            cmb_products.SelectedIndex = -1;
            txt_productId.Clear();
            txt_productName.Clear();
            txt_productCategory.Clear();
            txt_productBrand.Clear();
            txt_productInventory.Clear();
            txt_productQuantity.Clear();
            txt_productSellvalue.Clear();

            txt_productId.Select();

            pic_selectedProduct.Image = Properties.Resources.default_prod;
            pic_selectedProduct.ImageLocation = null;

            btn_productSearch.Enabled = true;
            btn_productSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#3cb371");

            btn_addProduct.Enabled = false;
            btn_addProduct.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");

            dgv_recorder.ClearSelection();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            client_reference = new Cliente();
            cmb_clients.DataSource = client_reference.OpenQuery();
            cmb_clients.DisplayMember = "cpf";
            cmb_clients.ValueMember = "id";

            product_reference = new Produto();
            cmb_products.DataSource = product_reference.OpenQuery();
            cmb_products.ValueMember = "id";

            

            clearAllProduct();
            clearAllClient();
        }

        public void selectClient()
        {      
                DataRowView reg = (DataRowView)cmb_clients.SelectedItem;

                txt_clientName.Text = reg["nome"].ToString();
                msk_clientBirthday.Text = reg["datanasc"].ToString();
                txt_clientCity.Text = reg["cidade"].ToString();
                lbl_uf.Text = reg["uf"].ToString();
                pic_selectedClient.ImageLocation = reg["foto"].ToString();
                txt_clientIncome.Text = reg["renda"].ToString();

                if ((bool)reg["venda"])
                {
                    img_clientBlock.ImageLocation = "";
                    img_clientBlock.Image = Properties.Resources.check_mark;
                }
                else
                {
                    img_clientBlock.ImageLocation = null;
                    img_clientBlock.Image = null;

                    btn_confirmClient.Enabled = true;
                    btn_confirmClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#06488a");
                }

           


        }

        public void selectProduct() {
            DataRowView reg = (DataRowView)cmb_products.SelectedItem;


            txt_productName.Text = reg["descricao"].ToString();
            pic_selectedProduct.ImageLocation = reg["foto"].ToString();
            txt_productCategory.Text = reg["categoria"].ToString();
            txt_productBrand.Text = reg["marca"].ToString();
            txt_productInventory.Text = reg["estoque"].ToString();
            txt_productSellvalue.Text = reg["valorVenda"].ToString();

            btn_addProduct.Enabled = true;
            btn_addProduct.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");

            txt_productQuantity.Select();

        }


        private void btn_clientSearch_Click(object sender, EventArgs e)
        {
            int search = cmb_clients.FindStringExact(msk_clientCpf.Text);

            if (msk_clientCpf.Text == "000.000.000-00")
            {
                btn_defaultClient.PerformClick();
                return;
            }


            if (msk_clientCpf.Text == " " || msk_clientCpf.Text == String.Empty)
            {
                MessageBox.Show("A caixa de texto estava vazia, portanto, não houve nenhuma consulta!", "Nenhuma sugestão de cliente foi digitada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                msk_clientCpf.Select();
            }
            else if(search != -1)
            {             
                cmb_clients.SelectedIndex = search;
                selectClient(); 
            }
            else
            {
                MessageBox.Show($"Não foi encontrado nenhum registro do cliente de cpf: {msk_clientCpf.Text}", "Cliente não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_clientCpf.Clear();
                msk_clientCpf.Select();
            }

        }

        private void txt_clientCpf_TextChanged(object sender, EventArgs e)
        {
            if (txt_clientName.TextLength > 0)
            {
                msk_clientCpf.SelectionStart = 0;
                clearAllClient();
            }            
        }

        private void btn_defaultClient_Click(object sender, EventArgs e)
        {
            btn_defaultClient.Enabled = false;
            btn_defaultClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b5a75");

            btn_clientSearch.Enabled = false;
            btn_clientSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0700d");

            msk_clientCpf.Text = "000.000.000-00";
            cmb_clients.SelectedIndex = cmb_clients.FindStringExact(msk_clientCpf.Text);
            selectClient();
        }

        private void btn_addClient_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmClientes add_new_client = new FrmClientes();

            add_new_client.Show();
        }

        private void btn_confirmClient_Click(object sender, EventArgs e)
        {
            btn_clientSearch.Enabled = false;
            btn_clientSearch.BackColor = System.Drawing.ColorTranslator.FromHtml("#e0700d");

            btn_confirmClient.Enabled = false;
            btn_confirmClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#22374d");

            btn_defaultClient.Enabled = false;
            btn_defaultClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#2b5a75");

            btn_addClient.Enabled = false;
            btn_addClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");

            grb_infoClient.Enabled = false;
            grb_infoClient.BackColor = System.Drawing.ColorTranslator.FromHtml("#d1d1d1");

            txt_productId.Select();

        }

        

        private void btn_productSearch_Click(object sender, EventArgs e)
        {

            int search = cmb_products.FindStringExact(txt_productId.Text);

            if (txt_productId.Text == " " || txt_productId.Text == String.Empty)
            {
                MessageBox.Show("A caixa de texto estava vazia, portanto, não houve nenhuma consulta!", "Nenhuma sugestão de produto foi digitada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_productId.Select();
            }
            else if (search != -1)
            {
                cmb_products.SelectedValue = txt_productId.Text;
                selectProduct();
            }
            else
            {
                MessageBox.Show($"Não foi encontrado nenhum registro do produto de código: {txt_productId.Text}", "Produto não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_productId.Clear();
                txt_productId.Select();
            }
        }

        private void txt_productId_TextChanged(object sender, EventArgs e)
        {
            if (txt_productId.TextLength == 0)
            {
                clearAllProduct();
            }
        }

        public void keys(KeyPressEventArgs i)
        {
            if (!char.IsControl(i.KeyChar) && !char.IsDigit(i.KeyChar))
            {
                i.Handled = true;
            }
        }
        private void txt_productId_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys(e);
        }

        private void txt_productQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            keys(e);
        }

        private void txt_productSellvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == ','))
            {
                if (txt_productSellvalue.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            

            if(txt_productName.Text == String.Empty || txt_productName.Text == " " ||
               txt_productQuantity.Text == String.Empty || txt_productSellvalue.Text == String.Empty)
            {
                MessageBox.Show("Verifique os campos em vazio para registrar o produto na compra", "Um ou mais campos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_productQuantity.Select();
                return;
            }
            else if(int.Parse(txt_productQuantity.Text) > int.Parse(txt_productInventory.Text))
            {        
                MessageBox.Show($"A quantidade inserida, ultrapassa o quantidade atual em estoque do produto: {txt_productName.Text}", "Estoque não correspondente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_productQuantity.Clear();
                txt_productQuantity.Select();
                return;
            }

            
            dgv_recorder.Rows.Add(txt_productId.Text, txt_productName.Text, double.Parse(txt_productSellvalue.Text).ToString("C"), txt_productQuantity.Text, (int.Parse(txt_productQuantity.Text) * double.Parse(txt_productSellvalue.Text)).ToString("C"));

            

            total += int.Parse(txt_productQuantity.Text) * double.Parse(txt_productSellvalue.Text);

            lbl_summation.Text = total.ToString("C");

            clearAllProduct();
        }

        private void btn_removeProduct_Click(object sender, EventArgs e)
        {
            total -= int.Parse(dgv_recorder.CurrentRow.Cells[3].Value.ToString()) * double.Parse(dgv_recorder.CurrentRow.Cells[2].Value.ToString().Replace("R$", ""));
            lbl_summation.Text = total.ToString("C");

            dgv_recorder.Rows.RemoveAt(dgv_recorder.CurrentRow.Index);
            txt_productId.Select();
        }

        private void dgv_recorder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_recorder.SelectedCells.Count == 0)
            {
                btn_removeProduct.Enabled = false;
                btn_removeProduct.BackColor = System.Drawing.ColorTranslator.FromHtml("#802436");
            }
            else
            {
                btn_removeProduct.Enabled = true;
                btn_removeProduct.BackColor = System.Drawing.ColorTranslator.FromHtml("#c20632");
            }
            
        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            clearAllClient();
            clearAllProduct();

            total = 0;
            lbl_summation.Text = total.ToString("C");

            dgv_recorder.Rows.Clear();
        }

        private void btn_recorder_Click(object sender, EventArgs e)
        {
            if(grb_infoClient.Enabled == false && total > 0)
            {
                int id_mark = (int)cmb_clients.SelectedValue;



                recorder_reference = new VendaGravada()
                {
                    recorder_clientid = id_mark,
                    recorder_date = DateTime.Now,
                    recorder_summation = total
                };

                int id_sale = recorder_reference.Incluide();

                foreach(DataGridViewRow row in dgv_recorder.Rows)
                {
                    details_reference = new VendaDetalhada()
                    {
                        details_recorderid = id_sale,
                        details_productid = Convert.ToInt32(row.Cells[0].Value),
                        details_quantity = Convert.ToInt32(row.Cells[3].Value),
                        details_sellvalue = double.Parse(row.Cells[2].Value.ToString().Replace("R$ ", ""))
                    };
                    
                    details_reference.Incluide();

                    //updateInventory('-', int.Parse(row.Cells[3].Value.ToString()), int.Parse(row.Cells[0].Value.ToString()));

                    try
                    {
                        Banco.Conexao.Open();
                        Banco.Comando = new MySqlCommand($"UPDATE produtos SET estoque = estoque - @qtde where id = @id", Banco.Conexao);
                        Banco.Comando.Parameters.AddWithValue("@qtde", int.Parse(row.Cells[3].Value.ToString()));
                        Banco.Comando.Parameters.AddWithValue("@id", int.Parse(row.Cells[0].Value.ToString()));
                        Banco.Comando.ExecuteNonQuery();
                        Banco.Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro durante a atualização: {ex}", "Erro ao alterar o estoque do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                FrmCaixa newDesk = new FrmCaixa(total, id_sale, (int)cmb_clients.SelectedValue, msk_clientCpf.Text, txt_clientName.Text);

                //newDesk.ShowDialog(); - Faria aparecer a janela, inativando a atual, mas não à fechando
                newDesk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Defina e confirme um cliente, e adicione ao menos um produto!", "Atenção, vendanão confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
