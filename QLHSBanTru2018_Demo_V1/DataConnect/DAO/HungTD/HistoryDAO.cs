using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnect.DAO.HungTD;

namespace DataConnect.DAO.HungTD
{
    public class HistoryDAO
    {
        QLHSSmartKidsDataContext db = new QLHSSmartKidsDataContext();
        Table<History> history;
        public void Insert(int employeeID, int functionID, string detail)
        {            
            try
            {
                History obj = new History();
                obj.EmployeeID = employeeID;
                obj.FunctionID = functionID;
                obj.HistoryTime = DateTime.Now;
                obj.Detail = detail;
                obj.Status = true;
                
                history = db.GetTable<History>();
                history.InsertOnSubmit(obj);
                db.SubmitChanges();

            }
            catch
            {

            }
        }
    }
}
