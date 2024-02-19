using _221047_registros.Models;
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

namespace _221047_registros.Views
{
    public partial class FrmCidades : Form
    {
        public Cidade city_reference;
        public int max = 0;
        public FrmCidades()
        {
            InitializeComponent();

            cmb_uf.SelectedIndex = 0;
            
            
        }

        public void clearAll()
        {
            txt_cityname.Clear();
            txt_filter.Clear();
            cmb_uf.SelectedIndex = 0;

            btn_edit.Enabled = false;
            btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#425f87");

            btn_remove.Enabled = false;
            btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#802436");

            btn_add.Enabled = true;
            btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#0e9c61");


            lbl_id.Text = max.ToString();
            
            lbl_id.ForeColor = System.Drawing.ColorTranslator.FromHtml("#20bd86");

            dgv_cities.ClearSelection();
            txt_cityname.Focus();

            if (dgv_cities.RowCount > 0)
            {
                max = (dgv_cities.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
            }
            else
            {
                max = 1;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_cityname.Text != String.Empty || txt_cityname.Text != " ")
            {
                
                Cidade city = new Cidade()
                {
                    city_id = int.Parse(lbl_id.Text),
                    city_name = txt_cityname.Text,
                    city_uf = cmb_uf.Text
                };

                city.Incluide();

                max++;
                load_grid("");
                clearAll();

            }
            else{
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao adicionar a cidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            if (txt_cityname.Text != String.Empty && txt_cityname.Text != " ")
            {
                Cidade city = new Cidade()
                {
                    city_id = int.Parse(lbl_id.Text), //--------------------!!!!!!!!!
                    city_name = txt_cityname.Text,
                    city_uf = cmb_uf.Text
                };

                city.Edit();

                
                load_grid("");
                clearAll();
            }
            else
            {
                MessageBox.Show("Dados inválidos ou vazios", "Erro ao salvar alterações", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if(MessageBox.Show("Deseja excluir a cidade "+txt_cityname.Text+" do registro?", "CONFIRMAÇÃO", 
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cidade city = new Cidade()
                    {
                        city_id = int.Parse(lbl_id.Text),
                    };

                    city.Remove();

                    

                    load_grid("");

                if (dgv_cities.RowCount > 0)
                {
                    max = (dgv_cities.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
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
            city_reference = new Cidade()
            {
                city_name = search
            };
            dgv_cities.DataSource = city_reference.OpenQuery();
            dgv_cities.Rows.RemoveAt(0);

        }

        private void FrmCidades_Load(object sender, EventArgs e)

        {
            
            
            load_grid("");
            

            if (dgv_cities.RowCount > 0)
            {
                max = (dgv_cities.Rows.Cast<DataGridViewRow>().Max(row => Convert.ToInt32(row.Cells[0].Value)) + 1);
            }
            else
            {
                max = 1;
            }

            clearAll();


        }

        public void section()
        {
            if (dgv_cities.RowCount > 0)
            {
                lbl_id.ForeColor = Color.Teal;
                lbl_id.Text = dgv_cities.CurrentRow.Cells["id"].Value.ToString();
                txt_cityname.Text = dgv_cities.CurrentRow.Cells["nome"].Value.ToString();
                cmb_uf.Text = dgv_cities.CurrentRow.Cells["uf"].Value.ToString();


                btn_edit.Enabled = true;
                btn_edit.BackColor = System.Drawing.ColorTranslator.FromHtml("#149cdb");
                btn_remove.Enabled = true;
                btn_remove.BackColor = System.Drawing.ColorTranslator.FromHtml("#c20632");

                btn_add.Enabled = false;
                btn_add.BackColor = System.Drawing.ColorTranslator.FromHtml("#285734");
            }
            }

        private void dgv_cities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            section();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            load_grid(txt_filter.Text);

            if(dgv_cities.RowCount != 0)
            {
                dgv_cities.Rows[0].Selected = true;
                section();
            }
            else
            {
                MessageBox.Show("Não foram encontrados resultados para: "+ txt_filter.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_grid("");
                
            }
        }

       
    }
}
