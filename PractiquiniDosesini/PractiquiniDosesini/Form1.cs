using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractiquiniDosesini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Plum;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            int i = 0;
            for(i=0;i<50;i++)
            {

            }
            this.BackColor = Color.Black;
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor=Color.White; 
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
            panel1.BackColor = Color.Violet;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Teal;
        }
    }
}
