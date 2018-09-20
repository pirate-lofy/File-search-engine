namespace File_Search_Engine
{
    partial class add_new_cat
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
            this.save_key_btn = new System.Windows.Forms.Button();
            this.done_btn = new System.Windows.Forms.Button();
            this.cat_name_txt = new System.Windows.Forms.TextBox();
            this.key_txt = new System.Windows.Forms.TextBox();
            this.cat_names_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // save_key_btn
            // 
            this.save_key_btn.Location = new System.Drawing.Point(238, 92);
            this.save_key_btn.Name = "save_key_btn";
            this.save_key_btn.Size = new System.Drawing.Size(104, 23);
            this.save_key_btn.TabIndex = 0;
            this.save_key_btn.Text = "Add keyword";
            this.save_key_btn.UseVisualStyleBackColor = true;
            this.save_key_btn.Click += new System.EventHandler(this.save_key_btn_Click);
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(258, 175);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(75, 23);
            this.done_btn.TabIndex = 1;
            this.done_btn.Text = "Done!";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // cat_name_txt
            // 
            this.cat_name_txt.Location = new System.Drawing.Point(155, 12);
            this.cat_name_txt.Name = "cat_name_txt";
            this.cat_name_txt.Size = new System.Drawing.Size(187, 22);
            this.cat_name_txt.TabIndex = 2;
            this.cat_name_txt.Text = "Type category name..";
            this.cat_name_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cat_name_txt_MouseClick);
            // 
            // key_txt
            // 
            this.key_txt.Location = new System.Drawing.Point(155, 66);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(187, 22);
            this.key_txt.TabIndex = 3;
            this.key_txt.Text = "type keyword..";
            this.key_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.key_txt_MouseClick);
            // 
            // cat_names_list
            // 
            this.cat_names_list.FormattingEnabled = true;
            this.cat_names_list.ItemHeight = 16;
            this.cat_names_list.Location = new System.Drawing.Point(7, 12);
            this.cat_names_list.Name = "cat_names_list";
            this.cat_names_list.Size = new System.Drawing.Size(142, 180);
            this.cat_names_list.TabIndex = 4;
            // 
            // add_new_cat
            // 
            this.ClientSize = new System.Drawing.Size(345, 208);
            this.Controls.Add(this.cat_names_list);
            this.Controls.Add(this.key_txt);
            this.Controls.Add(this.cat_name_txt);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.save_key_btn);
            this.Name = "add_new_cat";
            this.Load += new System.EventHandler(this.add_new_cat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save_key_btn;
        private System.Windows.Forms.Button done_btn;
        private System.Windows.Forms.TextBox cat_name_txt;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.ListBox cat_names_list;
    }
}