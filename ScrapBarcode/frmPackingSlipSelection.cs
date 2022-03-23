using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrapBarcode
{
    public partial class frmPackingSlipSelection : Form
    {
        public frmPackingSlipSelection()
        {
            InitializeComponent();
        }

        private void frmPackingSlipSelection_Load(object sender, EventArgs e)
        {
        }
        

        private void frmPackingSlipSelection_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ActivateMainForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Application.OpenForms.Count;
                if (i > 0)
                {
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.Name == "frmMain")
                        {
                            ((frmMain)form).Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            OpenNextForm();
        }

        private void OpenNextForm()
        {
            this.Hide();
            bool IsFormOpened = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmPackingSlipYes")
                {
                    ((frmPackingSlipYes)form).Show();
                    Program.ChangeLanguage(form);
                    IsFormOpened = true;
                    break;
                }
            }
            if (IsFormOpened == false)
            {
                frmPackingSlipYes frm = new frmPackingSlipYes();
                frm.Show();
                Program.ChangeLanguage(frm);
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool IsFormOpened = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmPackingSlipNo")
                {
                    ((frmPackingSlipNo)form).Show();
                    Program.ChangeLanguage(form);
                    IsFormOpened = true;
                    break;
                }
            }
            if (IsFormOpened == false)
            {
                frmPackingSlipNo frm = new frmPackingSlipNo();
                frm.Show();
                Program.ChangeLanguage(frm);
            }
        }
    }
}
