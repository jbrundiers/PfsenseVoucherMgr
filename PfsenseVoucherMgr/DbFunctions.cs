using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PfsenseVoucherMgr
{

     class DbFunctions
     {
        public SqlConnection gSqlConn = null;
        public SqlDataAdapter gSqlAdapter ;

        public void Open(String strConnectString)
        {
            if (String.IsNullOrEmpty(strConnectString))                                             // open standard database
                gSqlConn = new SqlConnection(Properties.Settings.Default.strConnectionString);
            else
                gSqlConn = new SqlConnection(strConnectString);
            
            try
            {
                gSqlConn.Open();
                gSqlAdapter = new SqlDataAdapter();
                
            }
            // Catch other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database open connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void Close()
        {

            if (gSqlConn != null && gSqlConn.State == ConnectionState.Open)
            {
                gSqlConn.Close();
                gSqlConn.Dispose();
            }
        }


        public bool isOpen()
        {
            if (gSqlConn != null && gSqlConn.State == ConnectionState.Open)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Find user in "Users" table
        /// </summary>
        /// <param name="strUsername"></param>
        /// <returns></returns>
        public bool FindUser( String strUsername)
        {
            string sql;
            SqlCommand command;
            int iAffectedRows = 0;

            //sql = "Select Count (*) from Users Where uName = 'name' ";
            sql = "Select Count (*) from Users Where uName = '" + strUsername + "'";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                iAffectedRows = (int) command.ExecuteScalar();
                //gSqlAdapter.InsertCommand = command;
                //iAffectedRows = gSqlAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database find user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();

            if (iAffectedRows > 0)
                return (true);
            else
                return (false);
        }

        public int GetUserID(String strUsername)
        {
            string sql;
            SqlCommand command;
            int iuID = 0;

            //sql = "Select uID from Users Where uName = 'name' ";
            sql = "Select uID from Users Where uName = '" + strUsername + "'";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                iuID = (int)command.ExecuteScalar();
                //gSqlAdapter.InsertCommand = command;
                //iAffectedRows = gSqlAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database get user id", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();

            return iuID;
        }

        public int GetAdminStatus(String strUsername)
        {
            string sql;
            SqlCommand command;
            int uAdminStatus = 0;

            //sql = "Select uAdminStatus from Users Where uName = 'name' ";
            sql = "Select uAdminStatus from Users Where uName = '" + strUsername + "'";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                uAdminStatus = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database get user AdminStatus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();

            return uAdminStatus;
        }


        /// <summary>
        /// Creates a new user in "Users" table
        /// normal user become AdminStatus  = 0   no admin
        /// admin user  become AdminStatus <> 0   is admin
        /// </summary>
        /// <param name="strUsername"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public void InsertUser(String strUsername, int isAdmin = 0 )
        {
            SqlCommand command;
            string sql;
            DateTime now = DateTime.Now;

            // sql :   Insert into Users( uName, uAdminStatus, uCDate ) values( 'name', 1, '2010/12/20 10:25:00' )
            sql = "Insert into Users( uName, uAdminStatus, uCDate ) values( '" + strUsername + "'," + isAdmin + ",'" + now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                gSqlAdapter.InsertCommand = command;
                gSqlAdapter.InsertCommand.ExecuteNonQuery();
            }
            // Catch other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database insert user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
       
        }


        public int GetUserId(string sUser)
        {
            string sql;
            SqlCommand command;
            SqlDataReader datareader = null;
            int iVoucherId = 0;

            // sql = "SELECT [uId],  [uName] FROM Users Where uName = 'sUser' ";
            sql = "SELECT [uId],  [uName] FROM Users Where uName = '" + sUser + "'";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                datareader = command.ExecuteReader();

                datareader.Read();

                iVoucherId = (int)datareader.GetSqlInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database get ID of user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            datareader.Close();
            command.Dispose();

            return iVoucherId;
        }

        /// Creates a new user in "Users" table
        /// </summary>
        /// <param name="strUsername"></param>
        /// <returns></returns>
        public void InsertVoucher(String strCode, int iRole, int iImpUser )
        {
            SqlCommand command;
            string sql;
            DateTime now = DateTime.Now;


            // sql :   Insert into Vouchers( vVoucherCode, vRoll, vImportDate, vImportUser ) values( 'vcode', 3, '1.12.2020', 'user' )
            sql = "Insert into Vouchers( vCode, vRoll, vImportDate, vImportUser ) values( '" + strCode + "'," + iRole + ", '" + now.ToString("yyyy - MM - dd HH: mm: ss") + "'," + iImpUser + ")";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                gSqlAdapter.InsertCommand = command;
                gSqlAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database insert voucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
        }

        public int CountFreeVouchers()
        {
            string sql;
            SqlCommand command;
            int iAffectedRows = 0;

           // sql = "SELECT TOP 10 [vId],[vCode],[vRoll],[vImportDate],[vSpendDate],[vSpendUser],[vSpendToUser] FROM Vouchers Where vSpendDate is NULL";
            sql = "Select Count (*) from Vouchers Where vSpendDate is NUll" ;
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                iAffectedRows = (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database count free vouchers", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();

            return iAffectedRows;
        }

        public int GetOneFreeVoucherId()
        {
            string sql;
            SqlCommand command;
            SqlDataReader datareader = null;
            int iVoucherId = 0;
           
            // sql = "SELECT TOP 1 [vId], [vCode] FROM Vouchers Where vSpendDate is NULL";
            sql = "SELECT TOP 1 [vId],[vCode] from Vouchers Where vSpendDate is NUll";
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                datareader = command.ExecuteReader();

                datareader.Read();

                iVoucherId = (int) datareader.GetSqlInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database get ID of one free voucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            datareader.Close();
            command.Dispose();

            return iVoucherId;
        }

        public String GetVoucherCode(int iVoucherID )
        {
            string sql;
            SqlCommand command;
            SqlDataReader datareader = null;
            
            String sVoucherCode ="";
            // sql = "SELECT [vId], [vCode] FROM Vouchers Where vSpendDate is NULL";
            sql = "SELECT [vCode] from Vouchers Where vId = " + iVoucherID ;
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                datareader = command.ExecuteReader();

                datareader.Read();

                sVoucherCode = datareader.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database get voucher code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
            datareader.Close();

            return sVoucherCode;
        }

        public void UpdateVoucher( int vID, int vSpendUser, String vSpendToUser)
        {
            SqlCommand command;
            string sql = "";
            DateTime now = DateTime.Now;


            // sql :   Update Vouchers set vSpendUser = 4, vSpendToUser = 'firma', vSpendDate = '2020-12-03 18:12:00'  where vId = 212
            
            sql = "Update Vouchers set vSpendUser = " + vSpendUser + ", vSpendToUser = '" + vSpendToUser + "', vSpendDate = '" + now.ToString("yyyy - MM - dd HH: mm: ss") + "' Where vId = " + vID;
                
                
            command = new SqlCommand(sql, gSqlConn);

            try
            {
                gSqlAdapter.UpdateCommand = command;
                gSqlAdapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database update voucher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            command.Dispose();
        }

        public bool CheckForSQLInjection(string userInput)
        {
            bool isSQLInjection = false;

            string[] sqlCheckList = { "--", ";--",  ";",  "/*",  "*/",  "@@",  "@",
                                      "char", "nchar", "varchar", "nvarchar",
                                      "alter", "begin", "cast", "create", "cursor", "declare",
                                      "delete", "drop", "end", "exec", "execute", "fetch",
                                      "insert", "kill", "select", "sys", "sysobjects", "syscolumns",
                                      "table", "update"
                                    };

            string CheckString = userInput.Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((CheckString.IndexOf(sqlCheckList[i], StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    isSQLInjection = true; 
                }
            }

            return isSQLInjection;
        }
    }


}

