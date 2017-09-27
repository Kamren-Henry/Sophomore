using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_Pattern
{
    public partial class Form1 : Form
    {
        Singleton x = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_btn1_Click(object sender, EventArgs e)
        {
            x = Singleton.getInstance();

            if (m_tb1.Text.Equals ("Design Patterns"))
            {
                label3.Text = "9:00am - 9:50am";
            }
            if(m_tb1.Text.Equals("Data Structures and Algorithms"))
            {
                label3.Text = "10:00am - 10:50am";
            }
            if (m_tb1.Text.Equals("Calculus 1"))
            {
                label3.Text = "11:00am - 11:50am MWF\n 12:00pm - 12:50pm R";
            }
            if (m_tb1.Text.Equals("Programming Environments"))
            {
                label3.Text = "2:00pm - 2:50pm";
            }
            if (m_tb1.Text.Equals("Macro Economics"))
            {
                label3.Text = "3:00pm - 4:15pm";
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
