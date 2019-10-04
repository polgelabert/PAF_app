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

        /**
         * Add new job:
         * 1. Add name to listBoxItems
         * 2. Create panel asociated with this task
         * 3. Update "switch" inside ListBoxProcesses_SelectedIndexChanged Method (modify the case statement)
         * 4. Copy older BtnRunAB29_Click into new Panel Button click code
         * 5. Update labels and txtbox names, and parameters in code.
         */

        List<string> listBoxItems = new List<string>();         // List containing all processes names
        public string selectedItem;                             // Name of selected item
        public bool appIsBusy = false;                          // Bool that determines wheter the app is executing a job or not
        Queue<Button> WaitingQueue = new Queue<Button>();       // Waiting Queue (Button type)
        public Dictionary<string, string[]> jobHistory = new Dictionary<string, string[]>();    // Dictionary to register all jobs executed and current execution.

        public Form1()
        {
            InitializeComponent();
        }


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
            listBoxItems.Add("Analysis FX Rate");
            listBoxItems.Add("OwnCC Open Difference");
            listBoxItems.Add("Integrity Accrual Analysis");
            listBoxItems.Add("Integrity AX-AX Dashboard");
            listBoxItems.Add("ChargeBack");
            listBoxItems.Add("Cut Off PSP");
            listBoxItems.Add("Accounting Sales & Collection Extraction");
            listBoxItems.Add("Match Supplier DT20");
            ListBoxProcesses.DataSource = listBoxItems;
        }

        public void ListBoxProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //string selectedText = ListBoxProcesses.SelectedItem.ToString();
                //MessageBox.Show(selectedText);
                selectedItem = ListBoxProcesses.SelectedItem.ToString();

                RefreshAllPanels();

                switch (selectedItem)
                {
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
                    case "OwnCC Open Difference":
                        MakePanelVisible("OwnCC_Open_Diff");
                        break;
                    case "Analysis FX Rate":
                        MakePanelVisible("FXRate");
                        break;
                    case "ChargeBack":
                        MakePanelVisible("ChargeBack");
                        break;
                    default:
                        HideAllPanels();
                        break;

                }
            }
            catch (NullReferenceException Null_ex)
            {
                Console.WriteLine(Null_ex.Message);
                throw Null_ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }

        private void BtnRunAB29_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    Console.WriteLine("Start Execution");
                    UpdateWaitingJobsDGV();
                    string outputPath = TxtBox2String(outputPath_AB_txtBox);
                    string jobName = "001_AB28_AB29";
                    string connString = ConnStringASAXPRE();

                    UpdateParameterTable(connString, 7, outputPath);        // Update outputPath in table SHEF.DBO.[00_PARAMETERS]
                    StartJob(connString, jobName);

                    MonitorJob(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void RunFXRate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    Console.WriteLine("Start Execution");
                    UpdateWaitingJobsDGV();
                    string startDateFXRate = TxtBox2String(FXRate_startDate_txtBox);
                    string endDateFXRate = TxtBox2String(FXRate_endDate_txtBox);
                    string outputPathFXRate = TxtBox2String(FXRate_outputPath_txtBox);
                    string jobName = "005_FXRate";
                    string connString = ConnStringASAXPRE();

                    UpdateParameterTable(connString, 9, startDateFXRate);
                    UpdateParameterTable(connString, 10, endDateFXRate);
                    UpdateParameterTable(connString, 11, outputPathFXRate);
                    StartJob(connString, jobName);
                    MonitorJob(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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

                    switch (selectedItem)
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
                    MonitorJob(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void RunOwnCC_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    Console.WriteLine("Start Execution");
                    UpdateWaitingJobsDGV();
                    string outputPath = TxtBox2String(outputPath_OwnCC_txtBox);
                    string jobName = "004_OwnCC_OpenDiff";
                    string connString = ConnStringASAXPRE();

                    UpdateParameterTable(connString, 8, outputPath);        // Update outputPath in table SHEF.DBO.[00_PARAMETERS]
                    StartJob(connString, jobName);
                    MonitorJob(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Run_Chargeback_Click(object sender, EventArgs e)
        {
            try
            {
                bool canExecuteTask = EnqueTask(sender, e);
                if (canExecuteTask)
                {
                    Console.WriteLine("Start Execution");
                    UpdateWaitingJobsDGV();
                    string startDateChargeback = TxtBox2String(ChargebackStartDate_txtBox);
                    string endDateChargeback = TxtBox2String(ChargebackEndDate_txtBox);
                    string inputPathChargeback = TxtBox2String(ChargebackInputPath_txtBox);
                    string outputPathChargeback = TxtBox2String(ChargebackOutputPath_txtBox);
                    string jobName = "006_Chargeback";
                    string connString = ConnStringASAXPRE();

                    UpdateParameterTable(connString, 12, startDateChargeback);
                    UpdateParameterTable(connString, 13, endDateChargeback);
                    UpdateParameterTable(connString, 14, inputPathChargeback);
                    UpdateParameterTable(connString, 15, outputPathChargeback);
                    StartJob(connString, jobName);
                    MonitorJob(jobName);
                    LaunchNextProcess();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                MessageBox.Show(ex.Message, "PAF Application", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

















        //METHODS//

        //ON LOAD FORM//
        /**
         * Dictionary containing relation between current status id and its description.
         * key: status id (int), value: description (string).
         */
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

        /**
         * Foreach Loop to hide all panels. Called when Form is showed up for first time.
         */
        private void HideAllPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }

        /**
         * Method to create columns for both Queues.
         */
        private void InitializeDataGridView()
        {
            runningJobsDGV.ColumnCount = 6;
            runningJobsDGV.Columns[0].Name = "Id";
            runningJobsDGV.Columns[1].Name = "Process";
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


        //ON CLICK LISTBOXPROCESSES//
        /**
         * Method to refresh all panels.
         * Called each time the user clicks an item of the ListBoxProcesses.
         */
        private void RefreshAllPanels()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Refresh();
            }
        }

        /**
         * Method to make a single panel visible.
         * It also centers all the Title labels (which contains the text: _title in it design name).
         * @panelName is the name of the future visible panel.
         */
        private void MakePanelVisible(string panelName)
        {
            foreach (Control x in this.Controls) //this.Controls.OfType<Panel>())
            {
                if (x is Panel)
                {
                    if (x.Name == panelName)
                    {
                        foreach (Control control in x.Controls)
                        {
                            if (control is Label && control.Name.Contains("title"))
                            {
                                control.Top = 0;
                                control.Left = (x.Width / 2) - (control.Width / 2);
                            }
                            if (control is Button)
                            {
                                control.Top = 205;
                                control.Left = (x.Width / 2) - (control.Width / 2);
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


        //ON RUN CLICK//
        /**
         * Method to Enqueue a task.
         * @sender is the (button) object
         * @e is an instance of EventArgs and contains data related to the sender
         * @return bool = True if the app is not currently busy executing another job.
         */
        public bool EnqueTask(object sender, EventArgs e)
        {
            if (appIsBusy)
            {
                WaitingQueue.Enqueue((Button)sender);
                Console.WriteLine("Job Added to queue.");
                UpdateWaitingJobsDGV();
                return false;
            }
            else
            {
                appIsBusy = true;
                Console.WriteLine("Runing from queue.");
                return true;
            }
        }

        /**
         * Method to update the waitingJobs DataGridView.
         * Called at the start of each button if the appIsBusy = false (so the task will be launched), to update the waitingJobDGV (the task will switch from waitingJobsDGV to runningJobsDGV)
         */
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

        /**
         * Connection String for BCNAXDBASAXPRE\ASAX SHEF
         * @return connectionString for DB
         */
        public string ConnStringASAXPRE()
        {
            return @"Data Source=BCNAXDBASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI";
        }

        /**
         * Method to check consistency of input fields. It replaces the U: with \\bcn-files-odi\odigeo$ in paths.
         * @aTxtBox is the input field written by user.
         * @return the string of the input field.
         */
        public string TxtBox2String(TextBox aTxtBox)
        {
            //Console.WriteLine(aTxtBox.Text);
            if (aTxtBox.Text == "" || aTxtBox == null)
            {
                throw new System.ArgumentException("Output Path cannot be blank." + Environment.NewLine + "Please, write it again.");
            }
            else
            {
                if (aTxtBox.Text.Substring(0, 2) == "U:")
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

        /**
         * Method called by TxtBox2String. It searches a substring and replaces with correct one.
         * @Source is the field text
         * @aText2Replace is the text to be replaced (U:)
         * @aNewText is the new text to write (\\bcn-files-odi\odigeo$)
         * @return modified string
         */
        public static string ReplaceFirstOccurrence(string Source, string aText2Replace, string aNewText)
        {
            int Place = Source.IndexOf(aText2Replace);
            string result = Source.Remove(Place, aText2Replace.Length).Insert(Place, aNewText);
            return result;
        }

        /**
         * Method to update SHEF.dbo.[00_PARAMETERS] table.
         * @aConnString is the connection string for the DB.
         * @aId is the Id of the parameter name.
         * @aNewValue is the parameter value.
         * 
         */
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

        /**
         * Method to launch Job.
         * @aConnString is the connection string for the DB.
         * @aJobName name of the job to execute.
         */
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

        /**
         * Method to monitor a Job while it is being executed.
         * @aJobName name of the monitored Job.
         */
        public void MonitorJob(string aJobName)
        {
            string[] JobStatusArr;              // = new string[6];
            bool hasEnded = false;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            while (!hasEnded)
            {
                JobStatusArr = GetJobStatus(aJobName);
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

        /**
         * Function to get the job status by launching the query: exec msdb.dbo.sp_help_job @job_name = "006_Chargeback"
         * @aJobName name of the monitored Job.
         * @returns string array containing monitored data: job_id, name, current_execution_status id, current_execution_status description, start_execution_date, stop_execution_date
         */
        public string[] GetJobStatus(string aJobName)
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

        /**
         * Method to Add monitored data from GetJobStatus to dictionary jobHistory and later to runningJobsDGV.
         * jobHistory is the dictionary for saving all the jobs launched so far, and the executing job is updated.
         * Note that the ended jobs are also stored in the dictionary so they can be showed in the run DGV.
         */
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

        /**
         * Method to Launch next task. If waitingQueue has items, it dequeues and performs click.
         * Then it updates waitingJobsDGV so the task is not showed anymore. (It will be showed in runningJobsDGV).
         */
        public void LaunchNextProcess()
        {
            appIsBusy = false;
            if (WaitingQueue.Count > 0)
            {
                WaitingQueue.Dequeue().PerformClick();
            }
            UpdateWaitingJobsDGV();
        }





        




        

        

        

        

        

        

        

        









        // RUN SINGLE QUERY AND SAVE TO CSV//
        /*
        public string ConnStringCLUASAXPRE()
        {
            return @"Data Source=BCN-CLUASAXPRE\ASAX;Initial Catalog=SHEF;Integrated Security=SSPI;";
        }
        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            string sql = SqlText();
            string connString = ConnStringCLUASAXPRE();
            DataTable result = SqlExecute(connString, sql);

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
        */


    }
}
