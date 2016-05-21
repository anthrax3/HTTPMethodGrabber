using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MethodGrabber
{
    public partial class Formabout : Form
    {
        public Formabout()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Launch("http://facebook.com/prince.gersy2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Launch("http://twitter.com/yassergersy");

        }

        private void Launch(string p)
        {
            try
            {
                System.Diagnostics.Process.Start(p);
            }
            catch { }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Launch("http://ask.fm/yassergersy");

        }

        private void Formabout_Load(object sender, EventArgs e)
        {

        }
    }
}
