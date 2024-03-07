namespace IMLab3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            StartStopButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            RuleNumeric = new NumericUpDown();
            RuleLabel = new Label();
            TestLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ClearButton = new Button();
            ((System.ComponentModel.ISupportInitialize)RuleNumeric).BeginInit();
            SuspendLayout();
            // 
            // StartStopButton
            // 
            StartStopButton.Location = new Point(256, 24);
            StartStopButton.Name = "StartStopButton";
            StartStopButton.Size = new Size(108, 23);
            StartStopButton.TabIndex = 0;
            StartStopButton.Text = "Старт/Стоп";
            StartStopButton.UseVisualStyleBackColor = true;
            StartStopButton.Click += StartStopButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // RuleNumeric
            // 
            RuleNumeric.Location = new Point(109, 12);
            RuleNumeric.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            RuleNumeric.Name = "RuleNumeric";
            RuleNumeric.Size = new Size(120, 23);
            RuleNumeric.TabIndex = 2;
            // 
            // RuleLabel
            // 
            RuleLabel.AutoSize = true;
            RuleLabel.Location = new Point(44, 14);
            RuleLabel.Name = "RuleLabel";
            RuleLabel.Size = new Size(59, 15);
            RuleLabel.TabIndex = 3;
            RuleLabel.Text = "Правило:";
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.Location = new Point(186, 44);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(12, 15);
            TestLabel.TabIndex = 4;
            TestLabel.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 5;
            label1.Text = "Правило в двоичной форме:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 16;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(14, 68);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tableLayoutPanel1.Size = new Size(625, 625);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(370, 24);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 700);
            Controls.Add(ClearButton);
            Controls.Add(label1);
            Controls.Add(TestLabel);
            Controls.Add(RuleLabel);
            Controls.Add(RuleNumeric);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(StartStopButton);
            Name = "Form1";
            Text = "Lab3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RuleNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartStopButton;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown RuleNumeric;
        private Label RuleLabel;
        private Label TestLabel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ClearButton;
    }
}
