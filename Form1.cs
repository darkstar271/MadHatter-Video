using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadHatter_Video
{
    //sql connection string//
    //Data Source=CYGNUS271\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    //sql connection string//


    // make a Age check , for movie ratings

    public partial class Form1 : Form
    {   // this instantiates a new class of the Data Class
        Data loreData = new Data();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAlmovies_Click(object sender, EventArgs e)
        {//This gets the button by it's "Name"
            Button Gkeeper = (Button)sender;
            Gate(Gkeeper.Name);
        }
        // This "Gate" checks which button or Radio button has been pressed
        public void Gate(string ButCheck)

        {
            {
                switch (ButCheck)
                {
                    case "All Movies":
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





    }
}
