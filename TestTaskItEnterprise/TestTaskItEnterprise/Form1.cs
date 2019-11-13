using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestTaskItEnterprise
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;

        int countGroup;
        int columnCount = 7;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ItEnterpriseShipment.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
           

            SqlDataReader sqlReader = null;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlCommand command;

            dataGridView1.ColumnCount = columnCount;
            dataGridView1.RowCount = RowCount() + 1;

            command = new SqlCommand("SELECT * FROM [Shipment]", sqlConnection);

            sqlReader = await command.ExecuteReaderAsync();
            
            dataGridView1.Rows[0].Cells[0].Value = "Date";
            dataGridView1.Rows[0].Cells[1].Value = "Organisation";
            dataGridView1.Rows[0].Cells[2].Value = "Country";
            dataGridView1.Rows[0].Cells[4].Value = "Sity";
            dataGridView1.Rows[0].Cells[3].Value = "Manager";
            dataGridView1.Rows[0].Cells[5].Value = "Quantity";
            dataGridView1.Rows[0].Cells[6].Value = "Amount";

            int counter = 0;

            while (await sqlReader.ReadAsync())
            {
                for (int i = 0; i < columnCount; i++)
                {
                    dataGridView1.Rows[1 + counter].Cells[i].Value = Convert.ToString(sqlReader[i+1]);
                }
                counter++;
            }

            if (sqlReader != null)
                sqlReader.Close();
        }
        private void BtnGroup_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = columnCount;
            dataGridView1.RowCount = RowCount() + 1;

            string groupQuery = "";

                if (chbDate.Checked == true)
                {
                    groupQuery = groupQuery + " Date";
                }

                if (chbOrg.Checked == true)
                {
                    groupQuery = groupQuery + " Organisation";
                }

                if (chbCountry.Checked == true)
                {
                    groupQuery = groupQuery + " Country";
                }

                if (chbSity.Checked == true)
                {
                    groupQuery = groupQuery + " Sity";
                }

                if (chbMan.Checked == true)
                {
                    groupQuery = groupQuery + " Manager";
                }

            if (groupQuery == "")
            {
                MessageBox.Show("Fill group by");
                return;
            }

            string[] arrGroup = groupQuery.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arrGroup.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arrGroup[i];
            }
            dataGridView1.Rows[0].Cells[arrGroup.Length].Value = "Quantity";
            dataGridView1.Rows[0].Cells[arrGroup.Length  + 1].Value = "Amount";

            string group = string.Join(",", arrGroup);

            int counter = 0;

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlDataReader sqlReader = null;

            string query = "SELECT " + group + " ,sum(Quantity), sum(Amount) FROM [Shipment]" +
                            " GROUP BY " + group;

            SqlCommand command = new SqlCommand(query, sqlConnection);

            sqlReader = command.ExecuteReader();

            while (sqlReader.Read())
            {
                for (int i = 0; i < 7; i++)
                {
                    try
                    {
                        dataGridView1.Rows[1 + counter].Cells[i].Value = Convert.ToString(sqlReader[i]);
                    }
                    catch
                    {
                        break;
                    }
                }
                counter++;
            }

            if (sqlReader != null)
                sqlReader.Close();
        }

        int RowCount()
        {

            SqlCommand command = new SqlCommand("SELECT count(*) FROM [Shipment]", sqlConnection);

            return Convert.ToInt32(command.ExecuteScalar());

        }
    }
}
