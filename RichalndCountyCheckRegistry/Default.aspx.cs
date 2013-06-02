using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RichalndCountyCheckRegistry
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var db = new CountyChecksDataContext();
            //IQueryable<CountyCheck> checks = db.CountyChecks.Where(P => P.Amount > 0.0);
            //Seed();
        }
        //protected void Seed()
        //{
        //    using (CountyChecksDataContext dc = new CountyChecksDataContext())
        //    {
        //        //GetCountyChecks().ForEach(c => dc.CountyChecks.InsertOnSubmit(c));
        //        foreach (CityCheck check in GetCityChecks())
        //        {
        //            dc.CityChecks.InsertOnSubmit(check);
        //            dc.SubmitChanges();
        //        }
        //        //GetCityChecks().ForEach(d => dc.CityChecks.InsertOnSubmit(d));
        //        //dc.SubmitChanges();
        //    }
        //}

        //private List<CountyCheck> GetCountyChecks()
        //{
        //    List<CountyCheck> checksToAdd = new List<CountyCheck>();
        //    List<string> lines = System.IO.File.ReadAllLines(Server.MapPath("~/Data/richChecks.txt")).ToList();
        //    //List<string> lines = System.IO.File.ReadAllLines(@"C:\data\richChecks.txt").ToList();
        //    foreach (string line in lines)
        //    {
        //        var fields = line.Split(new char[] { ',' });
        //        bool multi_Desc = fields.Count() > 7;

        //        CountyCheck checkToAdd = new CountyCheck();
                
        //        string[] date = fields[0].Split(new char[] { '/' });
        //        checkToAdd.CheckDate = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[0]), Int32.Parse(date[1]));
        //        checkToAdd.Category_CD = fields[1];
        //        checkToAdd.Category = fields[1] == "AP" ? "Accounts Payable" : "Treasurer";
        //        checkToAdd.CheckNumber = Int32.Parse(fields[2]);
        //        checkToAdd.Subsystem = fields[3];
        //        checkToAdd.VenderName = multi_Desc ? fields.Count() > 8 ? fields[4] + "," + fields[5] + "," + fields[6] : fields[4] + "," + fields[5] : fields[4];
        //        checkToAdd.Status_CD = multi_Desc ? fields.Count() > 8 ? fields[7] : fields[6] : fields[5];
        //        checkToAdd.Amount = multi_Desc ? fields.Count() > 8 ? Double.Parse(fields[8]) : Double.Parse(fields[7]) : Double.Parse(fields[6]);
        //        checksToAdd.Add(checkToAdd);
        //    }
        //    return checksToAdd;
        //}




        //private List<CityCheck> GetCityChecks()
        //{
        //    List<CityCheck> checksToAdd = new List<CityCheck>();
        //    List<string> lines = System.IO.File.ReadAllLines(Server.MapPath("~/Data/Columbia.txt")).ToList();
        //    //List<string> lines = System.IO.File.ReadAllLines(@"C:\data\Columbia.txt").ToList();
        //    foreach (string line in lines)
        //    {
        //        var fields = line.Split(new char[] { ',' });
        //        bool multi_Desc = fields.Count() > 6;

        //        CityCheck checkToAdd = new CityCheck();

        //        checkToAdd.PayeeName = multi_Desc ? fields[0] +"," + fields[1]: fields[0];
        //        string[] date = multi_Desc ? fields[2].Split(new char[] { '/' }): fields[1].Split(new char[] { '/' });
        //        checkToAdd.CheckDate = new DateTime(Int32.Parse(date[2]), Int32.Parse(date[0]), Int32.Parse(date[1]));
        //        checkToAdd.Amount = multi_Desc ? Double.Parse(fields[3]): Double.Parse(fields[2]);
        //        checkToAdd.City_Division = multi_Desc ? fields[4]: fields[3];
        //        checkToAdd.Check_Description = multi_Desc ? fields[5]: fields[4];
        //        checkToAdd.Category = multi_Desc ? fields[6] : fields[5];

                

        //        checksToAdd.Add(checkToAdd);
               
        //    }
        //    return checksToAdd;
        //}
    }
}