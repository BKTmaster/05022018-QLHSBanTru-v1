using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.HungTD
{
    public class LocationDAO
    {
        QLHSSmartKidsDataContext db;
        public LocationDAO()
        {
            db = new QLHSSmartKidsDataContext();
        }
        public List<Location> ListAllProvince()
        {
            Table<Location> provinceTable = db.GetTable<Location>();
            var province = from p in provinceTable
                           where (p.Status.Equals(true) && p.LocationParent.Equals(0))
                           orderby p.LocationName
                           select p;
            return province.ToList();
        }

        public List<Location> ListLocationFromParent(int locationParentID)
        {
            Table<Location> child = db.GetTable<Location>();
            var query = from c in child
                        where (c.Status.Equals(true) && c.LocationParent.Equals(locationParentID))
                        orderby c.LocationName
                        select c;
            return query.ToList();
        }
    }
}
