
namespace ScrapBarcode
{
    partial class frmPackingSlipYes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingSlipYes));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RadWebCam = new Telerik.WinControls.UI.RadWebCam();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadWebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::ScrapBarcode.ScrapBarcodeResource.previous_icon_48;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.btnScan, "btnScan");
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Image = global::ScrapBarcode.ScrapBarcodeResource.barcode_48;
            this.btnScan.Name = "btnScan";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // picCam
            // 
            resources.ApplyResources(this.picCam, "picCam");
            this.picCam.Name = "picCam";
            this.picCam.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ScrapBarcode.ScrapBarcodeResource.AM_logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // RadWebCam
            // 
            resources.ApplyResources(this.RadWebCam, "RadWebCam");
            this.RadWebCam.Name = "RadWebCam";
            this.RadWebCam.SnapshotTaken += new System.EventHandler<Telerik.WinControls.UI.SnapshotTakenEventArgs>(this.RadWebCam_SnapshotTaken);
            ((Telerik.WinControls.UI.RadWebCamElement)(this.RadWebCam.GetChildAt(1))).AutoSize = false;
            ((Telerik.WinControls.UI.RadWebCamElement)(this.RadWebCam.GetChildAt(1))).StretchHorizontally = false;
            ((Telerik.WinControls.UI.RadWebCamElement)(this.RadWebCam.GetChildAt(1))).StretchVertically = false;
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(1).GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText");
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(1).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(1).GetChildAt(3))).ToolTipText = resources.GetString("resource.ToolTipText1");
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(1).GetChildAt(3))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(2).GetChildAt(0))).ToolTipText = resources.GetString("resource.ToolTipText2");
            ((Telerik.WinControls.UI.RadButtonElement)(this.RadWebCam.GetChildAt(1).GetChildAt(2).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // frmPackingSlipYes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RadWebCam);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPackingSlipYes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPackingSlipYes_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadWebCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnPrevious;
        private Telerik.WinControls.UI.RadWebCam RadWebCam;
    }
}