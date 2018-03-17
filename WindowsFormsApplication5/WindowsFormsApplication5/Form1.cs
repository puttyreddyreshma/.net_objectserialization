using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary12;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox2.Text);
            c.set(s1, s2);
            FileStream fs = File.Create(@"G:\\arith.dat");
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fs, c);
            fs.Close();
            MessageBox.Show("serialized");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = File.OpenRead(@"G:\\arith.dat");
            BinaryFormatter b = new BinaryFormatter();
            Class1 c = (Class1)b.Deserialize(fs);
            int a = c.sum();
            int d = c.product();
            textBox3.Text = a.ToString();
            textBox4.Text = d.ToString();
            fs.Close();
            MessageBox.Show("deserialized");


        }
    }
}
