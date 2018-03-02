using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
   public class ReceivableDetailDAO
    {
        QLHSDbContext dt = new QLHSDbContext();
        public List<ReceivableDetail> ListReceivableDetail()
        {
            var a = dt.ReceivableDetails;
            return a.ToList();
        }
        public bool Insetr(ReceivableDetail a)
        {
            ReceivableDetail b = new ReceivableDetail();
            //b.ReceivableDetailID = a.ReceivableDetailID;
            b.ReceivableID = a.ReceivableID;
            b.Name = a.Name;
            b.Price = a.Price;
            b.SalePrice = a.SalePrice;
            b.Status = a.Status;
            dt.ReceivableDetails.Add(b);
            dt.SaveChanges();
            return true;
        }
        public bool Edit(ReceivableDetail a)
        {
            ReceivableDetail b = dt.ReceivableDetails.Where(t => t.ReceivableDetailID == a.ReceivableDetailID).FirstOrDefault();
            b.ReceivableID = a.ReceivableID;
            b.Name = a.Name;
            b.Price = a.Price;
            b.SalePrice = a.SalePrice;
            b.Status = a.Status;
            dt.SaveChanges();
            return true;
        }
        public bool Remove(ReceivableDetail a)
        {
            ReceivableDetail b = dt.ReceivableDetails.Where(t => t.ReceivableDetailID == a.ReceivableDetailID).FirstOrDefault();
            dt.ReceivableDetails.Remove(b);
            dt.SaveChanges();
            return true;
        }
    }
}
