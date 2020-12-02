namespace PfsenseVoucherMgr
{
    partial class frmShowVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowVoucher));
            this.lblCode = new System.Windows.Forms.Label();
            this.lblToUser = new System.Windows.Forms.Label();
            this.lblFromUser = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.printDocPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.lblToUserValue = new System.Windows.Forms.Label();
            this.lblFromUserValue = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            resources.ApplyResources(this.lblCode, "lblCode");
            this.lblCode.Name = "lblCode";
            // 
            // lblToUser
            // 
            resources.ApplyResources(this.lblToUser, "lblToUser");
            this.lblToUser.Name = "lblToUser";
            // 
            // lblFromUser
            // 
            resources.ApplyResources(this.lblFromUser, "lblFromUser");
            this.lblFromUser.Name = "lblFromUser";
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPrintPreview
            // 
            resources.ApplyResources(this.btnPrintPreview, "btnPrintPreview");
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // printDocPreviewDialog
            // 
            resources.ApplyResources(this.printDocPreviewDialog, "printDocPreviewDialog");
            this.printDocPreviewDialog.Name = "printDocPreviewDialog";
            // 
            // lblToUserValue
            // 
            resources.ApplyResources(this.lblToUserValue, "lblToUserValue");
            this.lblToUserValue.Name = "lblToUserValue";
            // 
            // lblFromUserValue
            // 
            resources.ApplyResources(this.lblFromUserValue, "lblFromUserValue");
            this.lblFromUserValue.Name = "lblFromUserValue";
            // 
            // btnClipboard
            // 
            resources.ApplyResources(this.btnClipboard, "btnClipboard");
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // frmShowVoucher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClipboard);
            this.Controls.Add(this.lblFromUserValue);
            this.Controls.Add(this.lblToUserValue);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblFromUser);
            this.Controls.Add(this.lblToUser);
            this.Controls.Add(this.lblCode);
            this.Name = "frmShowVoucher";
            this.Load += new System.EventHandler(this.frmShowVoucher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblToUser;
        private System.Windows.Forms.Label lblFromUser;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.PrintPreviewDialog printDocPreviewDialog;
        private System.Windows.Forms.Label lblToUserValue;
        private System.Windows.Forms.Label lblFromUserValue;
        private System.Windows.Forms.Button btnClipboard;
    }
}