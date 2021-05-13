
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddProgress = new System.Windows.Forms.TabPage();
            this.InsertProgress = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabShowHistory = new System.Windows.Forms.TabPage();
            this.TabControl1.SuspendLayout();
            this.tabAddProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl1.Controls.Add(this.tabAddProgress);
            this.TabControl1.Controls.Add(this.tabShowHistory);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(774, 441);
            this.TabControl1.TabIndex = 3;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabAddProgress
            // 
            this.tabAddProgress.Controls.Add(this.InsertProgress);
            this.tabAddProgress.Controls.Add(this.richTextBox1);
            this.tabAddProgress.Controls.Add(this.dateTimePicker1);
            this.tabAddProgress.Location = new System.Drawing.Point(4, 27);
            this.tabAddProgress.Name = "tabAddProgress";
            this.tabAddProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddProgress.Size = new System.Drawing.Size(766, 410);
            this.tabAddProgress.TabIndex = 0;
            this.tabAddProgress.Text = "Add";
            this.tabAddProgress.UseVisualStyleBackColor = true;
            // 
            // InsertProgress
            // 
            this.InsertProgress.Location = new System.Drawing.Point(689, 376);
            this.InsertProgress.Name = "InsertProgress";
            this.InsertProgress.Size = new System.Drawing.Size(69, 23);
            this.InsertProgress.TabIndex = 4;
            this.InsertProgress.Text = "Insert";
            this.InsertProgress.UseVisualStyleBackColor = true;
            this.InsertProgress.Click += new System.EventHandler(this.Button1_Click);
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
            this.Controls.Add(this.TabControl1);
            this.MinimumSize = new System.Drawing.Size(400, 240);
            this.Name = "MainForm";
            this.Text = "Progress Keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TabControl1.ResumeLayout(false);
            this.tabAddProgress.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabAddProgress;
        private System.Windows.Forms.TabPage tabShowHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button InsertProgress;
    }
}

