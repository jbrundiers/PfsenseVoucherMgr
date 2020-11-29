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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace PfsenseVoucherMgr
{
    public partial class frmShowVoucher : Form
    {

        public String VoucherCode { get; set; }
        public String FromUser { get; set; }
        public String ToUser { get; set; }
        
        private PrintDocument prnDoc ;

        public frmShowVoucher()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            prnDoc = new PrintDocument();
            prnDoc.PrintPage += new PrintPageEventHandler(PrnDoc_PrintPage);
        }

        private void frmShowVoucher_Load(object sender, EventArgs e)
        {
            lblToUserValue.Text = ToUser;
            lblCode.Text = VoucherCode;
            lblFromUserValue.Text = FromUser;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //CaptureScreen();
            prnDoc.Print();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PrnDoc_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Create content for the print document

            //e.Graphics.DrawImage(memoryImage, 0, 0);          // Insert the memoryImage created by CaptureScreen()
                                                                
            // Build a new document
            
            Image newImage = Properties.Resources.Bubbles_70x400;                           // get Logo-Image from Ressources
            e.Graphics.DrawImage( newImage, 25, 25, newImage.Width, newImage.Height);       // insert Logo at position 

            e.Graphics.DrawString( Properties.Resources.RES_ID_CodeFor ,        // insert a Text at position    
                                   new Font("Arial",12, FontStyle.Regular), 
                                   Brushes.Black, new Point(25,100) );

            e.Graphics.DrawString(ToUser,                                       // insert a Text at position    
                                  new Font("Arial", 12, FontStyle.Bold),
                                  Brushes.Black, new Point(170, 100));

            e.Graphics.DrawString( VoucherCode,                                 // insert a Text at position    
                                   new Font("Arial", 20, FontStyle.Bold),
                                   Brushes.Black, new Point(80, 150));

            e.Graphics.DrawString(Properties.Resources.RES_ID_CodeGenBy,        // insert a Text at position    
                                   new Font("Arial", 12, FontStyle.Regular),
                                   Brushes.Black, new Point(25, 250));

            e.Graphics.DrawString(FromUser,                                     // insert a Text at position    
                                   new Font("Arial", 12, FontStyle.Regular),
                                   Brushes.Black, new Point(170, 250));

            e.Graphics.DrawRectangle( Pens.Black  , 25, 25, 400, 260);          // insert a rectangle at position    
                                   

        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            //CaptureScreen();
            printDocPreviewDialog.Document = prnDoc;
            printDocPreviewDialog.ShowDialog();


        }

        


        //Bitmap memoryImage;

        //private void CaptureScreen()
        //{
        //    Graphics myGraphics = this.CreateGraphics();
        //    Size s = this.Size;
        //    memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
        //    Graphics memoryGraphics = Graphics.FromImage(memoryImage);
        //    memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        //}
    }
}
