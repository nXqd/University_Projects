using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using ktmt_multiple_datasource.models;

namespace ktmt_multiple_datasource
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var students = load_data();
            dataGridView1.DataSource = students;
        }

        private static List<Student> load_data()
        {
            var students = new List<Student>();
            var data = XDocument.Load("./data_source/data_sources.xml");
            var sources = (from c in data.Descendants("source")
                           select new
                           {
                               id = Convert.ToInt32(c.Attribute("id").Value),
                               type = c.Attribute("type").Value,
                               path = c.Value
                           }).ToList();
            foreach (var source in sources)
            {
                var list = Student.get_from(source.type, source.path);
                if (list != null)
                    students.AddRange(list);
            }
            return students;
        }
    }
}
