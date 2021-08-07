using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BBMS.ChildForms
{
    public partial class User_Registrations : Form
    {
        public User_Registrations()
        {
            InitializeComponent();
            textpass.PasswordChar = '*';
            textConfirmPass.PasswordChar = '*';
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void iconButton1_MouseEnter(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.Red;
            iconButton1.ForeColor = Color.White;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.BackColor = Color.White;
            iconButton1.ForeColor = Color.Red;
        }
       

        private void iconButton1_Click(object sender, EventArgs e)
        {
           String registerAs ="";
            if (radioButton1.Checked)
            {
                registerAs = "Admin";
            }
            if (radioButton2.Checked)
            {
                registerAs = "Hospital";
            }

            string FullName = textFname.Text;
            string UserName = textUsername.Text;
            String password ="";
            if (textpass.Text.Equals(textConfirmPass.Text))
            {
               password  = Encryption.passwordEncypt(textpass.Text);
            }
            
            string StaffID = textStaffID.Text;
            string NIC = textNic.Text;
            String telphone = textTele.Text;
            string query = $"INSERT INTO `emptbl`(`EmpNIC`, `EmpName`, `EmpUserName`, `EmpPw`, `Register as`, `Staff ID`, `Telephone`) VALUES ('{NIC}','{FullName}','{UserName}','{password}','{registerAs}','{StaffID}','{telphone}')";
            try
            {
                DbConnection.Write(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            


            

            

        }

        private void textNic_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textUsername.Focus();
            }
        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textpass.Focus();
            }
            else if(e.KeyChar==17)
                {
                textFname.Focus();
            }
        }

        private void textpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textConfirmPass.Focus();
            }
            else if (e.KeyChar == 17)
            {
                textUsername.Focus();
            }
        }

        private void textConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textStaffID.Focus();
            }
            else if (e.KeyChar == 17)
            {
                textpass.Focus();
            }
        }

        private void textStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar!=47)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textNic.Focus();
            }
            else if (e.KeyChar == 17)
            {
                textConfirmPass.Focus();
            }
        }

        private void textNic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 || e.KeyChar == 18)
            {
                textTele.Focus();
            }
            else if (e.KeyChar == 17)
            {
                textStaffID.Focus();
            }
        }

        private void textTele_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != 43)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13 )
            {
                iconButton1.PerformClick();
            }
            else if (e.KeyChar == 17)
            {
                textNic.Focus();
            }
        }

        private void textConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            if (textpass.Text == textConfirmPass.Text)
            {
                lblConfirm.Text = "";
                iconButton1.Enabled = true;
            }
            else
            {
                lblConfirm.Text = "Password did not match";
                iconButton1.Enabled = false;
            }
        }

        private void textNic_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textNic_Leave(object sender, EventArgs e)
        {
            String nic = textNic.Text;

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
                        iconButton1.Enabled = false;
                    }
                }
                else
                {
                    lblmsg.Text = "";
                    iconButton1.Enabled = true;
                }
            }
            else
            {
                lblmsg.Text = "Wrong NIC";
                iconButton1.Enabled = false;
            }
        }
    }
    }


