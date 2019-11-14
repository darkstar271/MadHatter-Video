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
        DataTable CusTable = new DataTable();
        DataTable RenMovTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            //Con.ConnectionString

            Con.ConnectionString = loreData.Trek;
            loreData.loaddbCus();
            loreData.loaddb();
            //  loreData.loaddbRenMov();
            DgvMovies.DataSource = loreData.AllMovies;
            DgvCustomers.DataSource = loreData.AllCustomers;
            DgvRented_Movies.DataSource = loreData.AllRentedMovies;


        }

        private void BtnAlmovies_Click(object sender, EventArgs e)
        {//This gets the button by it's "Name"
            Button Gkeeper = (Button)sender;
            Gate(Gkeeper.Name);
            // DgvMovies.DataSource = loreData.AllMovies;

        }

        // the Add Customer method
        private string AddCus(string FirstName, string LastName, string Address, string Phone)
        {
            //load datatable columns
            string borg = "INSERT INTO Customer (FirstName, LastName, Address, Phone) " +
                          "VALUES(@FirstName, @LastName, @Address, @Phone)";
            var myCat = new SqlCommand(borg, Con);
            //page 294

            using (SqlConnection connection = new SqlConnection(Trek))
            {
                string QueryString = @"SELECT * FROM Movies order by MovieID";

                connection.Open();

                SqlCommand command = new SqlCommand(QueryString, connection);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                }
                reader.Close();
                connection.Close();





            }

        }



        // This "Gate" or Switch checks which button or Radio button has been pressed
        // and turns on that case.
        public void Gate(string ButCheck)

        {
            {
                switch (ButCheck)
                {
                    case "All Movies":
                        // run some Method or do something
                        DgvMovies.DataSource = MovieTable;
                        loreData.loaddb();
                        break;
                    case " 2  ":// Add customer
                        // method to insert data
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

        //private void DgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        public void CelClickMovie(object sender, DataGridViewCellEventArgs e)
        {

            // TbxIdCu.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void DgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtID.Text = DgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = DgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DgvMovies_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtMovieID.Text = DgvMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRating.Text = DgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTitle.Text = DgvMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtYear.Text = DgvMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtRent_Cost.Text = DgvMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPlot.Text = DgvMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtGenre.Text = DgvMovies.Rows[e.RowIndex].Cells[6].Value.ToString();

                //if (e.RowIndex >= 0)
                //{
                //    DGVCustomers.DataSource = myData.Fill(OwnerID.ToString());
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DgvRented_Movies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                txtID.Text = DgvCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DgvCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DgvCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = DgvCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtPhone.Text = DgvCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
