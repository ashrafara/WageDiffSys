namespace WageSys.Edit
{
    partial class EditEmployee
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
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.coBankBranch = new System.Windows.Forms.ComboBox();
            this.coBank = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtdegreAssign = new System.Windows.Forms.TextBox();
            this.txtbounsAssign = new System.Windows.Forms.TextBox();
            this.cbDegreee = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtemployementName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtemployeeBankNumber = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtemployeeInsuranceNumber = new System.Windows.Forms.TextBox();
            this.txtemployeeNationalNumber = new System.Windows.Forms.TextBox();
            this.txtemployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.cbDivision = new System.Windows.Forms.ComboBox();
            this.cbDepartement = new System.Windows.Forms.ComboBox();
            this.txtchildno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(645, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 26);
            this.label14.TabIndex = 146;
            this.label14.Text = "شاشة تعديل موظف";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "اعزب(ة)",
            "متزوج(ة)",
            "مطلق(ة)",
            "ارمل(ة)"});
            this.comboBox3.Location = new System.Drawing.Point(479, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(207, 23);
            this.comboBox3.TabIndex = 145;
            // 
            // coBankBranch
            // 
            this.coBankBranch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBankBranch.FormattingEnabled = true;
            this.coBankBranch.Location = new System.Drawing.Point(121, 83);
            this.coBankBranch.Name = "coBankBranch";
            this.coBankBranch.Size = new System.Drawing.Size(246, 23);
            this.coBankBranch.TabIndex = 144;
            this.coBankBranch.SelectedIndexChanged += new System.EventHandler(this.coBankBranch_SelectedIndexChanged);
            // 
            // coBank
            // 
            this.coBank.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coBank.FormattingEnabled = true;
            this.coBank.Location = new System.Drawing.Point(1114, 53);
            this.coBank.Name = "coBank";
            this.coBank.Size = new System.Drawing.Size(226, 23);
            this.coBank.TabIndex = 143;
            this.coBank.SelectedIndexChanged += new System.EventHandler(this.coBank_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "مفعل",
            "موقوف"});
            this.comboBox2.Location = new System.Drawing.Point(777, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(231, 23);
            this.comboBox2.TabIndex = 140;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "تعيين",
            "عقد ",
            "ندب"});
            this.comboBox1.Location = new System.Drawing.Point(1114, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 23);
            this.comboBox1.TabIndex = 139;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 138);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 23);
            this.dateTimePicker1.TabIndex = 138;
            // 
            // txtNationality
            // 
            this.txtNationality.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(121, 135);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(246, 23);
            this.txtNationality.TabIndex = 137;
            this.txtNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdegreAssign
            // 
            this.txtdegreAssign.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdegreAssign.Location = new System.Drawing.Point(1114, 137);
            this.txtdegreAssign.Name = "txtdegreAssign";
            this.txtdegreAssign.Size = new System.Drawing.Size(226, 23);
            this.txtdegreAssign.TabIndex = 136;
            this.txtdegreAssign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbounsAssign
            // 
            this.txtbounsAssign.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbounsAssign.Location = new System.Drawing.Point(120, 160);
            this.txtbounsAssign.Name = "txtbounsAssign";
            this.txtbounsAssign.Size = new System.Drawing.Size(247, 23);
            this.txtbounsAssign.TabIndex = 135;
            this.txtbounsAssign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDegreee
            // 
            this.cbDegreee.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDegreee.FormattingEnabled = true;
            this.cbDegreee.Location = new System.Drawing.Point(479, 108);
            this.cbDegreee.Name = "cbDegreee";
            this.cbDegreee.Size = new System.Drawing.Size(205, 23);
            this.cbDegreee.TabIndex = 133;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1170, 706);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 27);
            this.button2.TabIndex = 132;
            this.button2.Text = "تعديل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1300, 706);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 131;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtemployementName
            // 
            this.txtemployementName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployementName.Location = new System.Drawing.Point(121, 109);
            this.txtemployementName.Name = "txtemployementName";
            this.txtemployementName.Size = new System.Drawing.Size(245, 23);
            this.txtemployementName.TabIndex = 130;
            this.txtemployementName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1075, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 15);
            this.label20.TabIndex = 114;
            this.label20.Text = "القسم ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(57, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 15);
            this.label23.TabIndex = 115;
            this.label23.Text = "اسم الوظيفة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 126;
            this.label5.Text = "تاريخ المباشرة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 122;
            this.label4.Text = "الجنسية";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 15);
            this.label11.TabIndex = 121;
            this.label11.Text = "الحالة الاجتماعية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(716, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 120;
            this.label6.Text = "حالة المرتب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1049, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 119;
            this.label3.Text = "نوع التوظيف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 118;
            this.label8.Text = "العلاوة المنتدب اليها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 117;
            this.label2.Text = "العلاوة السنوية";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 125;
            this.label10.Text = "الفرع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1069, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 124;
            this.label9.Text = "المصرف";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1017, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 116;
            this.label7.Text = "الدرجة المنتدب اليها";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(394, 116);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 15);
            this.label25.TabIndex = 123;
            this.label25.Text = "الدرجة الوظيفية";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(407, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 15);
            this.label21.TabIndex = 127;
            this.label21.Text = "رقم الحساب ";
            // 
            // txtemployeeBankNumber
            // 
            this.txtemployeeBankNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeBankNumber.Location = new System.Drawing.Point(479, 83);
            this.txtemployeeBankNumber.Name = "txtemployeeBankNumber";
            this.txtemployeeBankNumber.Size = new System.Drawing.Size(205, 23);
            this.txtemployeeBankNumber.TabIndex = 129;
            this.txtemployeeBankNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(716, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 15);
            this.label29.TabIndex = 128;
            this.label29.Text = "اسم الادارة";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(406, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 110;
            this.label13.Text = "الرقم الضماني";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(715, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 111;
            this.label12.Text = "الرقم الوطني";
            // 
            // txtemployeeInsuranceNumber
            // 
            this.txtemployeeInsuranceNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeInsuranceNumber.Location = new System.Drawing.Point(479, 56);
            this.txtemployeeInsuranceNumber.Name = "txtemployeeInsuranceNumber";
            this.txtemployeeInsuranceNumber.Size = new System.Drawing.Size(205, 23);
            this.txtemployeeInsuranceNumber.TabIndex = 112;
            this.txtemployeeInsuranceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemployeeNationalNumber
            // 
            this.txtemployeeNationalNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeNationalNumber.Location = new System.Drawing.Point(777, 52);
            this.txtemployeeNationalNumber.Name = "txtemployeeNationalNumber";
            this.txtemployeeNationalNumber.Size = new System.Drawing.Size(231, 23);
            this.txtemployeeNationalNumber.TabIndex = 113;
            this.txtemployeeNationalNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtemployeeName
            // 
            this.txtemployeeName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeName.Location = new System.Drawing.Point(121, 58);
            this.txtemployeeName.Name = "txtemployeeName";
            this.txtemployeeName.Size = new System.Drawing.Size(246, 23);
            this.txtemployeeName.TabIndex = 109;
            this.txtemployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 108;
            this.label1.Text = "اسم الموظف";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(89, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 15);
            this.label15.TabIndex = 108;
            this.label15.Text = "ر.م";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 147;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1345, 505);
            this.dataGridView1.TabIndex = 148;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1233, 706);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 27);
            this.button3.TabIndex = 149;
            this.button3.Text = "الحذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbDivision
            // 
            this.cbDivision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDivision.FormattingEnabled = true;
            this.cbDivision.Items.AddRange(new object[] {
            "مكتب المراجعة الداخلية",
            "مكتب شؤون المدير التنفيذي",
            "مكتب المستشارين ",
            "قسم الشؤون القانونية ",
            "قسم التسجيل والمنازعات",
            "قسم التخطيط والتعاون الفني",
            "قسم المتابعة الفنية",
            "قسم المتابعة المالية",
            "قسم شؤون الموظفين والتدريب",
            "قسم الشؤون المالية",
            "قسم العلاقات العامة الخدمات"});
            this.cbDivision.Location = new System.Drawing.Point(1114, 82);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(226, 23);
            this.cbDivision.TabIndex = 151;
            // 
            // cbDepartement
            // 
            this.cbDepartement.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartement.FormattingEnabled = true;
            this.cbDepartement.Items.AddRange(new object[] {
            "رئيس مجلس الادارة",
            "المدير التنفيذي",
            "ادارة الشؤون القانونية والتسجيل",
            "إدارة الخطيط والمتابعة",
            "إدارة الشؤون الادارية والمالية"});
            this.cbDepartement.Location = new System.Drawing.Point(777, 80);
            this.cbDepartement.Name = "cbDepartement";
            this.cbDepartement.Size = new System.Drawing.Size(231, 23);
            this.cbDepartement.TabIndex = 150;
            // 
            // txtchildno
            // 
            this.txtchildno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtchildno.Location = new System.Drawing.Point(777, 163);
            this.txtchildno.Name = "txtchildno";
            this.txtchildno.Size = new System.Drawing.Size(231, 23);
            this.txtchildno.TabIndex = 153;
            this.txtchildno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(720, 168);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 15);
            this.label16.TabIndex = 152;
            this.label16.Text = "عدد الابناء";
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox4.Location = new System.Drawing.Point(777, 108);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(231, 22);
            this.comboBox4.TabIndex = 154;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1369, 745);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.txtchildno);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cbDivision);
            this.Controls.Add(this.cbDepartement);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.coBankBranch);
            this.Controls.Add(this.coBank);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtdegreAssign);
            this.Controls.Add(this.txtbounsAssign);
            this.Controls.Add(this.cbDegreee);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtemployementName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtemployeeBankNumber);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtemployeeInsuranceNumber);
            this.Controls.Add(this.txtemployeeNationalNumber);
            this.Controls.Add(this.txtemployeeName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Name = "EditEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تعديل الموظفين";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox coBankBranch;
        private System.Windows.Forms.ComboBox coBank;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtdegreAssign;
        private System.Windows.Forms.TextBox txtbounsAssign;
        private System.Windows.Forms.ComboBox cbDegreee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtemployementName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtemployeeBankNumber;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtemployeeInsuranceNumber;
        private System.Windows.Forms.TextBox txtemployeeNationalNumber;
        private System.Windows.Forms.TextBox txtemployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbDivision;
        private System.Windows.Forms.ComboBox cbDepartement;
        private System.Windows.Forms.TextBox txtchildno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}