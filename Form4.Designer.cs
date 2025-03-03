namespace WinFormsApp1
{
    partial class Form4
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
            comBox2 = new ComboBox();
            comBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGrid2 = new DataGridView();
            dataGrid1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // comBox2
            // 
            comBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comBox2.FormattingEnabled = true;
            comBox2.Location = new Point(639, 27);
            comBox2.Name = "comBox2";
            comBox2.Size = new Size(298, 28);
            comBox2.TabIndex = 20;
            // 
            // comBox1
            // 
            comBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comBox1.FormattingEnabled = true;
            comBox1.Location = new Point(204, 27);
            comBox1.Name = "comBox1";
            comBox1.Size = new Size(294, 28);
            comBox1.TabIndex = 19;
            comBox1.SelectedIndexChanged += comBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(512, 23);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 18;
            label2.Text = "ประเทศที่จัดส่ง";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 17;
            label1.Text = "ประเทศผู้จัดจำหน่าย";
            // 
            // dataGrid2
            // 
            dataGrid2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid2.Location = new Point(36, 337);
            dataGrid2.Name = "dataGrid2";
            dataGrid2.RowHeadersWidth = 51;
            dataGrid2.Size = new Size(1036, 211);
            dataGrid2.TabIndex = 16;
            dataGrid2.CellMouseClick += dataGrid2_CellMouseClick;
            // 
            // dataGrid1
            // 
            dataGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid1.Location = new Point(36, 86);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.RowHeadersWidth = 51;
            dataGrid1.Size = new Size(1036, 231);
            dataGrid1.TabIndex = 15;
            dataGrid1.CellContentClick += dataGrid1_CellContentClick;
            dataGrid1.CellMouseClick += dataGrid1_CellMouseClick;
            // 
            // button1
            // 
            button1.Location = new Point(944, 14);
            button1.Name = "button1";
            button1.Size = new Size(128, 53);
            button1.TabIndex = 14;
            button1.Text = "แสดง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 558);
            Controls.Add(comBox2);
            Controls.Add(comBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGrid2);
            Controls.Add(dataGrid1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comBox2;
        private ComboBox comBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGrid2;
        private DataGridView dataGrid1;
        private Button button1;
    }
}