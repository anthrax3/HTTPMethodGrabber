using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MethodGrabber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGrab_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            linkLabeldev.Visible= panel2.Visible = true;
            labelStat .Text= "...";
            textBoxHeaderValue.Text = "null";
            textBoxcode.Text = "";
            labelComment.Text = "";
            string b = textBox1.Text;

            if (!isurl(b))
            {
                b = "http://" + b;
                if (!isurl(b))
                {
                    MessageBox.Show("invalid url");
                    return;
             
                }
            }
            sendRequest(b);
            this.Visible = true;
            switchsize();
        }
        public Size mini = new Size(361, 131);
        private void switchsize()
        {
            if (this.Size.Width < orgsize.Width || this.Size.Height < orgsize.Height)
                this.Size = orgsize;
        }
        public Size orgsize = new Size(359, 237);
        private void sendRequest(string url)
        {
            try
            {
                var req = (HttpWebRequest)WebRequest.Create(url);
                req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; rv:46.0) Gecko/20100101 Firefox/46.0";
                req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                req.Headers.Add("Accept-Language", "en-US,en;q=0.5");
                req.Method = "OPTIONS";
                req.Timeout = 20000;

                var resp = (HttpWebResponse)req.GetResponse();
                this.Body = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                string AllowHeaderVal = "";
                AllowHeaderVal = resp.Headers["allow"];
                if (AllowHeaderVal == "")
                    AllowHeaderVal = resp.Headers["Allow"];
                WebHeaderCollection hd = resp.Headers;
                for (int i = 0; i < hd.Count; i++)
                {
                    string header__ = hd.GetKey(i);
                    string[] values = hd.GetValues(header__);
                    if (values.Length > 0)
                    {
                        for (int j = 0; j < values.Length; j++)
                        {
                            if (!string.IsNullOrEmpty(values[j]))
                                this.headers += header__ + ":" + values[j] + "\r\n";

                        }
                    }
                    else
                        this.headers += (header__ + "");
                }


                this.requestCompleted = true;
                this.succeed = true;
                textBoxcode.Text = resp.StatusCode.ToString();
                labelStat.Text = "Request Sent";
                this.textBoxHeaderValue.Text = AllowHeaderVal;
                if (this.textBoxHeaderValue.TextLength < 1) 
                    this.textBoxHeaderValue.Text = "empty";
                    

            }
            catch (Exception s)
            {
                this.succeed = false;
                requestCompleted = true;
                bool _404 = s.Message.Contains("The remote server returned an error: (404) Not Found");
                bool _405 = s.Message.Contains("405");
                if (_405)
                {
                    labelStat.Text = "Request sent";
                    textBoxHeaderValue.Text = "Options not allowed";
                    textBoxcode.Text = 405.ToString();
                   succeed= requestCompleted = true;
                }
                else
                {
                    labelStat.Text = "Error";
                    MessageBox.Show(s.Message + (_404 ? "\r\n can not check for headers in 404 response\r\n" : ""), "error on connection");
                }
            }
            linkLabelbody.Visible = linkLabelHeaders.Visible = true;
            
        }

        private bool isurl(string b)
        {
            try
            {
                var t = new Uri(b);
                return true;
            }
            catch { }
            return false;
        }

        public bool requestCompleted =false;//{ get; set; }

        public bool succeed =false;///{ get; set; }

        public string Body ="";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible=textBox1.TextLength<3;
        }//{ get; set; }

        public string headers ="";

        private void linkLabelbody_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormBody f = new FormBody();
            f.setBody(this.Body);
            f.ShowInTaskbar = true;
            f.Icon = this.Icon;
            f.Show();
        }

        private void linkLabelHeaders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(this.headers);
        }

        private void linkLabeldev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Formabout f = new Formabout();
            f.Icon = this.Icon;
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = this.mini;
        } 
    }
}
