using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrapBarcode
{
    static class Program
    {
        public static bool IsEnglish = true;
        public static void ChangeLanguage(Form frm)
        {
            string lang = "en";
            ComponentResourceManager resources = new ComponentResourceManager();
            if (!IsEnglish)
            {
                lang = "fr-FR";
            }
            switch (frm.Name)
            {
                case "frmMain":
                    resources = new ComponentResourceManager(typeof(frmMain));
                    break;
                case "frmPackingSlipSelection":
                    resources = new ComponentResourceManager(typeof(frmPackingSlipSelection));
                    break;
                case "frmPackingSlipYes":
                    resources = new ComponentResourceManager(typeof(frmPackingSlipYes));
                    break;
                case "frmPackingSlipNo":
                    resources = new ComponentResourceManager(typeof(frmPackingSlipNo));
                    break;
                default:
                    break;
            }
            foreach (Control c in frm.Controls)
            {
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }
        public static void ActivateMainForm()
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
