using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class OrderDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public OrderDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Order order)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO [Order] VALUES (@Pay_Form, @Id_Client, @Date_Order, @Amount_Order)";

            Cmd.Parameters.AddWithValue("@Pay_Form", order.PayForm);
            Cmd.Parameters.AddWithValue("@Id_Client", order.IdClient == 0 ? 1 : order.IdClient);
            Cmd.Parameters.AddWithValue("@Date_Order", order.Date);
            Cmd.Parameters.AddWithValue("@Amount_Order", order.Amount);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir pedido no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        
    }
}
