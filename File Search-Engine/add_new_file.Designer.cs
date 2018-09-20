namespace File_Search_Engine
{
    partial class add_new_file
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
            this.components = new System.ComponentModel.Container();
            this.brows = new System.Windows.Forms.Button();
            this.file_path = new System.Windows.Forms.TextBox();
            this.categories_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_file_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // brows
            // 
            this.brows.Location = new System.Drawing.Point(383, 28);
            this.brows.Name = "brows";
            this.brows.Size = new System.Drawing.Size(75, 23);
            this.brows.TabIndex = 0;
            this.brows.Text = "Browse..";
            this.brows.UseVisualStyleBackColor = true;
            this.brows.Click += new System.EventHandler(this.brows_Click);
            // 
            // file_path
            // 
            this.file_path.Location = new System.Drawing.Point(15, 30);
            this.file_path.Name = "file_path";
            this.file_path.Size = new System.Drawing.Size(362, 20);
            this.file_path.TabIndex = 1;
            // 
            // categories_list
            // 
            this.categories_list.FormattingEnabled = true;
            this.categories_list.Location = new System.Drawing.Point(15, 87);
            this.categories_list.Name = "categories_list";
            this.categories_list.Size = new System.Drawing.Size(175, 21);
            this.categories_list.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "categories";
            // 
            // add_file_btn
            // 
            this.add_file_btn.Location = new System.Drawing.Point(328, 87);
            this.add_file_btn.Name = "add_file_btn";
            this.add_file_btn.Size = new System.Drawing.Size(130, 23);
            this.add_file_btn.TabIndex = 5;
            this.add_file_btn.Text = "Add file";
            this.add_file_btn.UseVisualStyleBackColor = true;
            this.add_file_btn.Click += new System.EventHandler(this.add_file_btn_Click);
            // 
            // add_new_file
            // 
            this.ClientSize = new System.Drawing.Size(470, 119);
            this.Controls.Add(this.add_file_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categories_list);
            this.Controls.Add(this.file_path);
            this.Controls.Add(this.brows);
            this.Name = "add_new_file";
            this.Load += new System.EventHandler(this.add_new_file_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brows;
        private System.Windows.Forms.TextBox file_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_file_btn;
        public System.Windows.Forms.ComboBox categories_list;
        private System.Windows.Forms.Timer timer1;
    }
}