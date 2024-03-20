namespace EMS_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            Password = new TextBox();
            Username = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // loginbutton
            // 
            loginbutton.BackColor = SystemColors.ControlLightLight;
            loginbutton.ForeColor = SystemColors.ActiveCaptionText;
            loginbutton.Location = new Point(271, 523);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 29);
            loginbutton.TabIndex = 3;
            loginbutton.Text = "login";
            loginbutton.UseVisualStyleBackColor = false;
            loginbutton.Click += loginclick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(118, 408);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 13;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(121, 469);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 14;
            label2.Text = "password";
            label2.Click += label2_Click;
            // 
            // Password
            // 
            Password.Location = new Point(220, 466);
            Password.Name = "Password";
            Password.Size = new Size(216, 27);
            Password.TabIndex = 15;
            Password.TextChanged += textBox1_TextChanged_1;
            // 
            // Username
            // 
            Username.Location = new Point(220, 408);
            Username.Name = "Username";
            Username.Size = new Size(216, 27);
            Username.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(217, 325);
            label3.Name = "label3";
            label3.Size = new Size(194, 50);
            label3.TabIndex = 17;
            label3.Text = "EMS  NKC";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(138, 82);
            label4.Name = "label4";
            label4.Size = new Size(353, 20);
            label4.TabIndex = 22;
            label4.Text = "หน่วยกู้ชีพมหาวิทยาลัยขอนแก่น  วิทยาเขตหนองคาย";
            label4.Click += label4_Click_1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(271, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.AliceBlue;
            pictureBox6.Location = new Point(-5, 135);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(618, 168);
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(149, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(300, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(142, 145);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(448, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(165, 145);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(613, 588);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Username);
            Controls.Add(Password);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginbutton);
            Name = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginbutton;
        private Label label1;
        private Label label2;
        private TextBox Password;
        private TextBox Username;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
