namespace EMS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Login login = new Login();
        Form2 form2 = new Form2();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_5(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_6(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        // หน้า form1 ใส่รหัสถูกแล้วเด้งหน้า 2
        private void loginclick(object sender, EventArgs e)
        {
            // ดึงหน้า login มาใช้ฃ
            
            string username = Username.Text;
            int password = int.Parse(Password.Text);
            // ดึงมาใช้แล้ว ถ้าถูกจะขึ้นว่า....ผิดจะขึ้นว่า... 

            bool newLogin = login.checkUser(username, password); 
            if (newLogin)
            {
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("ชื่อผู็ใช้หรือรหัสผ่านผิด  กรุณาเข้าสู่ระบบอีกครั้ง");
            }
        }
    }
}
