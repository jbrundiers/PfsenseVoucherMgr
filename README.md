# PfsenseVoucherMgr
Import Pfsense Captive Portal CSV files to an SQl Database.
Self Service for deploying voucher codes

### Prerequisites
- Database connection with read/write access rights 
- pfSense captive portal voucher CSV exports

# Preparation

### 1. Create database tables
create the needed tables with the given scripts (CreateGuestVoucher-Users-Table.sql and CreateGuestVoucher-Vouchers-Table.sql)
start the program and configure the database connection with File->Settings.


