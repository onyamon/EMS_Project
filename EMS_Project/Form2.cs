using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EMS_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<EMSData>Data = new List<EMSData>();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            EMSData SaveData = new EMSData();
            SaveData.Name = User.Text;
            SaveData.Age = int.Parse(Age.Text);
            SaveData.branch = Branch.Text;
            SaveData.symptom = Symptom.Text;
            SaveData.Drugallergy = Mdi.Text;
            SaveData.day = Day.Text;
            SaveData.T = double.Parse(buttonT.Text);
            SaveData.BP = BP.Text;
            SaveData.RR = int.Parse(RR.Text);
            SaveData.P = int.Parse(P.Text);
            SaveData.O2Sat = int.Parse(O2sat.Text);
            SaveData.EMRCode = Emr.Text;
            Data.Add(SaveData);
            User.Text = string.Empty;
            Age.Text =string.Empty;
            Branch.Text =string.Empty;
            Symptom.Text=string.Empty;
            Mdi.Text=string.Empty;
            Day.Text=string.Empty;
            buttonT.Text=string.Empty;
            BP.Text =string.Empty;
            RR.Text=string.Empty;
            P.Text=string.Empty;
            O2sat.Text = string.Empty;
            Emr.Text = string.Empty;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณแน่ใจหรือไม่ว่าจะออกจากระบบ", "ออกจากระบบ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("ออกจากโปรแกรมแล้ว");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("ยกเลิกการออกจากโปรแกรม");
            }
        }

        private void buttonCSV_Click(object sender, EventArgs e)
        {
            CSV cSV = new CSV();
            if (cSV.csvfile(Data))
            {
                MessageBox.Show("บันทึกไฟล์แล้ว");
            }
            else
            {
                MessageBox.Show("บันทึกไฟล์ไม่สำเร็จ");

            }

        }
    }
}
