using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class AdmDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public AdmDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Adm adm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Administrator VALUES (@login, @name, @password)";

            Cmd.Parameters.AddWithValue("@login", adm.Login);
            Cmd.Parameters.AddWithValue("@name", adm.Name);
            Cmd.Parameters.AddWithValue("@password", adm.Password);
            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir administrador no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Update(Adm admToBeUpdated)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Administrator SET Login_Adm = @login, Name_Adm = @name, Password_Adm = @password WHERE Id_Adm = @id";
            Cmd.Parameters.AddWithValue("@id", admToBeUpdated.Id);
            Cmd.Parameters.AddWithValue("@login", admToBeUpdated.Login);
            Cmd.Parameters.AddWithValue("@name", admToBeUpdated.Name);
            Cmd.Parameters.AddWithValue("@password", admToBeUpdated.Password);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao atualizar administrador no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }

        public void Delete(int id)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Administrator WHERE Id_Adm = @id";
            Cmd.Parameters.AddWithValue("@id", id);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao deletar o administrador do banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public List<Adm> ListAllAdms()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Administrator";

            List<Adm> listOfAdms = new List<Adm>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Adm adm = new Adm((int)rd["Id_Adm"], (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"]);
                    listOfAdms.Add(adm);
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
            return listOfAdms;
        }
        public bool ValidateLogin(Adm adm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Administrator WHERE Login_Adm = @login and Password_Adm = @password";
            Cmd.Parameters.AddWithValue("@login", adm.Login);
            Cmd.Parameters.AddWithValue("@password", adm.Password);

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao verificar login\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
            return false;
        }

    }
}
