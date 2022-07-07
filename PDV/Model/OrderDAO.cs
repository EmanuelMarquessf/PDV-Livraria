using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data;
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
            Cmd.CommandText = @"INSERT INTO [Order] VALUES (@Pay_Form, @Id_Client, @Date_Order, @Amount_Order, @Id_Adm)";

            Cmd.Parameters.AddWithValue("@Pay_Form", order.PayForm);
            Cmd.Parameters.AddWithValue("@Id_Client", order.IdClient);
            Cmd.Parameters.AddWithValue("@Date_Order", order.Date);
            Cmd.Parameters.AddWithValue("@Amount_Order", order.Amount);
            Cmd.Parameters.AddWithValue("@Id_Adm", order.IdAdm);

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

        public DataTable DisplayAndSearch(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"select O.Id_Order, O.Pay_Form, O.Id_Client, C.Name_Client, C.CPF_Client, A.Name_Adm, O.Date_Order, O.Amount_Order from dbo.[Order] as O left join dbo.Client as C on (O.Id_Client = C.Id_Client)  left join dbo.Administrator as A on (O.Id_Adm = A.Id_Adm) WHERE Id_Order LIKE @id";
            Cmd.Parameters.AddWithValue("@id", "%" + id + "%");
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Con.CloseConnection();
            return table;
        }
        public DataTable DisplayAndSearchNull()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"select O.Id_Order, O.Pay_Form, O.Id_Client, C.Name_Client, C.CPF_Client, A.Name_Adm, O.Date_Order, O.Amount_Order from dbo.[Order] as O left join dbo.Client as C on (O.Id_Client = C.Id_Client)  left join dbo.Administrator as A on (O.Id_Adm = A.Id_Adm) order by O.Id_Order DESC;";
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Con.CloseConnection();
            return table;
        }
        public List<Order> ListAllOrders()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select Id_Order, Id_Client from [Order]";

            List<Order> listOfOrders = new List<Order>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Order order = new Order((int)rd["Id_Order"], (int)rd["Id_Client"], (int)rd["Id_Adm"]);
                    listOfOrders.Add(order);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a leitura do banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listOfOrders;
        }
        public List<Order> SearchOrder(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "select * from [order] where Id_Order Like @id";
            Cmd.Parameters.AddWithValue("@id","%"+ id + "%");

            List<Order> listOfOrders = new List<Order>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Order order = new Order((int)rd["Id_Order"], (int)rd["Id_Client"], (int)rd["Id_Adm"]);
                    listOfOrders.Add(order);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a leitura do banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return listOfOrders;
        }
        public Order AddOrder(int orderId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM [Order] WHERE Id_Order =  @id";
            Cmd.Parameters.AddWithValue("@id", orderId);
            Order selectedOrder = new Order(orderId);

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    Order order = new Order((int)rd["Id_Order"], (string)rd["Pay_Form"], (int)rd["Id_Client"], (DateTime)rd["Date_Order"], (float)rd["Amount_Order"], (int)rd["Id_Adm"]);
                    selectedOrder = order;
                    rd.Close();
                    return selectedOrder;
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar a leitura do banco. \n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return selectedOrder;
        }
    }
}
