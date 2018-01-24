using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiuroNieruchomosci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'biuroNieruchomosciDataSet2.View_NieruchomosciLista' . Możesz go przenieść lub usunąć.
            this.view_NieruchomosciListaTableAdapter.Fill(this.biuroNieruchomosciDataSet2.View_NieruchomosciLista);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'biuroNieruchomosciDataSet1.RodzajNieruchomosci' . Możesz go przenieść lub usunąć.
            this.rodzajNieruchomosciTableAdapter.Fill(this.biuroNieruchomosciDataSet1.RodzajNieruchomosci);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'biuroNieruchomosciDataSet.Nieruchomosci' . Możesz go przenieść lub usunąć.
            this.nieruchomosciTableAdapter.Fill(this.biuroNieruchomosciDataSet.Nieruchomosci);

            //SqlConnection connection = new SqlConnection("DESKTOP-R5MRMG"); 
            /*
                        SqlCommand command = new SqlCommand();
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "BiuroNieruchomosciILes";

                        // create sql parameter if your procedure expects any input
                        SqlParameter param1 = new SqlParameter("@spParam1", SqlDbType.NVarChar);

                        // add parameters to parameters collection
                        command.Parameters.Add(param1);

                        // you can define more parameters based on your Stored Procedure's design

                        // set this parameter to a value we would like to set
                        command.Parameters["@spParam1"].Value = "<<Input goes here...>>";

                        // open connection
                        command.Connection.Open();

                        // populate data reader with return data result set 
                        // and close connection after populating data set
                        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                        // assign data source to Chart
                        chart1.DataSource = reader;

                        // Set series data source to stored procedures returned data set's columns
                        chart1.Series[0].XValueMember = "ProductName";
                        chart1.Series[0].YValueMembers = "TotalPurchase";

                        // data bind chart
                        chart1.DataBind();

                */
            // chart1.Series[1].XValueMember = "ProductName";

          //  chart1.Series[0].XValueMember = "ProductName";
           // chart1.Series[0].YValueMembers = "TotalPurchase";


        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //this.chart1.Series{}
        }
    }
}
