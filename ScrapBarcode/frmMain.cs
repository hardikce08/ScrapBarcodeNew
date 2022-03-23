using ScarpBarcode.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrapBarcode
{
    public partial class frmMain : Form
    {
        //public bool IsEnglish { get; set; }
        OracleDataHelper db = new OracleDataHelper();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable dt = db.ExecuteStoredProcedureDataTable("select * FROM PO_LINE_REV$", null, CommandType.Text);
            //dataGridView1.DataSource = dt;
            //foreach (Control control in this.Controls)
            //{
            //    // #2
            //    MdiClient client = control as MdiClient;
            //    if (!(client == null))
            //    {
            //        // #3
            //        client.BackColor = Color.White;
            //        // 4#
            //        break;
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Program.IsEnglish = true;
            OpenNextForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.IsEnglish = false;
            OpenNextForm();
        }
        private void OpenNextForm()
        {
            this.Hide();
            bool IsFormOpened = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmPackingSlipSelection")
                {
                    ((frmPackingSlipSelection)form).Show();
                    Program.ChangeLanguage(form);
                    IsFormOpened = true;
                    break;
                }
            }
            if (IsFormOpened == false)
            {
                frmPackingSlipSelection frm = new frmPackingSlipSelection();
                Program.ChangeLanguage(frm);
                frm.ShowDialog();
              
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
