using Newtonsoft.Json;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MRZ_Generator_TD1
{
    public partial class fMain : Form
    {
        List<Tuple<string, string>> provinces;
        dulieu m;
        public fMain()
        {
            InitializeComponent();
        }
        #region MRZ

        void LoadProvince()
        {
            using (StreamReader r = new StreamReader("tinh_thanh.json"))
            {
                string json = r.ReadToEnd();
                m = JsonConvert.DeserializeObject<dulieu>(json);

            }
            cbxProvince.DataSource = m.data;
            cbxProvince.DisplayMember = "name";
            cbxProvince.ValueMember = "level1_id";
        }

        void LoadDistrict()
        {
            if (m != null)
            {
                //LoadProvince();
                cbxDistrict.DataSource = ((province)cbxProvince.SelectedItem).level2s;
                cbxDistrict.DisplayMember = "name"; // Tên thuộc tính hiển thị của thành phố
                cbxDistrict.ValueMember = "level2_id";
            }
        }

        private void LoadCommune()
        {
            cbxWard.DataSource = ((district)cbxDistrict.SelectedItem).level3s;
            cbxWard.DisplayMember = "name";
            cbxWard.ValueMember = "level3_id";
        }

        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.Checked = false;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.ClearSelected();
                    }
                }
            }
        }
        private string RunCMD(string cmd)
        {
            Process cmdProcess;
            cmdProcess = new Process();
            cmdProcess.StartInfo.FileName = "cmd.exe";
            cmdProcess.StartInfo.Arguments = "/c " + cmd;
            cmdProcess.StartInfo.RedirectStandardOutput = true;
            cmdProcess.StartInfo.UseShellExecute = false;
            cmdProcess.StartInfo.CreateNoWindow = true;
            cmdProcess.StartInfo.Verb = "runas";
            cmdProcess.Start();
            string output = cmdProcess.StandardOutput.ReadToEnd();
            cmdProcess.WaitForExit();
            if (String.IsNullOrEmpty(output))
                return "";
            return output;
        }
        private void btnGen_Click(object sender, EventArgs e)
        {
            //Gen final Hash
            string f1 = txtID.Text + GenDigit(txtID.Text) + GetProvinceCode() + txtID.Text + "<<" + GenDigit(GetProvinceCode() + txtID.Text);
            string f2 = getDOB() + GenDigit(getDOB()) + getExpDate() + GenDigit(getExpDate()) + "<<<<<<<<<<";
            string fHash = GenDigit(f1 + f2).ToString();

            //Gen each line
            string line1 = "IDVNM" + txtID.Text + GenDigit(txtID.Text) + GetProvinceCode() + txtID.Text + "<<" + GenDigit(GetProvinceCode() + txtID.Text) + Environment.NewLine;
            string line2 = getDOB() + GenDigit(getDOB()) + GetSex() + getExpDate() + GenDigit(getExpDate()) + "VNM" + "<<<<<<<<<<<" + fHash + Environment.NewLine;
            int len = GetName().Length;
            string line3 = GetName() + string.Concat(Enumerable.Repeat("<", 30 - len));

            txtResult.Text = line1 + line2 + line3;
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            string output = RunCMD("wmic diskdrive get serialNumber"); // check số serial ổ cứng
            using (StreamWriter HDD = new StreamWriter("HDD.txt", true))
            {
                HDD.WriteLine(output);
                HDD.Close();
            }
            string[] lines = File.ReadAllLines("HDD.txt");
            File.Delete("HDD.txt");
            string str = Regex.Replace(lines[2], @"\s", ""); // lấy serial đầu tiên

            string outputs = RunCMD("wmic bios get serialnumber"); // check số serial bios
            using (StreamWriter BIOS = new StreamWriter("bios.txt", true))
            {
                BIOS.WriteLine(outputs);
                BIOS.Close();
            }
            string[] liness = File.ReadAllLines("bios.txt");
            File.Delete("bios.txt");
            string strs = Regex.Replace(liness[2], @"\s", ""); // lấy serial đầu tiên

            string keys = string.Concat(strs, str);

            HttpClient httpClient = new HttpClient();
            string text2 = keys;
            string requestUri2 = "https://docs.google.com/spreadsheets/d/1XxDRBvH_kD7yXjpU5Qo7Hig8vrCxrBK0uHVXrN3GFio/edit?usp=sharing";
            string text3 = httpClient.GetAsync(requestUri2).Result.Content.ReadAsStringAsync().Result.ToString();
            Match match2 = Regex.Match(text3.ToString(), text2 + ".*?(?=ok)");
            bool flag2 = match2 != Match.Empty;
            if (flag2)
            {
                string[] array = match2.ToString().Split(new char[]
                {
                            '|'
                });
                //string siteurlold = "https://mmosorfware.com/time.php";
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //string htmlold = new System.Net.WebClient().DownloadString(siteurlold);
                //string[] arrayn = htmlold.ToString().Split(new char[]
                //{
                //             '/'
                //});
                //int dayn = Int32.Parse(arrayn[0]);
                //int monthn = Int32.Parse(arrayn[1]);
                //int yearn = Int32.Parse(arrayn[2]);

                DateTime time = DateTime.Now;
                int dayn = time.Day;
                int monthn = time.Month;
                int yearn = time.Year;

                string[] arrays = array[1].ToString().Split(new char[]
               {
                            '/'
               });

                int dayt = Int32.Parse(arrays[0]);
                int montht = Int32.Parse(arrays[1]);
                int yeart = Int32.Parse(arrays[2]);

                System.DateTime now = new System.DateTime(yearn, monthn, dayn);
                System.DateTime then = new System.DateTime(yeart, montht, dayt);
                System.TimeSpan diff1 = then.Subtract(now);


                int days = (int)Math.Ceiling(diff1.TotalDays);

                bool flag3 = days <= 0;
                if (flag3)
                {
                    MessageBox.Show("Vui lòng liên hệ admin để gia hạn.", "Phần mềm hết hạn" + days, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.tslExp.Text = array[1].ToString();
                    this.tslRemainTime.Text = "Còn lại: " + days.ToString() + " ngày";
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thành Công !", "Còn lại: " + days + " ngày!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.tslExp.Text = array[1].ToString();
                    this.tslRemainTime.Text = "Còn lại: " + days.ToString() + " ngày";
                }
            }

            else
            {
                MessageBox.Show(string.Format("Bạn chưa mua bản quyền tool, vui lòng bấm Ctrl + C và gửi mã \"{0}\" cho chúng tôi để kích hoạt tool, bấm OK để sao chép key!", keys), "Thông báo active bản quyền!", MessageBoxButtons.OK);
                Clipboard.SetText(keys);
                //Environment.Exit(Environment.ExitCode);
                Application.Exit();
            }

            provinces = new List<Tuple<string, string>>()
            {
                Tuple.Create("001","Hà Nội"),
                Tuple.Create("002","Hà Giang"),
                Tuple.Create("004","Cao Bằng"),
                Tuple.Create("006","Bắc Kạn"),
                Tuple.Create("008","Tuyên Quang"),
                Tuple.Create("010","Lào Cai"),
                Tuple.Create("011","Điện Biên"),
                Tuple.Create("012","Lai Châu"),
                Tuple.Create("014","Sơn La"),
                Tuple.Create("015","Yên Bái"),
                Tuple.Create("017","Hòa Bình"),
                Tuple.Create("019","Thái Nguyên"),
                Tuple.Create("020","Lạng Sơn"),
                Tuple.Create("022","Quảng Ninh"),
                Tuple.Create("024","Bắc Giang"),
                Tuple.Create("025","Phú Thọ"),
                Tuple.Create("026","Vĩnh Phúc"),
                Tuple.Create("027","Bắc Ninh"),
                Tuple.Create("030","Hải Dương"),
                Tuple.Create("031","Hải Phòng"),
                Tuple.Create("033","Hưng Yên"),
                Tuple.Create("034","Thái Bình"),
                Tuple.Create("035","Hà Nam"),
                Tuple.Create("036","Nam Định"),
                Tuple.Create("037","Ninh Bình"),
                Tuple.Create("038","Thanh Hóa"),
                Tuple.Create("040","Nghệ An"),
                Tuple.Create("042","Hà Tĩnh"),
                Tuple.Create("044","Quảng Bình"),
                Tuple.Create("045","Quảng Trị"),
                Tuple.Create("046","Thừa Thiên Huế"),
                Tuple.Create("048","Đà Nẵng"),
                Tuple.Create("049","Quảng Nam"),
                Tuple.Create("051","Quảng Ngãi"),
                Tuple.Create("052","Bình Định"),
                Tuple.Create("054","Phú Yên"),
                Tuple.Create("056","Khánh Hòa"),
                Tuple.Create("058","Ninh Thuận"),
                Tuple.Create("060","Bình Thuận"),
                Tuple.Create("062","Kon Tum"),
                Tuple.Create("064","Gia Lai"),
                Tuple.Create("066","Đắk Lắk"),
                Tuple.Create("067","Đắk Nông"),
                Tuple.Create("068","Lâm Đồng"),
                Tuple.Create("070","Bình Phước"),
                Tuple.Create("072","Tây Ninh"),
                Tuple.Create("074","Bình Dương"),
                Tuple.Create("075","Đồng Nai"),
                Tuple.Create("077","Bà Rịa - Vũng Tàu"),
                Tuple.Create("079","Hồ Chí Minh"),
                Tuple.Create("080","Long An"),
                Tuple.Create("082","Tiền Giang"),
                Tuple.Create("083","Bến Tre"),
                Tuple.Create("084","Trà Vinh"),
                Tuple.Create("086","Vĩnh Long"),
                Tuple.Create("087","Đồng Tháp"),
                Tuple.Create("089","An Giang"),
                Tuple.Create("091","Kiên Giang"),
                Tuple.Create("092","Cần Thơ"),
                Tuple.Create("093","Hậu Giang"),
                Tuple.Create("094","Sóc Trăng"),
                Tuple.Create("095","Bạc Liêu"),
                Tuple.Create("096","Cà Mau")
            };

            LoadProvince();

            cbProvince.DataSource = provinces;
            cbProvince.ValueMember = "Item1";
            cbProvince.DisplayMember = "Item2";

            dtNgayCap.CustomFormat = "dd/MM/yyyy";
            dtDOB.CustomFormat = "dd/MM/yyyy";
            dtNgayCapCCCD.CustomFormat = "dd/MM/yyyy";
            dtNgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        public string GetName()
        {
            string[] ten = txtLName.Text.Trim().ToUpper().Split(' ');
            return txtFName.Text.Trim().ToUpper() + "<<" + string.Join("<", ten);
        }

        public string GetProvinceCode()
        {
            return cbProvince.SelectedValue.ToString();
        }

        public string GetSex()
        {
            string sex;
            if (radMale.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }

            return sex;

        }

        public string getDOB()
        {
            string date = dtDOB.Value.ToString("yyMMdd");
            return date;
        }

        public string getExpDate()
        {
            string date = dtNgayCap.Value.ToString("yyMMdd");
            return date;
        }
        private static int GenDigit(string phrase)
        {
            int result = 0;
            int count = 0;
            int charValue = 0;

            Dictionary<char, int> mrzCheckDigitLookup = new Dictionary<char, int>();

            mrzCheckDigitLookup.Add('<', 0);
            mrzCheckDigitLookup.Add('A', 10);
            mrzCheckDigitLookup.Add('B', 11);
            mrzCheckDigitLookup.Add('C', 12);
            mrzCheckDigitLookup.Add('D', 13);
            mrzCheckDigitLookup.Add('E', 14);
            mrzCheckDigitLookup.Add('F', 15);
            mrzCheckDigitLookup.Add('G', 16);
            mrzCheckDigitLookup.Add('H', 17);
            mrzCheckDigitLookup.Add('I', 18);
            mrzCheckDigitLookup.Add('J', 19);
            mrzCheckDigitLookup.Add('K', 20);
            mrzCheckDigitLookup.Add('L', 21);
            mrzCheckDigitLookup.Add('M', 22);
            mrzCheckDigitLookup.Add('N', 23);
            mrzCheckDigitLookup.Add('O', 24);
            mrzCheckDigitLookup.Add('P', 25);
            mrzCheckDigitLookup.Add('Q', 26);
            mrzCheckDigitLookup.Add('R', 27);
            mrzCheckDigitLookup.Add('S', 28);
            mrzCheckDigitLookup.Add('T', 29);
            mrzCheckDigitLookup.Add('U', 30);
            mrzCheckDigitLookup.Add('V', 31);
            mrzCheckDigitLookup.Add('W', 32);
            mrzCheckDigitLookup.Add('X', 33);
            mrzCheckDigitLookup.Add('Y', 34);
            mrzCheckDigitLookup.Add('Z', 35);

            foreach (var letter in phrase.Replace(' ', '<').ToUpper().ToCharArray())
            {
                count++;

                if (Char.IsNumber(letter))
                {
                    charValue = (int)char.GetNumericValue(letter);
                }
                else if (mrzCheckDigitLookup.ContainsKey(letter))
                {
                    charValue = mrzCheckDigitLookup[letter];
                }
                else
                {
                    var ex = new Exception("Unknown character in MRZ :" + letter);
                    throw ex;
                }

                var weightedcharValue = WeightingMultiplier(count, charValue);
                result += weightedcharValue;
                var tmp = " " + letter + "[" + charValue + "] * " + WeightingMultiplier(count, 1) + " = " + weightedcharValue + " += " + result;
                if (count > 2)
                {
                    count = 0;
                }
                //tmp.Dump();
            }

            var remainder = result % 10;
            //(result+" % 10 = "+remainder+Environment.NewLine).Dump();

            return remainder;
        }

        private static int WeightingMultiplier(int count, int value)
        {
            switch (count)
            {
                case 1:
                    value *= 7;
                    break;
                case 2:
                    value *= 3;
                    break;
                case 3:
                    value *= 1;
                    break;
            }

            return value;
        }

        private Dictionary<string, string> ProvinceCode = new Dictionary<string, string>
    {
        {"Hà Nội","001"},
        {"Hà Giang","002"},
        {"Cao Bằng","004"},
        {"Bắc Kạn","006"},
        {"Tuyên Quang","008"},
        {"Lào Cai","010"},
        {"Điện Biên","011"},
        {"Lai Châu","012"},
        {"Sơn La","014"},
        {"Yên Bái","015"},
        {"Hòa Bình","017"},
        {"Thái Nguyên","019"},
        {"Lạng Sơn","020"},
        {"Quảng Ninh","022"},
        {"Bắc Giang","024"},
        {"Phú Thọ","025"},
        {"Vĩnh Phúc","026"},
        {"Bắc Ninh","027"},
        {"Hải Dương","030"},
        {"Hải Phòng","031"},
        {"Hưng Yên","033"},
        {"Thái Bình","034"},
        {"Hà Nam","035"},
        {"Nam Định","036"},
        {"Ninh Bình","037"},
        {"Thanh Hóa","038"},
        {"Nghệ An","040"},
        {"Hà Tĩnh","042"},
        {"Quảng Bình","044"},
        {"Quảng Trị","045"},
        {"Thừa Thiên Huế","046"},
        {"Đà Nẵng","048"},
        {"Quảng Nam","049"},
        {"Quảng Ngãi","051"},
        {"Bình Định","052"},
        {"Phú Yên","054"},
        {"Khánh Hòa","056"},
        {"Ninh Thuận","058"},
        {"Bình Thuận","060"},
        {"Kon Tum","062"},
        {"Gia Lai","064"},
        {"Đắk Lắk","066"},
        {"Đắk Nông","067"},
        {"Lâm Đồng","068"},
        {"Bình Phước","070"},
        {"Tây Ninh","072"},
        {"Bình Dương","074"},
        {"Đồng Nai","075"},
        {"Bà Rịa - Vũng Tàu","077"},
        {"Hồ Chí Minh","079"},
        {"Long An","080"},
        {"Tiền Giang","082"},
        {"Bến Tre","083"},
        {"Trà Vinh","084"},
        {"Vĩnh Long","086"},
        {"Đồng Tháp","087"},
        {"An Giang","089"},
        {"Kiên Giang","091"},
        {"Cần Thơ","092"},
        {"Hậu Giang","093"},
        {"Sóc Trăng","094"},
        {"Bạc Liêu","095"},
        {"Cà Mau","096"}
    };

        private void btnReset_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtResult.Text);
            }
            catch (Exception)
            {

            }

        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime day = dtDOB.Value;
            dtNgayCap.Value = day;
        }
        #endregion

        #region QRCode

        public string getCCCD()
        {
            return txtCCCD.Text.Trim();
        }

        public string getCMND()
        {
            return txtCMND.Text.Trim();
        }

        public string getFullName()
        {
            return txtName.Text.Trim();
        }

        public string getDateofBirth()
        {
            string date = dtNgaySinh.Value.ToString("ddMMyyyy");
            return date;
        }

        public string getGioiTinh()
        {
            string gt = string.Empty;
            if (rbMale.Checked)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nữ";
            }
            return gt;
        }

        public string getNgayCapCCCD()
        {
            string date = dtNgayCapCCCD.Value.ToString("ddMMyyyy");
            return date;
        }

        public string getAddress()
        {
            string add = string.Empty;
            add += txtVillage.Text + ", ";
            add += cbxWard.Text + ", ";
            add += cbxDistrict.Text + ", ";
            add += cbxProvince.Text;

            return add;
        }

        void GenQRCode(string data)
        {

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(30, "#000000", "#00FFFFFF");
            picQRCode.Image = qrCodeImage;
        }

        private void btnGenQR_Click(object sender, EventArgs e)
        {
            string dataQR = string.Empty;
            dataQR += getCCCD() + "|";
            dataQR += getCMND() + "|";
            dataQR += getFullName() + "|";
            dataQR += getDateofBirth() + "|";
            dataQR += getGioiTinh() + "|";
            dataQR += getAddress() + "|";
            dataQR += getNgayCapCCCD();
            GenQRCode(dataQR);
        }

        private void btnExitQR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "qrcode";// Default file name
            s.DefaultExt = ".png";// Default file extension
            s.Filter = "Image (.png)|*.png"; // Filter files by extension

            // Below are two examples of setting the initial (default) folder - choose one

            // 1. example of setting the default folder to a special folder
            s.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            // 2 example of setting the default folder to an absolute path
            //s.InitialDirectory = ("C:\\Temp");

            // setting the RestoreDirectory property to true causes the
            // dialog to restore the current directory before closing
            s.RestoreDirectory = true;
            // Show save file dialog box
            // Process save file dialog box results
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image
                string filename = s.FileName;
                // the using statement causes the FileStream's dispose method to be
                // called when the object goes out of scope
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Png);
                    fstream.Close();
                }
            }


        }

        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            SaveImageCapture(picQRCode.Image);
        }





        #endregion

        private void cbxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCommune();
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDistrict();
        }
    }
}


