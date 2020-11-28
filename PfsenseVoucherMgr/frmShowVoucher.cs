﻿using System;
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
            lblToUser.Text = "Voucher code for: " + ToUser;
            lblCode.Text = VoucherCode;
            lblFromUser.Text = "Generated by: " + FromUser;


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
            
            //Image newImage = Properties.Resources.linux;                                    // get Logo-Image from Ressources
            Image newImage = Properties.Resources.Bubbles_70x400;                                    // get Logo-Image from Ressources
            e.Graphics.DrawImage( newImage, 25, 25, newImage.Width, newImage.Height);       // insert Logo at position 

            //e.Graphics.DrawImage(newImage, 25, 20, 400, 70);                   // insert Logo at position 

            e.Graphics.DrawString("Voucher code for:" ,                        // insert a Text at position    
                                   new Font("Arial",12, FontStyle.Regular), 
                                   Brushes.Black, new Point(25,100) );

            e.Graphics.DrawString(ToUser,                                      // insert a Text at position    
                                  new Font("Arial", 12, FontStyle.Bold),
                                  Brushes.Black, new Point(170, 100));

            e.Graphics.DrawString( VoucherCode,                                // insert a Text at position    
                                   new Font("Arial", 20, FontStyle.Bold),
                                   Brushes.Black, new Point(80, 150));

            e.Graphics.DrawString("Generated by: " + FromUser,                 // insert a Text at position    
                                   new Font("Arial", 12, FontStyle.Regular),
                                   Brushes.Black, new Point(25, 250));

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