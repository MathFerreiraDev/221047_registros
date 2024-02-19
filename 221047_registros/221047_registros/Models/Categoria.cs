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
    public class Categoria
    {
        public int category_id { get; set; }
        public string category_name { get; set; }
        public string category_email { get; set; }




        public DataTable OpenQuery()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT * FROM Categorias where categoria like @Categoria order by categoria", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Categoria", category_name + "%");
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
            return null;
        }

        public void Incluide()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("INSERT INTO categorias VALUES (@id, @categoria)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", category_id);
                Banco.Comando.Parameters.AddWithValue("@categoria", category_name);

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
                Banco.Comando = new MySqlCommand("UPDATE categorias SET categoria = @categoria where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", category_id);
                Banco.Comando.Parameters.AddWithValue("@categoria", category_name);


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




                Banco.Comando = new MySqlCommand("DELETE FROM categorias where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", category_id);

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
