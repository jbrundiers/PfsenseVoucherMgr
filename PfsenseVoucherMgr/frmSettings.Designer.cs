
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Database connect string:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "CSV Delimiter:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(223, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(38, 292);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbDbConnectionString
            // 
            this.tbDbConnectionString.AcceptsReturn = true;
            this.tbDbConnectionString.Location = new System.Drawing.Point(38, 47);
            this.tbDbConnectionString.Name = "tbDbConnectionString";
            this.tbDbConnectionString.Size = new System.Drawing.Size(260, 20);
            this.tbDbConnectionString.TabIndex = 7;
            // 
            // tbCsvDelimiter
            // 
            this.tbCsvDelimiter.Location = new System.Drawing.Point(38, 119);
            this.tbCsvDelimiter.Name = "tbCsvDelimiter";
            this.tbCsvDelimiter.Size = new System.Drawing.Size(100, 20);
            this.tbCsvDelimiter.TabIndex = 15;
            this.tbCsvDelimiter.Text = ";";
            this.tbCsvDelimiter.WordWrap = false;
            // 
            // btnCheckDbConnction
            // 
            this.btnCheckDbConnction.Location = new System.Drawing.Point(38, 74);
            this.btnCheckDbConnction.Name = "btnCheckDbConnction";
            this.btnCheckDbConnction.Size = new System.Drawing.Size(260, 23);
            this.btnCheckDbConnction.TabIndex = 16;
            this.btnCheckDbConnction.Text = "Check Database connection";
            this.btnCheckDbConnction.UseVisualStyleBackColor = true;
            this.btnCheckDbConnction.Click += new System.EventHandler(this.btnCheckDbConnction_Click);
            // 
            // labelCultures
            // 
            this.labelCultures.AutoSize = true;
            this.labelCultures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelCultures.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCultures.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCultures.Location = new System.Drawing.Point(35, 160);
            this.labelCultures.Name = "labelCultures";
            this.labelCultures.Size = new System.Drawing.Size(66, 15);
            this.labelCultures.TabIndex = 25;
            this.labelCultures.Text = "Language:";
            // 
            // listBoxCultures
            // 
            this.listBoxCultures.DisplayMember = "NativeName";
            this.listBoxCultures.FormattingEnabled = true;
            this.listBoxCultures.Location = new System.Drawing.Point(38, 178);
            this.listBoxCultures.Name = "listBoxCultures";
            this.listBoxCultures.Size = new System.Drawing.Size(260, 95);
            this.listBoxCultures.TabIndex = 26;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 318);
            this.Controls.Add(this.listBoxCultures);
            this.Controls.Add(this.labelCultures);
            this.Controls.Add(this.btnCheckDbConnction);
            this.Controls.Add(this.tbCsvDelimiter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbDbConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
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