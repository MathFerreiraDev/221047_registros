using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros
{
    public class Banco
    {

        // Não coloquei em inglês, pois poderia criar conflito entre os nomes :)
        public static MySqlConnection Conexao;
        public static MySqlCommand Comando;
        public static MySqlDataAdapter Adaptador;

        public static DataTable datTable;


        public static void OpenConnection()
        {
            string local = "localhost";
            int port = 3307;
            string uid = "root";
            string password = "etecjau";


            try
            {
                Conexao = new MySqlConnection($"server={local}; port={port}; uid={uid}; pwd={password}");

                Conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao encerrar a conexão com a base de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CreateData()
        {
            try
            {
                OpenConnection();

                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas", Conexao);

                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Cidades " +
                                           "(id integer auto_increment primary key, " +
                                           "nome char(40), " +
                                           "uf char(2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Marcas " +
                                           "(id integer auto_increment primary key, " +
                                           "marca char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Categorias " +
                                           "(id integer auto_increment primary key, " +
                                           "categoria char(20))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Clientes " +
                                           "(id integer auto_increment primary key, " +
                                           "nome char(40)," +
                                           "idCidade integer," +
                                           "dataNasc date," +
                                           "renda decimal(10,2)," +
                                           "cpf char(14)," +
                                           "foto varchar(100)," +
                                           "venda boolean)", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Produtos " +
                                           "(id integer auto_increment primary key, " +
                                           "descricao char(40)," +
                                           "idCategoria integer," +
                                           "idMarca integer," +
                                           "estoque int," +
                                           "valorVenda decimal(10, 2)," +
                                           "foto varchar(100))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaCab " +
                                           "(id integer auto_increment primary key, " +
                                           "idCliente int," +
                                           "data date," +
                                           "total decimal(10, 2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS VendaDet " +
                                           "(id integer auto_increment primary key, " +
                                           "idVendaCab int," +
                                           "idProduto int," +
                                           "qtde decimal(10, 3)," +
                                           "valorUnitario decimal(10, 2))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS Caixa " +
                                           "(id integer auto_increment primary key, " +
                                           "idVendaCab int," +
                                           "dinheiro decimal(10,2)," +
                                           "cartao decimal(10,2)," +
                                           "pix decimal(10,2)," +
                                           "cheque decimal(10,2)," +
                                           "boleto decimal(10,2))", Conexao);
                Comando.ExecuteNonQuery();

                CloseConnection();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao estabilizar com a database principal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
