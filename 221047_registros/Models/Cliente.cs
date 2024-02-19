using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros.Models
{
    public class Cliente
    {
        public int client_id { get; set; }
        public string client_name { get; set; }
        public int client_cityid { get; set; }
        public DateTime client_birthday { get; set; }
        public double client_income { get; set; }
        public string client_cpf { get; set; }
        public string client_picture { get; set; }
        public bool client_block { get; set; }

        public DataTable OpenQuery()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM Clientes cl INNER JOIN Cidades ci on (ci.id = cl.idCidade)" +
                    "where cl.nome like @Nome order by cl.nome", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", client_name + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTable = new DataTable();
                Banco.Adaptador.Fill(Banco.datTable);

                Banco.CloseConnection();

                return Banco.datTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        public void Incluide()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("INSERT INTO clientes VALUES (@id, @nome, @idCidade, @dataNasc, @renda, @cpf, @foto, @venda)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", client_id);
                Banco.Comando.Parameters.AddWithValue("@nome", client_name);
                Banco.Comando.Parameters.AddWithValue("@idCidade", client_cityid);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", client_birthday);
                Banco.Comando.Parameters.AddWithValue("@renda", client_income);
                Banco.Comando.Parameters.AddWithValue("@cpf", client_cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", client_picture);
                Banco.Comando.Parameters.AddWithValue("@venda", client_block);

                Banco.Comando.ExecuteNonQuery();

                Banco.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao incluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("UPDATE clientes SET nome = @nome, idCidade = @idCidade, dataNasc = @dataNasc," +
                    "renda = @renda, cpf = @cpf, foto = @foto, venda = @venda where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", client_id);
                Banco.Comando.Parameters.AddWithValue("@nome", client_name);
                Banco.Comando.Parameters.AddWithValue("@idCidade", client_cityid);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", client_birthday);
                Banco.Comando.Parameters.AddWithValue("@renda", client_income);
                Banco.Comando.Parameters.AddWithValue("@cpf", client_cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", client_picture);
                Banco.Comando.Parameters.AddWithValue("@venda", client_block);

                Banco.Comando.ExecuteNonQuery();

                Banco.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao acessar a edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Remove()
        {
            try
            {
                Banco.OpenConnection();

                Banco.Comando = new MySqlCommand("DELETE FROM clientes where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", client_id);

                Banco.Comando.ExecuteNonQuery();
                Banco.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao remover item", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
