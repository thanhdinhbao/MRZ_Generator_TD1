﻿
namespace MRZ_Generator_TD1
{
    partial class fMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabMRZ = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslRemainTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslExp = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtNgayCap = new System.Windows.Forms.DateTimePicker();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.tabQRCode = new System.Windows.Forms.TabPage();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnExitQR = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.btnGenQR = new System.Windows.Forms.Button();
            this.dtNgayCapCCCD = new System.Windows.Forms.DateTimePicker();
            this.rbFamale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxWard = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabMRZ.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabMRZ);
            this.tabMain.Controls.Add(this.tabQRCode);
            this.tabMain.Location = new System.Drawing.Point(3, 3);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(585, 590);
            this.tabMain.TabIndex = 0;
            // 
            // tabMRZ
            // 
            this.tabMRZ.Controls.Add(this.statusStrip1);
            this.tabMRZ.Controls.Add(this.label6);
            this.tabMRZ.Controls.Add(this.btnCopy);
            this.tabMRZ.Controls.Add(this.txtID);
            this.tabMRZ.Controls.Add(this.txtResult);
            this.tabMRZ.Controls.Add(this.btnExit);
            this.tabMRZ.Controls.Add(this.label8);
            this.tabMRZ.Controls.Add(this.txtLName);
            this.tabMRZ.Controls.Add(this.btnReset);
            this.tabMRZ.Controls.Add(this.dtNgayCap);
            this.tabMRZ.Controls.Add(this.dtDOB);
            this.tabMRZ.Controls.Add(this.label5);
            this.tabMRZ.Controls.Add(this.label4);
            this.tabMRZ.Controls.Add(this.label3);
            this.tabMRZ.Controls.Add(this.label2);
            this.tabMRZ.Controls.Add(this.label1);
            this.tabMRZ.Controls.Add(this.btnGen);
            this.tabMRZ.Controls.Add(this.radFemale);
            this.tabMRZ.Controls.Add(this.radMale);
            this.tabMRZ.Controls.Add(this.cbProvince);
            this.tabMRZ.Controls.Add(this.txtFName);
            this.tabMRZ.Location = new System.Drawing.Point(4, 22);
            this.tabMRZ.Name = "tabMRZ";
            this.tabMRZ.Padding = new System.Windows.Forms.Padding(3);
            this.tabMRZ.Size = new System.Drawing.Size(577, 564);
            this.tabMRZ.TabIndex = 0;
            this.tabMRZ.Text = "MRZ";
            this.tabMRZ.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslRemainTime,
            this.tslExp});
            this.statusStrip1.Location = new System.Drawing.Point(3, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(78, 17);
            this.toolStripStatusLabel1.Text = "Hạn sử dụng:";
            // 
            // tslRemainTime
            // 
            this.tslRemainTime.Name = "tslRemainTime";
            this.tslRemainTime.Size = new System.Drawing.Size(85, 17);
            this.tslRemainTime.Text = "Còn lại ... ngày";
            // 
            // tslExp
            // 
            this.tslExp.Name = "tslExp";
            this.tslExp.Size = new System.Drawing.Size(118, 17);
            this.tslExp.Text = "toolStripStatusLabel3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "ID:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(447, 416);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(87, 57);
            this.btnCopy.TabIndex = 49;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 305);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 20);
            this.txtID.TabIndex = 48;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(64, 345);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(348, 170);
            this.txtResult.TabIndex = 50;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 46);
            this.btnExit.TabIndex = 47;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(99, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Tên:";
            // 
            // txtLName
            // 
            this.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLName.Location = new System.Drawing.Point(146, 67);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(185, 20);
            this.txtLName.TabIndex = 33;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(447, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 49);
            this.btnReset.TabIndex = 45;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCap.Location = new System.Drawing.Point(146, 260);
            this.dtNgayCap.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgayCap.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(185, 20);
            this.dtNgayCap.TabIndex = 38;
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(146, 209);
            this.dtDOB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(185, 20);
            this.dtDOB.TabIndex = 37;
            this.dtDOB.ValueChanged += new System.EventHandler(this.dtDOB_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ngày hết hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Họ:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(447, 99);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(87, 61);
            this.btnGen.TabIndex = 39;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(260, 165);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 36;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(169, 165);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 35;
            this.radMale.TabStop = true;
            this.radMale.Text = "Nam";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // cbProvince
            // 
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Items.AddRange(new object[] {
            "Hà Nội",
            "Hà Giang",
            "Cao Bằng",
            "Bắc Kạn",
            "Tuyên Quang",
            "Lào Cai",
            "Điện Biên",
            "Lai Châu",
            "Sơn La",
            "Yên Bái",
            "Hòa Bình",
            "Thái Nguyên",
            "Lạng Sơn",
            "Quảng Ninh",
            "Bắc Giang",
            "Phú Thọ",
            "Vĩnh Phúc",
            "Bắc Ninh",
            "Hải Dương",
            "Hải Phòng",
            "Hưng Yên",
            "Thái Bình",
            "Hà Nam",
            "Nam Định",
            "Ninh Bình",
            "Thanh Hóa",
            "Nghệ An",
            "Hà Tĩnh",
            "Quảng Bình",
            "Quảng Trị",
            "Thừa Thiên Huế",
            "Đà Nẵng",
            "Quảng Nam",
            "Quảng Ngãi",
            "Bình Định",
            "Phú Yên",
            "Khánh Hòa",
            "Ninh Thuận",
            "Bình Thuận",
            "Kon Tum",
            "Gia Lai",
            "Đắk Lắk",
            "Đắk Nông",
            "Lâm Đồng",
            "Bình Phước",
            "Tây Ninh",
            "Bình Dương",
            "Đồng Nai",
            "Bà Rịa - Vũng Tàu",
            "Hồ Chí Minh",
            "Long An",
            "Tiền Giang",
            "Bến Tre",
            "Trà Vinh",
            "Vĩnh Long",
            "Đồng Tháp",
            "An Giang",
            "Kiên Giang",
            "Cần Thơ",
            "Hậu Giang",
            "Sóc Trăng",
            "Bạc Liêu",
            "Cà Mau"});
            this.cbProvince.Location = new System.Drawing.Point(146, 118);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(185, 21);
            this.cbProvince.TabIndex = 34;
            // 
            // txtFName
            // 
            this.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFName.Location = new System.Drawing.Point(146, 25);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(185, 20);
            this.txtFName.TabIndex = 32;
            // 
            // tabQRCode
            // 
            this.tabQRCode.Controls.Add(this.label15);
            this.tabQRCode.Controls.Add(this.label14);
            this.tabQRCode.Controls.Add(this.label13);
            this.tabQRCode.Controls.Add(this.cbxWard);
            this.tabQRCode.Controls.Add(this.cbxDistrict);
            this.tabQRCode.Controls.Add(this.cbxProvince);
            this.tabQRCode.Controls.Add(this.btnSaveQR);
            this.tabQRCode.Controls.Add(this.txtVillage);
            this.tabQRCode.Controls.Add(this.label17);
            this.tabQRCode.Controls.Add(this.btnExitQR);
            this.tabQRCode.Controls.Add(this.label16);
            this.tabQRCode.Controls.Add(this.label12);
            this.tabQRCode.Controls.Add(this.label11);
            this.tabQRCode.Controls.Add(this.label10);
            this.tabQRCode.Controls.Add(this.label9);
            this.tabQRCode.Controls.Add(this.label7);
            this.tabQRCode.Controls.Add(this.picQRCode);
            this.tabQRCode.Controls.Add(this.btnGenQR);
            this.tabQRCode.Controls.Add(this.dtNgayCapCCCD);
            this.tabQRCode.Controls.Add(this.rbFamale);
            this.tabQRCode.Controls.Add(this.rbMale);
            this.tabQRCode.Controls.Add(this.dtNgaySinh);
            this.tabQRCode.Controls.Add(this.txtName);
            this.tabQRCode.Controls.Add(this.txtCMND);
            this.tabQRCode.Controls.Add(this.txtCCCD);
            this.tabQRCode.Location = new System.Drawing.Point(4, 22);
            this.tabQRCode.Name = "tabQRCode";
            this.tabQRCode.Padding = new System.Windows.Forms.Padding(3);
            this.tabQRCode.Size = new System.Drawing.Size(577, 564);
            this.tabQRCode.TabIndex = 1;
            this.tabQRCode.Text = "Gen QR";
            this.tabQRCode.UseVisualStyleBackColor = true;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(427, 210);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(100, 67);
            this.btnSaveQR.TabIndex = 25;
            this.btnSaveQR.Text = "Save QR Code";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // txtVillage
            // 
            this.txtVillage.Location = new System.Drawing.Point(92, 410);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(277, 20);
            this.txtVillage.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 410);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Thôn/Xóm:";
            // 
            // btnExitQR
            // 
            this.btnExitQR.Location = new System.Drawing.Point(427, 448);
            this.btnExitQR.Name = "btnExitQR";
            this.btnExitQR.Size = new System.Drawing.Size(84, 61);
            this.btnExitQR.TabIndex = 21;
            this.btnExitQR.Text = "Exit";
            this.btnExitQR.UseVisualStyleBackColor = true;
            this.btnExitQR.Click += new System.EventHandler(this.btnExitQR_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Ngày cấp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ngày tháng \r\nnăm sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Số CMND cũ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số CCCD:";
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(385, 23);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(174, 162);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 11;
            this.picQRCode.TabStop = false;
            // 
            // btnGenQR
            // 
            this.btnGenQR.Location = new System.Drawing.Point(427, 320);
            this.btnGenQR.Name = "btnGenQR";
            this.btnGenQR.Size = new System.Drawing.Size(84, 61);
            this.btnGenQR.TabIndex = 10;
            this.btnGenQR.Text = "Gen QR";
            this.btnGenQR.UseVisualStyleBackColor = true;
            this.btnGenQR.Click += new System.EventHandler(this.btnGenQR_Click);
            // 
            // dtNgayCapCCCD
            // 
            this.dtNgayCapCCCD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCapCCCD.Location = new System.Drawing.Point(92, 448);
            this.dtNgayCapCCCD.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgayCapCCCD.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayCapCCCD.Name = "dtNgayCapCCCD";
            this.dtNgayCapCCCD.Size = new System.Drawing.Size(277, 20);
            this.dtNgayCapCCCD.TabIndex = 9;
            // 
            // rbFamale
            // 
            this.rbFamale.AutoSize = true;
            this.rbFamale.Location = new System.Drawing.Point(284, 235);
            this.rbFamale.Name = "rbFamale";
            this.rbFamale.Size = new System.Drawing.Size(39, 17);
            this.rbFamale.TabIndex = 5;
            this.rbFamale.Text = "Nữ";
            this.rbFamale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(92, 235);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 4;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(92, 177);
            this.dtNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(277, 20);
            this.dtNgaySinh.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(92, 71);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(277, 20);
            this.txtCMND.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(92, 23);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(277, 20);
            this.txtCCCD.TabIndex = 0;
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(92, 285);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(277, 21);
            this.cbxProvince.TabIndex = 26;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(92, 325);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(277, 21);
            this.cbxDistrict.TabIndex = 27;
            this.cbxDistrict.SelectedIndexChanged += new System.EventHandler(this.cbxDistrict_SelectedIndexChanged);
            // 
            // cbxWard
            // 
            this.cbxWard.FormattingEnabled = true;
            this.cbxWard.Location = new System.Drawing.Point(92, 368);
            this.cbxWard.Name = "cbxWard";
            this.cbxWard.Size = new System.Drawing.Size(277, 21);
            this.cbxWard.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Tỉnh:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "TP/Quận:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Phường/Xã:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 594);
            this.Controls.Add(this.tabMain);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAKE BANKER v2";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabMRZ.ResumeLayout(false);
            this.tabMRZ.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabQRCode.ResumeLayout(false);
            this.tabQRCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabMRZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtNgayCap;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TabPage tabQRCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnGenQR;
        private System.Windows.Forms.DateTimePicker dtNgayCapCCCD;
        private System.Windows.Forms.RadioButton rbFamale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnExitQR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslRemainTime;
        private System.Windows.Forms.ToolStripStatusLabel tslExp;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.ComboBox cbxWard;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

