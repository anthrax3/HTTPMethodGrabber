namespace MethodGrabber
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabeldev = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelbody = new System.Windows.Forms.LinkLabel();
            this.linkLabelHeaders = new System.Windows.Forms.LinkLabel();
            this.labelStat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHeaderValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGrab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.linkLabeldev);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonGrab);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 192);
            this.panel1.TabIndex = 0;
            // 
            // linkLabeldev
            // 
            this.linkLabeldev.AutoSize = true;
            this.linkLabeldev.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkLabeldev.Location = new System.Drawing.Point(274, 4);
            this.linkLabeldev.Name = "linkLabeldev";
            this.linkLabeldev.Size = new System.Drawing.Size(35, 13);
            this.linkLabeldev.TabIndex = 7;
            this.linkLabeldev.TabStop = true;
            this.linkLabeldev.Text = "About";
            this.linkLabeldev.Visible = false;
            this.linkLabeldev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeldev_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelComment);
            this.panel2.Controls.Add(this.linkLabelbody);
            this.panel2.Controls.Add(this.linkLabelHeaders);
            this.panel2.Controls.Add(this.labelStat);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxHeaderValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxcode);
            this.panel2.Location = new System.Drawing.Point(7, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 99);
            this.panel2.TabIndex = 6;
            this.panel2.Visible = false;
            // 
            // linkLabelbody
            // 
            this.linkLabelbody.AutoSize = true;
            this.linkLabelbody.Location = new System.Drawing.Point(273, 75);
            this.linkLabelbody.Name = "linkLabelbody";
            this.linkLabelbody.Size = new System.Drawing.Size(31, 13);
            this.linkLabelbody.TabIndex = 8;
            this.linkLabelbody.TabStop = true;
            this.linkLabelbody.Text = "Body";
            this.linkLabelbody.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelbody_LinkClicked);
            // 
            // linkLabelHeaders
            // 
            this.linkLabelHeaders.AutoSize = true;
            this.linkLabelHeaders.Location = new System.Drawing.Point(201, 77);
            this.linkLabelHeaders.Name = "linkLabelHeaders";
            this.linkLabelHeaders.Size = new System.Drawing.Size(47, 13);
            this.linkLabelHeaders.TabIndex = 7;
            this.linkLabelHeaders.TabStop = true;
            this.linkLabelHeaders.Text = "Headers";
            this.linkLabelHeaders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHeaders_LinkClicked);
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Location = new System.Drawing.Point(94, 6);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(88, 13);
            this.labelStat.TabIndex = 6;
            this.labelStat.Text = "Request not sent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Statue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Allow value";
            // 
            // textBoxHeaderValue
            // 
            this.textBoxHeaderValue.Location = new System.Drawing.Point(86, 50);
            this.textBoxHeaderValue.Name = "textBoxHeaderValue";
            this.textBoxHeaderValue.ReadOnly = true;
            this.textBoxHeaderValue.Size = new System.Drawing.Size(219, 20);
            this.textBoxHeaderValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Statue code";
            // 
            // textBoxcode
            // 
            this.textBoxcode.Location = new System.Drawing.Point(86, 24);
            this.textBoxcode.Name = "textBoxcode";
            this.textBoxcode.ReadOnly = true;
            this.textBoxcode.Size = new System.Drawing.Size(219, 20);
            this.textBoxcode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label2.Location = new System.Drawing.Point(209, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "ex: http://google.com";
            this.label2.Visible = false;
            // 
            // buttonGrab
            // 
            this.buttonGrab.Location = new System.Drawing.Point(166, 57);
            this.buttonGrab.Name = "buttonGrab";
            this.buttonGrab.Size = new System.Drawing.Size(75, 23);
            this.buttonGrab.TabIndex = 2;
            this.buttonGrab.Text = "Grab";
            this.buttonGrab.UseVisualStyleBackColor = true;
            this.buttonGrab.Click += new System.EventHandler(this.buttonGrab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://google.com";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "url";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(6, 77);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(10, 13);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(343, 199);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Method Grabber";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGrab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeaderValue;
        private System.Windows.Forms.TextBox textBoxcode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelbody;
        private System.Windows.Forms.LinkLabel linkLabelHeaders;
        private System.Windows.Forms.LinkLabel linkLabeldev;
        private System.Windows.Forms.Label labelComment;
    }
}

