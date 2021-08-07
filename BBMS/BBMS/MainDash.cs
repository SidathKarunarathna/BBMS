using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;


namespace BBMS
{
    public partial class MainDash : Form

       
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentchildform;
        public MainDash()
        {
            InitializeComponent();
            OpenChildForm(new ChildForms.Dashboard());
            leftBorderBtn = new Panel();

            leftBorderBtn.Size = new Size(10, 70);
            panelMenue.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(249, 118, 176);
            public static Color color2 = Color.FromArgb(253, 138, 114);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(249, 88, 155);
            public static Color color5 = Color.FromArgb(172,126,241);
            public static Color color6 = Color.FromArgb(24,161,251);

        }
        private void ActiveButton(Object sendBtn, Color color)
        {
            if (sendBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)sendBtn;
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //leftborderbutton
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icontitlebar
                iconcurrent.IconChar = currentBtn.IconChar;
                iconcurrent.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.White; ;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

       private void OpenChildForm(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            desktoppanel.Controls.Add(childform);
            desktoppanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
            TitleText.Text = childform.Text;
        }
     
        private void iconclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBloodStock_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new ChildForms.Blood_Stock());


        }

        private void iconDonorRegistration_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new ChildForms.Donor_Registration());
        }

        private void iconDonors_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new ChildForms.Donors());
        }

        private void iconPendingReq_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new ChildForms.Pending_Requests());
        }

        private void iconDonations_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new ChildForms.Donations());
        }

        private void iconUserRegistration_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new ChildForms.User_Registrations());
        }

        private void iconCampaign_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new ChildForms.Donations_Campaigns());
        }

        private void IconRestLogo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconcurrent.IconChar = IconChar.Hospital;
            iconcurrent.IconColor = Color.Red;
            TitleText.Text = "Dashboard";
            OpenChildForm(new ChildForms.Dashboard());



        }

        private void iconclose_MouseEnter(object sender, EventArgs e)
        {
            iconclose.BackColor = Color.Transparent;
        }

        private void iconclose_MouseLeave(object sender, EventArgs e)
        {
            iconclose.BackColor = Color.Transparent;
        }

        private void iconclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconBloodStock_MouseEnter(object sender, EventArgs e)
        {
            iconBloodStock.BackColor = Color.Transparent;

        }

        private void iconBloodStock_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
    
}
