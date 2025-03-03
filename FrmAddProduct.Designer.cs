namespace WinFormsApp1
{
    partial class FrmAddProduct
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
            label1 = new Label();
            label2 = new Label();
            txtPname = new TextBox();
            txtPrice = new TextBox();
            btnInsert = new Button();
            dgvProduct = new DataGridView();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 0;
            label1.Text = "ชื่อสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 112);
            label2.Name = "label2";
            label2.Size = new Size(68, 31);
            label2.TabIndex = 1;
            label2.Text = "ราคา";
            // 
            // txtPname
            // 
            txtPname.BorderStyle = BorderStyle.FixedSingle;
            txtPname.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            txtPname.Location = new Point(147, 24);
            txtPname.Margin = new Padding(3, 2, 3, 2);
            txtPname.Name = "txtPname";
            txtPname.Size = new Size(742, 37);
            txtPname.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            txtPrice.Location = new Point(147, 112);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(742, 37);
            txtPrice.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Lime;
            btnInsert.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(917, 17);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(129, 72);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "เพิ่มข้อมูล";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvProduct
            // 
            dgvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(35, 169);
            dgvProduct.Margin = new Padding(3, 2, 3, 2);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1011, 331);
            dgvProduct.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 192, 0);
            btnClear.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(917, 93);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 72);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 521);
            Controls.Add(btnClear);
            Controls.Add(dgvProduct);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtPname);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            WindowState = FormWindowState.Maximized;
            Load += FrmAddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPname;
        private TextBox txtPrice;
        private Button btnInsert;
        private DataGridView dgvProduct;
        private Button btnClear;
    }
}