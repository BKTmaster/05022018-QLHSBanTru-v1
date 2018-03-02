using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class ReceivableDetail_StudentDAO
    {
        QLHSDbContext dt = new QLHSDbContext();
        public bool Insert(ReceivableDetail_Student a)
        {
            ReceivableDetail_Student b = new ReceivableDetail_Student();
            b.ReceivableDetailID = a.ReceivableDetailID;
            b.StudentID = a.StudentID;
            b.Status = a.Status;
            dt.ReceivableDetail_Student.Add(b);
            dt.SaveChanges();
            return true;
        }
        public bool Edit(ReceivableDetail_Student a)
        {
            ReceivableDetail_Student b = dt.ReceivableDetail_Student.Where(t => t.ReceivableDetailID == a.ReceivableDetailID && t.StudentID == a.StudentID).FirstOrDefault();
            b.Status = a.Status;
            dt.SaveChanges();
            return true;
        }
        public bool Remove(ReceivableDetail_Student a)
        {
            ReceivableDetail_Student b = dt.ReceivableDetail_Student.Where(t => t.ReceivableDetailID == a.ReceivableDetailID && t.StudentID == a.StudentID).FirstOrDefault();
            dt.ReceivableDetail_Student.Remove(b);
            dt.SaveChanges();
            return true;
        }
    }
}
