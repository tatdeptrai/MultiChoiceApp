namespace DoAnMonHoc_MultipleChoiceApp.Forms
{
    partial class frmThongTinNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongTinNguoiDung));
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 106);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(397, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(83, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(397, 150);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(542, 178);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 6;
            label2.Text = "Tên User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(542, 296);
            label3.Name = "label3";
            label3.Size = new Size(147, 37);
            label3.TabIndex = 7;
            label3.Text = "**********";
            label3.Click += label3_Click;
            // 
            // frmThongTinNguoiDung
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1300, 737);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "frmThongTinNguoiDung";
            Text = "Thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
    }
}