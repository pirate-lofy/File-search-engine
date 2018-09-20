using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace File_Search_Engine
{
    class functions
    {
        public functions()
        {
        }


        //return all keywords that have been saved in the seperated categories.xml file
        //all keywords of all catrgories
        public List<string> get_all_keywords_from_category_xml()
        {
            //FileStream stream = new FileStream("keywords", FileMode.Append);
            //var reader = new StreamReader(stream);
            //List<string> list = new List<string>();
            //while(reader.Peek()!=-1)list.Add(reader.ReadLine());
            //
            List<string> list = new List<string>();
            if (System.IO.File.Exists("categories.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("categories.xml");
                XmlNodeList l = doc.GetElementsByTagName("w");
                for (int i = 0; i < l.Count; i++) list.Add(l[i].InnerText);
            }
            
            return list;
        }



        //return all keywords that appeared in the file 
        public List<KeyValuePair<string, string>> get_keywords_from_curr_file_by_text(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            List<string> list = get_all_keywords_from_category_xml();// gets all keywords to check if any word in the file is a previous saved keyword
            List<KeyValuePair<string, string>> new_keywords_list = new List<KeyValuePair<string, string>>();// the finale keywords list
            //a temporary list that saved every word 
            //and a vector of all lines that it has appeared into
            List<KeyValuePair<string, List<int>>> temp = new List<KeyValuePair<string, List<int>>>();
            for (int i = 1; reader.Peek() != -1; i++)
            {
                string line = reader.ReadLine();
                string[] words = line.Split(new char[] { ' ', ',', '-' });// just prepare every line in the file to be checked
                bool k = false;
                //comparring every word in the line with all old keywords 
                foreach (string nw in words)
                    foreach (string ow in list)
                    {
                        k = false;
                        if (nw == ow)
                        {
                            //search if this keyword has appeared in the temp list before
                            foreach (var j in temp)
                                if (j.Key == nw)
                                {
                                    //if it apearred and has been already  saved, just push the new line number to its vector
                                    j.Value.Add(i);
                                    k = true; //just to not do the next few lines if it existes
                                }
                            //if it doesn't  exist in the list, push it 
                            if (k == false)
                            {
                                var l = new List<int>();
                                l.Add(i);
                                var t = new KeyValuePair<string, List<int>>(nw, l);
                                temp.Add(t);
                            }

                        }
                    }
                //convert the vector of lines into a string
                foreach (var el in temp)
                {
                    string new_lines = "";
                    foreach (int ll in el.Value)
                    {
                        new_lines += (ll.ToString() + ",");
                    }
                    new_keywords_list.Add(new KeyValuePair<string, string>(el.Key, new_lines));
                }
            }
            return new_keywords_list;
        }



        public void add_file_to_xml(string path, string cat, List<KeyValuePair<string, string>> keyword_line)
        {
            if (!System.IO.File.Exists("files.xml"))
            {
                XmlWriter writer = XmlWriter.Create("files.xml");
                XmlDocument doc = new XmlDocument();
                writer.WriteStartDocument();
                writer.WriteStartElement("files");  //1
                writer.WriteStartElement("file");   //2
                writer.WriteStartElement("path");   //3
                writer.WriteString(path);
                writer.WriteEndElement();           //-3
                writer.WriteStartElement("category");//4
                writer.WriteString(cat);
                writer.WriteEndElement();            //-4
                if (keyword_line.Count != 0) {
                    writer.WriteStartElement("keywords");//5
                    for (int i = 0; i < keyword_line.Count; i++)
                    {
                        writer.WriteStartElement("word");//6
                        writer.WriteStartElement("w");  //7
                        writer.WriteString(keyword_line[i].Key);
                        writer.WriteEndElement();       //-7
                        writer.WriteStartElement("lines");//8
                        writer.WriteString(keyword_line[i].Value);
                        writer.WriteEndElement();         //8
                        writer.WriteEndElement();          //-6
                    }
                    writer.WriteEndElement();
                }               //5
                writer.WriteEndElement();               //-2
                writer.WriteEndElement();               //-1
                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("files.xml");
                XmlElement file = doc.CreateElement("file");
                var locaation = doc.CreateElement("path");
                locaation.InnerText = path;
                var caty = doc.CreateElement("category");
                caty.InnerText = cat;
                file.AppendChild(locaation);
                file.AppendChild(caty);
                var keywords = doc.CreateElement("keywords");
                for (int i = 0; i < keyword_line.Count; i++)
                {
                    var word = doc.CreateElement("word");
                    var w = doc.CreateElement("w");
                    w.InnerText = keyword_line[i].Key;
                    var line = doc.CreateElement("lines");
                    line.InnerText = keyword_line[i].Value;
                    word.AppendChild(w);
                    word.AppendChild(line);
                    keywords.AppendChild(word);
                }
                file.AppendChild(keywords);
                var root = doc.DocumentElement;
                root.AppendChild(file);
                doc.Save("files.xml");
            }
        }


        



        //returns keywords under a specifiec category
        public List<string> get_keywords_of_cateory_from_xml(string cat)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("categories.xml");
            List<string> temp = new List<string>();
            XmlNodeList list = doc.GetElementsByTagName("category");
            foreach (XmlElement c in list)
                if (c.ChildNodes[0].InnerText == cat)
                {
                    XmlNodeList kws = c.ChildNodes[1].ChildNodes;
                    foreach (XmlElement ee in kws) temp.Add(ee.InnerText);
                }
            return temp;
        }



        //search in files.xml to find all files that contain a specifiec keyword
        public List<string> get_files_contain_keywords_by_xml(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("files.xml");
            List<string> temp = new List<string>();
            XmlNodeList files_list = doc.GetElementsByTagName("file");
            foreach (XmlElement f in files_list)
            {
                XmlNodeList words = f.ChildNodes[2].ChildNodes;
                foreach (XmlElement w in words)
                    if (w.ChildNodes[0].InnerText == key) temp.Add(f.ChildNodes[0].InnerText);

            }
            return temp;
        }



        //search in files.xml to find all files that contain a specifiec keyword and line number of every word
        public List<KeyValuePair<string,string>> get_files_and_line_contain_keywords_by_xml(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("files.xml");
            List<KeyValuePair<string, string>> temp = new List<KeyValuePair<string, string>>();
            XmlNodeList files_list = doc.GetElementsByTagName("file");
            foreach (XmlElement ff in files_list)
            {
                XmlNodeList words = ff.ChildNodes[2].ChildNodes;
                foreach (XmlElement w in words)
                    if (w.ChildNodes[0].InnerText == key) 
                        temp.Add(new KeyValuePair<string,string>(ff.ChildNodes[0].InnerText,w.ChildNodes[1].InnerText));
            }
            return temp;
        }




        //find what is the category of the current keyword
        //checks the categories.xml file
        public string return_cat_of_the_keyword_from_xml(string keyword)
        {
            XmlDocument doc = new XmlDocument();
            string cat = "";
            doc.Load("categories.xml");
            XmlNodeList list = doc.GetElementsByTagName("category");
            foreach (XmlElement c in list)
            {
                XmlNodeList temp = c.ChildNodes[1].ChildNodes;
                foreach (XmlElement t in temp)
                    if (t.InnerText == keyword) cat = c.ChildNodes[0].InnerText;
            }
            return cat;
        }




        //public void add_keywords_to_file() {
        //    FileStream stream = new FileStream("keywords", FileMode.Append);
        //    var writer = new StreamWriter(stream);
        //    foreach (string word in key_words) writer.WriteLine(word);
        //    stream.Close();
        //}




        public void add_cat_to_xml(string cat_name, List<string> key_words)
        {
            if (System.IO.File.Exists("categories.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("categories.xml");
                XmlElement category = doc.CreateElement("category");
                XmlElement cat = doc.CreateElement("cat");
                cat.InnerText = cat_name;
                XmlElement keywords = doc.CreateElement("keywords");
                foreach (var word in key_words)
                {
                    XmlElement kw = doc.CreateElement("w");
                    kw.InnerText = word;
                    keywords.AppendChild(kw);
                }
                category.AppendChild(cat);
                category.AppendChild(keywords);
                XmlElement root = doc.DocumentElement;
                root.AppendChild(category);
                doc.Save("categories.xml");
            }
            else
            {
                XmlWriter writer = XmlWriter.Create("categories.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("categories");
                writer.WriteStartElement("category");
                writer.WriteStartElement("cat");
                writer.WriteString(cat_name);
                writer.WriteEndElement();
                writer.WriteStartElement("keywords");
                foreach (var word in key_words)
                {
                    writer.WriteStartElement("kw");
                    writer.WriteString(word);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }


    }
}
