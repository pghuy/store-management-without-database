
namespace store_management_without_database
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCategoryNotice = new System.Windows.Forms.Label();
            this.cbBoxCategory = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbCompany = new System.Windows.Forms.TextBox();
            this.tbEDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.starLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteSearch = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioBtnCategory = new System.Windows.Forms.RadioButton();
            this.radioBtnItem = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phần Mềm Quản Lí Cửa Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCategoryNotice);
            this.panel1.Controls.Add(this.cbBoxCategory);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbCode);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbYear);
            this.panel1.Controls.Add(this.tbCompany);
            this.panel1.Controls.Add(this.tbEDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.starLabel);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 142);
            this.panel1.TabIndex = 0;
            // 
            // labelCategoryNotice
            // 
            this.labelCategoryNotice.AutoSize = true;
            this.labelCategoryNotice.Location = new System.Drawing.Point(0, 9);
            this.labelCategoryNotice.Name = "labelCategoryNotice";
            this.labelCategoryNotice.Size = new System.Drawing.Size(0, 25);
            this.labelCategoryNotice.TabIndex = 10;
            // 
            // cbBoxCategory
            // 
            this.cbBoxCategory.FormattingEnabled = true;
            this.cbBoxCategory.Location = new System.Drawing.Point(119, 1);
            this.cbBoxCategory.Name = "cbBoxCategory";
            this.cbBoxCategory.Size = new System.Drawing.Size(208, 33);
            this.cbBoxCategory.TabIndex = 0;
            this.cbBoxCategory.SelectedValueChanged += new System.EventHandler(this.cbBoxCategory_SelectedValueChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(208, 31);
            this.tbName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên Hàng:";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(119, 47);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(208, 31);
            this.tbCode.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã hàng:";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(517, 91);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(209, 31);
            this.tbYear.TabIndex = 5;
            // 
            // tbCompany
            // 
            this.tbCompany.Location = new System.Drawing.Point(517, 47);
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(209, 31);
            this.tbCompany.TabIndex = 4;
            // 
            // tbEDate
            // 
            this.tbEDate.Location = new System.Drawing.Point(517, 3);
            this.tbEDate.Name = "tbEDate";
            this.tbEDate.Size = new System.Drawing.Size(209, 31);
            this.tbEDate.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Năm sản xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Công ty sản xuất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hạn dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Loại hàng:";
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.Location = new System.Drawing.Point(323, 4);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(30, 25);
            this.starLabel.TabIndex = 11;
            this.starLabel.Text = "(*)";
            this.starLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.noteSearch);
            this.panel2.Controls.Add(this.dataGridViewItems);
            this.panel2.Controls.Add(this.radioBtnCategory);
            this.panel2.Controls.Add(this.radioBtnItem);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnModify);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(12, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 474);
            this.panel2.TabIndex = 1;
            // 
            // noteSearch
            // 
            this.noteSearch.AutoSize = true;
            this.noteSearch.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.noteSearch.Location = new System.Drawing.Point(26, 155);
            this.noteSearch.Name = "noteSearch";
            this.noteSearch.Size = new System.Drawing.Size(0, 19);
            this.noteSearch.TabIndex = 7;
            // 
            // dataGridViewItems
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewItems.Location = new System.Drawing.Point(26, 194);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersWidth = 62;
            this.dataGridViewItems.RowTemplate.Height = 33;
            this.dataGridViewItems.Size = new System.Drawing.Size(698, 258);
            this.dataGridViewItems.TabIndex = 3;
            this.dataGridViewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "category";
            this.Column1.HeaderText = "Loại hàng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 115;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "code";
            this.Column2.HeaderText = "Mã hàng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "name";
            this.Column3.HeaderText = "Tên hàng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "date";
            this.Column4.HeaderText = "Hạn dùng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.DataPropertyName = "company";
            this.Column5.HeaderText = "Công ty sàn xuất";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 115;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "year";
            this.Column6.HeaderText = "Năm sx";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 90;
            // 
            // radioBtnCategory
            // 
            this.radioBtnCategory.AutoSize = true;
            this.radioBtnCategory.Location = new System.Drawing.Point(272, 16);
            this.radioBtnCategory.Name = "radioBtnCategory";
            this.radioBtnCategory.Size = new System.Drawing.Size(114, 29);
            this.radioBtnCategory.TabIndex = 1;
            this.radioBtnCategory.TabStop = true;
            this.radioBtnCategory.Text = "Loại hàng";
            this.radioBtnCategory.UseVisualStyleBackColor = true;
            this.radioBtnCategory.CheckedChanged += new System.EventHandler(this.radioBtnCategory_CheckedChanged);
            // 
            // radioBtnItem
            // 
            this.radioBtnItem.AutoSize = true;
            this.radioBtnItem.Location = new System.Drawing.Point(153, 16);
            this.radioBtnItem.Name = "radioBtnItem";
            this.radioBtnItem.Size = new System.Drawing.Size(113, 29);
            this.radioBtnItem.TabIndex = 0;
            this.radioBtnItem.TabStop = true;
            this.radioBtnItem.Text = "Mặt hàng";
            this.radioBtnItem.UseVisualStyleBackColor = true;
            this.radioBtnItem.CheckedChanged += new System.EventHandler(this.radioBtnItem_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Thao tác trên:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(27, 117);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(457, 31);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(503, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(503, 58);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(222, 39);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Sửa";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(263, 58);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(222, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(222, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(274, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "21880053 - Phạm Gia Huy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 746);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbCompany;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TextBox tbEDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioBtnCategory;
        private System.Windows.Forms.RadioButton radioBtnItem;
        private System.Windows.Forms.ComboBox cbBoxCategory;
        private System.Windows.Forms.Label noteSearch;
        private System.Windows.Forms.Label labelCategoryNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Label label9;
    }
}

