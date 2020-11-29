
namespace PfsenseVoucherMgr
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbDbConnectionString = new System.Windows.Forms.TextBox();
            this.tbCsvDelimiter = new System.Windows.Forms.TextBox();
            this.btnCheckDbConnction = new System.Windows.Forms.Button();
            this.labelCultures = new System.Windows.Forms.Label();
            this.listBoxCultures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbDbConnectionString
            // 
            this.tbDbConnectionString.AcceptsReturn = true;
            resources.ApplyResources(this.tbDbConnectionString, "tbDbConnectionString");
            this.tbDbConnectionString.Name = "tbDbConnectionString";
            // 
            // tbCsvDelimiter
            // 
            resources.ApplyResources(this.tbCsvDelimiter, "tbCsvDelimiter");
            this.tbCsvDelimiter.Name = "tbCsvDelimiter";
            // 
            // btnCheckDbConnction
            // 
            resources.ApplyResources(this.btnCheckDbConnction, "btnCheckDbConnction");
            this.btnCheckDbConnction.Name = "btnCheckDbConnction";
            this.btnCheckDbConnction.UseVisualStyleBackColor = true;
            this.btnCheckDbConnction.Click += new System.EventHandler(this.btnCheckDbConnction_Click);
            // 
            // labelCultures
            // 
            resources.ApplyResources(this.labelCultures, "labelCultures");
            this.labelCultures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCultures.Name = "labelCultures";
            // 
            // listBoxCultures
            // 
            this.listBoxCultures.DisplayMember = "NativeName";
            this.listBoxCultures.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxCultures, "listBoxCultures");
            this.listBoxCultures.Name = "listBoxCultures";
            // 
            // frmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxCultures);
            this.Controls.Add(this.labelCultures);
            this.Controls.Add(this.btnCheckDbConnction);
            this.Controls.Add(this.tbCsvDelimiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbDbConnectionString);
            this.Name = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbDbConnectionString;
        private System.Windows.Forms.TextBox tbCsvDelimiter;
        private System.Windows.Forms.Button btnCheckDbConnction;
        private System.Windows.Forms.Label labelCultures;
        private System.Windows.Forms.ListBox listBoxCultures;
    }
}