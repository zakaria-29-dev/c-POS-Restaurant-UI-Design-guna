using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void GunaLinePanel_valid_Paint(object sender, PaintEventArgs e)
        {
            if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
         
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void GunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void GunaShadowPanel1_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }
        }

        private void GunaLinePanel_valid_Click(object sender, EventArgs e)
        {
            if (gunaGradientButton_valid.Visible == false)
            {
                gunaGradientButton_valid.Visible = true;
                gunaLinePanel_valid.Visible = true;
            }
            else
            {
                gunaGradientButton_valid.Visible = false;
                gunaLinePanel_valid.Visible = false;
            }
        }
    }
}
