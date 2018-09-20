namespace File_Search_Engine
{
    partial class file_view
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
            this.file_view_box = new System.Windows.Forms.RichTextBox();
            this.keywords_list = new System.Windows.Forms.DataGridView();
            this.keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existing_times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.path_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.keywords_list)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_view_box
            // 
            this.file_view_box.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_view_box.Location = new System.Drawing.Point(4, 48);
            this.file_view_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file_view_box.Name = "file_view_box";
            this.file_view_box.Size = new System.Drawing.Size(643, 484);
            this.file_view_box.TabIndex = 0;
            this.file_view_box.Text = "";
            this.file_view_box.TextChanged += new System.EventHandler(this.file_view_box_TextChanged);
            // 
            // keywords_list
            // 
            this.keywords_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keywords_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyword,
            this.category,
            this.existing_times});
            this.keywords_list.Location = new System.Drawing.Point(667, 133);
            this.keywords_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keywords_list.Name = "keywords_list";
            this.keywords_list.Size = new System.Drawing.Size(460, 400);
            this.keywords_list.TabIndex = 1;
            // 
            // keyword
            // 
            this.keyword.HeaderText = "keyword";
            this.keyword.Name = "keyword";
            this.keyword.ReadOnly = true;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // existing_times
            // 
            this.existing_times.HeaderText = "existing times";
            this.existing_times.Name = "existing_times";
            this.existing_times.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "File content";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "File path";
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.Location = new System.Drawing.Point(101, 30);
            this.path_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(46, 17);
            this.path_lbl.TabIndex = 6;
            this.path_lbl.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.path_lbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(667, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(460, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File info.";
            // 
            // file_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keywords_list);
            this.Controls.Add(this.file_view_box);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "file_view";
            this.Text = "file_view";
            this.Load += new System.EventHandler(this.file_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keywords_list)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox file_view_box;
        private System.Windows.Forms.DataGridView keywords_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn existing_times;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label path_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}