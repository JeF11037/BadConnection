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

namespace BadConnection
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        int ID;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\JeF11037\BadConnection\BadConnection\AppData\MyDB.mdf;Integrated Security=True");
            DisplayDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.myDBDataSet.Table);

        }

        private void ClearData()
        {
            ITEM_textbox.Text = "";
            AMOUNT_num.Text = "";
            PRICE_num.Text = "";
        }

        private void DisplayDataGrid()
        {
            connection.Open();
            DataTable tbl = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM dbo.MyTable", connection);
            adapter.Fill(tbl);
            TABLE_datagrid.DataSource = tbl;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ITEM_textbox.Text != "" && ITEM_textbox.Text != null && AMOUNT_num.Text != "" && AMOUNT_num.Text != null && PRICE_num.Text != "" && PRICE_num.Text != null)
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO dbo.MyTable(Item, Amount, Price) VALUES(@Item, @Amount, @Price)", connection);
                command.Parameters.AddWithValue("@Item", ITEM_textbox.Text);
                command.Parameters.AddWithValue("@Amount", AMOUNT_num.Text);
                command.Parameters.AddWithValue("@Price", PRICE_num.Text.Replace(",", "."));
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                connection.Close();
                ClearData();
            }
            DisplayDataGrid();
        }

        private void BTN_change_Click(object sender, EventArgs e)
        {
        }

        private void TABLE_datagrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(TABLE_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            ITEM_textbox.Text = TABLE_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            AMOUNT_num.Text = TABLE_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            PRICE_num.Text = TABLE_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
