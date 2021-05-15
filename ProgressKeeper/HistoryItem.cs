using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProgressKeeper
{
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _date;
        private string _progress;
        private Size _windowSize;

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; LabelDate.Text = value; }
        }

        [Category("Custom Props")]
        public string Progress
        {
            get { return _progress; }
            set { _progress = value; richTextBox1.Text = value; }
        }

        [Category("Custom Props")]
        public Size WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; this.Size = value; }
        }

        #endregion

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int newHeight = e.NewRectangle.Height + 5;
            ((RichTextBox)sender).Height = newHeight;
            this.Height = newHeight;
        }
    }
}
