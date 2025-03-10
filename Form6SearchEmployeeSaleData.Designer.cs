﻿namespace WinFormsApp1
{
    partial class Form6SearchEmployeeSaleData
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
            cboEmployee = new ComboBox();
            label2 = new Label();
            cboCountry = new ComboBox();
            label3 = new Label();
            btnShow = new Button();
            dgvOrder = new DataGridView();
            label4 = new Label();
            dgvDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            label1.Location = new Point(273, 26);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 0;
            label1.Text = "เลือกพนักงานขาย :";
            // 
            // cboEmployee
            // 
            cboEmployee.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            cboEmployee.FormattingEnabled = true;
            cboEmployee.Location = new Point(199, 67);
            cboEmployee.Name = "cboEmployee";
            cboEmployee.Size = new Size(443, 46);
            cboEmployee.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            label2.Location = new Point(814, 26);
            label2.Name = "label2";
            label2.Size = new Size(294, 38);
            label2.TabIndex = 2;
            label2.Text = "เลือกประเทศที่จัดส่ง :";
            // 
            // cboCountry
            // 
            cboCountry.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            cboCountry.FormattingEnabled = true;
            cboCountry.Location = new Point(770, 67);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new Size(437, 46);
            cboCountry.TabIndex = 3;
            cboCountry.SelectedIndexChanged += cboCountry_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            label3.Location = new Point(35, 95);
            label3.Name = "label3";
            label3.Size = new Size(123, 38);
            label3.TabIndex = 4;
            label3.Text = "ใบสั่งซื้อ";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Lime;
            btnShow.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            btnShow.Location = new Point(1305, 23);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(201, 78);
            btnShow.TabIndex = 5;
            btnShow.Text = "แสดงข้อมูล";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // dgvOrder
            // 
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(35, 142);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(1492, 378);
            dgvOrder.TabIndex = 6;
            dgvOrder.CellMouseClick += dgvOrder_CellMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 19.7999973F, FontStyle.Bold);
            label4.Location = new Point(35, 538);
            label4.Name = "label4";
            label4.Size = new Size(189, 38);
            label4.TabIndex = 7;
            label4.Text = "รายการสั่งซื้อ";
            // 
            // dgvDetail
            // 
            dgvDetail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetail.Location = new Point(35, 585);
            dgvDetail.Name = "dgvDetail";
            dgvDetail.RowHeadersWidth = 51;
            dgvDetail.Size = new Size(1492, 258);
            dgvDetail.TabIndex = 8;
            dgvDetail.CellMouseClick += dgvDetail_CellMouseClick;
            // 
            // Form6SearchEmployeeSaleData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1549, 855);
            Controls.Add(dgvDetail);
            Controls.Add(label4);
            Controls.Add(dgvOrder);
            Controls.Add(btnShow);
            Controls.Add(label3);
            Controls.Add(cboCountry);
            Controls.Add(label2);
            Controls.Add(cboEmployee);
            Controls.Add(label1);
            Name = "Form6SearchEmployeeSaleData";
            Text = "ค้นหาข้อมูลการขายของพนักงาน";
            WindowState = FormWindowState.Maximized;
            Load += Form6SearchEmployeeSaleData_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboEmployee;
        private Label label2;
        private ComboBox cboCountry;
        private Label label3;
        private Button btnShow;
        private DataGridView dgvOrder;
        private Label label4;
        private DataGridView dgvDetail;
    }
}