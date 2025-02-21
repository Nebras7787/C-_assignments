using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Activity_C__1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name1 = name.Text;
            var password1 = password.Text;
            var email1 = email.Text;
            var Gender = gender.Text;
            var country=birth_place.Text; 
            MessageBox.Show(
                 
                $" name :{name1} \n  password: {password1} \n  email :{email1} \n  gender {Gender} \n coundery {country} "
            ) ; 
            


        }
    }
}
