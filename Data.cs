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
    class Data
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
        // this is the connection string, it can be used anywhere in program and it is read only.
        public String Trek { get; } = @"Data Source=CYGNUS271\SQLEXPRESS;Initial Catalog = VBMoviesFullData; Integrated Security = True";

        SqlConnection Con = new SqlConnection();
        DataTable MovieTable = new DataTable();


        // just a method to load database
        private void loaddb()
        {
            //load datatable columns
            datatablecolumns();


        }

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
                MovieTable.Columns.Add("Date");


            }
            catch
            {
                MessageBox.Show("Not working");
            }



        }


    }
}
