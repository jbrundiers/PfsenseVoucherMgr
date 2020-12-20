//------------------------------------------------------------------------------------------------
//
//	PfsenseVoucherMgr
//
//	Copyright (C) 2020 Soft-Toolware. All Rights Reserved
//
//	The software is a free software.
//	It is distributed under the Code Project Open License (CPOL 1.02)
//	agreement. The full text of the CPOL is given in:
//	https://www.codeproject.com/info/cpol10.aspx
//	
//	The main points of CPOL 1.02 subject to the terms of the License are:
//
//	Source Code and Executable Files can be used in commercial applications;
//	Source Code and Executable Files can be redistributed; and
//	Source Code can be modified to create derivative works.
//	No claim of suitability, guarantee, or any warranty whatsoever is
//	provided. The software is provided "as-is".
//	
//
//------------------------------------------------------------------------------------------------

using ReadWriteCsv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PfsenseVoucherMgr
{
    

    public partial class frmMain : Form
    {
        public String gUserName;
        public int gUserId;

        DbFunctions vDb = new DbFunctions();

        public frmMain()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate window
            frmAbout dlg = new frmAbout();

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate window
            frmSettings dlg = new frmSettings();

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();

            frmMain_Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importVoucherCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instantiate window
            frmImport dlg = new frmImport();

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();

            frmMain_Refresh();

        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain_Refresh();
         
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                vDb.Close();
                
            }
            // Catch other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database close connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRequestVoucher_Click(object sender, EventArgs e)
        {
            int iVoucherId;
            String sVoucherCode;

            if (String.IsNullOrWhiteSpace(tbSpendToUser.Text) || tbSpendToUser.Text.Length < 10)
            {
                MessageBox.Show(this, Properties.Resources.RES_ID_MinChar, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (vDb.CheckForSQLInjection(tbSpendToUser.Text) )
            {
                MessageBox.Show(this, Properties.Resources.RES_ID_SqlWords, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // get one free Voucher code
                iVoucherId = vDb.GetOneFreeVoucherId();
                sVoucherCode = vDb.GetVoucherCode(iVoucherId);

                // Mark this as used
                vDb.UpdateVoucher(iVoucherId, gUserId, tbSpendToUser.Text);

                //MessageBox.Show("Voucher Code for " + tbSpendToUser.Text + "\n" + sVoucherCode + "\n" + "Requested by: " + gUserName );

                // Instantiate form frmShowVoucher
                frmShowVoucher dlg = new frmShowVoucher();

                dlg.VoucherCode = sVoucherCode;
                dlg.FromUser = gUserName; 
                dlg.ToUser = tbSpendToUser.Text;

                // Show window modally
                dlg.ShowDialog();


            }
            UpdateUnusedVoucherHint();
        }

        private void tbSpendToUser_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbSpendToUser.Text))
                btnRequestVoucher.Enabled = true;
            else
                btnRequestVoucher.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateUnusedVoucherHint()
        {
            int iUnusedVouchers;

            iUnusedVouchers = vDb.CountFreeVouchers();
            
            if (iUnusedVouchers < 1)
                lblUnusedVouchers.ForeColor = Color.Red;
            else
                lblUnusedVouchers.ForeColor = default(Color);

            lblUnusedVouchersNum.Text = "" + iUnusedVouchers;

        }

        private void frmMain_Refresh()
        {
            //gUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            gUserName = Environment.UserName;

            vDb.Open(Properties.Settings.Default.strConnectionString);

            if (vDb.isOpen())                                                   // a connection had been created
            {
                StripStatLabelDbStatus.Text = "Database: opened";
                StripStatLabelDbStatus.ForeColor = Color.Green;

                if (vDb.CountUser() == 0 )                          // if no user exists in database
                {
                    vDb.InsertUser(gUserName, 1);                   // create admin user 
                } 
                else if (!vDb.FindUser(gUserName))                  // if user does not exist in database
                {
                    vDb.InsertUser(gUserName);                      // create a user 
                }

                gUserId = vDb.GetUserId(gUserName);

                //StripStatLabelUserVal.Text = gUserName + "(" + gUserId + ")";
                StripStatLabelUserVal.Text = gUserName ;

                if (vDb.GetAdminStatus(gUserName) > 0)               // only admin can import
                    importVoucherCodesToolStripMenuItem.Enabled = true;
                else
                    importVoucherCodesToolStripMenuItem.Enabled = false;

                if (String.IsNullOrWhiteSpace(tbSpendToUser.Text))
                    btnRequestVoucher.Enabled = false;

                UpdateUnusedVoucherHint();                                      // show # unused vouchers
            }
            else                                                                // no database connection
            {
                StripStatLabelDbStatus.Text = "Database: closed";               // show hint
                StripStatLabelDbStatus.ForeColor = Color.Red;

                btnRequestVoucher.Enabled = false;                              // disable some functions
                tbSpendToUser.Enabled = false;
                importVoucherCodesToolStripMenuItem.Enabled = false;
            }
        }
    }
}
