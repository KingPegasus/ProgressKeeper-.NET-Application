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
                storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date);
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
            PopulateHistory();

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            Record newRecord = new Record
            {
                WorkDate = DateTimePicker1.Value.Date,
                Progress = richTextBox1.Text
            };

            // Get Record of current Date
            try
            {
                storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date);
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

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
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
            storedRecord = DatabaseAccessLayer.GetDocumentByDate<Record>(tableName, DateTimePicker1.Value.Date);
            if (storedRecord != null)
            {
                richTextBox1.Text = storedRecord.Progress;
            }
            else
            {
                richTextBox1.Text = String.Empty;
            }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button newbutt = new Button();
            newbutt.Visible = true;
            newbutt.Location= new Point(50,50);
            newbutt.Anchor = AnchorStyles.Top;
            TabShowHistory.Controls.Add(newbutt);

        }

        /// <summary>
        /// Populate History Tab
        /// </summary>
        private void PopulateHistory()
        {
            // Create a List of HistoryItem 
            HistoryItem[] historyItems = new HistoryItem[20];

            // clear flowlayout
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            // add HistoryItems to flowlayout
            for (int i=0; i < historyItems.Length; i++)
            {
                //Update 
                historyItems[i] = new HistoryItem
                {
                    Date = DateTimePicker1.Text,
                    Progress = "Progressadskjlndkjnasokdnkdajsndkljabsjhgdbbasjkdbkjsbajhdsavbdkjasnkjdnaskhbdkjaskdnl;asknjdkjasbjhdbsjsabjlndbakjsbdkjsbakjbdlkjabslkjdbkjasbkdbkasjbdk;jsabkdn;laksbndkjnsakdbkjbask;bdkabskbd;askbdk;jabsksjadbk;djasbkjdbksajbdkjabProgressadskjlndkjnasokdnkdajsndkljabsjhgdbbasjkdbkjsbajhdsavbdkjasnkjdnaskhbdkjaskdnl;asknjdkjasbjhdbsjsabjlndbakjsbdkjsbakjbdlkjabslkjdbkjasbkdbkasjbdk;jsabkdn;laksbndkjnsakdbkjbask;bdkabskbd;askbdk;jabsksjadbk;djasbkjdbksajbdkjabProgressadskjlndkjnasokdnkdajsndkljabsjhgdbbasjkdbkjsbajhdsavbdkjasnkjdnaskhbdkjaskdnl;asknjdkjasbjhdbsjsabjlndbakjsbdkjsbakjbdlkjabslkjdbkjasbkdbkasjbdk;jsabkdn;laksbndkjnsakdbkjbask;bdkabskbd;askbdk;jabsksjadbk;djasbkjdbksajbdkjabProgressadskjlndkjnasokdnkdajsndkljabsjhgdbbasjkdbkjsbajhdsavbdkjasnkjdnaskhbdkjaskdnl;asknjdkjasbjhdbsjsabjlndbakjsbdkjsbakjbdlkjabslkjdbkjasbkdbkasjbdk;jsabkdn;laksbndkjnsakdbkjbask;bdkabskbd;askbdk;jabsksjadbk;djasbkjdbksajbdkjab"
                };

                // add to flowlayout
                flowLayoutPanel1.Controls.Add(historyItems[i]);
            }
        }
    }
}
