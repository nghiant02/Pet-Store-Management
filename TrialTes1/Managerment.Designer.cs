namespace ATrialTes1
{
    partial class Managerment
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtDec = new TextBox();
            dtpImportDate = new DateTimePicker();
            nudQuantity = new NumericUpDown();
            nudPrice = new NumericUpDown();
            cbGroup = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label8 = new Label();
            dgvList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 108);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(229, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 157);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 23);
            txtName.TabIndex = 2;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(12, 252);
            txtDec.Multiline = true;
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(229, 107);
            txtDec.TabIndex = 4;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Location = new Point(12, 205);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(229, 23);
            dtpImportDate.TabIndex = 5;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(12, 379);
            nudQuantity.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(229, 23);
            nudQuantity.TabIndex = 6;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(12, 422);
            nudPrice.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(229, 23);
            nudPrice.TabIndex = 7;
            // 
            // cbGroup
            // 
            cbGroup.FormattingEnabled = true;
            cbGroup.Location = new Point(13, 464);
            cbGroup.Name = "cbGroup";
            cbGroup.Size = new Size(228, 23);
            cbGroup.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 9;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 139);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Branch Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 187);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 11;
            label3.Text = "Import Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 12;
            label4.Text = "Decription";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 362);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 13;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 405);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 446);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 15;
            label7.Text = "Group";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(378, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(334, 23);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(718, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlText;
            btnAdd.Location = new Point(261, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 100);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLight;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ControlText;
            btnUpdate.Location = new Point(261, 243);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 100);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLight;
            btnDelete.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(261, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 100);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 39);
            label8.Name = "label8";
            label8.Size = new Size(187, 30);
            label8.TabIndex = 21;
            label8.Text = "MANAGERMENT";
            // 
            // dgvList
            // 
            dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(378, 41);
            dgvList.MultiSelect = false;
            dgvList.Name = "dgvList";
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(628, 483);
            dgvList.TabIndex = 22;
            dgvList.CellContentClick += dgvList_CellContentClick;
            // 
            // Managerment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 536);
            Controls.Add(dgvList);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGroup);
            Controls.Add(nudPrice);
            Controls.Add(nudQuantity);
            Controls.Add(dtpImportDate);
            Controls.Add(txtDec);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "Managerment";
            Text = "Managerment";
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDec;
        private DateTimePicker dtpImportDate;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudPrice;
        private ComboBox cbGroup;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label8;
        private DataGridView dgvList;
    }
}