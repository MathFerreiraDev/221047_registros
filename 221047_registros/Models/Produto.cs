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
    public class Produto
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int product_categoryid { get; set; }
        public int product_brandid { get; set; }
        public int product_inventory { get; set; }
        public double product_sellvalue { get; set; }
        public string product_picture { get; set; }

        public DataTable OpenQuery()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT p.*, m.marca, c.categoria FROM Produtos p INNER JOIN Marcas m on (m.id = p.idMarca) " +
                    "INNER JOIN Categorias c on (c.id = p.idCategoria) " +
                    "where p.descricao like @Descricao order by p.descricao", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Descricao", product_name + "%");
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
                Banco.Comando = new MySqlCommand("INSERT INTO produtos VALUES (@id, @produto, @idCategoria, @idMarca, @estoque, @valor, @foto)", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", product_id);
                Banco.Comando.Parameters.AddWithValue("@produto", product_name);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", product_categoryid);
                Banco.Comando.Parameters.AddWithValue("@idMarca", product_brandid);
                Banco.Comando.Parameters.AddWithValue("@estoque", product_inventory);
                Banco.Comando.Parameters.AddWithValue("@valor", product_sellvalue);
                Banco.Comando.Parameters.AddWithValue("@foto", product_picture);


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
                Banco.Comando = new MySqlCommand("UPDATE produtos SET descricao = @produto, idCategoria = @idCategoria, idMarca = @idMarca, " +
                    "estoque = @estoque, valorVenda = @valor, foto = @foto where id = @id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@id", product_id);
                Banco.Comando.Parameters.AddWithValue("@produto", product_name);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", product_categoryid);
                Banco.Comando.Parameters.AddWithValue("@idMarca", product_brandid);
                Banco.Comando.Parameters.AddWithValue("@estoque", product_inventory);
                Banco.Comando.Parameters.AddWithValue("@valor", product_sellvalue);
                Banco.Comando.Parameters.AddWithValue("@foto", product_picture);

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

                Banco.Comando = new MySqlCommand("DELETE FROM produtos where id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", product_id);
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
