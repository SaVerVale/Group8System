namespace Group8Sytem
{
    partial class Inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridInventory = new DataGridView();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCategory = new TextBox();
            label5 = new Label();
            txtManufacturer = new TextBox();
            label6 = new Label();
            txtSpecifications = new TextBox();
            label7 = new Label();
            txtQuantity = new TextBox();
            label8 = new Label();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnShow = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 46);
            label1.TabIndex = 2;
            label1.Text = "INVENTORY";
            // 
            // dataGridInventory
            // 
            dataGridInventory.AllowUserToAddRows = false;
            dataGridInventory.AllowUserToDeleteRows = false;
            dataGridInventory.BackgroundColor = SystemColors.Control;
            dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventory.Location = new Point(0, 53);
            dataGridInventory.Margin = new Padding(3, 4, 3, 4);
            dataGridInventory.Name = "dataGridInventory";
            dataGridInventory.ReadOnly = true;
            dataGridInventory.RowHeadersWidth = 51;
            dataGridInventory.RowTemplate.Height = 25;
            dataGridInventory.Size = new Size(1098, 566);
            dataGridInventory.TabIndex = 3;
            dataGridInventory.CellClick += dataGridInventoryClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1218, 53);
            label2.Name = "label2";
            label2.Size = new Size(171, 40);
            label2.TabIndex = 4;
            label2.Text = "ADD ITEMS";
            // 
            // txtName
            // 
            txtName.Location = new Point(1274, 141);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 27);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1139, 144);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1139, 363);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(1274, 192);
            txtCategory.Margin = new Padding(3, 4, 3, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(223, 27);
            txtCategory.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1139, 192);
            label5.Name = "label5";
            label5.Size = new Size(77, 24);
            label5.TabIndex = 10;
            label5.Text = "Category";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(1274, 250);
            txtManufacturer.Margin = new Padding(3, 4, 3, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(223, 27);
            txtManufacturer.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1139, 250);
            label6.Name = "label6";
            label6.Size = new Size(107, 24);
            label6.TabIndex = 12;
            label6.Text = "Manufacturer";
            // 
            // txtSpecifications
            // 
            txtSpecifications.Location = new Point(1274, 306);
            txtSpecifications.Margin = new Padding(3, 4, 3, 4);
            txtSpecifications.Name = "txtSpecifications";
            txtSpecifications.Size = new Size(223, 27);
            txtSpecifications.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1137, 309);
            label7.Name = "label7";
            label7.Size = new Size(109, 24);
            label7.TabIndex = 14;
            label7.Text = "Specifications";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1274, 360);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(223, 27);
            txtQuantity.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1139, 417);
            label8.Name = "label8";
            label8.Size = new Size(46, 24);
            label8.TabIndex = 16;
            label8.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1274, 414);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(223, 27);
            txtPrice.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1182, 465);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1411, 465);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1303, 465);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdateClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(912, 627);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSaveClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1012, 627);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelClick;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(1005, 20);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(93, 27);
            btnShow.TabIndex = 23;
            btnShow.Text = "SHOW ALL";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShowAllClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(865, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(133, 27);
            txtSearch.TabIndex = 22;
            txtSearch.TextChanged += txtSearchTextChanged;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShow);
            Controls.Add(txtSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(txtPrice);
            Controls.Add(label7);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtSpecifications);
            Controls.Add(label5);
            Controls.Add(txtManufacturer);
            Controls.Add(label4);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(dataGridInventory);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inventory";
            Size = new Size(1520, 696);
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dataGridInventory;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtCategory;
        private Label label5;
        private TextBox txtManufacturer;
        private Label label6;
        private TextBox txtSpecifications;
        private Label label7;
        private TextBox txtQuantity;
        private Label label8;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnCancel;
        private Button btnShow;
        private TextBox txtSearch;
    }
}
