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

namespace IS_Project
{
    public partial class Form1 : Form
    {
       
        public Form1()
        { 
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5E0TPLF\SQLEXPRESS;Initial Catalog='Recruitment System' ;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "' ", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            //  If the record can be queried, it means passing verification, then open another form.  
            if ((sdr.Read() == true))
            {
                //MessageBox.Show("The user is valid!");
                Form3 frm = new Form3(textBox1.Text);
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();                   
            this.Hide();
            frm.ShowDialog();
        }

       
    }

}
