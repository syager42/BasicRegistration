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
    public partial class Form1 : Form
    {
        //RegistrationModelContainer myRegister = new RegistrationModelContainer();
        public Form1()
        {
            InitializeComponent();
        }

        private Students selectedStudent;
        private Classes selectedClass;
        public Registration newRegister;

        private void buttonSearchStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxShowStudent.Text);
                GetStudent(studentID);
                GetClasses(studentID);
            }
            catch (Exception)
            {
                labelErrorStudent.Text = "Student ID must be an integer";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //opens up the addEditStudent form with functionality to add new student
        private void buttonNewStudent_Click(object sender, EventArgs e)
        {
            addEditStudent addEditForm = new addEditStudent();
            addEditForm.addStudent = true;
            DialogResult result = addEditForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedStudent = addEditForm.student;
                textBoxShowStudent.Text = selectedStudent.StudentID.ToString();
                this.DisplayStudent();
            }
        }

        //opens up the addEditStudent form with functionality to edit the current student
        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            
                addEditStudent addEditForm = new addEditStudent();
                addEditForm.addStudent = false;
                addEditForm.student = selectedStudent;
                DialogResult result = addEditForm.ShowDialog();
                if (result == DialogResult.OK || result == DialogResult.Retry)
                {
                    selectedStudent = addEditForm.student;
                    this.DisplayStudent();
                }
                else if (result == DialogResult.Abort)
                {
                    textBoxShowStudent.Text = "";
                    this.ClearControls();
                }
            
            
        }

        //register the selected student for the selected class - or offer to waitlist them
        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            newRegister = new Registration();
            selectedClass = (Classes)comboBoxClasses.SelectedItem;

            if(ClassList(selectedStudent.StudentID).Contains(selectedClass.ClassName))
            {
                labelErrorClass.Text = "Can not register for same class twice";
            }
            else if (checkWaitlist(selectedClass))
            {
                WaitlistForm addToWaitlist = new WaitlistForm();
                addToWaitlist.theStudent = selectedStudent;
                addToWaitlist.theClass = selectedClass;
                DialogResult result = addToWaitlist.ShowDialog();
               
            }
            else
            {

                newRegister.Class = (Classes)comboBoxClasses.SelectedItem;
                newRegister.Student = selectedStudent;
                newRegister.RegisterDate = DateTime.Now.Date.ToString();
                newRegister.ClassID = selectedClass.ClassID.ToString();
                newRegister.StudentID = selectedStudent.StudentID.ToString();

                RegistrationObject.myRegister.Registrations.Add(newRegister);
                RegistrationObject.myRegister.SaveChanges();

                GetClasses(selectedStudent.StudentID);
            }
            
            
        }

        //used to drop classes the student is currently registered for!
        private void buttonDrop_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.CurrentCell = dataGridView1.Rows[selectedRow].Cells[0];

            var toDelete = (from eachReg in RegistrationObject.myRegister.Registrations
                            where eachReg.RegisterID == (Int32)dataGridView1.CurrentCell.Value
                            select eachReg).Single();
            Registration deleteReg = toDelete;
            RegistrationObject.myRegister.Registrations.Remove(deleteReg);

            RegistrationObject.myRegister.SaveChanges();
            GetClasses(selectedStudent.StudentID);
        }

        //this searches for a student by StudentID, then calls a method to display their classes and info
        private void GetStudent(int studentID)
        {
            labelErrorStudent.Text = "";
            labelErrorClass.Text = "";
            try
            {
                selectedStudent = (from eachStudent in RegistrationObject.myRegister.Students
                                       where eachStudent.StudentID == studentID
                                       select eachStudent).First();
                
                DisplayStudent();
                buttonEditStudent.Enabled = true; 
            }
            catch (InvalidOperationException)
            {

                labelErrorStudent.Text = "No student found \nIf new student, please add yourself";
                this.ClearControls();
                textBoxShowStudent.Focus();
            }
        }


        //this populates the data grid with class information for the student currently selected!
        private void GetClasses(int studentID)
        {
            try
            {
                var myClasses = from eachRegister in RegistrationObject.myRegister.Registrations
                                orderby eachRegister.ClassID
                                where eachRegister.Student.StudentID == studentID
                                select new
                                {
                                    eachRegister.RegisterID,
                                    eachRegister.Class.ClassName,
                                    eachRegister.Class.Description,
                                    eachRegister.RegisterDate
                                };
                dataGridView1.DataSource = myClasses.ToList();
            }
            catch (InvalidOperationException)
            {
                this.ClearControls();
                textBoxShowStudent.Focus();
            }
        }

        //this returns a list of class names that a student is currently enrolled in
        private List<String> ClassList(int studentID)
        {
            var myClasses = from eachRegister in RegistrationObject.myRegister.Registrations
                            orderby eachRegister.ClassID
                            where eachRegister.Student.StudentID == studentID
                            select eachRegister.Class.ClassName;

            return myClasses.ToList();
        }

        //this checks the capacity of the selected class vs the amount of students currently in it
        private bool checkWaitlist(Classes newClass)
        {
            
            var classCount = (from eachRegister in RegistrationObject.myRegister.Registrations
                              where eachRegister.Class.ClassID == newClass.ClassID
                              select eachRegister).Count();
            return classCount == Convert.ToInt32(newClass.Capacity);
        }

        //this populates the text boxes with student information
        private void DisplayStudent()
        {
            textBoxFName.Text = selectedStudent.FirstName;
            textBoxLName.Text = selectedStudent.LastName;
            textBoxEmail.Text = selectedStudent.Email;
            textBoxPhone.Text = selectedStudent.Phone;
        }

        //this is for situations where we need to clear the text boxes
        private void ClearControls()
        {
            textBoxShowStudent.Text = "";
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
        }

        //this loads up the combo box with all of the classes currently being offered
        private void LoadClasses()
        {
            var allClasses = from eachClass in RegistrationObject.myRegister.Classes
                             orderby eachClass.ClassName
                             select eachClass;

            comboBoxClasses.DataBindings.Clear();
            comboBoxClasses.DataSource = allClasses.ToList();
            comboBoxClasses.DisplayMember = "ClassName";
            comboBoxClasses.ValueMember = "ClassID";
        }

        //when the form loads, we load the combo box, and set our error messages to blanks
        private void Form1_Load(object sender, EventArgs e)
        {
            labelErrorStudent.Text = "";
            labelErrorClass.Text = "";

            LoadClasses();
        }

        //used to empty the form of all selected information for a fresh start
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearControls();
            dataGridView1.DataSource = null;
        }
    }
}
