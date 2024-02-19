using _221047_registros.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221047_registros
{
    public class Consulta
    {

        public DateTime query_startDate { get; set; }
        public DateTime query_finalDate { get; set; }

        public DataTable OpenQueryByCategory()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT C.categoria AS Categoria, ROUND(SUM(V.qtde)) AS Valor FROM Categorias C " +
                    "INNER JOIN Produtos P ON C.id = P.idCategoria INNER JOIN Vendadet V ON P.id = V.idProduto INNER JOIN Vendacab VC ON V.idVendaCab = VC.id " +
                    "WHERE VC.data between @startDate and @finalDate GROUP BY C.id, C.categoria", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@startDate", query_startDate);
                Banco.Comando.Parameters.AddWithValue("@finalDate", query_finalDate);
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

        public DataTable OpenQueryByProductSales(string product_id)
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT vcab.id AS Id,  vcab.data AS Data, c.nome AS Cliente, ROUND(vdet.qtde) AS Quantidade, vdet.valorUnitario AS Valor_Unidade FROM Vendacab AS vcab " +
                    "INNER JOIN Clientes c ON c.id = vcab.idCliente INNER JOIN Vendadet vdet ON vdet.idVendaCab = vcab.id INNER JOIN Produtos p ON p.id = vdet.idProduto " +
                    "WHERE p.id = @productId AND vcab.data between @startDate and @finalDate ORDER BY vcab.id", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@startDate", query_startDate);
                Banco.Comando.Parameters.AddWithValue("@finalDate", query_finalDate);
                Banco.Comando.Parameters.AddWithValue("@productId", product_id);
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
        public DataTable OpenQueryAllSalesProducts()
        {
            try
            {
                Banco.OpenConnection();
                Banco.Comando = new MySqlCommand("SELECT p.descricao AS Produto, ROUND(SUM(vdet.qtde)) AS Soma FROM Vendacab AS vcab " +
                    "INNER JOIN Vendadet vdet ON vdet.idVendaCab = vcab.id INNER JOIN Produtos p ON p.id = vdet.idProduto " +
                    "WHERE vcab.data between @startDate and @finalDate GROUP BY Produto ORDER BY Produto", Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@startDate", query_startDate);
                Banco.Comando.Parameters.AddWithValue("@finalDate", query_finalDate);
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
    }
}
