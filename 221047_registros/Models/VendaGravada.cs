using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros.Models
{
    //Venda no 
    public class VendaGravada
    {
        public int recorder_id { get; set; }
        public int recorder_clientid { get; set; }
        public DateTime recorder_date { get; set; }
        public double recorder_summation { get; set; }

        public int Incluide()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("INSERT INTO vendaCab VALUES (@id, @idCliente, @dataVenda, @total)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", recorder_id);
                Banco.Comando.Parameters.AddWithValue("@idCliente", recorder_clientid);
                Banco.Comando.Parameters.AddWithValue("@dataVenda", recorder_date);
                Banco.Comando.Parameters.AddWithValue("@total", recorder_summation);


                Banco.Comando.ExecuteNonQuery();

                Banco.CloseConnection();

                return (int)Banco.Comando.LastInsertedId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
