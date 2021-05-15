using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using ProgressKeeper.DomainModels.Report;
using ProgressKeeper.Services.DatabaseAccess;

namespace ProgressKeeper
{
    public partial class MainForm : Form
    {
        Size mainFormLastSize;
        Record storedRecord = null;

        readonly int historyDays = 30;
        readonly int localTimeZoneOffset = TimeZoneInfo.Local.BaseUtcOffset.Hours;

        static IDatabaseAccess DatabaseAccessLayer;
        static readonly string tableName = "Records";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainFormLastSize = this.Size;
            DatabaseAccessLayer = new DatabaseAccess();
            DatabaseAccessLayer.GetDatabase("ProgressKeeperDB");

            // Get Record of current Date
            try
            {
                storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date.AddHours(localTimeZoneOffset));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Couldn't get the any document");
            }

            // Show Progress of the Record
            if (storedRecord != null)
            {
                richTextBox1.Text = storedRecord.Progress;
            }

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedTab == TabShowHistory)
            {
                PopulateHistory(historyDays);
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Record newRecord = new Record
            {
                WorkDate = DateTimePicker1.Value.Date.AddHours(localTimeZoneOffset),
                Progress = richTextBox1.Text
            };

            // Get Record of current Date
            try
            {
                storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date.AddHours(localTimeZoneOffset));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Couldn't get the any document");
            }

            // Insert the progress in the Database
            try 
            {
                // If there is no record for the selected date, Insert the Record
                // Else Update the record in DB
                if (storedRecord == null)
                {
                    DatabaseAccessLayer.InsertRecord<Record>(tableName, newRecord);
                }
                else 
                {
                    DatabaseAccessLayer.UpdateSignalValue(tableName, newRecord);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Couldn't store the progress");
            }

            
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            // Getting new or current size of Main Form
            int mainFormCurrentWidth = this.Size.Width;
            int mainFormCurrentHeight= this.Size.Height;

            // Checks if the Tab "Add" is selected
            if(TabControl1.SelectedTab == TabAddProgress)
            {
                // Getting change in Main Form size
                int changeInWidth = mainFormLastSize.Width - mainFormCurrentWidth;
                int changeInHeight = mainFormLastSize.Height - mainFormCurrentHeight;

                // Getting new Size of Rich TextBox
                int newTextBoxWidth = richTextBox1.Size.Width - changeInWidth;
                int newTextBoxHeight = richTextBox1.Size.Height - changeInHeight;

                // Setting new Size of Rich TextBox
                richTextBox1.Size= new Size(newTextBoxWidth, newTextBoxHeight);

                // Getting new position of Button "Insert"
                int newButtonLocX = InsertProgress.Location.X - changeInWidth;
                int newButtonLocY = InsertProgress.Location.Y - changeInHeight;

                // Setting new position of Button "Insert"
                InsertProgress.Location = new Point(newButtonLocX, newButtonLocY);
            }

            // Updating Main Form Last Size with Current Size
            mainFormLastSize.Width = mainFormCurrentWidth;
            mainFormLastSize.Height = mainFormCurrentHeight;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get Record for the date selected
            try
            {
                storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date.AddHours(localTimeZoneOffset));
            }
            catch { }

            // Display the Progress
            if (storedRecord != null)
            {
                richTextBox1.Text = storedRecord.Progress;
            }
            else
            {
                richTextBox1.Text = String.Empty;
            }
            
        }

        /// <summary>
        /// Fetch History of Records from the DB
        /// </summary>
        /// <param name="days">No. of days from today</param>
        /// <returns>List of Record fetched</returns>
        private Record[] FetchHistory(int days)
        {
            Record[] records = new Record[days];
            DateTime dateTime = DateTime.Today.AddHours(localTimeZoneOffset);

            for (int i = 0; i < days; i++)
            {
                records[i] = new Record();
                try
                {
                    records[i] = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, dateTime);
                }
                catch { }

                dateTime = dateTime.AddDays(-1);
            }
            return records;
        }

        /// <summary>
        /// Populate History Tab
        /// </summary>
        private void PopulateHistory(int days)
        {
            // Fetch History from DB
            Record[] records = FetchHistory(days);

            // Create a List of HistoryItem 
            HistoryItem[] historyItems = new HistoryItem[records.Length];

            // clear flowlayout
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            // add HistoryItems to flowlayout
            for (int i=0; i < historyItems.Length; i++)
            {
                if (records[i] != null)
                {
                    //Update 
                    historyItems[i] = new HistoryItem
                    {
                        Date = records[i].WorkDate.ToString("dd MMM yyyy"),
                        Progress = records[i].Progress
                    };
                    // add to flowlayout
                    flowLayoutPanel1.Controls.Add(historyItems[i]);
                }
            }
        }
    }
}
