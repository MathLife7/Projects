namespace WindowsFormsApplication1
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nUD_RmvQtd = new System.Windows.Forms.NumericUpDown();
            this.txt_Setor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_RtProduto = new System.Windows.Forms.ComboBox();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.btn_AddEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RmvQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Retirar Produto";
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(109, 177);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 6;
            this.Btn_Remove.Text = "Retirar";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Funcionário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produto:";
            // 
            // nUD_RmvQtd
            // 
            this.nUD_RmvQtd.Cursor = System.Windows.Forms.Cursors.Default;
            this.nUD_RmvQtd.Location = new System.Drawing.Point(91, 84);
            this.nUD_RmvQtd.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nUD_RmvQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_RmvQtd.Name = "nUD_RmvQtd";
            this.nUD_RmvQtd.Size = new System.Drawing.Size(181, 20);
            this.nUD_RmvQtd.TabIndex = 11;
            this.nUD_RmvQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_Setor
            // 
            this.txt_Setor.Location = new System.Drawing.Point(91, 136);
            this.txt_Setor.Name = "txt_Setor";
            this.txt_Setor.ReadOnly = true;
            this.txt_Setor.Size = new System.Drawing.Size(181, 20);
            this.txt_Setor.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Setor:";
            // 
            // cB_RtProduto
            // 
            this.cB_RtProduto.BackColor = System.Drawing.SystemColors.Window;
            this.cB_RtProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_RtProduto.FormattingEnabled = true;
            this.cB_RtProduto.Location = new System.Drawing.Point(91, 57);
            this.cB_RtProduto.Name = "cB_RtProduto";
            this.cB_RtProduto.Size = new System.Drawing.Size(181, 21);
            this.cB_RtProduto.TabIndex = 18;
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeesComboBox.Location = new System.Drawing.Point(91, 109);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(151, 21);
            this.EmployeesComboBox.TabIndex = 19;
            this.EmployeesComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeesComboBox_SelectedIndexChanged);
            // 
            // btn_AddEmp
            // 
            this.btn_AddEmp.Location = new System.Drawing.Point(246, 109);
            this.btn_AddEmp.Name = "btn_AddEmp";
            this.btn_AddEmp.Size = new System.Drawing.Size(26, 21);
            this.btn_AddEmp.TabIndex = 20;
            this.btn_AddEmp.Text = "+";
            this.btn_AddEmp.UseVisualStyleBackColor = true;
            this.btn_AddEmp.Click += new System.EventHandler(this.btn_AddEmp_Click);
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.btn_AddEmp);
            this.Controls.Add(this.EmployeesComboBox);
            this.Controls.Add(this.cB_RtProduto);
            this.Controls.Add(this.txt_Setor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUD_RmvQtd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Remove);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 249);
            this.MinimumSize = new System.Drawing.Size(300, 249);
            this.Name = "Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Almoxarifado CPII ©";
            this.Load += new System.EventHandler(this.Remove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_RmvQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUD_RmvQtd;
        private System.Windows.Forms.TextBox txt_Setor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_RtProduto;
        private System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.Button btn_AddEmp;
    }
}