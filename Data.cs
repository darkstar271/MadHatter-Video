using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//todo page 253 new golf book
namespace MadHatter_Video
{
    // Clean up code with #region #endregion
    class Data
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        // this is the connection string, it can be used anywhere in program and it is read only.
        // public String Trek { get; } = @"Data Source=CYGNUS271\SQLEXPRESS;Initial Catalog = VBMoviesFullData; Integrated Security = True";

        public String Trek { get; } = @"Data Source = CYGNUS271\SQLEXPRESS;Initial Catalog = VBMoviesFullData; Integrated Security = True";

        SqlConnection Con = new SqlConnection();
        DataTable MovieTable = new DataTable();
        DataTable CusTable = new DataTable();
        DataTable RenMovTable = new DataTable();
        // these 3 properties allow data to be sent to the winform
        public DataTable AllMovies { get; set; }
        public DataTable AllCustomers { get; set; }
        public DataTable AllRentedMovies { get; set; }



        //constructor
        public Data()
        {
            Con.ConnectionString = Trek;
        }

        // make 2 more load data for Customer and Rented Movies
        // just a method to load all Movies for database
        public void loaddb()
        {
            //load datatable columns
            datatablecolumns();
            using (SqlConnection connection = new SqlConnection(Trek))
            {
                string QueryString = @"SELECT * FROM Movies order by MovieID";

                connection.Open();

                SqlCommand command = new SqlCommand(QueryString, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MovieTable.Rows.Add(
                        reader["MovieID"],
                        reader["Rating"],
                        reader["Title"],
                        reader["Year"],
                        reader["Rental_Cost"],
                        reader["Plot"],
                        reader["Genre"]);//reader["Date"]
                }
                reader.Close();
                connection.Close();
                //DgvMovies.DataSource = MovieTable;
                AllMovies = MovieTable;
            }
        }


        public void loaddbCus()
        {
            //load datatable columns
            datatableColCus();
            using (SqlConnection connection = new SqlConnection(Trek))
            {
                string QueryString = @"SELECT * FROM Customer order by CustID";

                connection.Open();

                SqlCommand command = new SqlCommand(QueryString, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CusTable.Rows.Add(

                        reader["CustID"],
                        reader["FirstName"],
                        reader["LastName"],
                        reader["Address"],
                        reader["Phone"]);

                }
                reader.Close();
                connection.Close();
                //DgvMovies.DataSource = MovieTable;

                AllCustomers = CusTable;
            }
        }



        // make 2 more load data for Customer and Rented Movies
        // This gets the data form each column and sends it to the table Columns
        public void datatablecolumns()
        {
            MovieTable.Clear();
            try
            {
                MovieTable.Columns.Add("MovieID");
                MovieTable.Columns.Add("Rating");
                MovieTable.Columns.Add("Title");
                MovieTable.Columns.Add("Year");
                MovieTable.Columns.Add("Rental_Cost");
                MovieTable.Columns.Add("Plot");
                MovieTable.Columns.Add("Genre");
                // MovieTable.Columns.Add("Date");
            }
            catch
            {
                MessageBox.Show("Not working");
            }
        }

        public void datatableColCus()
        {
            CusTable.Clear();

            try
            {
                CusTable.Columns.Add("CusID");
                CusTable.Columns.Add("FirstName");
                CusTable.Columns.Add("LastName");
                CusTable.Columns.Add("Address");
                CusTable.Columns.Add("Phone");
            }
            catch
            {
                MessageBox.Show("Not working");
            }

        }


    }
}
