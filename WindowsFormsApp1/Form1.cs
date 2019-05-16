using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "I did something: "+DateTime.Now.ToString();// here is a new comment
            DoSomething();
        }

        /// <summary>
        /// omments go here
        /// </summary>
        public void DoSomething()
        {
            // here is a comment
            
        }
    }
}
