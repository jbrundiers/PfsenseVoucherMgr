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
    public partial class frmImport : Form
    {

        DbFunctions vDb = new DbFunctions();

        int iUserID = 0;
        int iRoll = 0 ;

        public frmImport()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            vDb.Open("");

            iUserID = vDb.GetUserId(Environment.UserName);

            tbRollNumber.Text = iRoll.ToString();
            tbUserId.Text = iUserID.ToString();
            tbUserId.Enabled = false;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            int iRowCount = 0;

            iRoll = Int32.Parse( tbRollNumber.Text );

            if ( ! String.IsNullOrWhiteSpace( tbImportFilePath.Text ) )
            {
                using (CsvFileReader reader = new CsvFileReader(tbImportFilePath.Text))
                {
                    if (vDb.isOpen())                                           // a connection had been created
                    {
                        CsvRow row = new CsvRow();
                        while (reader.ReadRow(row))
                        {
                            if (row[0][0] == '#')                               // Skip comments in CSV file
                                continue;

                            iRowCount++;
                            foreach (string s in row)                           // loop through the single values of a row
                            {
                                vDb.InsertVoucher(s, iRoll, iUserID);           // To be done: find Roll  
                            }
                        }
                        MessageBox.Show(iRowCount + " vouchers imported", "Voucher import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            vDb.Close();
            this.Close();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog with necessary properties
            OpenFileDialog opFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse for pfsence CSV files",
                DefaultExt = "csv",
                Filter = "CSV files (*.csv)|*.csv",
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };

            if (opFileDialog.ShowDialog() == DialogResult.OK)
                tbImportFilePath.Text = opFileDialog.FileName;
        }

        private void frmImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            vDb.Close();
        }
    }
}
