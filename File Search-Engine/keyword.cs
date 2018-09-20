using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Search_Engine
{
    public partial class keyword : Form
    {
        string key_name = "";
        functions f;
        DataGridViewComboBoxColumn c = new DataGridViewComboBoxColumn();


        public keyword(string key_name)
        {
            InitializeComponent();
            this.key_name = key_name;
            f = new functions();
            label1.Text = "All files that contains " + key_name;
        }

        private void keyword_Load(object sender, EventArgs e)
        {
            List<KeyValuePair<string, string>> file_and_line = f.get_files_and_line_contain_keywords_by_xml(key_name);
            foreach (KeyValuePair<string, string> file in file_and_line) {
                string[] lines = file.Value.Split(',');
                for (int i = 0; i < lines.Length - 1; i++) c.Items.Add(lines[i]);
                dgv.Rows.Add(file.Key);
            }
                c.HeaderText = "Lines";
                dgv.Columns.Add(c);
        }
    }
}
