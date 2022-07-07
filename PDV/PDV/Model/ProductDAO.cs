using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class ProductDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public ProductDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Product product)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Product VALUES (@description, @quant, @value)";

            Cmd.Parameters.AddWithValue("@description", product.Description);
            Cmd.Parameters.AddWithValue("@quant", product.Quant);
            Cmd.Parameters.AddWithValue("@value", product.Value);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir produto no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Update(Product produtToBeUpdated)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Product SET Description_Product = @description, Quant_Product = @quant, Value_Product = @value WHERE Id_Product = @id";
            Cmd.Parameters.AddWithValue("@id", produtToBeUpdated.Id);
            Cmd.Parameters.AddWithValue("@description", produtToBeUpdated.Description);
            Cmd.Parameters.AddWithValue("@quant", produtToBeUpdated.Quant);
            Cmd.Parameters.AddWithValue("@value", produtToBeUpdated.Value);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar produto no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }

        public void Delete(int productId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Product WHERE Id_Product = @id";
            Cmd.Parameters.AddWithValue("@id", productId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao deletar o produto do banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Product> ListAllProducts()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Product";

            List<Product> listOfProducts = new List<Product>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Product product = new Product((int)rd["Id_Product"], (string)rd["Description_Product"], (int)rd["Quant_Product"], float.Parse(rd["Value_Product"].ToString()));
                    listOfProducts.Add(product);
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
            return listOfProducts;
        }

    }
}
