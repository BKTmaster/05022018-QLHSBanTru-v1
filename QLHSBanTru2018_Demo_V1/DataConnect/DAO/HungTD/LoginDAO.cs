using DataConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DataConnect.DAO.HungTD;

namespace QLHSBanTru2018_Demo_V1.DAO.HungTD
{
    public class LoginDAO
    {
        QLHSSmartKidsDataContext db = new QLHSSmartKidsDataContext();
        Table<Employee> employee;

        public int Login(string username, string password)
        {
            try
            {
                employee = db.GetTable<Employee>();
                HistoryDAO historyDAO = new HistoryDAO();
                var user = (from emp in employee
                            where emp.Username.Equals(username)
                            select new
                            {
                                emp.EmployeeID,
                                emp.Username,
                                emp.Password,
                                emp.FirstName,
                                emp.LastName,
                                emp.Status
                            });
                if (user.Count() > 0)
                {
                    if (user.FirstOrDefault().Password.Equals(password))
                    {
                        if (user.FirstOrDefault().Status.Equals(true))
                        {
                            historyDAO.Insert(user.FirstOrDefault().EmployeeID,1,"Thành công");
                            return 1; //Đăng nhập thành công
                        }
                        else
                        {
                            historyDAO.Insert(user.FirstOrDefault().EmployeeID, 1, "Thất bại");
                            return -1; //Tài khoản đã bị khóa
                        }
                    }
                    else
                    {
                        historyDAO.Insert(user.FirstOrDefault().EmployeeID, 1, "Thất bại");
                        return 2; //Mật khẩu không chính xác
                    }
                }
                else
                {
                    return -2; //Tài khoản không tồn tại
                }
            }
            catch
            {
                return 0; //Đã xảy ra lỗi trong quá trình đăng nhập
            }
        }

    }
}
