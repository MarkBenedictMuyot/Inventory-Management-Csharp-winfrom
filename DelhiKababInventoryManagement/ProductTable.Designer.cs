namespace DelhiKababInventoryManagement
{
    partial class ProductTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Number,
            this.Product_Name,
            this.Price,
            this.Category,
            this.Unit,
            this.Supplier});
            this.dataGridView1.Location = new System.Drawing.Point(13, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1137, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Product_Number
            // 
            this.Product_Number.HeaderText = "Product_Number";
            this.Product_Number.MinimumWidth = 9;
            this.Product_Number.Name = "Product_Number";
            this.Product_Number.Width = 175;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.MinimumWidth = 9;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Width = 175;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 9;
            this.Price.Name = "Price";
            this.Price.Width = 175;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 9;
            this.Category.Name = "Category";
            this.Category.Width = 175;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 9;
            this.Unit.Name = "Unit";
            this.Unit.Width = 175;
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.MinimumWidth = 9;
            this.Supplier.Name = "Supplier";
            this.Supplier.Width = 175;
            // 
            // Add
            // 
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Add.Location = new System.Drawing.Point(61, 558);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(131, 40);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit.Location = new System.Drawing.Point(219, 558);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(131, 40);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete.Location = new System.Drawing.Point(385, 558);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(131, 40);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(997, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(1018, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(837, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 35);
            this.textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(567, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 38);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(325, 17);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 38);
            this.comboBox2.TabIndex = 8;
            // 
            // ProductTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 619);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.productgrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Product_Number;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Supplier;
    }
}