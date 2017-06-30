namespace EmployeeDatabase
{
    partial class AddEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.btnClose = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.tbResident = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbDept = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.dtHire = new System.Windows.Forms.DateTimePicker();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.employeedataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empData = new EmployeeDatabase.EmpData();
            this.employeedataTableAdapter = new EmployeeDatabase.EmpDataTableAdapters.employeedataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(723, 652);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 46);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbId
            // 
            this.tbId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "ID", true));
            this.tbId.Location = new System.Drawing.Point(226, 41);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Department";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 499);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hire Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Resident Telephone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 564);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Mobile";
            // 
            // tbFullname
            // 
            this.tbFullname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Full Name", true));
            this.tbFullname.Location = new System.Drawing.Point(226, 104);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(554, 22);
            this.tbFullname.TabIndex = 1;
            // 
            // tbResident
            // 
            this.tbResident.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Resident Telephone", true));
            this.tbResident.Location = new System.Drawing.Point(222, 561);
            this.tbResident.Name = "tbResident";
            this.tbResident.Size = new System.Drawing.Size(199, 22);
            this.tbResident.TabIndex = 11;
            // 
            // tbPosition
            // 
            this.tbPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Position", true));
            this.tbPosition.Location = new System.Drawing.Point(558, 366);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(222, 22);
            this.tbPosition.TabIndex = 8;
            // 
            // tbFname
            // 
            this.tbFname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "First Name", true));
            this.tbFname.Location = new System.Drawing.Point(226, 169);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(199, 22);
            this.tbFname.TabIndex = 2;
            // 
            // tbLname
            // 
            this.tbLname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Last Name", true));
            this.tbLname.Location = new System.Drawing.Point(558, 175);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(222, 22);
            this.tbLname.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Address", true));
            this.tbAddress.Location = new System.Drawing.Point(226, 227);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(554, 38);
            this.tbAddress.TabIndex = 4;
            // 
            // tbDept
            // 
            this.tbDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Department", true));
            this.tbDept.Location = new System.Drawing.Point(226, 366);
            this.tbDept.Name = "tbDept";
            this.tbDept.Size = new System.Drawing.Size(203, 22);
            this.tbDept.TabIndex = 7;
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Gender", true));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(558, 301);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(222, 24);
            this.cbGender.TabIndex = 6;
            // 
            // tbMobile
            // 
            this.tbMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Mobile Number", true));
            this.tbMobile.Location = new System.Drawing.Point(558, 561);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(222, 22);
            this.tbMobile.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 434);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(226, 429);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 22);
            this.tbEmail.TabIndex = 9;
            // 
            // dtHire
            // 
            this.dtHire.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Hire Date", true));
            this.dtHire.Location = new System.Drawing.Point(222, 494);
            this.dtHire.Name = "dtHire";
            this.dtHire.Size = new System.Drawing.Size(203, 22);
            this.dtHire.TabIndex = 10;
            // 
            // dtDob
            // 
            this.dtDob.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeedataBindingSource, "Date of Birth", true));
            this.dtDob.Location = new System.Drawing.Point(226, 299);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(203, 22);
            this.dtDob.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(632, 652);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 46);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(541, 652);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 46);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(450, 652);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(76, 46);
            this.btnNew.TabIndex = 29;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // employeedataBindingSource
            // 
            this.employeedataBindingSource.DataMember = "employeedata";
            this.employeedataBindingSource.DataSource = this.empData;
            // 
            // empData
            // 
            this.empData.DataSetName = "EmpData";
            this.empData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeedataTableAdapter
            // 
            this.employeedataTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 710);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtHire);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.tbDept);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbResident);
            this.Controls.Add(this.tbFullname);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeedataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbId;
        private EmpData empData;
        private System.Windows.Forms.BindingSource employeedataBindingSource;
        private EmpDataTableAdapters.employeedataTableAdapter employeedataTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.TextBox tbResident;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbDept;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.DateTimePicker dtHire;
        private System.Windows.Forms.DateTimePicker dtDob;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
    }
}