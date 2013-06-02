using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RichalndCountyCheckRegistry
{
    public partial class CountyChecks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChecksMultiView.ActiveViewIndex = 0;
        }

        protected void CountyGridView_Sorting(object sender, GridViewSortEventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<RichalndCountyCheckRegistry.CountyCheck> CountyGridView_GetData()
        {
            CountyChecksDataContext dc = new CountyChecksDataContext();
                IQueryable<CountyCheck> checks = dc.CountyChecks.Where(p => p == p);
                return checks;  
        }
    }
}