namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Department
{
    partial class frmDepartmentDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartmentDetail));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.pnDock = new DevExpress.XtraEditors.PanelControl();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.radBlock = new System.Windows.Forms.RadioButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnDock)).BeginInit();
            this.pnDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // pnDock
            // 
            this.pnDock.Controls.Add(this.labError);
            this.pnDock.Controls.Add(this.btnCancel);
            this.pnDock.Controls.Add(this.btnSave);
            this.pnDock.Controls.Add(this.radBlock);
            this.pnDock.Controls.Add(this.radActive);
            this.pnDock.Controls.Add(this.label1);
            this.pnDock.Controls.Add(this.txtName);
            this.pnDock.Controls.Add(this.labName);
            this.pnDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDock.Location = new System.Drawing.Point(0, 0);
            this.pnDock.Name = "pnDock";
            this.pnDock.Size = new System.Drawing.Size(316, 106);
            this.pnDock.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 15);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(83, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Tên Phòng Ban:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 21);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tình Trạng Hoạt Động:";
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.Checked = true;
            this.radActive.Location = new System.Drawing.Point(135, 40);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(69, 17);
            this.radActive.TabIndex = 3;
            this.radActive.TabStop = true;
            this.radActive.Text = "Kích hoạt";
            this.radActive.UseVisualStyleBackColor = true;
            // 
            // radBlock
            // 
            this.radBlock.AutoSize = true;
            this.radBlock.Location = new System.Drawing.Point(210, 40);
            this.radBlock.Name = "radBlock";
            this.radBlock.Size = new System.Drawing.Size(49, 17);
            this.radBlock.TabIndex = 4;
            this.radBlock.Text = "Khóa";
            this.radBlock.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(164, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(237, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 29);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labError
            // 
            this.labError.ForeColor = System.Drawing.Color.Red;
            this.labError.Location = new System.Drawing.Point(12, 80);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(146, 14);
            this.labError.TabIndex = 8;
            this.labError.Text = "Đã xảy ra lỗi";
            this.labError.Visible = false;
            // 
            // frmDepartmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 106);
            this.Controls.Add(this.pnDock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDepartmentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Phòng Ban";
            this.Load += new System.EventHandler(this.frmDepartmentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnDock)).EndInit();
            this.pnDock.ResumeLayout(false);
            this.pnDock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.PanelControl pnDock;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.RadioButton radBlock;
        private System.Windows.Forms.RadioButton radActive;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label labError;
    }
}