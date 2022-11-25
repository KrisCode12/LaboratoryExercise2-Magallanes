namespace _05_Laboratory_Exercise_2
{
    partial class Student_Record
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.dtpBday = new System.Windows.Forms.DateTimePicker();
            this.tbContactno = new System.Windows.Forms.TextBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbMiddlename = new System.Windows.Forms.TextBox();
            this.tbage = new System.Windows.Forms.TextBox();
            this.tbgender = new System.Windows.Forms.TextBox();
            this.tbStudNo = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.lblContactnum = new System.Windows.Forms.Label();
            this.lblMiddlename = new System.Windows.Forms.Label();
            this.lbalGender = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblStudentno = new System.Windows.Forms.Label();
            this.btnRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(271, 308);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(111, 30);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dtpBday
            // 
            this.dtpBday.Location = new System.Drawing.Point(96, 214);
            this.dtpBday.Name = "dtpBday";
            this.dtpBday.Size = new System.Drawing.Size(200, 20);
            this.dtpBday.TabIndex = 36;
            // 
            // tbContactno
            // 
            this.tbContactno.Location = new System.Drawing.Point(547, 211);
            this.tbContactno.Name = "tbContactno";
            this.tbContactno.Size = new System.Drawing.Size(99, 20);
            this.tbContactno.TabIndex = 35;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(320, 114);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(251, 21);
            this.cbProgram.TabIndex = 34;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(115, 154);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(132, 20);
            this.tbFname.TabIndex = 33;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(314, 154);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(117, 20);
            this.tbLname.TabIndex = 32;
            // 
            // tbMiddlename
            // 
            this.tbMiddlename.Location = new System.Drawing.Point(514, 154);
            this.tbMiddlename.Name = "tbMiddlename";
            this.tbMiddlename.Size = new System.Drawing.Size(132, 20);
            this.tbMiddlename.TabIndex = 31;
            // 
            // tbage
            // 
            this.tbage.Location = new System.Drawing.Point(89, 180);
            this.tbage.Name = "tbage";
            this.tbage.Size = new System.Drawing.Size(38, 20);
            this.tbage.TabIndex = 30;
            // 
            // tbgender
            // 
            this.tbgender.Location = new System.Drawing.Point(343, 211);
            this.tbgender.Name = "tbgender";
            this.tbgender.Size = new System.Drawing.Size(117, 20);
            this.tbgender.TabIndex = 29;
            // 
            // tbStudNo
            // 
            this.tbStudNo.Location = new System.Drawing.Point(114, 112);
            this.tbStudNo.Name = "tbStudNo";
            this.tbStudNo.Size = new System.Drawing.Size(132, 20);
            this.tbStudNo.TabIndex = 28;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(57, 183);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(26, 13);
            this.lblage.TabIndex = 27;
            this.lblage.Text = "Age";
            // 
            // lblContactnum
            // 
            this.lblContactnum.AutoSize = true;
            this.lblContactnum.Location = new System.Drawing.Point(466, 214);
            this.lblContactnum.Name = "lblContactnum";
            this.lblContactnum.Size = new System.Drawing.Size(84, 13);
            this.lblContactnum.TabIndex = 26;
            this.lblContactnum.Text = "Contact Number";
            // 
            // lblMiddlename
            // 
            this.lblMiddlename.AutoSize = true;
            this.lblMiddlename.Location = new System.Drawing.Point(437, 157);
            this.lblMiddlename.Name = "lblMiddlename";
            this.lblMiddlename.Size = new System.Drawing.Size(72, 13);
            this.lblMiddlename.TabIndex = 25;
            this.lblMiddlename.Text = "Middle Name:";
            // 
            // lbalGender
            // 
            this.lbalGender.AutoSize = true;
            this.lbalGender.Location = new System.Drawing.Point(302, 214);
            this.lbalGender.Name = "lbalGender";
            this.lbalGender.Size = new System.Drawing.Size(42, 13);
            this.lbalGender.TabIndex = 24;
            this.lbalGender.Text = "Gender";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(253, 157);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(58, 13);
            this.lblLastname.TabIndex = 23;
            this.lblLastname.Text = "Last Name";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(268, 117);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(46, 13);
            this.lblProgram.TabIndex = 22;
            this.lblProgram.Text = "Program";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(47, 218);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(45, 13);
            this.lblBirthday.TabIndex = 21;
            this.lblBirthday.Text = "Birthday";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(52, 157);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname.TabIndex = 20;
            this.lblFirstname.Text = "First Name";
            // 
            // lblStudentno
            // 
            this.lblStudentno.AutoSize = true;
            this.lblStudentno.Location = new System.Drawing.Point(47, 117);
            this.lblStudentno.Name = "lblStudentno";
            this.lblStudentno.Size = new System.Drawing.Size(61, 13);
            this.lblStudentno.TabIndex = 19;
            this.lblStudentno.Text = "StudentNo.";
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(535, 310);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(111, 30);
            this.btnRecords.TabIndex = 38;
            this.btnRecords.Text = "Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 352);
            this.Controls.Add(this.btnRecords);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpBday);
            this.Controls.Add(this.tbContactno);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbMiddlename);
            this.Controls.Add(this.tbage);
            this.Controls.Add(this.tbgender);
            this.Controls.Add(this.tbStudNo);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblContactnum);
            this.Controls.Add(this.lblMiddlename);
            this.Controls.Add(this.lbalGender);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.lblStudentno);
            this.Name = "Student_Record";
            this.Text = "Student_Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DateTimePicker dtpBday;
        private System.Windows.Forms.TextBox tbContactno;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbMiddlename;
        private System.Windows.Forms.TextBox tbage;
        private System.Windows.Forms.TextBox tbgender;
        private System.Windows.Forms.TextBox tbStudNo;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lblContactnum;
        private System.Windows.Forms.Label lblMiddlename;
        private System.Windows.Forms.Label lbalGender;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblStudentno;
        private System.Windows.Forms.Button btnRecords;
    }
}