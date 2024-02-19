using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros.Models
{
    public class Caixa
    {
        public int desk_id { get; set; }
        public int desk_recorderid { get; set; }
        public double desk_cash { get; set; }
        public double desk_card { get; set; }
        public double desk_PIX { get; set; }
        public double desk_draft { get; set; }
        public double desk_slip { get; set; }


        public void Incluide()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("INSERT INTO Caixa (idVendaCab, dinheiro, cartao, pix, cheque, boleto) " +
                    "VALUES (@idVendaGravada, @dinheiro, @cartao, @pix, @cheque, @boleto)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@idVendaGravada", desk_recorderid);
                Banco.Comando.Parameters.AddWithValue("@dinheiro", desk_cash);
                Banco.Comando.Parameters.AddWithValue("@cartao", desk_card);
                Banco.Comando.Parameters.AddWithValue("@pix", desk_PIX);
                Banco.Comando.Parameters.AddWithValue("@cheque", desk_draft);
                Banco.Comando.Parameters.AddWithValue("@boleto", desk_slip);


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
