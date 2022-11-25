using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Laboratory_Exercise_2
{
    public partial class Student_Record : Form
    {
        public Student_Record()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmFileName FFN = new FrmFileName();
            FFN.ShowDialog();

            string getStudentNo = tbStudNo.Text;
            string getFirstName = tbFname.Text;
            string getLastName = tbLname.Text;
            string getMiddleInitial = tbMiddlename.Text;
            string getProgram = cbProgram.Text;
            string getGender = tbgender.Text;
            string getAge = tbage.Text;
            string getBirthday = dtpBday.Text;
            string getContact = tbContactno.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student Info:" + getStudentNo);
                outputFile.WriteLine("Fullname: " + getFirstName + " " + getMiddleInitial + "." + " " + getLastName);
                outputFile.WriteLine("Program: " + getProgram);
                outputFile.WriteLine("Gender: " + getGender);
                outputFile.WriteLine("Age: " + getAge);
                outputFile.WriteLine("Birthday: " + getBirthday);
                outputFile.WriteLine("Contact No.: " + getContact);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
