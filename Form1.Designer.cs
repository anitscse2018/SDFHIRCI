namespace EmailSender
{
    partial class Email
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsender = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtreciever = new System.Windows.Forms.TextBox();
            this.txtattachment = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.btnattach = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Email ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Receiver\'s Email ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attachment :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Body :";
            // 
            // txtsender
            // 
            this.txtsender.Location = new System.Drawing.Point(209, 50);
            this.txtsender.Name = "txtsender";
            this.txtsender.Size = new System.Drawing.Size(322, 20);
            this.txtsender.TabIndex = 6;
            this.txtsender.TextChanged += new System.EventHandler(this.txtsender_TextChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(209, 79);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(322, 20);
            this.txtpass.TabIndex = 7;
            // 
            // txtreciever
            // 
            this.txtreciever.Location = new System.Drawing.Point(209, 114);
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.Size = new System.Drawing.Size(322, 20);
            this.txtreciever.TabIndex = 8;
            // 
            // txtattachment
            // 
            this.txtattachment.Location = new System.Drawing.Point(134, 143);
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.ReadOnly = true;
            this.txtattachment.Size = new System.Drawing.Size(316, 20);
            this.txtattachment.TabIndex = 9;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(104, 177);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(427, 20);
            this.txtsubject.TabIndex = 10;
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(88, 217);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(443, 112);
            this.txtbody.TabIndex = 11;
            // 
            // btnattach
            // 
            this.btnattach.Location = new System.Drawing.Point(457, 140);
            this.btnattach.Name = "btnattach";
            this.btnattach.Size = new System.Drawing.Size(75, 31);
            this.btnattach.TabIndex = 12;
            this.btnattach.Text = "Attach";
            this.btnattach.UseVisualStyleBackColor = true;
            this.btnattach.Click += new System.EventHandler(this.btnattach_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(25, 335);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(222, 31);
            this.btnsend.TabIndex = 13;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 388);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnattach);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtsender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsender;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtreciever;
        private System.Windows.Forms.TextBox txtattachment;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.Button btnattach;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}

