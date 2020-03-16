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

namespace LiuWriteAndReaderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Age=21,Name="黑白红",Sex="女"},
                new Student(){Age=22,Name="白黑",Sex="男"},
                new Student(){Age=23,Name="白红",Sex="女"},
                new Student(){Age=24,Name="净白",Sex="男"}
            };

            StreamWriter sw = new StreamWriter("StuInfo.dat");


            foreach (Student item in students)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr =new StreamReader("StuInfo.dat");
            //新建一个集合存储对象
            List<Student> NewStudents = new List<Student>();
            //声明一个字符串以获取文件中读取的字符串
            string StrStudent = null;

            do
            {
                StrStudent = sr.ReadLine();
                if (StrStudent!=null)
                {
                    NewStudents.Add(Student.ReturnStudent(StrStudent));
                }


            } while (StrStudent!=null);

            listBox1.DisplayMember = "Name";
            listBox1.DataSource = NewStudents;

            sr.Close();

        }
    }
}
