using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class ItemOrderDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

       public ItemOrderDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        public void Insert(ItemOrder itemOrder)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Item_Order VALUES((SELECT MAX(Id_Order) FROM[Order]), @Id_Book, @Quant_Item)";
            Cmd.Parameters.AddWithValue("@Id_Book", itemOrder.IdBook); 
            Cmd.Parameters.AddWithValue("@Quant_Item", itemOrder.Quant);

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
                
            }
        }

        public void UpdateStock(ItemOrder itemOrder)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Book SET Quant_Book = Quant_Book - @Quant_Item2 WHERE Id_Book = @Id_Book2";
            Cmd.Parameters.AddWithValue("@Id_Book2", itemOrder.IdBook);
            Cmd.Parameters.AddWithValue("@Quant_Item2", itemOrder.Quant);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar cliente no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<ItemOrder> ListItensOrder(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Item_Order WHERE Id_Order = @id";
            Cmd.Parameters.AddWithValue("@id", id);

            List<ItemOrder> listOfItemOrders = new List<ItemOrder>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    ItemOrder itemOrder = new ItemOrder((int)rd["Id_Order"], (int)rd["Id_Book"], (int)rd["Quant_Item"]);
                    listOfItemOrders.Add(itemOrder);
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
            return listOfItemOrders;
        }

    }
}
