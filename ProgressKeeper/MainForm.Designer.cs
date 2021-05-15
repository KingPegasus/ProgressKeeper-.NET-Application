
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabAddProgress = new System.Windows.Forms.TabPage();
            this.InsertProgress = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TabShowHistory = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TabControl1.SuspendLayout();
            this.TabAddProgress.SuspendLayout();
            this.TabShowHistory.SuspendLayout();
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
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl1.Controls.Add(this.TabAddProgress);
            this.TabControl1.Controls.Add(this.TabShowHistory);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(774, 441);
            this.TabControl1.TabIndex = 3;
            this.TabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
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
            // TabShowHistory
            // 
            this.TabShowHistory.Controls.Add(this.flowLayoutPanel1);
            this.TabShowHistory.Location = new System.Drawing.Point(4, 27);
            this.TabShowHistory.Name = "TabShowHistory";
            this.TabShowHistory.Padding = new System.Windows.Forms.Padding(3);
            this.TabShowHistory.Size = new System.Drawing.Size(766, 410);
            this.TabShowHistory.TabIndex = 1;
            this.TabShowHistory.Text = "History";
            this.TabShowHistory.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 404);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.TabControl1.ResumeLayout(false);
            this.TabAddProgress.ResumeLayout(false);
            this.TabShowHistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage TabAddProgress;
        private System.Windows.Forms.TabPage TabShowHistory;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button InsertProgress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

