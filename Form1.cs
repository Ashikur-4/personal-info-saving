using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalInfo
{
    public partial class Form1 : Form
    {
        Person aPerson = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void Savebutton_Click(object sender, EventArgs e)
        {
            

            aPerson.firstname = FirstNametextbox.Text;
            aPerson.lastname = LastNametextbox.Text;
            aPerson.MotherName = MotherNameTextbox.Text;
            aPerson.fathername = FatherNametextbox.Text;
            aPerson.address = Addresstextbox.Text;

            MessageBox.Show("Your information saved sucessfully.....");

            clear();
            
            

            
        }

        private void AllinformationButton_Click(object sender, EventArgs e)
        {
            clear();
            FirstNametextbox.Text = aPerson.firstname;
            LastNametextbox.Text = aPerson.lastname;
            FatherNametextbox.Text = aPerson.fathername;
            MotherNameTextbox.Text = aPerson.MotherName;
            Addresstextbox.Text = aPerson.address;





        }

        private void Namebutton_Click(object sender, EventArgs e)
        {
            clear();
            FirstNametextbox.Text = aPerson.firstname;
            LastNametextbox.Text = aPerson.lastname;
            
        }

        private void parentNamebutton_Click(object sender, EventArgs e)
        {
            clear();
            FatherNametextbox.Text = aPerson.fathername;
            MotherNameTextbox.Text = aPerson.MotherName;


        }

        private void addressbutton_Click(object sender, EventArgs e)
        {
            clear();

            Addresstextbox.Text = aPerson.address;


        }

        private void clear()
        {
            FirstNametextbox.Clear();
            LastNametextbox.Clear();
            FatherNametextbox.Clear();
            MotherNameTextbox.Clear();
            Addresstextbox.Clear();
        }
    }
}
