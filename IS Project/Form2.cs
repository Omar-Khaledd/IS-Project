using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;


namespace IS_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;*/
            string[] s = { "Computer Science", "Engineering", " Business", "Law", " Agriculture" };
            comboBox1.DataSource = s;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                MessageBox.Show("Please Fill The obligatory text boxes");
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5E0TPLF\SQLEXPRESS;Initial Catalog='Recruitment System' ;Integrated Security=True");
                conn.Open();
                
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [User] (Name,Username,Password) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ;", conn);
                cmd.ExecuteNonQuery();
                SqlCommand maxid = new SqlCommand(@"select max(User_ID) from [User]", conn);
                int max;
                max = (int)maxid.ExecuteScalar();
                string career = comboBox1.Text;
                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO UserProfile (User_Fullname,Phone,Email,Address,Nationality,Martial_Status,Gender,Educational_Details,Experience_Details,Career,User_ID) VALUES('" + textBox1.Text + "','" + textBox4.Text.ToString() + "','" + textBox13.Text + "','" + textBox6.Text + "','" + textBox11.Text + "','"+textBox9.Text+"','"+textBox10.Text+"','"+richTextBox1.Text+"','"+richTextBox2.Text+ "','" + career + "','" +max+ "') ;", conn);
                cmd2.ExecuteNonQuery();
                
                conn.Close();
                MessageBox.Show("Account Added to Database", "Successfull Registration");
                Form1 frm = new Form1();
                this.Hide();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
                frm.Focus();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Title = "Open CV";
            obj.Filter = "PDF File |*.Pdf|Word|*.docx";
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = obj.SafeFileName;
                //StreamReader sr = new StreamReader(File.OpenRead(obj.FileName));
                //s001r.ReadToEnd();
                string filename = obj.SafeFileName;
                string sourcepath = obj.FileName;
                string newpath = @"C:\Users\Ahmed reda\Desktop\is project\IS Project\IS Project\cvs";
                string filenewpath = System.IO.Path.Combine(newpath, filename);
                if (!System.IO.Directory.Exists(newpath))
                {
                    System.IO.Directory.CreateDirectory(newpath);
                }
                System.IO.File.Copy(sourcepath, filenewpath, true);






            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
    
}
