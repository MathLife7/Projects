namespace WindowsFormsApplication1
{
    partial class History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutButton = new System.Windows.Forms.Button();
            this.InButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateCheckbox = new System.Windows.Forms.CheckBox();
            this.StartDateCheckbox = new System.Windows.Forms.CheckBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.Results = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(6, 22);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(883, 44);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OutButton);
            this.groupBox2.Controls.Add(this.InButton);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.SearchTextBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1081, 101);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // OutButton
            // 
            this.OutButton.Location = new System.Drawing.Point(544, 74);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(531, 23);
            this.OutButton.TabIndex = 10;
            this.OutButton.Text = "Saída";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // InButton
            // 
            this.InButton.Location = new System.Drawing.Point(8, 74);
            this.InButton.Name = "InButton";
            this.InButton.Size = new System.Drawing.Size(530, 23);
            this.InButton.TabIndex = 9;
            this.InButton.Text = "Entrada";
            this.InButton.UseVisualStyleBackColor = true;
            this.InButton.Click += new System.EventHandler(this.InButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndDatePicker);
            this.groupBox1.Controls.Add(this.EndDateCheckbox);
            this.groupBox1.Controls.Add(this.StartDateCheckbox);
            this.groupBox1.Controls.Add(this.StartDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(902, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.CustomFormat = "\"DD/YYYY\"";
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndDatePicker.Location = new System.Drawing.Point(68, 37);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(95, 20);
            this.EndDatePicker.TabIndex = 5;
            this.EndDatePicker.Value = new System.DateTime(2016, 6, 14, 16, 18, 20, 0);
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // EndDateCheckbox
            // 
            this.EndDateCheckbox.AutoSize = true;
            this.EndDateCheckbox.Enabled = false;
            this.EndDateCheckbox.Location = new System.Drawing.Point(6, 39);
            this.EndDateCheckbox.Name = "EndDateCheckbox";
            this.EndDateCheckbox.Size = new System.Drawing.Size(45, 17);
            this.EndDateCheckbox.TabIndex = 4;
            this.EndDateCheckbox.Text = "Fim:";
            this.EndDateCheckbox.UseVisualStyleBackColor = true;
            this.EndDateCheckbox.CheckedChanged += new System.EventHandler(this.EndDateCheckbox_CheckedChanged);
            // 
            // StartDateCheckbox
            // 
            this.StartDateCheckbox.AutoSize = true;
            this.StartDateCheckbox.Location = new System.Drawing.Point(6, 16);
            this.StartDateCheckbox.Name = "StartDateCheckbox";
            this.StartDateCheckbox.Size = new System.Drawing.Size(56, 17);
            this.StartDateCheckbox.TabIndex = 2;
            this.StartDateCheckbox.Text = "Início:";
            this.StartDateCheckbox.UseVisualStyleBackColor = true;
            this.StartDateCheckbox.CheckedChanged += new System.EventHandler(this.StartDateCheckbox_CheckedChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "\"DD/YYYY\"";
            this.StartDatePicker.Enabled = false;
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartDatePicker.Location = new System.Drawing.Point(68, 14);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(95, 20);
            this.StartDatePicker.TabIndex = 1;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // Results
            // 
            this.Results.FormattingEnabled = true;
            this.Results.Location = new System.Drawing.Point(15, 119);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(1081, 407);
            this.Results.TabIndex = 4;
            this.Results.SelectedIndexChanged += new System.EventHandler(this.Results_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(1054, 536);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Imprimir";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 558);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1124, 592);
            this.MinimumSize = new System.Drawing.Size(1124, 592);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Histórico";
            this.Load += new System.EventHandler(this.History_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox EndDateCheckbox;
        private System.Windows.Forms.CheckBox StartDateCheckbox;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.ListBox Results;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button InButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}