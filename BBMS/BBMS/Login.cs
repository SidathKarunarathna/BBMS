using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool isMouseDown = false;
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - 400, MousePosition.Y - 20);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (login_username.Text=="User Name")
            {
                login_username.Text= "";
                

            }
            login_username.ForeColor = Color.Red;
            panel1.BackColor = Color.Red;
            pictureBox2.Image = null;
            pictureBox2.Image = BBMS.Properties.Resources.user_red;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login_username_Leave(object sender, EventArgs e)
        {
            if(login_username.Text == "")
            {
                login_username.Text = "User Name";
                login_username.ForeColor = Color.Gray;

            }
            else
            {
                login_username.ForeColor = Color.White;
            }
            panel1.BackColor = Color.White;
            pictureBox2.Image = null;
            pictureBox2.Image = BBMS.Properties.Resources.user_white;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login_password_Enter(object sender, EventArgs e)
        {
            if (login_password.Text == "Password")
            {
                login_password.Text = "";
                

            }
            login_password.ForeColor = Color.Red;
            panel2.BackColor = Color.Red;
            pictureBox3.Image = null;
            pictureBox3.Image = BBMS.Properties.Resources.password_60px;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void login_password_Leave(object sender, EventArgs e)
        {
            if(login_password.Text == "")
            {
                login_password.Text = "Password";
                login_password.ForeColor = Color.Gray;

            }
            else
            {
                login_password.ForeColor = Color.White;
            }
            panel2.BackColor = Color.White;
            pictureBox3.Image = null;
            pictureBox3.Image = BBMS.Properties.Resources.password_60px_white;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            lbl_forgot.ForeColor = Color.Red;
        }

        private void lbl_forgot_MouseLeave(object sender, EventArgs e)
        {
            lbl_forgot.ForeColor = Color.White;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Transparent;
            btn_login.ForeColor = Color.White;

           MainDash obj1 = new MainDash();
            obj1.Show();
            this.Hide();
        }

        private void btn_login_MouseEnter(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.Red;
            btn_login.ForeColor = Color.White;
        }

        private void btn_register_MouseEnter(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.Red;
        }

        private void btn_register_MouseLeave(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.Transparent;
        }
    }
}
