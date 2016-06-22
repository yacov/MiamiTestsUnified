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

    public class DynamicUsers : BaseWebAiiTest
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
    
        [CodedStep(@"ChooseURL IFSP based on base url")]
        public void ChooseUrl_IFSP()
        {
                        String bbaseUrl = Settings.Current.Web.BaseUrl.ToString();
                        String studentID = Data["STUDENT"].ToString();
                        
                        
                
                String address = "/Plan/Students/ViewStudent?CommonStudentId="+studentID+"&studentViewType=Events&programType=MiamiIFSP";
                 ActiveBrowser.NavigateTo(Settings.Current.Web.BaseUrl+address, true);
            
        }
      
    }
}
