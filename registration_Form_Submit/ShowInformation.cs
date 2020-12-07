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
    public partial class ShowInformation : Form
    {
        public ShowInformation()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ShowInformation_Load(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            Fnlabel1.Text = Form3.FirstName;
            Lnlabel1.Text = Form3.LastName;
            Addresslabel2.Text= Form3.Address;
            Phonelabel3.Text = Form3.Phone;
            Emaillabel1.Text = Form3.Email;
            Ziplabel4.Text = Form3.ZipCode;

            Citylabel5.Text = Form3.City;
        }
    }
}
