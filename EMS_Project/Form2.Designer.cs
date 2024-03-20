namespace EMS_Project
{
    partial class Form2
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
            label3 = new Label();
            label4 = new Label();
            save = new Button();
            logout = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            User = new TextBox();
            Age = new TextBox();
            Branch = new TextBox();
            Symptom = new TextBox();
            Mdi = new TextBox();
            Day = new TextBox();
            buttonT = new TextBox();
            BP = new TextBox();
            RR = new TextBox();
            P = new TextBox();
            O2sat = new TextBox();
            Emr = new TextBox();
            label16 = new Label();
            groupBox1 = new GroupBox();
            buttonCSV = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(323, 19);
            label3.Name = "label3";
            label3.Size = new Size(194, 50);
            label3.TabIndex = 18;
            label3.Text = "EMS  NKC";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(204, 69);
            label4.Name = "label4";
            label4.Size = new Size(471, 20);
            label4.TabIndex = 23;
            label4.Text = "ระบบบันทึกข้อมูลผู้ป่วยภายในมหาวิทยาลัยขอนแก่น  วิทยาเขตหนองคาย";
            label4.Click += label4_Click;
            // 
            // save
            // 
            save.ForeColor = Color.Black;
            save.Location = new Point(621, 580);
            save.Name = "save";
            save.Size = new Size(94, 29);
            save.TabIndex = 49;
            save.Text = "บันทึก";
            save.UseVisualStyleBackColor = true;
            save.Click += button1_Click;
            // 
            // logout
            // 
            logout.ForeColor = Color.Black;
            logout.Location = new Point(732, 580);
            logout.Name = "logout";
            logout.Size = new Size(112, 29);
            logout.TabIndex = 51;
            logout.Text = "ออกจากระบบ";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 24;
            label1.Text = "ชื่อ - นามกุล:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 48);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 48);
            label5.Name = "label5";
            label5.Size = new Size(51, 28);
            label5.TabIndex = 26;
            label5.Text = "อายุ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 118);
            label6.Name = "label6";
            label6.Size = new Size(62, 28);
            label6.TabIndex = 27;
            label6.Text = "สาขา :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 183);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 28;
            label7.Text = "อาการ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 244);
            label8.Name = "label8";
            label8.Size = new Size(63, 28);
            label8.TabIndex = 29;
            label8.Text = "แพ้ยา :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 307);
            label9.Name = "label9";
            label9.Size = new Size(99, 28);
            label9.TabIndex = 30;
            label9.Text = "วันเกิดเหตุ :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(18, 361);
            label10.Name = "label10";
            label10.Size = new Size(31, 28);
            label10.TabIndex = 31;
            label10.Text = "T :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(164, 361);
            label11.Name = "label11";
            label11.Size = new Size(43, 28);
            label11.TabIndex = 32;
            label11.Text = "BP :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(353, 361);
            label12.Name = "label12";
            label12.Size = new Size(45, 28);
            label12.TabIndex = 33;
            label12.Text = "RR :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(529, 361);
            label13.Name = "label13";
            label13.Size = new Size(32, 28);
            label13.TabIndex = 34;
            label13.Text = "P :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(675, 361);
            label14.Name = "label14";
            label14.Size = new Size(75, 28);
            label14.TabIndex = 35;
            label14.Text = "O2Sat :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(28, 418);
            label15.Name = "label15";
            label15.Size = new Size(98, 28);
            label15.TabIndex = 36;
            label15.Text = "รหัส EMR :";
            // 
            // User
            // 
            User.Location = new Point(128, 52);
            User.Name = "User";
            User.Size = new Size(183, 27);
            User.TabIndex = 26;
            // 
            // Age
            // 
            Age.Location = new Point(384, 52);
            Age.Name = "Age";
            Age.Size = new Size(73, 27);
            Age.TabIndex = 38;
            // 
            // Branch
            // 
            Branch.Location = new Point(86, 122);
            Branch.Name = "Branch";
            Branch.Size = new Size(183, 27);
            Branch.TabIndex = 39;
            // 
            // Symptom
            // 
            Symptom.Location = new Point(94, 187);
            Symptom.Name = "Symptom";
            Symptom.Size = new Size(183, 27);
            Symptom.TabIndex = 40;
            // 
            // Mdi
            // 
            Mdi.Location = new Point(94, 245);
            Mdi.Name = "Mdi";
            Mdi.Size = new Size(183, 27);
            Mdi.TabIndex = 41;
            // 
            // Day
            // 
            Day.Location = new Point(123, 308);
            Day.Name = "Day";
            Day.Size = new Size(183, 27);
            Day.TabIndex = 42;
            // 
            // buttonT
            // 
            buttonT.Location = new Point(55, 365);
            buttonT.Name = "buttonT";
            buttonT.Size = new Size(85, 27);
            buttonT.TabIndex = 43;
            // 
            // BP
            // 
            BP.Location = new Point(213, 362);
            BP.Name = "BP";
            BP.Size = new Size(85, 27);
            BP.TabIndex = 44;
            // 
            // RR
            // 
            RR.Location = new Point(404, 365);
            RR.Name = "RR";
            RR.Size = new Size(85, 27);
            RR.TabIndex = 45;
            // 
            // P
            // 
            P.Location = new Point(567, 361);
            P.Name = "P";
            P.Size = new Size(85, 27);
            P.TabIndex = 46;
            // 
            // O2sat
            // 
            O2sat.Location = new Point(747, 365);
            O2sat.Name = "O2sat";
            O2sat.Size = new Size(85, 27);
            O2sat.TabIndex = 47;
            // 
            // Emr
            // 
            Emr.Location = new Point(145, 422);
            Emr.Name = "Emr";
            Emr.Size = new Size(183, 27);
            Emr.TabIndex = 48;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(463, 52);
            label16.Name = "label16";
            label16.Size = new Size(23, 28);
            label16.TabIndex = 49;
            label16.Text = "ปี";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(Emr);
            groupBox1.Controls.Add(O2sat);
            groupBox1.Controls.Add(P);
            groupBox1.Controls.Add(RR);
            groupBox1.Controls.Add(BP);
            groupBox1.Controls.Add(buttonT);
            groupBox1.Controls.Add(Day);
            groupBox1.Controls.Add(Mdi);
            groupBox1.Controls.Add(Symptom);
            groupBox1.Controls.Add(Branch);
            groupBox1.Controls.Add(Age);
            groupBox1.Controls.Add(User);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 456);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลผู้ป่วย";
            // 
            // buttonCSV
            // 
            buttonCSV.ForeColor = Color.Black;
            buttonCSV.Location = new Point(30, 19);
            buttonCSV.Name = "buttonCSV";
            buttonCSV.Size = new Size(94, 29);
            buttonCSV.TabIndex = 52;
            buttonCSV.Text = "CSV";
            buttonCSV.UseVisualStyleBackColor = true;
            buttonCSV.Click += buttonCSV_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(865, 621);
            Controls.Add(buttonCSV);
            Controls.Add(logout);
            Controls.Add(save);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            ForeColor = Color.FromArgb(255, 192, 192);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private Button save;
        private Button logout;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox User;
        private TextBox Age;
        private TextBox Branch;
        private TextBox Symptom;
        private TextBox Mdi;
        private TextBox Day;
        private TextBox buttonT;
        private TextBox BP;
        private TextBox RR;
        private TextBox P;
        private TextBox O2sat;
        private TextBox Emr;
        private Label label16;
        private GroupBox groupBox1;
        private Button buttonCSV;
    }
}