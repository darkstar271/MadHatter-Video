using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadHatter_Video
{



    // make a Age check , for movie ratings

    public partial class Form1 : Form
    {   // this instantiates a new class of the Data Class
        Data loreData = new Data();
        //private String Trek = @"Data Source=CYGNUS271\SQLEXPRESS;Initial Catalog = VBMoviesFullData; Integrated Security = True";

        SqlConnection Con = new SqlConnection();
        DataTable MovieTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            //Con.ConnectionString

            Con.ConnectionString = loreData.Trek;
            loreData.loaddb();
            DgvMovies.DataSource = loreData.AllMovies;


        }

        private void BtnAlmovies_Click(object sender, EventArgs e)
        {//This gets the button by it's "Name"
            Button Gkeeper = (Button)sender;
            Gate(Gkeeper.Name);
            // DgvMovies.DataSource = loreData.AllMovies;

        }

        // just a method to load database
        //private void loaddb()
        //{
        //    //load datatable columns
        //    datatablecolumns();

        //    using (SqlConnection connection = new SqlConnection(Trek))
        //    {
        //        string QueryString = @"SELECT * FROM Movies order by MovieID";

        //        connection.Open();

        //        SqlCommand command = new SqlCommand(QueryString, connection);

        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            MovieTable.Rows.Add(
        //                reader["MovieID"],
        //                reader["Rating"],
        //                reader["Title"],
        //                reader["Year"],
        //                reader["Rental_Cost"],
        //                reader["Plot"],
        //                reader["Genre"],
        //                reader["Date"]);
        //        }
        //        reader.Close();
        //        connection.Close();





        //    }

        //}



        // This "Gate" checks which button or Radio button has been pressed
        public void Gate(string ButCheck)

        {
            {
                switch (ButCheck)
                {
                    case "All Movies":
                        DgvMovies.DataSource = MovieTable;
                        loreData.loaddb();
                        break;
                    case " 2  ":
                        break;
                    case "  3 ":
                        break;

                    case " 4  ":
                        break;
                    case " 5  ":
                        break;
                    case "  6 ":
                        break;
                    case " 7  ":
                        break;
                    case " 8  ":
                        break;
                }


            }



        }


        //public void datatablecolumns()
        //{

        //    MovieTable.Clear();
        //    try
        //    {
        //        MovieTable.Columns.Add("MovieID");
        //        MovieTable.Columns.Add("Rating");
        //        MovieTable.Columns.Add("Title");
        //        MovieTable.Columns.Add("Year");
        //        MovieTable.Columns.Add("Rental_Cost");
        //        MovieTable.Columns.Add("Plot");
        //        MovieTable.Columns.Add("Genre");
        //        MovieTable.Columns.Add("Date");


        //    }
        //    catch
        //    {
        //        MessageBox.Show("Not working");
        //    }



        //}

        private void DgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
