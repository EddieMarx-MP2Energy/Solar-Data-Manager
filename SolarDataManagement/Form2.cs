using HierarchicalGrid;
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

namespace SolarDataManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> displayColumns = new List<string>();
            displayColumns.Add("id");
            displayColumns.Add("Name");
            displayColumns.Add("Fruit");
            displayColumns.Add("BoughtFrom");
            displayColumns.Add("Date");

            List<GroupColumn> groupColumns = new List<GroupColumn>();
            groupColumns.Add(new GroupColumn("Quantity", GroupTypeEnum.Sum));

            String connectionString = SolarDataManager.Properties.Settings.Default.SolarConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(
                "SELECT * from dbo.prospect",
                connection);
            DataTable dtResult1 = new DataTable();
            dataAdapter.Fill(dtResult1);

            dataAdapter = new SqlDataAdapter(
                "select * from dbo.account",
                connection);
            DataTable dtResult2 = new DataTable();
            dataAdapter.Fill(dtResult2);

            DataSet dsResults = new DataSet("Results");
            dsResults.Tables.Add(dtResult1);
            dsResults.Tables.Add(dtResult2);
            DataRelation relation1 = new DataRelation(
                "relation1",
                dtResult1.Columns["prospect_id"],
                dtResult2.Columns["prospect_id"]);
            dsResults.Relations.Add(relation1);

            DataGridSource newGridSource = new DataGridSource(
            dtResult1.DataSet,
            displayColumns,
            groupColumns);
            hierarchicalGridView1.DataSource = newGridSource;

        }
    }
}
