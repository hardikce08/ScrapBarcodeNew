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
    public partial class frmPackingSlipNo : Form
    {
        OracleDataHelper db = new OracleDataHelper();
        Resizer rs = new Resizer();
        public frmPackingSlipNo()
        {
            InitializeComponent();
        }

        private void frmPackingSlipNo_Load(object sender, EventArgs e)
        {
            cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            LoadSupplier();
            LoadOrigin();
            //rs.FindAllControls(this);

            if (Program.IsEnglish)
            {
                btnClearSelectionFr.Visible = false;
                btnClearScreen.Visible = true;
                btnPreviousScreenFrance.Visible = false;
                btnPreviousScreen.Visible = true;
                btnSubmit.Visible = true;
                btnSubmitInfoFr.Visible = false;
            }
            else
            {
                btnClearSelectionFr.Visible = true;
                btnClearScreen.Visible = false;
                btnPreviousScreenFrance.Visible = true;
                btnPreviousScreen.Visible = false;
                btnSubmitInfoFr.Visible = true;
                btnSubmit.Visible = false;
               
            }
             
        }
        public void LoadSupplier()
        {
            DataTable dt = db.ExecuteStoredProcedureDataTable("Select CMMS_PRD_SUPLR.SUPLR_NAME,  CMMS_PRD_SUPLR.SUPLR_CD||'-'||CMMS_PRD_SUPLR.SUPLR_SUFFIX_CD SupplierValue From CMMS_PRD_SUPLR Group By CMMS_PRD_SUPLR.SUPLR_NAME, CMMS_PRD_SUPLR.SUPLR_CD, CMMS_PRD_SUPLR.SUPLR_SUFFIX_CD Order By CMMS_PRD_SUPLR.SUPLR_NAME", null, CommandType.Text);
            cmbSupplier.DataSource = dt;
            cmbSupplier.ValueMember = "SupplierValue";
            cmbSupplier.DisplayMember = "SUPLR_NAME";
            //cmbSupplier.Columns[1].IsVisible = false;
            //cmbSupplier.Columns[2].IsVisible = false;
            cmbSupplier.Refresh();
        }
        public void LoadOrigin()
        {
            DataTable dt = db.ExecuteStoredProcedureDataTable("SELECT CDTBL_SCRAP_ORIGIN.SHORT_DESC From CDTBL_SCRAP_ORIGIN Group By CDTBL_SCRAP_ORIGIN.SHORT_DESC Order By CDTBL_SCRAP_ORIGIN.SHORT_DESC", null, CommandType.Text);
            cmbOrigin .DataSource = dt;
            cmbOrigin.ValueMember = "SHORT_DESC";
            cmbOrigin.DisplayMember = "SHORT_DESC";
            cmbOrigin.Refresh();
        }
        private void frmPackingSlipNo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ActivateMainForm();
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSupplier_TextChanged(object sender, EventArgs e)
        {
            DataRowView dr = (DataRowView)cmbSupplier.SelectedItem;
            LoadItems(dr[1].ToString().Split('-')[0], dr[1].ToString().Split('-')[1]);
        }

        public void LoadItems(string strCode, string strSuffix)
        {
            string sql = "SELECT CMMS_PRD_SUPLR.SUPLR_NAME,CMMS_PRD_PO.PO_HI_NO||'-'||TO_CHAR(CMMS_PRD_PO.PO_LOW_NO)||'-'||TO_CHAR(CMMS_PRD_PO.RELEASE_NO) SupplierVal,";
            sql = sql + " MASTER_PART_CAT.STOCK_CD, MASTER_PART_CAT.COMDTY_DESC";
            sql = sql + " FROM CMMS_PRD_PO INNER JOIN(MASTER_PART_CAT INNER JOIN CMMS_PRD_SUPLR ON MASTER_PART_CAT.SUPLR_CD = CMMS_PRD_SUPLR.SUPLR_CD) ON CMMS_PRD_PO.SUPLR_CD = CMMS_PRD_SUPLR.SUPLR_CD";
            sql = sql + " GROUP BY CMMS_PRD_SUPLR.SUPLR_NAME, CMMS_PRD_PO.PO_HI_NO||'-'||TO_CHAR(CMMS_PRD_PO.PO_LOW_NO)||'-'||TO_CHAR(CMMS_PRD_PO.RELEASE_NO), MASTER_PART_CAT.STOCK_CD, MASTER_PART_CAT.COMDTY_DESC,";
            sql = sql + " CMMS_PRD_PO.PO_HI_NO, CMMS_PRD_PO.PO_LOW_NO, CMMS_PRD_PO.RELEASE_NO, MASTER_PART_CAT.STOCK_CD, CMMS_PRD_PO.SUPLR_CD, CMMS_PRD_PO.SUPLR_SUFFIX_CD";
            sql = sql + " HAVING(((CMMS_PRD_PO.SUPLR_CD) = '"+ strCode + "') AND ((CMMS_PRD_PO.SUPLR_SUFFIX_CD) = '"+ strSuffix + "'))";

            DataTable dt = db.ExecuteStoredProcedureDataTable(sql, null, CommandType.Text);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
            
        }

        private void btnClearScreen_Click(object sender, EventArgs e)
        {
            cmbSupplier.Text = "";
            cmbOrigin.Text = "";
            txtPackingSlip.Text = "";
            dataGridView1.Refresh();
        }

        private void btnPreviousScreen_Click(object sender, EventArgs e)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void frmPackingSlipNo_Resize(object sender, EventArgs e)
        {
            //rs.ResizeAllControls(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
