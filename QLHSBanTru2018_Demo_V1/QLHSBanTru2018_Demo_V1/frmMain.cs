using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Department;
using QLHSBanTru2018_Demo_V1.HungTD.Form.Employee;

namespace QLHSBanTru2018_Demo_V1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Trần Đức Hùng
        private void btnDepartment_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmDepartmentList());
        }

        private void btnEmployeeManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnControlsPanel.Controls.Clear();
            pnControlsPanel.Controls.Add(new frmEmployeeList());
        }
        #endregion

        #region Nguyễn Kiều Thành Công

        #endregion

        #region Nguyễn Tiến Bảo

        #endregion

        #region Vũ Đức Thiện

        #endregion
    }
}