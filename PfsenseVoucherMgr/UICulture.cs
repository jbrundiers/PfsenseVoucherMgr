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
using System.Globalization;
using System.Threading;

namespace PfsenseVoucherMgr
{
    class UICulture
    {
        //----------------------------------------------
        //Member Variables
        //----------------------------------------------

        // The array of supported cultures
        // must be updated or changed manually to add or remove cultures
        // private static string[] SupportedCultures = { "en-US", "de-DE", "fr-FR" };

        private static List<String> SupportedCultures = new List<String>(new string[] { "en-US", "de-DE" });

        public List<string> SupportedCulture
        {
            get
            {
                return SupportedCultures;
            }


        }

        private CultureInfo CurrentCulture;





        //----------------------------------------------
        //Public Methods
        //----------------------------------------------

        public UICulture()
        {
            CurrentCulture = Thread.CurrentThread.CurrentUICulture;    // Set the default
        }




        public void LoadAndActivate()
        {
            ReadfromProperties();

            if (CurrentCulture != Thread.CurrentThread.CurrentUICulture)           // Compare does not work ?!!
            {
                // Actually change the culture of the current thread.
                Thread.CurrentThread.CurrentUICulture = CurrentCulture;
            }
        }

        //----------------------------------------------
        //Private Methods
        //----------------------------------------------

        //
        // Load culture settings from properties
        //
        // In the Program-Properties under Settings a strin field "Culture" must exist !
        // to store this information, but it's certainly a .NET way to do it.
        //
        private void ReadfromProperties()
        {
            String CultName = Properties.Settings.Default.Culture;              // read from properties
            if (CultName != "")
            {
                CultureInfo CultInfo = new CultureInfo(CultName);               // get complet culture information
                CurrentCulture = CultInfo;
            }
            else
                CurrentCulture = Thread.CurrentThread.CurrentUICulture;         // Set the default

        }

        //
        // Load culture settings from properties
        //
        // In the Program-Properties under Settings a strin field "Culture" must exist !
        // to store this information, but it's certainly a .NET way to do it.
        //
        private void WriteToProperties()
        {
            Properties.Settings.Default.Culture = CurrentCulture.Name;          // write to properties
            Properties.Settings.Default.Save();
        }




    }
}
