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

namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    public partial class FrCacKhoanThu : DevExpress.XtraEditors.XtraForm
    {
        public FrCacKhoanThu()
        {
            InitializeComponent();
        }

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            FTaoKhoanThu a = new FTaoKhoanThu();
            a.ShowDialog();
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            FRSuaKhoanThu a = new FRSuaKhoanThu();
            a.ShowDialog();
        }
    }
}