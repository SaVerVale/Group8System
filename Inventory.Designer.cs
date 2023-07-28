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
            btnSearch = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridInventory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 2;
            label1.Text = "INVENTORY";
            // 
            // dataGridInventory
            // 
            dataGridInventory.AllowUserToAddRows = false;
            dataGridInventory.AllowUserToDeleteRows = false;
            dataGridInventory.BackgroundColor = SystemColors.Control;
            dataGridInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInventory.Location = new Point(0, 40);
            dataGridInventory.Name = "dataGridInventory";
            dataGridInventory.ReadOnly = true;
            dataGridInventory.RowHeadersWidth = 51;
            dataGridInventory.RowTemplate.Height = 25;
            dataGridInventory.Size = new Size(946, 375);
            dataGridInventory.TabIndex = 3;
            dataGridInventory.CellClick += dataGridInventoryClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(951, 40);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 4;
            label2.Text = "ADD ITEMS";
            // 
            // txtName
            // 
            txtName.Location = new Point(1066, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(196, 23);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(951, 108);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(952, 272);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(1066, 144);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(196, 23);
            txtCategory.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(951, 144);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 10;
            label5.Text = "Category";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(1066, 188);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(196, 23);
            txtManufacturer.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(951, 190);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Manufacturer";
            // 
            // txtSpecifications
            // 
            txtSpecifications.Location = new Point(1066, 230);
            txtSpecifications.Name = "txtSpecifications";
            txtSpecifications.Size = new Size(196, 23);
            txtSpecifications.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(949, 232);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 14;
            label7.Text = "Specifications";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(1066, 269);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(196, 23);
            txtQuantity.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(951, 313);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 16;
            label8.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1066, 310);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(196, 23);
            txtPrice.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1034, 349);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1115, 349);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1196, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdateClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(757, 421);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSaveClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(860, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancelClick;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(865, 15);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(81, 20);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(744, 15);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 22;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
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
            Name = "Inventory";
            Size = new Size(1296, 447);
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
        private Button btnSearch;
        private TextBox textBox1;
    }
}
