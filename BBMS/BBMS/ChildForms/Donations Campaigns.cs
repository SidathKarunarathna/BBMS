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
    public partial class Donations_Campaigns : Form
    {
        public Donations_Campaigns()
        {
            InitializeComponent();
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            String nic = txtNIC.Text;

            if (nic.Length == 10 ^ nic.Length == 12)
            {
                if (nic.Length == 10)
                {
                    String a = nic.Substring(9);
                    if (a == "v" || a == "V")
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
    }
}
