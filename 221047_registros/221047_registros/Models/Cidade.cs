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
    public class Cidade
    {
        public int city_id { get; set; }
        public string city_name { get; set; }
        public string city_uf { get; set;}

        
        
        
        public DataTable OpenQuery()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT * FROM Cidades where nome like @Nome order by nome", Banco.Conexao);
                
                Banco.Comando.Parameters.AddWithValue("@Nome", city_name + "%");
                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTable = new DataTable();
                Banco.Adaptador.Fill(Banco.datTable);
                
                Banco.CloseConnection();

                return Banco.datTable;
            
            }catch (Exception ex)
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
                Banco.Comando = new MySqlCommand("INSERT INTO cidades VALUES (@id, @nome, @uf)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", city_id);
                Banco.Comando.Parameters.AddWithValue("@nome", city_name);
                Banco.Comando.Parameters.AddWithValue("@uf", city_uf);

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
                Banco.Comando = new MySqlCommand("UPDATE Cidades SET nome = @nome, uf = @uf WHERE id =  @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", city_id);
                Banco.Comando.Parameters.AddWithValue("@nome", city_name);
                Banco.Comando.Parameters.AddWithValue("@uf", city_uf);
               

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

                


                Banco.Comando = new MySqlCommand("DELETE FROM cidades where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", city_id);

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
