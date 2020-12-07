using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_Form_Submit
{
    public partial class Form3 : Form
    {
        public static string FirstName, LastName, Email, Address, Phone, SecurityAnswer, ZipCode, City;

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstName = firstNametextBox1.Text;
            LastName = lastNametextBox2.Text;
            Email = emailtextBox5.Text;
            Address = addresstextBox10.Text;
            Phone = phonetextBox13.Text;
            SecurityAnswer = textBox8.Text;
            ZipCode = textBox11.Text;
            City = textBox9.Text;
            ShowInformation Info = new ShowInformation();
            Info.Show();
            
        }
    }
}
