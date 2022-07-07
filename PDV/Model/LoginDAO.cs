using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class LoginDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public LoginDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void InsertLogin(Login login, int lastId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Logins VALUES (@login, @password, @fkAdm)";

            Cmd.Parameters.AddWithValue("@login", login.LoginUser);
            Cmd.Parameters.AddWithValue("@name", login.Password);
            Cmd.Parameters.AddWithValue("@fkAdm", lastId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir login no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Update(Login loginToBeUpdated, int admId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE INTO Logins SET UserLogin = @login, Password = @password WHERE IdUser = @id";

            Cmd.Parameters.AddWithValue("@login", loginToBeUpdated.LoginUser);
            Cmd.Parameters.AddWithValue("@name", loginToBeUpdated.Password);
            Cmd.Parameters.AddWithValue("@fkCustomer", admId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir login no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Delete(int admId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Logins WHERE IdUser = @id";
            Cmd.Parameters.AddWithValue("@id", admId);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao deletar o login do banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public bool ValidateLogin(Login login)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT * FROM Logins WHERE UserLogin = @loginUser and Password = @password";
            Cmd.Parameters.AddWithValue("@loginUser", login.LoginUser);
            Cmd.Parameters.AddWithValue("@password", login.Password);

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
