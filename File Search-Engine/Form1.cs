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
    public partial class Form1 : Form
    {
        //file_view file_view_obj;

        string name;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            //refresh_keys_dgv();
            timer3.Start();
        }


        void refresh_keys_dgv() {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var ANF = new add_new_file();
            ANF.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            files_GR.Rows.Clear();
            if (System.IO.File.Exists("files.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("files.xml");
                XmlNodeList files = doc.GetElementsByTagName("file");
                for (int i = 0; i < files.Count; i++)
                {
                    XmlNodeList children = files[i].ChildNodes;
                    string path = children[0].InnerText;
                    string cat = children[1].InnerText;
                    files_GR.Rows.Add(new string[] { (i + 1).ToString(), path, cat });
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(System.IO.File.Exists("categories.xml")){
                dcv2.Rows.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("categories.xml");
                XmlNodeList words = doc.GetElementsByTagName("category");
                for(int i=0; i<words.Count; i++){
                    XmlNodeList ch = words[i].ChildNodes;
                    string name = ch[0].InnerText;
                    string no = ch[1].ChildNodes.Count.ToString();
                    dcv2.Rows.Add(new string []{(i+1).ToString(),name,no});
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            add_new_cat add_new_cat_obj = new add_new_cat();
            add_new_cat_obj.Show();
        }

        
        private void files_GR_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in files_GR.SelectedCells)
            {
                name = cell.Value.ToString();
                file_view file_view_obj = new file_view(name);
                file_view_obj.Show();
            }
        }

        private void dcv2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dcv2.SelectedCells)
            {
                name = cell.Value.ToString();
                cat_view cat_view_obj = new cat_view(name);
                cat_view_obj.Show();
            }
        }

        private void dgv3_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dgv3.SelectedCells)
            {
                string keyword = cell.Value.ToString();
                keyword keyword_obj = new keyword(keyword);
                keyword_obj.Show();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("categories.xml"))
            {
                dgv3.Rows.Clear();
                count = 1;
                dgv3.Rows.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("categories.xml");
                XmlNodeList cats = doc.GetElementsByTagName("category");
                foreach (XmlElement c in cats)
                {
                    XmlNodeList ch = c.ChildNodes;
                    string name_of_cat = ch[0].InnerText;
                    XmlNodeList keys = ch[1].ChildNodes;
                    List<string> l = new List<string>();
                    foreach (XmlElement ll in keys) l.Add(ll.InnerText);
                    foreach (string s in l)
                    {
                        dgv3.Rows.Add(new string[] { count.ToString(), s, name_of_cat });
                        count += 1;
                    }
                }
            }
        }
    }
}



/*
 * function is done
 *      
 *      
*/