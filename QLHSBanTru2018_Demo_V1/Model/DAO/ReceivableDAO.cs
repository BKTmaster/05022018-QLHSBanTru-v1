using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ReceivableDAO
    {
        QLHSDbContext dt = new QLHSDbContext();
        public List<Receivable>listReceivable()
        {
            var receivable = dt.Receivables;
            return receivable.ToList();
        }
       public bool insert (Receivable a)
        {
            Receivable b = new Receivable();
            b.Name = a.Name;
            b.TotalPrice = a.TotalPrice;
            b.EndDate = a.EndDate;
            b.StartDate = a.StartDate;
            b.Status = a.Status;
            b.CreatedDate = a.CreatedDate;
            dt.Receivables.Add(b);
            dt.SaveChanges();
            return true;
        }
        public bool Edit(Receivable a)
        {
            Receivable b = dt.Receivables.Where(t => t.ReceivableID == a.ReceivableID).FirstOrDefault();
            b.Name = a.Name;
            b.TotalPrice = a.TotalPrice;
            b.EndDate = a.EndDate;
            b.StartDate = a.StartDate;
            b.Status = a.Status;
            b.CreatedDate = a.CreatedDate;
            dt.SaveChanges();
            return true;
        }
        public bool Remove(Receivable a)
        {
            Receivable b = dt.Receivables.Where(t => t.ReceivableID == a.ReceivableID).FirstOrDefault();
            dt.Receivables.Remove(b);
            dt.SaveChanges();
            return true;
        }
    }
}
