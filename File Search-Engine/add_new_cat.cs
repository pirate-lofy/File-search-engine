using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace File_Search_Engine
{
    public partial class add_new_cat : Form
    {
        add_new_file add_new_file_obj = new add_new_file();
        List<string> key_words = new List<string>();
        string cat_name;
        functions f = new functions();
        

        

        public add_new_cat(int x=0)
        {
            InitializeComponent();
        }

        private void cat_name_txt_MouseClick(object sender, MouseEventArgs e)
        {
            cat_name_txt.Text="";
        }


        private void save_key_btn_Click(object sender, EventArgs e)
        {
            key_words.Add(key_txt.Text);
            cat_names_list.Items.Add(key_txt.Text);
            key_txt.Text = "";
        }

        private void key_txt_MouseClick(object sender, MouseEventArgs e)
        {
            key_txt.Text = "";
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            cat_name = cat_name_txt.Text;
            f.add_cat_to_xml(cat_name, key_words);
            //add_keywords_to_file();
            this.Hide();
        }

        private void add_new_cat_Load(object sender, EventArgs e)
        {

        }
    }
}

/*
 * function is done
 *      add_cat_to_xml
 *      
*/