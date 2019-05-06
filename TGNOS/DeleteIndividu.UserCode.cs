﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TGNOS
{
    public partial class DeleteIndividu
    {
    	private TGNOSRepository myRepo = new TGNOSRepository();
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void addRRNr(RepoItemInfo textInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varRRNr' with focus on 'textInfo'.", textInfo);
            this.myRepo.ApplicationUnderTest.OpzoekenIndividuStart.INSZNummer.TextValue =  varRRNr;
        }

    }
}
