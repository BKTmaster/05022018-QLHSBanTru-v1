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
using QLHSBanTru2018_Demo_V1.QLThuChi;

namespace QLHSBanTru2018_Demo_V1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void bntCackhoanThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrCacKhoanThu a = new FrCacKhoanThu();
            a.ShowDialog();
        }

        private void bntKhoanThuTuongLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            USCacKhoanThuTheoLop a = new USCacKhoanThuTheoLop();
            PNChinh.Controls.Clear();
            PNChinh.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }
    }
}