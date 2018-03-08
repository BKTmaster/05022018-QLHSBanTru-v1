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

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Employee
{
    public partial class frmEmployeeList : DevExpress.XtraEditors.XtraUserControl
    {
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeDetail employeeDetail = new frmEmployeeDetail();
            employeeDetail.iFunction = 1;
            employeeDetail.ShowDialog();
        }
    }
    
}
