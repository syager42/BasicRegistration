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
    public partial class WaitlistForm : Form
    {
        public Students theStudent;
        public Classes theClass;
        public Waitlist newWaitlist;

        public WaitlistForm()
        {
            InitializeComponent();
        }

        private void buttonDecline_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonJoinWaitlist_Click(object sender, EventArgs e)
        {
            newWaitlist = new Waitlist();

            newWaitlist.Class = theClass;
            newWaitlist.Student = theStudent;
            newWaitlist.ClassID = theClass.ClassID.ToString();
            newWaitlist.StudentID = theStudent.StudentID.ToString();

            RegistrationObject.myRegister.Waitlists.Add(newWaitlist);
            RegistrationObject.myRegister.SaveChanges();

            MessageBox.Show("You have been added to the waitlist");
            this.Close();
        }
    }
}
