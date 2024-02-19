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
    public partial class FrmMarcas : Form
    {
        public Marca label_reference;
        public int max = 0;
        public FrmMarcas()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            txt_labelname.Clear();
            txt_filter.Clear();

            btn_edit.Enabled = false;
            btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#425f87");

            btn_remove.Enabled = false;
            btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#802436");

            btn_add.Enabled = true;
            btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");


            lbl_id.Text = max.ToString();

            lbl_id.ForeColor = System.Drawing.ColorTranslator.FromHtml("#20bd86");

            dgv_brands.ClearSelection();
            txt_labelname.Focus();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_labelname.Text != String.Empty || txt_labelname.Text != " ")
            {

                Marca label = new Marca()
                {
                    label_id = int.Parse(lbl_id.Text),
                    label_name = txt_labelname.Text,
                };

                label.Incluide();

                max++;
                load_grid("");
                clearAll();

            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao adicionar a marca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_labelname.Text != String.Empty && txt_labelname.Text != " ")
            {
                Marca label = new Marca()
                {
                    label_id = int.Parse(lbl_id.Text),
                    label_name = txt_labelname.Text,
                };

                label.Edit();


                load_grid("");
                clearAll();
            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao salvar alterações"+txt_labelname.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearAll();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            load_grid("");
            clearAll();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            //CHAMADA DE UMA MESSAGE BOX PARA CONFIRMAÇÃO E VALIDAÇÃO DA RESPOSTA
            if (MessageBox.Show("Deseja excluir a marca " + txt_labelname.Text + " do registro?", "CONFIRMAÇÃO",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Marca label = new Marca()
                {
                    label_id = int.Parse(lbl_id.Text),
                };

                label.Remove();



                load_grid("");

                if (dgv_brands.RowCount > 0)
                {
                    max = (dgv_brands.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
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
            label_reference = new Marca()
            {
                label_name = search
            };
            dgv_brands.DataSource = label_reference.OpenQuery();

        }

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            load_grid("");


            if (dgv_brands.RowCount > 0)
            {
                max = (dgv_brands.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
            }
            else
            {
                max = 1;
            }

            clearAll();
        }

        public void section()
        {
            if (dgv_brands.RowCount > 0)
            {
                lbl_id.ForeColor = Color.Teal;
                lbl_id.Text = dgv_brands.CurrentRow.Cells["id"].Value.ToString();
                txt_labelname.Text = dgv_brands.CurrentRow.Cells["marca"].Value.ToString();



                btn_edit.Enabled = true;
                btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#149cdb");
                btn_remove.Enabled = true;
                btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#c20632");

                btn_add.Enabled = false;
                btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");
            }
            }

        private void dgv_brands_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            section();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_grid(txt_filter.Text);

            if (dgv_brands.RowCount != 0)
            {
                dgv_brands.Rows[0].Selected = true;
                section();
            }
            else
            {
                MessageBox.Show("Não foram encontrados resultados para: " + txt_filter.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grid("");
                
            }
        }
    }
}
