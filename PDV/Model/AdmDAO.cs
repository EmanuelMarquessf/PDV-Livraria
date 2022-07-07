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
            Cmd.CommandText = @"INSERT INTO Administrator VALUES (@login, @name, @password, @office, 1)";

            Cmd.Parameters.AddWithValue("@login", adm.Login);
            Cmd.Parameters.AddWithValue("@name", adm.Name);
            Cmd.Parameters.AddWithValue("@password", adm.Password);
            Cmd.Parameters.AddWithValue("@office", adm.Office);
    
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
            Cmd.CommandText = @"UPDATE Administrator SET Login_Adm = @login, Name_Adm = @name, Password_Adm = @password, Office_Adm = @office, Status_Adm = @status WHERE Id_Adm = @id";
            Cmd.Parameters.AddWithValue("@id", admToBeUpdated.Id);
            Cmd.Parameters.AddWithValue("@login", admToBeUpdated.Login);
            Cmd.Parameters.AddWithValue("@name", admToBeUpdated.Name);
            Cmd.Parameters.AddWithValue("@password", admToBeUpdated.Password);
            Cmd.Parameters.AddWithValue("@office", admToBeUpdated.Office);
            Cmd.Parameters.AddWithValue("@status", admToBeUpdated.Status);

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
                    Adm adm = new Adm((int)rd["Id_Adm"], (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"], (string)rd["Office_Adm"], (bool)rd["Status_Adm"]);
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
        public List<Adm> ListSearchAdms(string name)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Administrator WHERE Name_Adm like '%' + @name + '%';";
            Cmd.Parameters.AddWithValue("@name", name);

            List<Adm> listOfAdms = new List<Adm>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Adm adm = new Adm((int)rd["Id_Adm"], (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"], (string)rd["Office_Adm"], (bool)rd["Status_Adm"]);
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

        public Adm AddAdm(int admId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Administrator WHERE Id_Adm =  @id";
            Cmd.Parameters.AddWithValue("@id", admId);
            Adm selectedAdm= new Adm(admId);

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    Adm adm = new Adm((int)rd["Id_Adm"], (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"], (string)rd["Office_Adm"], (bool)rd["Status_Adm"]);
                    selectedAdm = adm;
                    rd.Close();
                    return selectedAdm;
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
            return selectedAdm;
        }
        public Adm ValidateLogin(Adm adm)
        {
            
            Cmd.Connection = Con.ReturnConnection();

            Cmd.CommandText = @"SELECT * FROM Administrator WHERE Login_Adm = @login and Password_Adm = @password";
            Cmd.Parameters.AddWithValue("@login", adm.Login);
            Cmd.Parameters.AddWithValue("@password", adm.Password);

            adm = new Adm(0, adm.Login, adm.Password);
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    
                    adm = new Adm(int.Parse(rd["Id_Adm"].ToString()), (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"], (string)rd["Office_Adm"], (bool)rd["Status_Adm"]);
                    rd.Close();
                    return adm;
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
            return adm;
        }

        public void UpdatePassword(Adm adm)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Administrator SET Password_Adm = @password WHERE Id_Adm = @id";
            Cmd.Parameters.AddWithValue("@password", adm.Password);
            Cmd.Parameters.AddWithValue("@id", adm.Id);


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
        public List<Adm> ListAllAdmsStatus()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Administrator where Status_Adm = 1";

            List<Adm> listOfAdms = new List<Adm>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Adm adm = new Adm((int)rd["Id_Adm"], (string)rd["Login_Adm"], (string)rd["Name_Adm"], (string)rd["Password_Adm"], (string)rd["Office_Adm"], (bool)rd["Status_Adm"]);
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

    }
}
