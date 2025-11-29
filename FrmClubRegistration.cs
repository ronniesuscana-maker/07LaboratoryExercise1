using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07LaboratoryExercise
{
    public partial class FrmClubRegistration : Form
    {

        // adds #9 
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private static int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentID;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
          
        }

        // add #10
        public void RefreshListOfClubMembers()
        {

           

        }

        // adds #12 
        public int RegistrationID()
        {
            count++;
            return count;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         

        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

       
       
    }
}
