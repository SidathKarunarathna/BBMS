using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS.ChildForms
{
    public partial class Donor_Registration : Form
    {
        public Donor_Registration()
        {
            InitializeComponent();
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNIC_TextChanged_1(object sender, EventArgs e)
        {
            String nic = txtNIC.Text;

            if(nic.Length==10 ^ nic.Length == 12)
            {
                if(nic.Length == 10)
                {
                    String a = nic.Substring(9);
                    if(a=="v"|| a == "V")
                    {
                        lblmsg.Text = "";
                    }
                    else
                    {
                        lblmsg.Text = "Wrong NIC";
                    }
                }
                else
                {
                    lblmsg.Text = "";
                }
            }
            else
            {
                lblmsg.Text = "Wrong NIC";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker.Value;
            DateTime to = DateTime.Now;
            TimeSpan tspan =(to - from);
            double days = tspan.TotalDays;
            int intAge = Convert.ToInt32(days / 365);

            if(intAge <18 || intAge > 60)
            {
              //  ErrorMessageAge err = new ErrorMessageAge();
              //  err.Show();
                txtAge.Text = "";
            }
            else
            {
                txtAge.Text = intAge.ToString("0");
            }
        }
    }
}
