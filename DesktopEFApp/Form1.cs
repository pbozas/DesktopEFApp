using DesktopEFApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopEFApp
{
    public partial class Form1 : Form
    {
        MeContext db;
        public Form1()
        {
            InitializeComponent();
            db = new MeContext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var courses = db.Courses.ToList();
            string content = "";
            foreach (var course in courses)
            {
                content += new StudentsPerCourse(course,course.Students) + "\n";
            }

            MessageBox.Show(content);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var students = db.Students.ToList();
            string content = "";
            foreach (var student in students)
            {
                content += student + "\n";
            }

            MessageBox.Show(content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var courses = db.Courses.ToList();
            string content = "";
            foreach(var course in courses)
            {
                content += course + "\n";
            }


            MessageBox.Show(content);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
