using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MethodGrabber
{
    public partial class FormBody : Form
    {
        public FormBody()
        {
            InitializeComponent();
        }

        internal void setBody(string x)
        {
            string p = "document is empty";
            if (!string.IsNullOrEmpty(x))
                p = x;
            this.richTextBox1.Text = this.webBrowser1.DocumentText = p;
        }
    }
}
