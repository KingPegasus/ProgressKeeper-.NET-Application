﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressKeeper
{
    public partial class MainForm : Form
    {
        Size mainFormLastSize;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainFormLastSize = this.Size;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
            if(tabControl1.SelectedTab == tabAddProgress)
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
    }
}