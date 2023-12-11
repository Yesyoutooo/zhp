using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zhp
{
    public partial class NewUserForm : Form
    {

        public NewUserForm()
        {
            InitializeComponent();
        }

        private void txt_OK_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
        private void txt_cim_Validating(object sender, CancelEventArgs e)
        {
            if (Check_If_Empty(txt_cim.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_cim, "a cím nem lehet üres");
            }
        }
        private void txt_cim_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_cim, "");
        }

        private void txt_nyelv_Validating(object sender, CancelEventArgs e)
        {
            if (Check_If_Empty(txt_nyelv.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_cim, "az éneknyelv nem lehet üres");
            }
        }

        private void txt_nyelv_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_nyelv, "");
        }

        private void txt_osbem_Validating(object sender, CancelEventArgs e)
        {
            if (!Check_Date_Year(txt_osbem.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_osbem, "Az ősbemutató évének 4 számból kell állnia");
            }
        }

        private void txt_osbem_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txt_osbem, "");
        }

        private bool Check_If_Empty(string txt)
        {
            return string.IsNullOrEmpty(txt);
        }
        private bool Check_Date_Year(string year_txt)
        {
            Regex r = new Regex("^[0-9]{4}$");
            return r.IsMatch(year_txt);
        }
    }
}
