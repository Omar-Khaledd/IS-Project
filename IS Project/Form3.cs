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
    public partial class Form3 : Form
    {
        public Form3(string username)
        {
            InitializeComponent();
            button1.Text = username;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel1.ClientSize.Width - thickness,
                                                              panel1.ClientSize.Height - thickness));
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (panel2.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel2.ClientSize.Width - thickness,
                                                              panel2.ClientSize.Height - thickness));
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            if (panel3.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel3.ClientSize.Width - thickness,
                                                              panel3.ClientSize.Height - thickness));
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (panel4.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel4.ClientSize.Width - thickness,
                                                              panel4.ClientSize.Height - thickness));
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (panel5.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel5.ClientSize.Width - thickness,
                                                              panel5.ClientSize.Height - thickness));
                }
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            if (panel6.BorderStyle == BorderStyle.FixedSingle)
            {
                int thickness = 3;//it's up to you
                int halfThickness = thickness / 2;
                using (Pen p = new Pen(Color.Black, thickness))
                {
                    e.Graphics.DrawRectangle(p, new Rectangle(halfThickness,
                                                              halfThickness,
                                                              panel6.ClientSize.Width - thickness,
                                                              panel6.ClientSize.Height - thickness));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
