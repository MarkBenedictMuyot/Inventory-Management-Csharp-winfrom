namespace DelhiKababInventoryManagement
{
    partial class InventoryGuest1
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
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Number,
            this.Product_Name,
            this.Quantity,
            this.Category,
            this.Unit,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 423);
            this.dataGridView1.TabIndex = 0;
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
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 9;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 175;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Expiry Date";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 9;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 175;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(41, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "List Expired Items";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(283, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Expired Items";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(536, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(235, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Low Stock Item";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(979, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // InventoryGuest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 530);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryGuest1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Product_Number;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}