using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class EmployeeDAO
    {
        QLHSDbContext db = null;
        public EmployeeDAO()
        {
            db = new QLHSDbContext();
        }

        #region Hàm kiểm tra đăng nhập
        public int Login(string username, string password)
        {
            try
            {
                var res = db.Employees.SingleOrDefault(x => x.Username == username);
                if (res == null)
                    return 0; //Tài khoản không tồn tại
                else
                {
                    if (res.Status == false)
                        return -1; //Tài khoản bị khóa
                    else
                    {
                        if (res.Password == password)
                            return 1; //Đăng nhập thành công
                        else
                            return 2; //Mật khẩu không chính xác
                    }
                }
            }
            catch
            {
                return 2;
            }
        }
        #endregion
    }
}
