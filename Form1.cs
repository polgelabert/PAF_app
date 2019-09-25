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
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace PAF_app2
{
    public partial class Form1 : Form
    {
        List<string> listBoxItems = new List<string>();
        public string selectedItem;
        public bool isBusy = false;
        Queue<Button> WaitingQueue = new Queue<Button>();
        public Dictionary<string, string[]> jobHistory = new Dictionary<string, string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddItemsToListBox();
            HideAllPanels();
            InitializeDataGridView();
        }

        private void AddItemsToListBox()
        {
            listBoxItems.Add("Aging (with DS, OF)");
            listBoxItems.Add("Aging (with Third Party)");
            listBoxItems.Add("AB28_AB29");
            listBoxItems.Add("PSP_Categorization");
            listBoxItems.Add("CCC_Categorization");
            listBoxItems.Add("Analysis FX (PL63000022)");
            listBoxItems.Add("OwnCC Open Difference");
            listBoxItems.Add("Integrity Accrual Analysis");
            listBoxItems.Add("Integrity AX-AX Dashboard");
            listBoxItems.Add("ChargeBack");
            listBoxItems.Add("Cut Off PSP");
            listBoxItems.Add("Accounting Sales & Collection Extraction");
            listBoxItems.Add("Match Supplier DT20");
            ListBoxProcesses.DataSource = listBoxItems;
        }

        public bool EnqueTask(object sender, EventArgs e)
        {
            if (isBusy)
            {
                WaitingQueue.Enqueue((Button)sender);
                Console.WriteLine("Job Added to queue");
                UpdateWaitingJobsDGV();
                return false;
            }
            else
            {
                isBusy = true;
                Console.WriteLine("Runing from queue");
                return true;
            }
        }

        public void LaunchNextProcess()
        {
            isBusy = false;
            if (WaitingQueue.Count > 0)
            {
                WaitingQueue.Dequeue().PerformClick();
            }
            UpdateWaitingJobsDGV();
        }

        private void UpdateWaitingJobsDGV()
        {
            waitingJobsDGV.Rows.Clear();
            foreach (var item in WaitingQueue)
            {
                string processName = item.Text.Replace("Run ", "");
                waitingJobsDGV.Rows.Add(processName, "Waiting"); 
            }
            waitingJobsDGV.Update();
            //Application.DoEvents();

        }

        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            string sql = SqlText();
            string connString = ConnStringCLUASAXPRE();
            //string path = Path2Save.Text;
            //string filename = Filename.Text;
            //if (path == "")
            //{
            //    MessageBox.Show("Please write Folder path correctly.");
            //    return;
            // }
            // else if (filename == "")
            // {
            //    MessageBox.Show("Please write Filename path correctly.");
            //    return;
            //}
            DataTable result = SqlExecute(connString, sql);
            //SaveResults2Csv(result, path, filename);

        }

        public string ConnStringCLUASAXPRE()
        {
            return @"Data Source=BCN-CLUASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI;";
        }

        public string ConnStringASAXPRE()
        {
            return @"Data Source=BCNAXDBASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI;";
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
            try
            {
                string selectedText = ListBoxProcesses.SelectedItem.ToString();
                //MessageBox.Show(selectedText);
                selectedItem = ListBoxProcesses.SelectedItem.ToString();

                RefreshAllPanels();
                
                switch (selectedItem)
                {
                    case "TEST QUERY":
                        MakePanelVisible("TEST_QUERY");
                        break;
                    case "AB29_TEST":
                        MakePanelVisible("AB28_AB29");
                        break;
                    case "AB28_AB29":
                        MakePanelVisible("AB28_AB29");
                        break;
                    case "PSP_Categorization":
                        MakePanelVisible("PSPCCC_Cat");
                        PSPCCC_Cat_title.Text = "PSP Categorization";
                        RunCategorization.Text = "Run PSP Categorization";
                        break;
                    case "CCC_Categorization":
                        MakePanelVisible("PSPCCC_Cat");
                        PSPCCC_Cat_title.Text = "CCC Categorization";
                        RunCategorization.Text = "Run CCC Categorization";
                        break;
                    default:
                        HideAllPanels();
                        break;

                }
            }
            catch (NullReferenceException Null_ex)
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }

        private void RefreshAllPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Refresh();
            }
        }
        private void HideAllPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }
        private void MakePanelVisible(string panelName)
        {
            foreach (Control x in this.Controls) //this.Controls.OfType<Panel>())
            {
                if (x is Panel)
                {
                    if (x.Name == panelName)
                    {
                        foreach (Control label in x.Controls)
                        {
                            if (label is Label && label.Name.Contains("title"))
                            {
                                //label.Location.X = (int)x.Size.Width / 2;
                            }
                        }
                        x.Visible = true;
                    }
                    else
                    {
                        x.Visible = false;
                    }
                }
            }
        }
        private void Label7_Click(object sender, EventArgs e){ }
        private void Button1_Click(object sender, EventArgs e) { }
        private void Label4_Click(object sender, EventArgs e) { }
        private void Label1_Click(object sender, EventArgs e) { }

        private void BtnRunAB29_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    Console.WriteLine("Start Execution");
                    UpdateWaitingJobsDGV();
                    string outputPath = TxtBox2String(outputPath_txtBox);
                    string jobName = "001_AB28_AB29";
                    string connString = ConnStringASAXPRE();

                    UpdateParameterTable(connString, 7, outputPath);        // Update outputPath in table SHEF.DBO.[00_PARAMETERS]
                    StartJob(connString, jobName);
                    Test(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message,"PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void RunCategorization_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    UpdateWaitingJobsDGV();
                    string startDateCat = TxtBox2String(startDateCat_txtbox);
                    string endDateCat = TxtBox2String(endDateCat_txtBox);
                    string outputPathCat = TxtBox2String(outputPathCat_txtBox);
                    string jobName = null;
                    int idStartDate = 0, idEndDate = 0, idOutputPathCat = 0;

                    switch(selectedItem)
                    {
                        case "PSP_Categorization":
                            jobName = "003_PSP_Categorization";
                            idStartDate = 1;
                            idEndDate = 2;
                            idOutputPathCat = 3;
                            break;
                        case "CCC_Categorization":
                            jobName = "002_CCC_Categorization";
                            idStartDate = 4;
                            idEndDate = 5;
                            idOutputPathCat = 6;
                            break;
                    }

                    string connString = ConnStringASAXPRE();
                    UpdateParameterTable(connString, idStartDate, startDateCat);
                    UpdateParameterTable(connString, idEndDate, endDateCat);
                    UpdateParameterTable(connString, idOutputPathCat, outputPathCat);        // Update outputPath in table SHEF.DBO.[00_PARAMETERS]
                    StartJob(connString, jobName);
                    Test(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        public string TxtBox2String(TextBox aTxtBox)
        {
            //Console.WriteLine(aTxtBox.Text);
            if (aTxtBox.Text == "" || aTxtBox == null)
            {
                throw new System.ArgumentException("Output Path cannot be blank." + Environment.NewLine + "Please, write it again.");
            }
            else
            {
                if (aTxtBox.Text.Substring(0,2) == "U:")
                {
                    /* // Too much CPU usage
                    var regex = new Regex(Regex.Escape("U:"));
                    var newText = regex.Replace(aTxtBox.Text, @"\\bcn-files-odi\odigeo$", 1);
                    */
                    string newText = ReplaceFirstOccurrence(aTxtBox.Text, "U:", @"\\bcn-files-odi\odigeo$");
                    return newText;
                }
                return aTxtBox.Text;
            }
        }

        public static string ReplaceFirstOccurrence(string Source, string aText2Replace, string aNewText)
        {
            int Place = Source.IndexOf(aText2Replace);
            string result = Source.Remove(Place, aText2Replace.Length).Insert(Place, aNewText);
            return result;
        }

        private static void UpdateParameterTable(string aConnString, int aId, string aNewValue)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(aConnString))
                {
                    conn.Open();
                    using (SqlCommand cmd =
                        new SqlCommand("UPDATE SHEF.DBO.[00_PARAMETERS] SET PARAMETERVALUE = @NEWVALUE WHERE ID = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", aId);
                        cmd.Parameters.AddWithValue("@NEWVALUE", aNewValue);

                        int rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void StartJob(string aConnString, string aJobName)
        {
            SqlConnection DbConn = new SqlConnection(aConnString);
            SqlCommand ExecJob = new SqlCommand();
            ExecJob.CommandType = CommandType.StoredProcedure;
            ExecJob.CommandText = "msdb.dbo.sp_start_job";
            ExecJob.Parameters.AddWithValue("@job_name", aJobName);
            ExecJob.Connection = DbConn; //assign the connection to the command.

            using (DbConn)
            {
                DbConn.Open();
                using (ExecJob)
                {
                    ExecJob.ExecuteNonQuery();
                }
            }
        }

        public void Test(string aJobName)
        {
            string[] JobStatusArr;              // = new string[6];
            bool hasEnded = false;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (!hasEnded)
            {     
                JobStatusArr = GetStatus(aJobName);
                if (string.IsNullOrEmpty(JobStatusArr[5]))
                {
                    JobStatusArr[6] = string.Format("{0:hh\\:mm\\:ss}", timer.Elapsed);
                }
                else if (Convert.ToDateTime(JobStatusArr[5]) > Convert.ToDateTime(JobStatusArr[4]))
                {
                    JobStatusArr[6] = string.Format("{0:hh\\:mm\\:ss}", Convert.ToDateTime(JobStatusArr[5]) - Convert.ToDateTime(JobStatusArr[4]));
                    hasEnded = true;
                    timer.Stop();
                }
                Application.DoEvents();
                WriteData(JobStatusArr);
            }
        }

        private void InitializeDataGridView()
        {
            runningJobsDGV.ColumnCount = 6;
            runningJobsDGV.Columns[0].Name = "Id";
            runningJobsDGV.Columns[1].Name = "Process" ;
            runningJobsDGV.Columns[2].Name = "Status";
            runningJobsDGV.Columns[3].Name = "Start Date";
            runningJobsDGV.Columns[4].Name = "End Date";
            runningJobsDGV.Columns[5].Name = "Elapsed Time";
            runningJobsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            waitingJobsDGV.ColumnCount = 2;
            waitingJobsDGV.Columns[0].Name = "Process";
            waitingJobsDGV.Columns[1].Name = "Status";
            waitingJobsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void WriteData(string[] aJobStatusArr)
        {
            if (!jobHistory.ContainsKey(aJobStatusArr[0]))              // if array isn't in Dictionary jobHistory
            {
                jobHistory.Add(aJobStatusArr[0], aJobStatusArr);
            }
            else
            {
                jobHistory[aJobStatusArr[0]] = aJobStatusArr;           // Update dictionary
            }

            runningJobsDGV.Rows.Clear();

            foreach (var key in jobHistory.Keys)
            {
                runningJobsDGV.Rows.Add(jobHistory[key][0], jobHistory[key][1], jobHistory[key][3], jobHistory[key][4], jobHistory[key][5], jobHistory[key][6]);
            }
            runningJobsDGV.Update();
        }

        private Dictionary<int, string> ExecutionStatusDictionary = new Dictionary<int, string>()
        {
            {0, "Not idle or suspended"},
            {1, "Executing"},
            {2, "Waiting for thread"},
            {3, "Between retries"},
            {4, "Success (Idle)."},
            {5, "Suspended"},
            {7, "Success."}
        };

        public string[] GetStatus(string aJobName)
        {
            string[] aJobStatusArr;
            aJobStatusArr = new string[7];

            string connString = ConnStringASAXPRE();
            SqlConnection msdbConnection = new SqlConnection(connString);

            try
            {
                msdbConnection.Open();

                SqlCommand jobStatusCommand = msdbConnection.CreateCommand();

                jobStatusCommand.CommandType = CommandType.StoredProcedure;
                jobStatusCommand.CommandText = "msdb.dbo.sp_help_job";

                SqlParameter jobName = jobStatusCommand.Parameters.Add("@job_name", SqlDbType.VarChar);
                jobName.Direction = ParameterDirection.Input;
                jobName.Value = aJobName;

                SqlParameter jobAspect = jobStatusCommand.Parameters.Add("@job_aspect", SqlDbType.VarChar);
                jobAspect.Direction = ParameterDirection.Input;
                jobAspect.Value = "JOB";

                SqlDataReader jobStatusReader = jobStatusCommand.ExecuteReader();

                while (jobStatusReader.Read())
                {
                    aJobStatusArr[0] = jobStatusReader["job_id"].ToString();
                    aJobStatusArr[1] = jobStatusReader["name"].ToString();
                    aJobStatusArr[2] = jobStatusReader["current_execution_status"].ToString();
                    aJobStatusArr[3] = ExecutionStatusDictionary[(int)jobStatusReader["current_execution_status"]];
                }   
                jobStatusReader.Close();


                // Get Started Job Time
                SqlCommand jobStartTimeCommand = msdbConnection.CreateCommand();
                jobStartTimeCommand.CommandType = CommandType.StoredProcedure;
                jobStartTimeCommand.CommandText = "msdb.dbo.sp_help_jobactivity";

                jobName = jobStartTimeCommand.Parameters.Add("@job_name", SqlDbType.VarChar);
                jobName.Direction = ParameterDirection.Input;
                jobName.Value = aJobName;
                jobStatusReader = jobStartTimeCommand.ExecuteReader();
                while (jobStatusReader.Read())
                {
                    aJobStatusArr[4] = jobStatusReader["start_execution_date"].ToString();
                    aJobStatusArr[5] = jobStatusReader["stop_execution_date"].ToString();
                    aJobStatusArr[6] = ""; //ElapsedTime
                }
                jobStatusReader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                msdbConnection.Close();
            }
            return aJobStatusArr;
        }
  
        private void runningJobsDGV_SelectionChanged(Object sender, EventArgs e)
        {
        }

        private void e(object sender, QuestionEventArgs e)
        {
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
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
