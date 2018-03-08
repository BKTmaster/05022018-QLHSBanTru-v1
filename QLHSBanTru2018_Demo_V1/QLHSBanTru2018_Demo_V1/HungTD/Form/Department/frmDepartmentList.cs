using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect.DAO.HungTD;
using DataConnect;
using DataConnect.ViewModel;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Department
{
    public partial class frmDepartmentList : DevExpress.XtraEditors.XtraUserControl
    {
        public frmDepartmentList()
        {
            InitializeComponent();
        }

        private void frmDepartmentList_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            FillGridControl();
            testLoadEmployee();
        }
        #region Đổ dữ liệu vào GridControl
        private void FillGridControl()
        {
            gcDepartmentList.DataSource = new DepartmentDAO().ListAll();
        }

        #endregion
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail departmentDetail = new frmDepartmentDetail();
            departmentDetail.Function = 1;
            departmentDetail.ShowDialog();
            if (departmentDetail.DialogResult == DialogResult.OK)
                FillGridControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail departmentDetail = new frmDepartmentDetail();
            departmentDetail.Function = 2;
            departmentDetail.ShowDialog();
            if (departmentDetail.DialogResult == DialogResult.OK)
                FillGridControl();
        }
        private void testLoadEmployee()
        {
            List<Department_EmployeeViewModel> listEmployee = new EmployeeDAO().ListAllByDepartment(1);
            gcEmployee.DataSource = listEmployee;
        }
    }
}
