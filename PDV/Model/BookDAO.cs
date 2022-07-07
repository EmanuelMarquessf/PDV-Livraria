using PDV.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Model
{
    class BookDAO
    {
        private Connection Con { get; set; }

        private SqlCommand Cmd { get; set; }

        public BookDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }
        public void Insert(Book book)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO Book VALUES (@title, @quant, @value, @author, @company, @pages, @gender, @volume, @edition, @isbn, @language, @cover, @release, 1)";

            Cmd.Parameters.AddWithValue("@title", book.Title);
            Cmd.Parameters.AddWithValue("@quant", book.Quant);
            Cmd.Parameters.AddWithValue("@value", book.Value);
            Cmd.Parameters.AddWithValue("@author", book.Author);
            Cmd.Parameters.AddWithValue("@company", book.Company);
            Cmd.Parameters.AddWithValue("@pages", book.Pages);
            Cmd.Parameters.AddWithValue("@gender", book.Gender);
            Cmd.Parameters.AddWithValue("@volume", book.Volume);
            Cmd.Parameters.AddWithValue("@edition", book.Edition);
            Cmd.Parameters.AddWithValue("@isbn", book.Isbn);
            Cmd.Parameters.AddWithValue("@language", book.Language);
            Cmd.Parameters.AddWithValue("@cover", book.Cover);
            Cmd.Parameters.AddWithValue("@release", book.ReleaseDate);

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

        public void Update(Book booktoBeUpdated)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Book SET Title_Book = @title, Quant_Book = @quant, Value_Book = @value, Author_Book = @author, 
                                Company_Book = @company, Pages_Book = @pages, Gender_Book = @gender, Volume_Book = @volume, Edition_Book= @edition, Isbn_Book = @isbn, 
                                Language_Book = @language, Cover_Book = @cover, ReleaseDate_Book = @release, Status_Book = @status WHERE Id_Book = @id";
            Cmd.Parameters.AddWithValue("@id", booktoBeUpdated.Id);
            Cmd.Parameters.AddWithValue("@title", booktoBeUpdated.Title);
            Cmd.Parameters.AddWithValue("@quant", booktoBeUpdated.Quant);
            Cmd.Parameters.AddWithValue("@value", booktoBeUpdated.Value);
            Cmd.Parameters.AddWithValue("@author", booktoBeUpdated.Author);
            Cmd.Parameters.AddWithValue("@company", booktoBeUpdated.Company);
            Cmd.Parameters.AddWithValue("@pages", booktoBeUpdated.Pages);
            Cmd.Parameters.AddWithValue("@gender", booktoBeUpdated.Gender);
            Cmd.Parameters.AddWithValue("@volume", booktoBeUpdated.Volume);
            Cmd.Parameters.AddWithValue("@edition", booktoBeUpdated.Edition);
            Cmd.Parameters.AddWithValue("@isbn", booktoBeUpdated.Isbn);
            Cmd.Parameters.AddWithValue("@language", booktoBeUpdated.Language);
            Cmd.Parameters.AddWithValue("@cover", booktoBeUpdated.Cover);
            Cmd.Parameters.AddWithValue("@release", booktoBeUpdated.ReleaseDate);
            Cmd.Parameters.AddWithValue("@status", booktoBeUpdated.Status);
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

        public void Delete(int BookId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"DELETE FROM Book WHERE Id_Book = @id";
            Cmd.Parameters.AddWithValue("@id", BookId);

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
        public List<Book> ListAllBooks()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book";

            List<Book> listOfBooks = new List<Book>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book Book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    listOfBooks.Add(Book);
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
            return listOfBooks;
        }

        public List<Book> ListAllBooksStock()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book where Quant_Book > 0 and Status_Book = 1";

            List<Book> listOfBooks = new List<Book>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book Book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    listOfBooks.Add(Book);
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
            return listOfBooks;
        }

        public List<Book> ListAllBooksStatus()
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book where Status_Book = 1";

            List<Book> listOfBooks = new List<Book>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book Book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    listOfBooks.Add(Book);
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
            return listOfBooks;
        }

        public List<Book> ListSearchBooks(string title)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book WHERE Title_Book like '%' + @title + '%';";
            Cmd.Parameters.AddWithValue("@title", title);

            List<Book> listOfBooks = new List<Book>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book Book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    listOfBooks.Add(Book);
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
            return listOfBooks;
        }
        public List<Book> ListSearchBooksClient(string title)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book WHERE Title_Book like '%' + @title + '%' and Status_Book = 1 and Quant_Book > 0;";
            Cmd.Parameters.AddWithValue("@title", title);

            List<Book> listOfBooks = new List<Book>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Book Book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    listOfBooks.Add(Book);
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
            return listOfBooks;
        }

        public Book AddBook(int bookId)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Book WHERE Id_Book =  @id";
            Cmd.Parameters.AddWithValue("@id", bookId);
            Book selectedBook = new Book(bookId);

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.Read())
                {
                    Book book = new Book((int)rd["Id_Book"], (string)rd["Title_Book"], (int)rd["Quant_Book"], float.Parse(rd["Value_Book"].ToString()), (string)rd["Author_Book"],
                                        (string)rd["Company_Book"], (int)rd["Pages_Book"], (string)rd["Gender_Book"], (int)rd["Volume_Book"], (string)rd["Edition_Book"],
                                        (string)rd["Isbn_Book"], (string)rd["Language_Book"], (string)rd["Cover_Book"], (string)rd["ReleaseDate_Book"], (bool)rd["Status_Book"]);
                    selectedBook = book;
                    rd.Close();
                    return selectedBook;
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
            return selectedBook;
        }
    }
}
