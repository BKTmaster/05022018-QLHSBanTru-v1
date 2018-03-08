using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect.DAO.HungTD;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Department
{
    public partial class frmDepartmentDetail : DevExpress.XtraEditors.XtraForm
    {
        public int Function = 0;
        public frmDepartmentDetail()
        {
            InitializeComponent();
        }

        private void frmDepartmentDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataConnect.Department entity = new DataConnect.Department();
            entity.Name = txtName.Text;
            entity.Status = radActive.Checked == true ? true : false;
            if (Function == 1)
            {
                if(new DepartmentDAO().Insert(entity) == true)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    labError.Visible = true;
                }
            }
            else if (Function == 2)
            {
                if (new DepartmentDAO().Edit(entity) == true)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    labError.Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}