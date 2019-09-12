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
using System.IO;

namespace PAF_app2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            string sql = SqlText();
            string connString = ConnStringCLUASAXPRE();
            string path = Path2Save.Text;
            string filename = Filename.Text;
            if (path == "")
            {
                MessageBox.Show("Please write Folder path correctly.");
                return;
            }
            else if (filename == "")
            {
                MessageBox.Show("Please write Filename path correctly.");
                return;
            }
            DataTable result = SqlExecute(connString, sql);
            SaveResults2Csv(result, path, filename);

        }




        //METHODS
        public string ConnStringCLUASAXPRE()
        {
            return @"Data Source=BCN-CLUASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI;";
        }

        public string SqlText()
        {
            string sqltext;
            if (ListBoxProcesses.SelectedItem.ToString() == "TEST QUERY")
            {
                sqltext = "SELECT TOP 5 * FROM SHEF.DBO.PAF117_00_MASTERTABLE";
            }
            else
            {
                sqltext = "";
            }
            return sqltext;
        }

        public DataTable SqlExecute(string connectionString, string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }

        public void SaveResults2Csv(DataTable aresult, string apath, string afilename)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = aresult.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(";", columnNames));

            foreach (DataRow row in aresult.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(";", fields));
            }

            File.WriteAllText(apath + "/" + afilename, sb.ToString());
            MessageBox.Show("Done");
        }

        private void InputQueryText_TextChanged(object sender, EventArgs e)
        {

        }

        public void ListBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = ListBoxProcesses.SelectedItem.ToString();
            //MessageBox.Show(selectedText);
            string selectedItem = ListBoxProcesses.SelectedItem.ToString();
            
            switch(selectedItem)
            {
                case "TEST QUERY":
                    panel1.Visible = true;
                    panel2.Visible = false;
                    break;
                case "TEST2":
                    panel1.Visible = false;
                    panel2.Visible = true;
                    break;
                default:
                    panel1.Visible = false;
                    break;
                    
            }

        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}



/**
 string connString=  @"Data Source=BCN-CLUASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI;";
            string sql = "SELECT TOP 3 * FROM SHEF.DBO.PAF117_00_MASTERTABLE";
            DataTable result = sqlQuery(connString, sql);

            Console.WriteLine(result.Rows.Count);
            foreach (DataRow dataRow in result.Rows)
            {
                StringBuilder consoleprint = new StringBuilder();
                foreach (var item in dataRow.ItemArray)
                {
                    consoleprint.Append(item);
                    consoleprint.Append(", ");
                }
                Console.WriteLine(consoleprint);
            }
            MessageBox.Show("Done.");
            Console.ReadKey();
*/

/*
public DataTable sqlQuery(string connectionString, string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }     
*/
