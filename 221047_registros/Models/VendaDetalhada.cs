using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros.Models
{
    //Venda detalhada
    public class VendaDetalhada
    {
        public int details_id { get; set; }
        public int details_recorderid { get; set; }
        public int details_productid { get; set; }
        public int details_quantity { get; set; }
        public double details_sellvalue { get; set; }


        public void Incluide()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("INSERT INTO vendaDet VALUES (@id, @idVendaGravada, @idProduto, @qtde, @valorUnit)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", details_id);
                Banco.Comando.Parameters.AddWithValue("@idVendaGravada", details_recorderid);
                Banco.Comando.Parameters.AddWithValue("@idProduto", details_productid);
                Banco.Comando.Parameters.AddWithValue("@qtde", details_quantity);
                Banco.Comando.Parameters.AddWithValue("@valorUnit", details_sellvalue);


                Banco.Comando.ExecuteNonQuery();

                Banco.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
