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
    public partial class add_new_file : Form
    {
        public List<string> key_list = new List<string>();
        functions f = new functions();



        public add_new_file()
        {
            InitializeComponent();
        }



        //this function is to refresh the combobox in the add_new_file form that contains the categories to get any changes
        public void get_cat_from_xml()
        {
            if (System.IO.File.Exists("categories.xml"))
            {
                categories_list.Items.Clear();
                //categories_list.Items.Add("Customize..");
                string cat;
                XmlDocument doc = new XmlDocument();
                doc.Load("categories.xml");
                XmlNodeList categories = doc.GetElementsByTagName("cat");
                for (int i = 0; i < categories.Count; i++)
                {
                    cat = categories[i].InnerText;
                    categories_list.Items.Insert(0, cat);
                }
            }
        }


        //this function is to return the  last category just been added to show it as the first element in the combobox
        //as i can't return its name directely i should search for it 
        //public string get_last_cat_from_xml() {
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load("categories.xml");
        //    XmlNodeList list = doc.GetElementsByTagName("cat");
        //    return list[list.Count - 1].InnerText;
        //}

        private void brows_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            var file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = file.OpenFile()) != null)
                        using (stream)
                        {
                            file_path.Text = file.FileName;

                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void add_file_btn_Click(object sender, EventArgs e)
        {
            string path = file_path.Text;
            string cat = categories_list.SelectedItem.ToString();
            var keywords_list=f.get_keywords_from_curr_file_by_text(path);
            f.add_file_to_xml(path, cat, keywords_list);
            Hide();
        }

        private void add_new_file_Load(object sender, EventArgs e)
        {
            get_cat_from_xml(); //call it here to refresh when the form starts
        }

        

             

    }
}

/*
 * the functions that are done...
 *      get_keywords_from_file
 *      add_file_to_xml
*/

/*
 *  functions to be done
 *      
*/