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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            tbCsvDelimiter.Text = Properties.Settings.Default.charDelimiter;

            tbDbConnectionString.Text = Properties.Settings.Default.strConnectionString;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.charDelimiter = tbCsvDelimiter.Text ;

            Properties.Settings.Default.strConnectionString = tbDbConnectionString.Text;

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
    }
}
