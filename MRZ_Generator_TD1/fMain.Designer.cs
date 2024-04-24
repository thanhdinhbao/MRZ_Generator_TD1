
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
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.picQRCode = new System.Windows.Forms.PictureBox();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxWard = new System.Windows.Forms.ComboBox();
            this.cbxDistrict = new System.Windows.Forms.ComboBox();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayCapCCCD = new System.Windows.Forms.DateTimePicker();
            this.rbFamale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.btnExitQR = new System.Windows.Forms.Button();
            this.btnGenQR = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslRemainTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslExp = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(950, 248);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(100, 67);
            this.btnSaveQR.TabIndex = 25;
            this.btnSaveQR.Text = "Save QR Code";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // picQRCode
            // 
            this.picQRCode.Location = new System.Drawing.Point(912, 62);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(174, 162);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 11;
            this.picQRCode.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "ID:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(838, 426);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(87, 57);
            this.btnCopy.TabIndex = 69;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(549, 347);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 20);
            this.txtID.TabIndex = 68;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(467, 387);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(348, 170);
            this.txtResult.TabIndex = 70;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(801, 300);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 61);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Tên:";
            // 
            // txtLName
            // 
            this.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLName.Location = new System.Drawing.Point(549, 109);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(185, 20);
            this.txtLName.TabIndex = 53;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(801, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 61);
            this.btnReset.TabIndex = 65;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtNgayCap
            // 
            this.dtNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCap.Location = new System.Drawing.Point(549, 302);
            this.dtNgayCap.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgayCap.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayCap.Name = "dtNgayCap";
            this.dtNgayCap.Size = new System.Drawing.Size(185, 20);
            this.dtNgayCap.TabIndex = 58;
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(549, 251);
            this.dtDOB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(185, 20);
            this.dtDOB.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Ngày hết hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Họ:";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(801, 64);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(84, 61);
            this.btnGen.TabIndex = 59;
            this.btnGen.Text = "Gen MRZ";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(663, 207);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(39, 17);
            this.radFemale.TabIndex = 56;
            this.radFemale.Text = "Nữ";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.Location = new System.Drawing.Point(572, 207);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(47, 17);
            this.radMale.TabIndex = 55;
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
            this.cbProvince.Location = new System.Drawing.Point(549, 160);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(185, 21);
            this.cbProvince.TabIndex = 54;
            // 
            // txtFName
            // 
            this.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFName.Location = new System.Drawing.Point(549, 67);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(185, 20);
            this.txtFName.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 391);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "Phường/Xã:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 91;
            this.label14.Text = "TP/Quận:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 90;
            this.label13.Text = "Tỉnh:";
            // 
            // cbxWard
            // 
            this.cbxWard.FormattingEnabled = true;
            this.cbxWard.Location = new System.Drawing.Point(117, 383);
            this.cbxWard.Name = "cbxWard";
            this.cbxWard.Size = new System.Drawing.Size(277, 21);
            this.cbxWard.TabIndex = 89;
            // 
            // cbxDistrict
            // 
            this.cbxDistrict.FormattingEnabled = true;
            this.cbxDistrict.Location = new System.Drawing.Point(117, 340);
            this.cbxDistrict.Name = "cbxDistrict";
            this.cbxDistrict.Size = new System.Drawing.Size(277, 21);
            this.cbxDistrict.TabIndex = 88;
            this.cbxDistrict.SelectedIndexChanged += new System.EventHandler(this.cbxDistrict_SelectedIndexChanged);
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(117, 300);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(277, 21);
            this.cbxProvince.TabIndex = 87;
            this.cbxProvince.SelectedIndexChanged += new System.EventHandler(this.cbxProvince_SelectedIndexChanged);
            // 
            // txtVillage
            // 
            this.txtVillage.Location = new System.Drawing.Point(117, 425);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(277, 20);
            this.txtVillage.TabIndex = 86;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(50, 425);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 85;
            this.label17.Text = "Thôn/Xóm:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 466);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 84;
            this.label16.Text = "Ngày cấp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "Giới tính:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 82;
            this.label11.Text = "Ngày tháng \r\nnăm sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Họ tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 80;
            this.label9.Text = "Số CMND cũ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Số CCCD:";
            // 
            // dtNgayCapCCCD
            // 
            this.dtNgayCapCCCD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayCapCCCD.Location = new System.Drawing.Point(117, 463);
            this.dtNgayCapCCCD.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgayCapCCCD.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgayCapCCCD.Name = "dtNgayCapCCCD";
            this.dtNgayCapCCCD.Size = new System.Drawing.Size(277, 20);
            this.dtNgayCapCCCD.TabIndex = 78;
            // 
            // rbFamale
            // 
            this.rbFamale.AutoSize = true;
            this.rbFamale.Location = new System.Drawing.Point(309, 250);
            this.rbFamale.Name = "rbFamale";
            this.rbFamale.Size = new System.Drawing.Size(39, 17);
            this.rbFamale.TabIndex = 77;
            this.rbFamale.Text = "Nữ";
            this.rbFamale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(117, 250);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 76;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(117, 192);
            this.dtNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtNgaySinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(277, 20);
            this.dtNgaySinh.TabIndex = 75;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 136);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 20);
            this.txtName.TabIndex = 74;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(117, 86);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(277, 20);
            this.txtCMND.TabIndex = 73;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(117, 38);
            this.txtCCCD.MaxLength = 12;
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(277, 20);
            this.txtCCCD.TabIndex = 72;
            // 
            // btnExitQR
            // 
            this.btnExitQR.Location = new System.Drawing.Point(950, 326);
            this.btnExitQR.Name = "btnExitQR";
            this.btnExitQR.Size = new System.Drawing.Size(84, 61);
            this.btnExitQR.TabIndex = 94;
            this.btnExitQR.Text = "Exit";
            this.btnExitQR.UseVisualStyleBackColor = true;
            this.btnExitQR.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGenQR
            // 
            this.btnGenQR.Location = new System.Drawing.Point(801, 139);
            this.btnGenQR.Name = "btnGenQR";
            this.btnGenQR.Size = new System.Drawing.Size(84, 61);
            this.btnGenQR.TabIndex = 93;
            this.btnGenQR.Text = "Gen QR";
            this.btnGenQR.UseVisualStyleBackColor = true;
            this.btnGenQR.Click += new System.EventHandler(this.btnGenQR_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslRemainTime,
            this.tslExp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1191, 22);
            this.statusStrip1.TabIndex = 95;
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
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 594);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnExitQR);
            this.Controls.Add(this.btnGenQR);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbxWard);
            this.Controls.Add(this.cbxDistrict);
            this.Controls.Add(this.cbxProvince);
            this.Controls.Add(this.txtVillage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayCapCCCD);
            this.Controls.Add(this.rbFamale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.dtNgaySinh);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtNgayCap);
            this.Controls.Add(this.dtDOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.radFemale);
            this.Controls.Add(this.radMale);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.txtFName);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAKE BANKER v2";
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Button btnSaveQR;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxWard;
        private System.Windows.Forms.ComboBox cbxDistrict;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayCapCCCD;
        private System.Windows.Forms.RadioButton rbFamale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Button btnExitQR;
        private System.Windows.Forms.Button btnGenQR;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslRemainTime;
        private System.Windows.Forms.ToolStripStatusLabel tslExp;
    }
}

