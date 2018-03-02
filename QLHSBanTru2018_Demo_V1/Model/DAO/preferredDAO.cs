using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;

namespace Model.DAO
{
    public class preferredDAO
    {
        QLHSDbContext dt = new QLHSDbContext();
        public bool Insert(Preferred a)
        {
            Preferred b = new Preferred();
            b.Name = a.Name;
            b.Status = a.Status;
            dt.Preferreds.Add(b);
            dt.SaveChanges();
            return true;
        }
        public bool Edit(Preferred a)
        {
            Preferred b = dt.Preferreds.Where(t => t.PreferredID == a.PreferredID).FirstOrDefault();
            b.Name = a.Name;
            b.Status = a.Status;
            dt.SaveChanges();
            return true;
        }
        public bool Remove(Preferred a)
        {
            Preferred b = dt.Preferreds.Where(t => t.PreferredID == a.PreferredID).FirstOrDefault();
            dt.Preferreds.Remove(b);
            dt.SaveChanges();
            return true;
        }
    }
}
