# PfsenseVoucherMgr
Import Pfsense Captive Portal CSV files to an SQl Database and create a kind of Self Service for deploying the voucher codes

### Prerequisites
- Database connection with read/write access rights (tested with MS SQL, other DBs should work too)
- pfSense captive portal voucher CSV exports

# Preparation

### 1. Create database tables
create the needed tables with the given scripts: 
   CreateGuestVoucher-Users-Table.sql 
   CreateGuestVoucher-Vouchers-Table.sql

This has to been done with any useable tool for your database. PfsenseVoucherMgr does not support creating a database or table.   

### 2. Configure the database connection for the program
Start PfsenseVoucherMgr.exe and configure the database connection with "File->Settings". Enter a valid database connection string like:
    Data Source=Your-PC\SQLEXPRESS;Initial Catalog=GuestVoucher;Integrated Security=True
 Test if the connction is valid.

### 3. Import the voucher Codes form pfSense
The first user who starts the application will get admin status for the PfsenseVoucherMgr. Only Admin Users can import Voucher codes.
Start PfsenseVoucherMgr.exe and open the Import dialog "File->Import Voucher Codes". Select the CSV file and press "Start import" button.

### 4. Request a Voucher
Everyone who has access to the database can request vouchers, but only the admin can import new vouchers.
Every voucher request is logged in the database with the name of the requester and the request date.



 


