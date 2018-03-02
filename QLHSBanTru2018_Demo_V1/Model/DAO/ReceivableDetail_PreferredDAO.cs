using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ReceivableDetail_PreferredDAO
    {
        QLHSDbContext dt = new QLHSDbContext();
        public List<ReceivableDetail_Preferred>ListReceivableDetail()
        {
            var a = dt.ReceivableDetail_Preferred;
            return a.ToList();
        }
        public bool Insert(ReceivableDetail_Preferred a)
        {
            ReceivableDetail_Preferred b = new ReceivableDetail_Preferred();
            b.ReceivableDetailID = a.ReceivableDetailID;
            b.PreferredID = a.PreferredID;
            b.Percent = a.Percent;
            b.Status = a.Status;
            dt.ReceivableDetail_Preferred.Add(b);
            dt.SaveChanges();
            return true;
        }
        public bool Edit(ReceivableDetail_Preferred a)
        {
            ReceivableDetail_Preferred b = dt.ReceivableDetail_Preferred.Where(t => t.ReceivableDetailID == a.ReceivableDetailID && t.PreferredID == a.PreferredID).FirstOrDefault();
            b.Percent = a.Percent;
            b.Status = a.Status;
            dt.SaveChanges();
            return true;
        }
        public bool Remove(ReceivableDetail_Preferred a)
        {
            ReceivableDetail_Preferred b = dt.ReceivableDetail_Preferred.Where(t => t.ReceivableDetailID == a.ReceivableDetailID && t.PreferredID == a.PreferredID).FirstOrDefault();
            dt.ReceivableDetail_Preferred.Remove(b);
            dt.SaveChanges();
            return true;
        }
    }
}
