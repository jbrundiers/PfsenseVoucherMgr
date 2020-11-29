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
using System.Globalization;

namespace PfsenseVoucherMgr
{
    public partial class frmSettings : Form
    {
        private CultureInfo SelectedCulture;
        private int CultureIndex;

        public frmSettings()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            tbCsvDelimiter.Text = Properties.Settings.Default.charDelimiter;

            tbDbConnectionString.Text = Properties.Settings.Default.strConnectionString;

            // uses the SupportedCultures array
            UICulture Lng = new UICulture();
            List<String> liste = Lng.SupportedCulture;

            String CultName = Properties.Settings.Default.Culture; // read from properties
            CultureInfo CultInfo = new CultureInfo(CultName);
            SelectedCulture = CultInfo;

            foreach (string IetfTag in liste)
            {
                CultureInfo Cult = new CultureInfo(IetfTag);

                // Note: The property listBoxCultures.DisplayName is set to "NativeName" in order to
                //       show language name in its own language.
                listBoxCultures.Items.Add(Cult);
            }

            listBoxCultures.SelectedItem = SelectedCulture;

            CultureIndex = listBoxCultures.SelectedIndex;


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.charDelimiter = tbCsvDelimiter.Text ;

            Properties.Settings.Default.strConnectionString = tbDbConnectionString.Text;

            if (listBoxCultures.SelectedItem != null)
            {
                if (CultureIndex != listBoxCultures.SelectedIndex)
                {
                    SelectedCulture = (CultureInfo)listBoxCultures.SelectedItem;
                    Properties.Settings.Default.Culture = SelectedCulture.Name;

                    MessageBox.Show(this, Properties.Resources.RES_ID_CultureChange, "Pfsense Voucher Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Properties.Settings.Default.Save();

            this.Close();

        }

        private void btnCheckDbConnction_Click(object sender, EventArgs e)
        {
            DbFunctions vDb = new DbFunctions();

            vDb.Open(tbDbConnectionString.Text);

            if ( vDb.isOpen() )
            {
                MessageBox.Show("Connection test successful.", "Check Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vDb.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
