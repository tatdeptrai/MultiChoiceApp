namespace DoAnMonHoc_MultipleChoiceApp.Forms
{
    partial class frmBaoCaoThongKe
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
            listView1 = new ListView();
            STT = new ColumnHeader();
            Mamonhoc = new ColumnHeader();
            TenMonHoc = new ColumnHeader();
            Diemthi = new ColumnHeader();
            Diemhe4 = new ColumnHeader();
            DiemCong = new ColumnHeader();
            XepLoai = new ColumnHeader();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackColor = Color.LavenderBlush;
            listView1.Columns.AddRange(new ColumnHeader[] { STT, Mamonhoc, TenMonHoc, Diemthi, Diemhe4, DiemCong, XepLoai });
            listView1.GridLines = true;
            listView1.Location = new Point(296, 140);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(1329, 800);
            listView1.TabIndex = 78;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // STT
            // 
            STT.Text = "STT";
            // 
            // Mamonhoc
            // 
            Mamonhoc.Text = "Mã môn học";
            Mamonhoc.Width = 150;
            // 
            // TenMonHoc
            // 
            TenMonHoc.Text = "Tên môn học";
            TenMonHoc.Width = 150;
            // 
            // Diemthi
            // 
            Diemthi.Text = "Điểm thi";
            Diemthi.Width = 150;
            // 
            // Diemhe4
            // 
            Diemhe4.Text = "Điểm thi hệ 4";
            Diemhe4.Width = 150;
            // 
            // DiemCong
            // 
            DiemCong.Text = "Điểm Cộng";
            DiemCong.Width = 150;
            // 
            // XepLoai
            // 
            XepLoai.Text = "Xếp Loại";
            XepLoai.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LavenderBlush;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(740, 58);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(659, 40);
            comboBox1.TabIndex = 80;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(490, 45);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 54);
            label2.TabIndex = 79;
            label2.Text = "Mã kì thi";
            // 
            // frmBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hinh_anh_gif_thanh_pho_buon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2010, 954);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "frmBaoCaoThongKe";
            Text = "Báo cáo và thống kê";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader STT;
        private ColumnHeader Mamonhoc;
        private ColumnHeader TenMonHoc;
        private ColumnHeader Diemthi;
        private ColumnHeader Diemhe4;
        private ColumnHeader DiemCong;
        private ColumnHeader XepLoai;
        private ComboBox comboBox1;
        private Label label2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
    }
}