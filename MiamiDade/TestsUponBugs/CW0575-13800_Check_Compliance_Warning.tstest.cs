using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace MiamiDade
{

    public class CW0575_13800_Check_Compliance_Warning : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void CW057513800_Check_Compliance_Warning_CodedStep()
        {
             object myData = GetExtractedValue("S");
            string fullname = Convert.ToString(myData);
            Log.WriteLine("Student Full Name is "+fullname);
            string[] name = fullname.Split(',');
            string FirstName = name[1];
            FirstName = FirstName.Trim();
            string LastName = name[0];
            SetExtractedValue("StudentFirstName", FirstName);
            Log.WriteLine("Student First Name is "+FirstName);
            SetExtractedValue("StudentLastName", LastName);
            Log.WriteLine("Student Last Name is "+LastName);

        }
    }
}
