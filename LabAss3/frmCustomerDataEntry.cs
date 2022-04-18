using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAss3
{
    public partial class frmCustomerDataEntry : Form
    {
        public frmCustomerDataEntry()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string Gender, Hobby, Status = "";
            if (radioMale.Checked) 
                Gender = "Male";
            else 
                Gender = "Female";
            if (chkReading.Checked) 
                Hobby = "Reading";
            else 
                Hobby = "Painting";
            if (radioMamied.Checked) 
                Status = "Mamied";
            else 
                Status = "Unmamied";
          
            try
            {
                CustomerValidation objVal=new CustomerValidation();
                objVal.CheckCustomerName(txtCustomerName.Text);

                frmCustomerPreview objPreview = new frmCustomerPreview();
                objPreview.SetValues(txtCustomerName.Text,cmbCountry.Text,Gender,Hobby,Status);
                objPreview.Show();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
