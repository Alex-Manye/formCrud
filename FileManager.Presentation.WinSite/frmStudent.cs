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
using StudentBs;

namespace FileManager.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            StudentBs student1 = new StudentBs();
            student1.Update(studentId.Text, studentName.Text, lastName.Text, birthDate.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaro la clase // REVISAR
            StudentBs newStudent = new StudentBs();
            string[] lineas = { studentId.Text, studentName.Text, lastName.Text, birthDate.Text };
            using (StreamWriter outputFile = new StreamWriter());
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        { //Delete
            StudentBs student1 = new StudentBll();
            student1.Delete(studentId.Text, studentName.Text, lastName.Text, birthDate.Text);

        }
    }
}
