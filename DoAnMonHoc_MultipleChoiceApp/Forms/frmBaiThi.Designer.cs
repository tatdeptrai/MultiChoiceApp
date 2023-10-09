namespace DoAnMonHoc_MultipleChoiceApp.Forms
{
    partial class frmBaiThi
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 259);
            label1.Name = "label1";
            label1.Size = new Size(246, 54);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên :";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Trebuchet MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(624, 702);
            button1.Name = "button1";
            button1.Size = new Size(198, 82);
            button1.TabIndex = 4;
            button1.Text = "Bắt đầu ";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 403);
            label2.Name = "label2";
            label2.Size = new Size(217, 54);
            label2.TabIndex = 5;
            label2.Text = "Ngày thi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(133, 510);
            label3.Name = "label3";
            label3.Size = new Size(133, 54);
            label3.TabIndex = 6;
            label3.Text = "Môn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(133, 638);
            label4.Name = "label4";
            label4.Size = new Size(209, 54);
            label4.TabIndex = 7;
            label4.Text = "Thời gian";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(517, 524);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(357, 40);
            comboBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.quiz;
            pictureBox1.Location = new Point(1156, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 505);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmBaiThi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1631, 933);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(5);
            Name = "frmBaiThi";
            Text = "Các bài thi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}