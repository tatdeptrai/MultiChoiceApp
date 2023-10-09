namespace DoAnMonHoc_MultipleChoiceApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnlMenu = new Panel();
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnThongTin = new FontAwesome.Sharp.IconButton();
            btnBaoCaoThongKe = new FontAwesome.Sharp.IconButton();
            btnQuanLy = new FontAwesome.Sharp.IconButton();
            btnBaiThi = new FontAwesome.Sharp.IconButton();
            pnlBaiThiVaCauHoi = new Panel();
            btnCauHoi = new FontAwesome.Sharp.IconButton();
            btnTaoExam = new FontAwesome.Sharp.IconButton();
            btnTaoBaiThi = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            btnHome = new PictureBox();
            pnlTitleBar = new Panel();
            icnCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            pnlShadow = new Panel();
            pnlDesktop = new Panel();
            pnlMenu.SuspendLayout();
            pnlBaiThiVaCauHoi.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icnCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.LavenderBlush;
            pnlMenu.Controls.Add(btnDangXuat);
            pnlMenu.Controls.Add(btnThongTin);
            pnlMenu.Controls.Add(btnBaoCaoThongKe);
            pnlMenu.Controls.Add(btnQuanLy);
            pnlMenu.Controls.Add(btnBaiThi);
            pnlMenu.Controls.Add(pnlBaiThiVaCauHoi);
            pnlMenu.Controls.Add(btnTaoBaiThi);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(469, 1174);
            pnlMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Black;
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnDangXuat.IconColor = Color.White;
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.IconSize = 32;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 895);
            btnDangXuat.Margin = new Padding(5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(16, 0, 32, 0);
            btnDangXuat.Size = new Size(469, 96);
            btnDangXuat.TabIndex = 8;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click_1;
            // 
            // btnThongTin
            // 
            btnThongTin.BackColor = Color.Black;
            btnThongTin.Dock = DockStyle.Top;
            btnThongTin.FlatAppearance.BorderSize = 0;
            btnThongTin.FlatStyle = FlatStyle.Flat;
            btnThongTin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnThongTin.ForeColor = Color.White;
            btnThongTin.IconChar = FontAwesome.Sharp.IconChar.Info;
            btnThongTin.IconColor = Color.White;
            btnThongTin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongTin.IconSize = 32;
            btnThongTin.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTin.Location = new Point(0, 799);
            btnThongTin.Margin = new Padding(5);
            btnThongTin.Name = "btnThongTin";
            btnThongTin.Padding = new Padding(16, 0, 32, 0);
            btnThongTin.Size = new Size(469, 96);
            btnThongTin.TabIndex = 6;
            btnThongTin.Text = "Thông tin người dùng";
            btnThongTin.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongTin.UseVisualStyleBackColor = false;
            btnThongTin.Click += btnThongTin_Click;
            // 
            // btnBaoCaoThongKe
            // 
            btnBaoCaoThongKe.BackColor = Color.Black;
            btnBaoCaoThongKe.Dock = DockStyle.Top;
            btnBaoCaoThongKe.FlatAppearance.BorderSize = 0;
            btnBaoCaoThongKe.FlatStyle = FlatStyle.Flat;
            btnBaoCaoThongKe.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaoCaoThongKe.ForeColor = Color.White;
            btnBaoCaoThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnBaoCaoThongKe.IconColor = Color.White;
            btnBaoCaoThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBaoCaoThongKe.IconSize = 32;
            btnBaoCaoThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.Location = new Point(0, 703);
            btnBaoCaoThongKe.Margin = new Padding(5);
            btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            btnBaoCaoThongKe.Padding = new Padding(16, 0, 32, 0);
            btnBaoCaoThongKe.Size = new Size(469, 96);
            btnBaoCaoThongKe.TabIndex = 5;
            btnBaoCaoThongKe.Text = "Báo cáo và thống kê";
            btnBaoCaoThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaoCaoThongKe.UseVisualStyleBackColor = false;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.Black;
            btnQuanLy.Dock = DockStyle.Top;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuanLy.ForeColor = Color.White;
            btnQuanLy.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnQuanLy.IconColor = Color.White;
            btnQuanLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnQuanLy.IconSize = 32;
            btnQuanLy.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.Location = new Point(0, 607);
            btnQuanLy.Margin = new Padding(5);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Padding = new Padding(16, 0, 32, 0);
            btnQuanLy.Size = new Size(469, 96);
            btnQuanLy.TabIndex = 2;
            btnQuanLy.Text = "Quản lý chung";
            btnQuanLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // btnBaiThi
            // 
            btnBaiThi.BackColor = Color.Black;
            btnBaiThi.Dock = DockStyle.Top;
            btnBaiThi.FlatAppearance.BorderSize = 0;
            btnBaiThi.FlatStyle = FlatStyle.Flat;
            btnBaiThi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaiThi.ForeColor = Color.White;
            btnBaiThi.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnBaiThi.IconColor = Color.White;
            btnBaiThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBaiThi.IconSize = 32;
            btnBaiThi.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaiThi.Location = new Point(0, 511);
            btnBaiThi.Margin = new Padding(5, 5, 5, 20);
            btnBaiThi.Name = "btnBaiThi";
            btnBaiThi.Padding = new Padding(16, 0, 32, 0);
            btnBaiThi.Size = new Size(469, 96);
            btnBaiThi.TabIndex = 3;
            btnBaiThi.Text = "Các Bài Thi";
            btnBaiThi.TextAlign = ContentAlignment.MiddleLeft;
            btnBaiThi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaiThi.UseVisualStyleBackColor = false;
            btnBaiThi.Click += btnBaiThi_Click;
            // 
            // pnlBaiThiVaCauHoi
            // 
            pnlBaiThiVaCauHoi.Controls.Add(btnCauHoi);
            pnlBaiThiVaCauHoi.Controls.Add(btnTaoExam);
            pnlBaiThiVaCauHoi.Dock = DockStyle.Top;
            pnlBaiThiVaCauHoi.Location = new Point(0, 320);
            pnlBaiThiVaCauHoi.Name = "pnlBaiThiVaCauHoi";
            pnlBaiThiVaCauHoi.Size = new Size(469, 191);
            pnlBaiThiVaCauHoi.TabIndex = 6;
            // 
            // btnCauHoi
            // 
            btnCauHoi.BackColor = Color.SlateGray;
            btnCauHoi.Dock = DockStyle.Top;
            btnCauHoi.FlatAppearance.BorderSize = 0;
            btnCauHoi.FlatStyle = FlatStyle.Flat;
            btnCauHoi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCauHoi.ForeColor = Color.White;
            btnCauHoi.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            btnCauHoi.IconColor = Color.WhiteSmoke;
            btnCauHoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCauHoi.IconSize = 32;
            btnCauHoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnCauHoi.Location = new Point(0, 97);
            btnCauHoi.Margin = new Padding(5);
            btnCauHoi.Name = "btnCauHoi";
            btnCauHoi.Padding = new Padding(60, 0, 32, 0);
            btnCauHoi.Size = new Size(469, 96);
            btnCauHoi.TabIndex = 9;
            btnCauHoi.Text = "Tạo câu hỏi";
            btnCauHoi.TextAlign = ContentAlignment.MiddleLeft;
            btnCauHoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCauHoi.UseVisualStyleBackColor = false;
            btnCauHoi.Click += btnCauHoi_Click;
            // 
            // btnTaoExam
            // 
            btnTaoExam.BackColor = Color.SlateGray;
            btnTaoExam.Dock = DockStyle.Top;
            btnTaoExam.FlatAppearance.BorderSize = 0;
            btnTaoExam.FlatStyle = FlatStyle.Flat;
            btnTaoExam.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoExam.ForeColor = Color.White;
            btnTaoExam.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            btnTaoExam.IconColor = Color.WhiteSmoke;
            btnTaoExam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaoExam.IconSize = 32;
            btnTaoExam.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoExam.Location = new Point(0, 0);
            btnTaoExam.Margin = new Padding(5);
            btnTaoExam.Name = "btnTaoExam";
            btnTaoExam.Padding = new Padding(60, 0, 32, 0);
            btnTaoExam.Size = new Size(469, 97);
            btnTaoExam.TabIndex = 10;
            btnTaoExam.Text = "Tạo bài thi";
            btnTaoExam.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoExam.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoExam.UseVisualStyleBackColor = false;
            // 
            // btnTaoBaiThi
            // 
            btnTaoBaiThi.BackColor = Color.Black;
            btnTaoBaiThi.Dock = DockStyle.Top;
            btnTaoBaiThi.FlatAppearance.BorderSize = 0;
            btnTaoBaiThi.FlatStyle = FlatStyle.Flat;
            btnTaoBaiThi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoBaiThi.ForeColor = Color.White;
            btnTaoBaiThi.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            btnTaoBaiThi.IconColor = Color.WhiteSmoke;
            btnTaoBaiThi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaoBaiThi.IconSize = 32;
            btnTaoBaiThi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoBaiThi.Location = new Point(0, 224);
            btnTaoBaiThi.Margin = new Padding(5, 5, 5, 20);
            btnTaoBaiThi.Name = "btnTaoBaiThi";
            btnTaoBaiThi.Padding = new Padding(16, 0, 32, 0);
            btnTaoBaiThi.Size = new Size(469, 96);
            btnTaoBaiThi.TabIndex = 4;
            btnTaoBaiThi.Text = "Tạo bài thi và câu hỏi";
            btnTaoBaiThi.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoBaiThi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoBaiThi.UseVisualStyleBackColor = false;
            btnTaoBaiThi.Click += btnTaoBaiThi_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.LavenderBlush;
            pnlLogo.Controls.Add(btnHome);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Margin = new Padding(5);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(469, 224);
            pnlLogo.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(91, 38);
            btnHome.Margin = new Padding(5);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 142);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.LavenderBlush;
            pnlTitleBar.Controls.Add(icnCurrentChildForm);
            pnlTitleBar.Controls.Add(lblTitleChildForm);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(469, 0);
            pnlTitleBar.Margin = new Padding(5);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1840, 120);
            pnlTitleBar.TabIndex = 1;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            // 
            // icnCurrentChildForm
            // 
            icnCurrentChildForm.BackColor = Color.Pink;
            icnCurrentChildForm.ForeColor = Color.Black;
            icnCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            icnCurrentChildForm.IconColor = Color.Black;
            icnCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icnCurrentChildForm.IconSize = 64;
            icnCurrentChildForm.Location = new Point(53, 28);
            icnCurrentChildForm.Margin = new Padding(5);
            icnCurrentChildForm.Name = "icnCurrentChildForm";
            icnCurrentChildForm.Size = new Size(65, 64);
            icnCurrentChildForm.TabIndex = 0;
            icnCurrentChildForm.TabStop = false;
            icnCurrentChildForm.Click += icnCurrentChildForm_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.Anchor = AnchorStyles.None;
            lblTitleChildForm.BackColor = Color.LavenderBlush;
            lblTitleChildForm.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.Black;
            lblTitleChildForm.Location = new Point(163, 0);
            lblTitleChildForm.Margin = new Padding(5, 0, 5, 0);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(1622, 115);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Trang chủ";
            lblTitleChildForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlShadow
            // 
            pnlShadow.BackColor = Color.LavenderBlush;
            pnlShadow.Dock = DockStyle.Top;
            pnlShadow.Location = new Point(469, 120);
            pnlShadow.Margin = new Padding(5);
            pnlShadow.Name = "pnlShadow";
            pnlShadow.Size = new Size(1840, 10);
            pnlShadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            pnlDesktop.BackColor = Color.Pink;
            pnlDesktop.Location = new Point(469, 131);
            pnlDesktop.Margin = new Padding(5);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1839, 1043);
            pnlDesktop.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2309, 1174);
            Controls.Add(pnlDesktop);
            Controls.Add(pnlShadow);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlMenu);
            Margin = new Padding(5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            FormClosing += FormMain_FormClosing;
            pnlMenu.ResumeLayout(false);
            pnlBaiThiVaCauHoi.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icnCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnThongTin;
        private FontAwesome.Sharp.IconButton btnBaoCaoThongKe;
        private FontAwesome.Sharp.IconButton btnTaoBaiThi;
        private FontAwesome.Sharp.IconButton btnBaiThi;
        private FontAwesome.Sharp.IconButton btnQuanLy;
        private Panel pnlLogo;
        private PictureBox btnHome;
        private Panel pnlTitleBar;
        private FontAwesome.Sharp.IconPictureBox icnCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel pnlShadow;
        private Panel pnlDesktop;
        private FontAwesome.Sharp.IconButton btnTaoExam;
        private FontAwesome.Sharp.IconButton btnCauHoi;
        private Panel pnlBaiThiVaCauHoi;
        private FontAwesome.Sharp.IconButton btnDangXuat;
    }
}