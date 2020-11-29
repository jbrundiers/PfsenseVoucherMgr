
namespace PfsenseVoucherMgr
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importVoucherCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRequestVoucher = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatLabelDbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.StripStatLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUnusedVouchers = new System.Windows.Forms.Label();
            this.lblRequestHint = new System.Windows.Forms.Label();
            this.tbSpendToUser = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUnusedVouchersNum = new System.Windows.Forms.Label();
            this.StripStatLabelUserVal = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importVoucherCodesToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // importVoucherCodesToolStripMenuItem
            // 
            this.importVoucherCodesToolStripMenuItem.Name = "importVoucherCodesToolStripMenuItem";
            resources.ApplyResources(this.importVoucherCodesToolStripMenuItem, "importVoucherCodesToolStripMenuItem");
            this.importVoucherCodesToolStripMenuItem.Click += new System.EventHandler(this.importVoucherCodesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnRequestVoucher
            // 
            resources.ApplyResources(this.btnRequestVoucher, "btnRequestVoucher");
            this.btnRequestVoucher.Name = "btnRequestVoucher";
            this.btnRequestVoucher.UseVisualStyleBackColor = true;
            this.btnRequestVoucher.Click += new System.EventHandler(this.btnRequestVoucher_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatLabelDbStatus});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // StripStatLabelDbStatus
            // 
            this.StripStatLabelDbStatus.ForeColor = System.Drawing.Color.Maroon;
            this.StripStatLabelDbStatus.Name = "StripStatLabelDbStatus";
            resources.ApplyResources(this.StripStatLabelDbStatus, "StripStatLabelDbStatus");
            // 
            // statusStrip2
            // 
            resources.ApplyResources(this.statusStrip2, "statusStrip2");
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatLabelUser,
            this.StripStatLabelUserVal});
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            // 
            // StripStatLabelUser
            // 
            resources.ApplyResources(this.StripStatLabelUser, "StripStatLabelUser");
            this.StripStatLabelUser.Name = "StripStatLabelUser";
            // 
            // lblUnusedVouchers
            // 
            resources.ApplyResources(this.lblUnusedVouchers, "lblUnusedVouchers");
            this.lblUnusedVouchers.Name = "lblUnusedVouchers";
            // 
            // lblRequestHint
            // 
            resources.ApplyResources(this.lblRequestHint, "lblRequestHint");
            this.lblRequestHint.Name = "lblRequestHint";
            // 
            // tbSpendToUser
            // 
            resources.ApplyResources(this.tbSpendToUser, "tbSpendToUser");
            this.tbSpendToUser.Name = "tbSpendToUser";
            this.tbSpendToUser.TextChanged += new System.EventHandler(this.tbSpendToUser_TextChanged);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblUnusedVouchersNum
            // 
            resources.ApplyResources(this.lblUnusedVouchersNum, "lblUnusedVouchersNum");
            this.lblUnusedVouchersNum.Name = "lblUnusedVouchersNum";
            // 
            // StripStatLabelUserVal
            // 
            this.StripStatLabelUserVal.Name = "StripStatLabelUserVal";
            resources.ApplyResources(this.StripStatLabelUserVal, "StripStatLabelUserVal");
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUnusedVouchersNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbSpendToUser);
            this.Controls.Add(this.lblRequestHint);
            this.Controls.Add(this.lblUnusedVouchers);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnRequestVoucher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importVoucherCodesToolStripMenuItem;
        private System.Windows.Forms.Button btnRequestVoucher;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatLabelDbStatus;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel StripStatLabelUser;
        private System.Windows.Forms.Label lblUnusedVouchers;
        private System.Windows.Forms.Label lblRequestHint;
        private System.Windows.Forms.TextBox tbSpendToUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUnusedVouchersNum;
        private System.Windows.Forms.ToolStripStatusLabel StripStatLabelUserVal;
    }
}

