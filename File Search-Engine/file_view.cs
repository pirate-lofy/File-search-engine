using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace File_Search_Engine
{
    public partial class file_view : Form
    {
        functions f = new functions();
        List<string> keywords = new List<string>();
        string file_name;



        public file_view(string file_name)
        {
            InitializeComponent();
            this.file_name=file_name;
            keywords = f.get_all_keywords_from_category_xml();
        }


        

        private void file_view_Load(object sender, EventArgs e)
        {
            path_lbl.Text = file_name;
            var stream = new FileStream(file_name, FileMode.Open);
            var reader = new StreamReader(stream);
            char[] seps = { ' ', ',', ';'};
            while (reader.Peek() != -1)
            {
                string text = reader.ReadLine();
                string[] line = text.Split(seps);
                foreach (string word in line)
                    if (keywords.Contains(word)) {
                        int i;
                        for(i=0; i<keywords_list.RowCount; i++)
                            if (keywords_list.Rows[i].Cells[0].Value!=null && keywords_list.Rows[i].Cells[0].Value.ToString() == word)
                            {
                                keywords_list.Rows[i].Cells[2].Value = Convert.ToString(Convert.ToInt32(keywords_list.Rows[i].Cells[2].Value) + 1);
                                break;
                            }
                        if (i == keywords_list.RowCount)
                        {
                            string cat = f.return_cat_of_the_keyword_from_xml(word);
                            keywords_list.Rows.Add(word, cat, "1");
                        }
                    }              
                file_view_box.AppendText(text+'\n');
            }
        }

        private void file_view_box_TextChanged(object sender, EventArgs e)
        {

        }




        //private void keywords_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    foreach (DataGridViewCell cell in keywords_list.SelectedCells)
        //    {
        //        string keyword = cell.Value.ToString();
        //        keyword keyword_obj = new keyword(keyword);
        //        file_view_box.Text += "\n"+keyword;
        //        keyword_obj.Show();
        //    }

        //}


    }
}



/*
 * function is done
 *      return_cat_of_the_keyword_from_xml
 *      
*/