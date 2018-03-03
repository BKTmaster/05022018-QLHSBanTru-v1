namespace QLHSBanTru2018_Demo_V1.QLThuChi
{
    partial class FrCacKhoanThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrCacKhoanThu));
            this.bntDong = new DevExpress.XtraEditors.SimpleButton();
            this.grCacKhoanThu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bntThem = new DevExpress.XtraEditors.SimpleButton();
            this.bntSua = new DevExpress.XtraEditors.SimpleButton();
            this.bntXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grCacKhoanThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntDong
            // 
            this.bntDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntDong.ImageOptions.Image")));
            this.bntDong.Location = new System.Drawing.Point(328, 208);
            this.bntDong.Name = "bntDong";
            this.bntDong.Size = new System.Drawing.Size(75, 23);
            this.bntDong.TabIndex = 0;
            this.bntDong.Text = "Đóng";
            this.bntDong.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // grCacKhoanThu
            // 
            this.grCacKhoanThu.Location = new System.Drawing.Point(3, 2);
            this.grCacKhoanThu.MainView = this.gridView1;
            this.grCacKhoanThu.Name = "grCacKhoanThu";
            this.grCacKhoanThu.Size = new System.Drawing.Size(400, 200);
            this.grCacKhoanThu.TabIndex = 1;
            this.grCacKhoanThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grCacKhoanThu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // bntThem
            // 
            this.bntThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntThem.ImageOptions.Image")));
            this.bntThem.Location = new System.Drawing.Point(3, 208);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 2;
            this.bntThem.Text = "Thêm";
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // bntSua
            // 
            this.bntSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntSua.ImageOptions.Image")));
            this.bntSua.Location = new System.Drawing.Point(84, 208);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 3;
            this.bntSua.Text = "Sửa";
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntXoa
            // 
            this.bntXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bntXoa.ImageOptions.Image")));
            this.bntXoa.Location = new System.Drawing.Point(165, 208);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 4;
            this.bntXoa.Text = "Xóa";
            // 
            // FrCacKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 235);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.grCacKhoanThu);
            this.Controls.Add(this.bntDong);
            this.Name = "FrCacKhoanThu";
            this.Text = "Các khoản thu";
            ((System.ComponentModel.ISupportInitialize)(this.grCacKhoanThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton bntDong;
        private DevExpress.XtraGrid.GridControl grCacKhoanThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton bntThem;
        private DevExpress.XtraEditors.SimpleButton bntSua;
        private DevExpress.XtraEditors.SimpleButton bntXoa;
    }
}