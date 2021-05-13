
namespace ProgressKeeper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TabHistory = new System.Windows.Forms.TabControl();
            this.TabAddProgress = new System.Windows.Forms.TabPage();
            this.InsertProgress = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabShowHistory = new System.Windows.Forms.TabPage();
            this.TabHistory.SuspendLayout();
            this.TabAddProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "";
            this.DateTimePicker1.Location = new System.Drawing.Point(9, 3);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(217, 23);
            this.DateTimePicker1.TabIndex = 2;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // TabHistory
            // 
            this.TabHistory.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabHistory.Controls.Add(this.TabAddProgress);
            this.TabHistory.Controls.Add(this.tabShowHistory);
            this.TabHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHistory.Location = new System.Drawing.Point(0, 0);
            this.TabHistory.Name = "TabHistory";
            this.TabHistory.SelectedIndex = 0;
            this.TabHistory.Size = new System.Drawing.Size(774, 441);
            this.TabHistory.TabIndex = 3;
            this.TabHistory.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // TabAddProgress
            // 
            this.TabAddProgress.Controls.Add(this.InsertProgress);
            this.TabAddProgress.Controls.Add(this.richTextBox1);
            this.TabAddProgress.Controls.Add(this.DateTimePicker1);
            this.TabAddProgress.Location = new System.Drawing.Point(4, 27);
            this.TabAddProgress.Name = "TabAddProgress";
            this.TabAddProgress.Padding = new System.Windows.Forms.Padding(3);
            this.TabAddProgress.Size = new System.Drawing.Size(766, 410);
            this.TabAddProgress.TabIndex = 0;
            this.TabAddProgress.Text = "Add";
            this.TabAddProgress.UseVisualStyleBackColor = true;
            // 
            // InsertProgress
            // 
            this.InsertProgress.Location = new System.Drawing.Point(689, 376);
            this.InsertProgress.Name = "InsertProgress";
            this.InsertProgress.Size = new System.Drawing.Size(69, 23);
            this.InsertProgress.TabIndex = 4;
            this.InsertProgress.Text = "Insert";
            this.InsertProgress.UseVisualStyleBackColor = true;
            this.InsertProgress.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(674, 363);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // tabShowHistory
            // 
            this.tabShowHistory.Location = new System.Drawing.Point(4, 27);
            this.tabShowHistory.Name = "tabShowHistory";
            this.tabShowHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabShowHistory.Size = new System.Drawing.Size(766, 410);
            this.tabShowHistory.TabIndex = 1;
            this.tabShowHistory.Text = "History";
            this.tabShowHistory.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.TabHistory);
            this.MinimumSize = new System.Drawing.Size(400, 240);
            this.Name = "MainForm";
            this.Text = "Progress Keeper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TabHistory.ResumeLayout(false);
            this.TabAddProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabAddProgress;
        private System.Windows.Forms.TabControl TabHistory;
        private System.Windows.Forms.TabPage tabShowHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button InsertProgress;
    }
}

