using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_Project
{
    public partial class INTRO : Form
    {
        public INTRO()
        {
            InitializeComponent();
           
        }

        private void INTRO_Load(object sender, EventArgs e)
        {
           
       
            
           
         
           
        }

     

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
                progressBar1.Value += 1;
            if(progressBar1.Value==50)
            {
                timer2.Stop();
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Close();
                
                
               
            }              
               
                
                
            
        }
    }
}
