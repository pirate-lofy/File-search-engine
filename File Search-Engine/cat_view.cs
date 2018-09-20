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

namespace File_Search_Engine
{
    public partial class cat_view : Form
    {
        string catt;
        List<string> Keywords = new List<string>();
        int counter = 1;
        functions f = new functions();




        public cat_view(string cat)
        {
            InitializeComponent();
            this.catt = cat;
        }


       

        private void cat_view_Load(object sender, EventArgs e)
        {
            Keywords = f.get_keywords_of_cateory_from_xml(catt);
            keys_list.Items.Add(catt);
            for (int i = 0; i < Keywords.Count; i++) {
                keys_list.Items.Add(Keywords[i]);
                List<string> temp = f.get_files_contain_keywords_by_xml(Keywords[i]);//for every keyword in this category, find all files that contain it
                for (int j = 0; j < temp.Count; j++)
                {
                    dgv.Rows.Add(new string[] { counter.ToString(), temp[j], Keywords[i] });
                    counter += 1;
                }
            }
        }

        

       
    }
}


/*
 * function is done
 *      get_keywords_of_cateory_from_xml
 *      get_files_contain_keywords_by_xml
 *      
*/