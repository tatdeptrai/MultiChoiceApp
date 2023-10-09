namespace DoAnMonHoc_MultipleChoiceApp.Forms
{
    partial class frmQuanLy
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(90, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(898, 673);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(449, 839);
            button1.Name = "button1";
            button1.Size = new Size(178, 53);
            button1.TabIndex = 1;
            button1.Text = "Cập nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1125, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 40);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1205, 60);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 3;
            label1.Text = "Loại người dùng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.undraw_Dog_c7i6;
            pictureBox1.Location = new Point(1125, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(90, 839);
            button2.Name = "button2";
            button2.Size = new Size(178, 53);
            button2.TabIndex = 5;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(810, 839);
            button3.Name = "button3";
            button3.Size = new Size(178, 53);
            button3.TabIndex = 6;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmQuanLy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.hinh_anh_gif_thanh_pho_buon;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1686, 933);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
            DoubleBuffered = true;
            Margin = new Padding(5);
            Name = "frmQuanLy";
            Text = "Quản lý";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
    }
}