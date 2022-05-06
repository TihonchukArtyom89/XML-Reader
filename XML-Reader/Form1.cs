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

namespace XML_Reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReceiveWorkers();
        }
        private void ReceiveWorkers()
        {
            XmlDocument xml_doc = new XmlDocument();
            string xml_path = "F:\\Downloads\\MEGA\\XMLFile-source.xml";
            xml_doc.Load(xml_path);
            foreach(XmlNode node in xml_doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                NameWorker.Items.Add(new Worker(name,age,programmer));
            }
        }
    }
}
