
namespace ScrapBarcode
{
    partial class frmPackingSlipNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingSlipNo));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackingSlip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.radKeyboard = new Telerik.WinControls.UI.RadVirtualKeyboard();
            this.btnPreviousScreen = new System.Windows.Forms.Button();
            this.btnClearScreen = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPreviousScreenFrance = new System.Windows.Forms.Button();
            this.btnClearSelectionFr = new System.Windows.Forms.Button();
            this.btnSubmitInfoFr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.DropDownHeight = 150;
            resources.ApplyResources(this.cmbSupplier, "cmbSupplier");
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Sorted = true;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            this.cmbSupplier.TextChanged += new System.EventHandler(this.cmbSupplier_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtPackingSlip
            // 
            resources.ApplyResources(this.txtPackingSlip, "txtPackingSlip");
            this.txtPackingSlip.Name = "txtPackingSlip";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrigin.DropDownHeight = 150;
            resources.ApplyResources(this.cmbOrigin, "cmbOrigin");
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Sorted = true;
            // 
            // radKeyboard
            // 
            resources.ApplyResources(this.radKeyboard, "radKeyboard");
            this.radKeyboard.Name = "radKeyboard";
            this.radKeyboard.TabStop = false;
            // 
            // btnPreviousScreen
            // 
            this.btnPreviousScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.btnPreviousScreen, "btnPreviousScreen");
            this.btnPreviousScreen.ForeColor = System.Drawing.Color.White;
            this.btnPreviousScreen.Image = global::ScrapBarcode.ScrapBarcodeResource.previous_icon_48;
            this.btnPreviousScreen.Name = "btnPreviousScreen";
            this.btnPreviousScreen.UseVisualStyleBackColor = false;
            this.btnPreviousScreen.Click += new System.EventHandler(this.btnPreviousScreen_Click);
            // 
            // btnClearScreen
            // 
            this.btnClearScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.btnClearScreen, "btnClearScreen");
            this.btnClearScreen.ForeColor = System.Drawing.Color.White;
            this.btnClearScreen.Image = global::ScrapBarcode.ScrapBarcodeResource.gui_check_no_48;
            this.btnClearScreen.Name = "btnClearScreen";
            this.btnClearScreen.UseVisualStyleBackColor = false;
            this.btnClearScreen.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = global::ScrapBarcode.ScrapBarcodeResource.play_button_icon_icons_com_53922;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ScrapBarcode.ScrapBarcodeResource.AM_logo;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnPreviousScreenFrance
            // 
            this.btnPreviousScreenFrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnPreviousScreenFrance.ForeColor = System.Drawing.Color.White;
            this.btnPreviousScreenFrance.Image = global::ScrapBarcode.ScrapBarcodeResource.previous_icon_48;
            resources.ApplyResources(this.btnPreviousScreenFrance, "btnPreviousScreenFrance");
            this.btnPreviousScreenFrance.Name = "btnPreviousScreenFrance";
            this.btnPreviousScreenFrance.UseVisualStyleBackColor = false;
            this.btnPreviousScreenFrance.Click += new System.EventHandler(this.btnPreviousScreen_Click);
            // 
            // btnClearSelectionFr
            // 
            this.btnClearSelectionFr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnClearSelectionFr.ForeColor = System.Drawing.Color.White;
            this.btnClearSelectionFr.Image = global::ScrapBarcode.ScrapBarcodeResource.gui_check_no_48;
            resources.ApplyResources(this.btnClearSelectionFr, "btnClearSelectionFr");
            this.btnClearSelectionFr.Name = "btnClearSelectionFr";
            this.btnClearSelectionFr.UseVisualStyleBackColor = false;
            this.btnClearSelectionFr.Click += new System.EventHandler(this.btnClearScreen_Click);
            // 
            // btnSubmitInfoFr
            // 
            this.btnSubmitInfoFr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(90)))), ((int)(((byte)(34)))));
            this.btnSubmitInfoFr.ForeColor = System.Drawing.Color.White;
            this.btnSubmitInfoFr.Image = global::ScrapBarcode.ScrapBarcodeResource.play_button_icon_icons_com_53922;
            resources.ApplyResources(this.btnSubmitInfoFr, "btnSubmitInfoFr");
            this.btnSubmitInfoFr.Name = "btnSubmitInfoFr";
            this.btnSubmitInfoFr.UseVisualStyleBackColor = false;
            this.btnSubmitInfoFr.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // frmPackingSlipNo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPreviousScreenFrance);
            this.Controls.Add(this.btnClearSelectionFr);
            this.Controls.Add(this.btnSubmitInfoFr);
            this.Controls.Add(this.btnPreviousScreen);
            this.Controls.Add(this.btnClearScreen);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.radKeyboard);
            this.Controls.Add(this.cmbOrigin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPackingSlip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPackingSlipNo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPackingSlipNo_FormClosed);
            this.Load += new System.EventHandler(this.frmPackingSlipNo_Load);
            this.Resize += new System.EventHandler(this.frmPackingSlipNo_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPackingSlip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private Telerik.WinControls.UI.RadVirtualKeyboard radKeyboard;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClearScreen;
        private System.Windows.Forms.Button btnPreviousScreen;
        private System.Windows.Forms.Button btnPreviousScreenFrance;
        private System.Windows.Forms.Button btnClearSelectionFr;
        private System.Windows.Forms.Button btnSubmitInfoFr;
        private System.Windows.Forms.Label label1;
    }
}