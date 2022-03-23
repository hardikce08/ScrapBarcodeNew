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
    public partial class frmPackingSlipYes : Form
    {
        public frmPackingSlipYes()
        {
            InitializeComponent();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
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
        

        private void btnScan_Click(object sender, EventArgs e)
        {
            DialogResult strAnswer;

            if (Program.IsEnglish)
                strAnswer = MessageBox.Show("Are you sure you are ready to scan your document?","Confirm Scan", MessageBoxButtons.YesNo);
            else
                strAnswer = MessageBox.Show("Êtes-vous sûr d'être prêt à numériser votre document ?", "Confirmer", MessageBoxButtons.YesNo);

            if (strAnswer == DialogResult.Yes)
            {
                //FrmBarcodeWait.Show();
                Application.DoEvents();
                RadWebCam.PreviewSnapshots = true;
                RadWebCam.TakeSnapshot();
                RadWebCam.SaveSnapshot();
                //FrmBarcodeWait.Close();
            }
        }

        private void RadWebCam_SnapshotTaken(object sender, Telerik.WinControls.UI.SnapshotTakenEventArgs e)
        {
            Image snapshot = e.Snapshot;
            e.Snapshot.Save(@"D:\\test.jpg");

            System.Threading.Thread.Sleep(1000);
            picCam.Load(@"D:\\sample.jpg");
            picCam.Visible = true;
            RadWebCam.Visible = false;
            DialogResult strAnswer;
            if (Program.IsEnglish)
                strAnswer = MessageBox.Show("Please confirm that the image looks correct and all information is accurate.", "Confirm Scan", MessageBoxButtons.YesNo);
            else
                strAnswer = MessageBox.Show("Veuillez confirmer que l'image semble correcte et que toutes les informations sont exactes?", "Confirmer", MessageBoxButtons.YesNo);

            if (strAnswer == DialogResult.Yes)
            {
                //GetBarCodeInfo();
                RadWebCam.Visible = false;

            }
            else
                picCam.Visible = false;
        }

        private void GetBarCodeInfo()
        {
            long xpos;
            bool bFound;
            DialogResult strAnswer;
            // pic.Image.Save("c:\temp\test.jpg", Imaging.ImageFormat.Jpeg)
            System.Threading.Thread.Sleep(1500);
            bFound = false;

            //using (var reader = new BarCodeReader(@"c:\temp\test.jpg", DecodeType.Code39Standard))
            //{
            //    foreach (var result in reader.ReadBarCodes())
            //    {
            //        Interaction.MsgBox(result.CodeType.ToString() + " " + result.CodeText);
            //        gPurchaseOrderNo = result.CodeType.ToString() + " " + result.CodeText; // Code39Standard E-57343-427-3541474
            //        gPurchaseOrderNo = Mid(gPurchaseOrderNo, 16);
            //        gPurchHiNo = Mid(gPurchaseOrderNo, 1, 1);
            //        gPurchLowNo = Mid(gPurchaseOrderNo, 3, 5);
            //        gPurchRelNo = Mid(gPurchaseOrderNo, 9);
            //        xpos = InStr(gPurchRelNo, "-");
            //        gPackingSlip = Mid(gPurchRelNo, xpos + 1);
            //        gPurchRelNo = Mid(gPurchRelNo, 1, xpos - 1);
            //        bFound = true;
            //        if (CheckWeight() == false)
            //        {
            //            frmLineItem.ShowDialog();
            //            return;
            //        }
            //        else
            //        {
            //            if (bEnglish == true)
            //                Interaction.MsgBox("It appears that you already scanned that packing slip. Please use the new barcoded receipt to scale out.", MsgBoxStyle.Information, "Invalid Scan");
            //            else
            //                Interaction.MsgBox("Il semble que vous ayez déjà scanné ce bordereau d'expédition. Veuillez utiliser le nouveau reçu à code-barres pour effectuer une mise à l'échelle.", MsgBoxStyle.Information, "Analyse non valide");
            //            return;
            //        }
            //    }
            //}
            //// MsgBox(Err.Description)
            //if (bFound == false)
            //{
            //    if (bEnglish == true)
            //        strAnswer = Interaction.MsgBox("No barcode was detected on your packing slip. Do you want to enter the information manually?", MsgBoxStyle.Information, "Confirm");
            //    else
            //        strAnswer = Interaction.MsgBox("Aucun code-barres n'a été détecté sur votre bon de livraison. Voulez-vous saisir les informations manuellement?", MsgBoxStyle.Information, "Confirmer");


            //    if (strAnswer == Constants.vbYes)
            //    {
            //        this.Close();
            //        frmManual.ShowDialog();
            //    }
            //}
        }

        private void frmPackingSlipYes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.ActivateMainForm();
        }
    }
}
