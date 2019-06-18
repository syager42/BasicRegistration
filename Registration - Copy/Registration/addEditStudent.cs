using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class addEditStudent : Form
    {
        public addEditStudent()
        {
            InitializeComponent();
        }

        public bool addStudent;
        public Students student;

        private void addEditStudent_Load(object sender, EventArgs e)
        {
            if (addStudent)
            {
                this.Text = "Add Student";
            }
            else
            {
                this.Text = "Edit Contact Info";
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox1.Text = student.FirstName;
                textBox2.Text = student.LastName;
                textBox3.Text = student.Email;
                textBox4.Text = student.Phone;
            }
        }

        private void buttonSubmitEdit_Click(object sender, EventArgs e)
        {
            if(addStudent)
            {
                student = new Students();
                int newID;

                student.FirstName = textBox1.Text;
                student.LastName = textBox2.Text;
                student.Email = textBox3.Text;
                student.Phone = textBox4.Text;

                RegistrationObject.myRegister.Students.Add(student);
                RegistrationObject.myRegister.SaveChanges();

                newID = getNewStudentID();
                MessageBox.Show("Your Student ID is: " + newID);

            }
            else
            {
                student.Email = textBox3.Text;
                student.Phone = textBox4.Text;

                RegistrationObject.myRegister.SaveChanges();
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int getNewStudentID()
        {
            int getID = (from eachStudent in RegistrationObject.myRegister.Students
                         orderby eachStudent.StudentID descending
                         select eachStudent.StudentID).First();
            return getID;
        }
    }
}
