
namespace Mimari
{
    partial class SeyahatBilgileri
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeyahatBilgileri));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.lbl_Tutar = new System.Windows.Forms.Label();
            this.txt_Tutar = new System.Windows.Forms.TextBox();
            this.check_TekYon = new System.Windows.Forms.CheckBox();
            this.lbl_Otobusler = new System.Windows.Forms.Label();
            this.cmb_Otobusler = new System.Windows.Forms.ComboBox();
            this.cmb_Kamplar = new System.Windows.Forms.ComboBox();
            this.lbl_Kamp = new System.Windows.Forms.Label();
            this.cmb_Ucaklar = new System.Windows.Forms.ComboBox();
            this.lbl_Ucak = new System.Windows.Forms.Label();
            this.cmb_Oteller = new System.Windows.Forms.ComboBox();
            this.lbl_Otel = new System.Windows.Forms.Label();
            this.cmb_Sehirler = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numeric_Kisisay = new System.Windows.Forms.NumericUpDown();
            this.lbl_DonusTar = new System.Windows.Forms.Label();
            this.lbl_GidişTar = new System.Windows.Forms.Label();
            this.dateTime_DonusTar = new System.Windows.Forms.DateTimePicker();
            this.dateTime_GidisTar = new System.Windows.Forms.DateTimePicker();
            this.cmb_Ulasim = new System.Windows.Forms.ComboBox();
            this.cmb_Konaklama = new System.Windows.Forms.ComboBox();
            this.lbl_Kisisay = new System.Windows.Forms.Label();
            this.lbl_Ulasim = new System.Windows.Forms.Label();
            this.lbl_Konaklama = new System.Windows.Forms.Label();
            this.lbl_KimlikNo = new System.Windows.Forms.Label();
            this.txt_KimlikNo = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.group_KimlikBilgileri = new System.Windows.Forms.GroupBox();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.radio_Kadin = new System.Windows.Forms.RadioButton();
            this.radio_Erkek = new System.Windows.Forms.RadioButton();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_KisiBilgi = new System.Windows.Forms.Label();
            this.lbl_Kisiler = new System.Windows.Forms.Label();
            this.lbl_GidisTar = new System.Windows.Forms.Label();
            this.lbl_CikisTar = new System.Windows.Forms.Label();
            this.lbl_GirişTarihi = new System.Windows.Forms.Label();
            this.lbl_DonusTarihi = new System.Windows.Forms.Label();
            this.lbl_Arac = new System.Windows.Forms.Label();
            this.lbl_UlasimArac = new System.Windows.Forms.Label();
            this.lbl_KonaklamaYer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.lbl_KalkisYeri = new System.Windows.Forms.Label();
            this.Varis_Yeri = new System.Windows.Forms.Label();
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.btn_CiktiAl = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kisisay)).BeginInit();
            this.group_KimlikBilgileri.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 500);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.tabPage1.Controls.Add(this.btn_Hesapla);
            this.tabPage1.Controls.Add(this.lbl_Tutar);
            this.tabPage1.Controls.Add(this.txt_Tutar);
            this.tabPage1.Controls.Add(this.check_TekYon);
            this.tabPage1.Controls.Add(this.lbl_Otobusler);
            this.tabPage1.Controls.Add(this.cmb_Otobusler);
            this.tabPage1.Controls.Add(this.cmb_Kamplar);
            this.tabPage1.Controls.Add(this.lbl_Kamp);
            this.tabPage1.Controls.Add(this.cmb_Ucaklar);
            this.tabPage1.Controls.Add(this.lbl_Ucak);
            this.tabPage1.Controls.Add(this.cmb_Oteller);
            this.tabPage1.Controls.Add(this.lbl_Otel);
            this.tabPage1.Controls.Add(this.cmb_Sehirler);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.numeric_Kisisay);
            this.tabPage1.Controls.Add(this.lbl_DonusTar);
            this.tabPage1.Controls.Add(this.lbl_GidişTar);
            this.tabPage1.Controls.Add(this.dateTime_DonusTar);
            this.tabPage1.Controls.Add(this.dateTime_GidisTar);
            this.tabPage1.Controls.Add(this.cmb_Ulasim);
            this.tabPage1.Controls.Add(this.cmb_Konaklama);
            this.tabPage1.Controls.Add(this.lbl_Kisisay);
            this.tabPage1.Controls.Add(this.lbl_Ulasim);
            this.tabPage1.Controls.Add(this.lbl_Konaklama);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seyahat Bilgileri";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.btn_Gonder);
            this.tabPage2.Controls.Add(this.group_KimlikBilgileri);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kimlik Bilgileri";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(655, 178);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(86, 30);
            this.btn_Hesapla.TabIndex = 62;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            // 
            // lbl_Tutar
            // 
            this.lbl_Tutar.AutoSize = true;
            this.lbl_Tutar.Location = new System.Drawing.Point(603, 135);
            this.lbl_Tutar.Name = "lbl_Tutar";
            this.lbl_Tutar.Size = new System.Drawing.Size(46, 17);
            this.lbl_Tutar.TabIndex = 61;
            this.lbl_Tutar.Text = "Tutar:";
            // 
            // txt_Tutar
            // 
            this.txt_Tutar.Location = new System.Drawing.Point(655, 134);
            this.txt_Tutar.Name = "txt_Tutar";
            this.txt_Tutar.Size = new System.Drawing.Size(182, 22);
            this.txt_Tutar.TabIndex = 60;
            // 
            // check_TekYon
            // 
            this.check_TekYon.AutoSize = true;
            this.check_TekYon.Location = new System.Drawing.Point(251, 68);
            this.check_TekYon.Name = "check_TekYon";
            this.check_TekYon.Size = new System.Drawing.Size(83, 21);
            this.check_TekYon.TabIndex = 59;
            this.check_TekYon.Text = "Tek Yön";
            this.check_TekYon.UseVisualStyleBackColor = true;
            // 
            // lbl_Otobusler
            // 
            this.lbl_Otobusler.AutoSize = true;
            this.lbl_Otobusler.Location = new System.Drawing.Point(307, 183);
            this.lbl_Otobusler.Name = "lbl_Otobusler";
            this.lbl_Otobusler.Size = new System.Drawing.Size(86, 17);
            this.lbl_Otobusler.TabIndex = 58;
            this.lbl_Otobusler.Text = "Otobüs Seç:";
            // 
            // cmb_Otobusler
            // 
            this.cmb_Otobusler.FormattingEnabled = true;
            this.cmb_Otobusler.Location = new System.Drawing.Point(395, 235);
            this.cmb_Otobusler.Name = "cmb_Otobusler";
            this.cmb_Otobusler.Size = new System.Drawing.Size(162, 24);
            this.cmb_Otobusler.TabIndex = 47;
            // 
            // cmb_Kamplar
            // 
            this.cmb_Kamplar.FormattingEnabled = true;
            this.cmb_Kamplar.Location = new System.Drawing.Point(395, 152);
            this.cmb_Kamplar.Name = "cmb_Kamplar";
            this.cmb_Kamplar.Size = new System.Drawing.Size(162, 24);
            this.cmb_Kamplar.TabIndex = 46;
            // 
            // lbl_Kamp
            // 
            this.lbl_Kamp.AutoSize = true;
            this.lbl_Kamp.Location = new System.Drawing.Point(314, 131);
            this.lbl_Kamp.Name = "lbl_Kamp";
            this.lbl_Kamp.Size = new System.Drawing.Size(76, 17);
            this.lbl_Kamp.TabIndex = 57;
            this.lbl_Kamp.Text = "Kamp Seç:";
            // 
            // cmb_Ucaklar
            // 
            this.cmb_Ucaklar.FormattingEnabled = true;
            this.cmb_Ucaklar.Location = new System.Drawing.Point(395, 182);
            this.cmb_Ucaklar.Name = "cmb_Ucaklar";
            this.cmb_Ucaklar.Size = new System.Drawing.Size(162, 24);
            this.cmb_Ucaklar.TabIndex = 45;
            // 
            // lbl_Ucak
            // 
            this.lbl_Ucak.AutoSize = true;
            this.lbl_Ucak.Location = new System.Drawing.Point(323, 183);
            this.lbl_Ucak.Name = "lbl_Ucak";
            this.lbl_Ucak.Size = new System.Drawing.Size(72, 17);
            this.lbl_Ucak.TabIndex = 56;
            this.lbl_Ucak.Text = "Uçak Seç:";
            // 
            // cmb_Oteller
            // 
            this.cmb_Oteller.FormattingEnabled = true;
            this.cmb_Oteller.Location = new System.Drawing.Point(395, 128);
            this.cmb_Oteller.Name = "cmb_Oteller";
            this.cmb_Oteller.Size = new System.Drawing.Size(162, 24);
            this.cmb_Oteller.TabIndex = 44;
            // 
            // lbl_Otel
            // 
            this.lbl_Otel.AutoSize = true;
            this.lbl_Otel.Location = new System.Drawing.Point(323, 131);
            this.lbl_Otel.Name = "lbl_Otel";
            this.lbl_Otel.Size = new System.Drawing.Size(66, 17);
            this.lbl_Otel.TabIndex = 55;
            this.lbl_Otel.Text = "Otel Seç:";
            // 
            // cmb_Sehirler
            // 
            this.cmb_Sehirler.FormattingEnabled = true;
            this.cmb_Sehirler.Location = new System.Drawing.Point(33, 32);
            this.cmb_Sehirler.Name = "cmb_Sehirler";
            this.cmb_Sehirler.Size = new System.Drawing.Size(184, 24);
            this.cmb_Sehirler.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // numeric_Kisisay
            // 
            this.numeric_Kisisay.Location = new System.Drawing.Point(109, 223);
            this.numeric_Kisisay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Kisisay.Name = "numeric_Kisisay";
            this.numeric_Kisisay.Size = new System.Drawing.Size(42, 22);
            this.numeric_Kisisay.TabIndex = 53;
            this.numeric_Kisisay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_DonusTar
            // 
            this.lbl_DonusTar.AutoSize = true;
            this.lbl_DonusTar.Location = new System.Drawing.Point(556, 35);
            this.lbl_DonusTar.Name = "lbl_DonusTar";
            this.lbl_DonusTar.Size = new System.Drawing.Size(93, 17);
            this.lbl_DonusTar.TabIndex = 51;
            this.lbl_DonusTar.Text = "Dönüş Tarihi:";
            // 
            // lbl_GidişTar
            // 
            this.lbl_GidişTar.AutoSize = true;
            this.lbl_GidişTar.Location = new System.Drawing.Point(248, 35);
            this.lbl_GidişTar.Name = "lbl_GidişTar";
            this.lbl_GidişTar.Size = new System.Drawing.Size(84, 17);
            this.lbl_GidişTar.TabIndex = 52;
            this.lbl_GidişTar.Text = "Gidiş Tarihi:";
            // 
            // dateTime_DonusTar
            // 
            this.dateTime_DonusTar.Location = new System.Drawing.Point(655, 33);
            this.dateTime_DonusTar.MinDate = new System.DateTime(2022, 5, 15, 21, 39, 53, 0);
            this.dateTime_DonusTar.Name = "dateTime_DonusTar";
            this.dateTime_DonusTar.Size = new System.Drawing.Size(200, 22);
            this.dateTime_DonusTar.TabIndex = 41;
            this.dateTime_DonusTar.Value = new System.DateTime(2022, 5, 15, 21, 39, 53, 0);
            // 
            // dateTime_GidisTar
            // 
            this.dateTime_GidisTar.Location = new System.Drawing.Point(338, 32);
            this.dateTime_GidisTar.MinDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dateTime_GidisTar.Name = "dateTime_GidisTar";
            this.dateTime_GidisTar.Size = new System.Drawing.Size(200, 22);
            this.dateTime_GidisTar.TabIndex = 40;
            // 
            // cmb_Ulasim
            // 
            this.cmb_Ulasim.FormattingEnabled = true;
            this.cmb_Ulasim.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.cmb_Ulasim.Location = new System.Drawing.Point(109, 178);
            this.cmb_Ulasim.Name = "cmb_Ulasim";
            this.cmb_Ulasim.Size = new System.Drawing.Size(162, 24);
            this.cmb_Ulasim.TabIndex = 43;
            // 
            // cmb_Konaklama
            // 
            this.cmb_Konaklama.FormattingEnabled = true;
            this.cmb_Konaklama.Items.AddRange(new object[] {
            "Otel",
            "Kamp"});
            this.cmb_Konaklama.Location = new System.Drawing.Point(109, 127);
            this.cmb_Konaklama.Name = "cmb_Konaklama";
            this.cmb_Konaklama.Size = new System.Drawing.Size(162, 24);
            this.cmb_Konaklama.TabIndex = 42;
            // 
            // lbl_Kisisay
            // 
            this.lbl_Kisisay.AutoSize = true;
            this.lbl_Kisisay.Location = new System.Drawing.Point(25, 225);
            this.lbl_Kisisay.Name = "lbl_Kisisay";
            this.lbl_Kisisay.Size = new System.Drawing.Size(75, 17);
            this.lbl_Kisisay.TabIndex = 48;
            this.lbl_Kisisay.Text = "Kişi Sayısı:";
            // 
            // lbl_Ulasim
            // 
            this.lbl_Ulasim.AutoSize = true;
            this.lbl_Ulasim.Location = new System.Drawing.Point(46, 178);
            this.lbl_Ulasim.Name = "lbl_Ulasim";
            this.lbl_Ulasim.Size = new System.Drawing.Size(54, 17);
            this.lbl_Ulasim.TabIndex = 49;
            this.lbl_Ulasim.Text = "Ulaşım:";
            // 
            // lbl_Konaklama
            // 
            this.lbl_Konaklama.AutoSize = true;
            this.lbl_Konaklama.Location = new System.Drawing.Point(18, 134);
            this.lbl_Konaklama.Name = "lbl_Konaklama";
            this.lbl_Konaklama.Size = new System.Drawing.Size(82, 17);
            this.lbl_Konaklama.TabIndex = 50;
            this.lbl_Konaklama.Text = "Konaklama:";
            // 
            // lbl_KimlikNo
            // 
            this.lbl_KimlikNo.AutoSize = true;
            this.lbl_KimlikNo.Location = new System.Drawing.Point(10, 25);
            this.lbl_KimlikNo.Name = "lbl_KimlikNo";
            this.lbl_KimlikNo.Size = new System.Drawing.Size(96, 17);
            this.lbl_KimlikNo.TabIndex = 0;
            this.lbl_KimlikNo.Text = "T.C Kimlik No:";
            // 
            // txt_KimlikNo
            // 
            this.txt_KimlikNo.Location = new System.Drawing.Point(112, 24);
            this.txt_KimlikNo.Name = "txt_KimlikNo";
            this.txt_KimlikNo.Size = new System.Drawing.Size(180, 22);
            this.txt_KimlikNo.TabIndex = 1;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(77, 57);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(29, 17);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "Ad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(112, 55);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(180, 22);
            this.txt_Ad.TabIndex = 1;
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(54, 87);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(52, 17);
            this.lbl_Soyad.TabIndex = 0;
            this.lbl_Soyad.Text = "Soyad:";
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(112, 86);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(180, 22);
            this.txt_Soyad.TabIndex = 1;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(46, 119);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(60, 17);
            this.lbl_Telefon.TabIndex = 0;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(112, 117);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(180, 22);
            this.txt_Telefon.TabIndex = 1;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Location = new System.Drawing.Point(69, 150);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(37, 17);
            this.lbl_Mail.TabIndex = 0;
            this.lbl_Mail.Text = "Mail:";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(112, 148);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(180, 22);
            this.txt_Mail.TabIndex = 1;
            // 
            // group_KimlikBilgileri
            // 
            this.group_KimlikBilgileri.Controls.Add(this.radio_Erkek);
            this.group_KimlikBilgileri.Controls.Add(this.radio_Kadin);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Cinsiyet);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_KimlikNo);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Mail);
            this.group_KimlikBilgileri.Controls.Add(this.txt_KimlikNo);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Mail);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Ad);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Telefon);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Ad);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Telefon);
            this.group_KimlikBilgileri.Controls.Add(this.lbl_Soyad);
            this.group_KimlikBilgileri.Controls.Add(this.txt_Soyad);
            this.group_KimlikBilgileri.Location = new System.Drawing.Point(8, 16);
            this.group_KimlikBilgileri.Name = "group_KimlikBilgileri";
            this.group_KimlikBilgileri.Size = new System.Drawing.Size(321, 216);
            this.group_KimlikBilgileri.TabIndex = 2;
            this.group_KimlikBilgileri.TabStop = false;
            this.group_KimlikBilgileri.Text = "1.Kişinin Bilgileri";
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(45, 180);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(61, 17);
            this.lbl_Cinsiyet.TabIndex = 2;
            this.lbl_Cinsiyet.Text = "Cinsiyet:";
            // 
            // radio_Kadin
            // 
            this.radio_Kadin.AutoSize = true;
            this.radio_Kadin.Location = new System.Drawing.Point(124, 180);
            this.radio_Kadin.Name = "radio_Kadin";
            this.radio_Kadin.Size = new System.Drawing.Size(65, 21);
            this.radio_Kadin.TabIndex = 3;
            this.radio_Kadin.TabStop = true;
            this.radio_Kadin.Text = "Kadın";
            this.radio_Kadin.UseVisualStyleBackColor = true;
            // 
            // radio_Erkek
            // 
            this.radio_Erkek.AutoSize = true;
            this.radio_Erkek.Location = new System.Drawing.Point(214, 180);
            this.radio_Erkek.Name = "radio_Erkek";
            this.radio_Erkek.Size = new System.Drawing.Size(65, 21);
            this.radio_Erkek.TabIndex = 3;
            this.radio_Erkek.TabStop = true;
            this.radio_Erkek.Text = "Erkek";
            this.radio_Erkek.UseVisualStyleBackColor = true;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Location = new System.Drawing.Point(120, 238);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(104, 43);
            this.btn_Gonder.TabIndex = 3;
            this.btn_Gonder.Text = "Gönder";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage3.Controls.Add(this.btn_CiktiAl);
            this.tabPage3.Controls.Add(this.btn_Odeme);
            this.tabPage3.Controls.Add(this.Varis_Yeri);
            this.tabPage3.Controls.Add(this.lbl_KalkisYeri);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.lbl_KonaklamaYer);
            this.tabPage3.Controls.Add(this.lbl_UlasimArac);
            this.tabPage3.Controls.Add(this.lbl_Arac);
            this.tabPage3.Controls.Add(this.lbl_DonusTarihi);
            this.tabPage3.Controls.Add(this.lbl_GirişTarihi);
            this.tabPage3.Controls.Add(this.lbl_CikisTar);
            this.tabPage3.Controls.Add(this.lbl_GidisTar);
            this.tabPage3.Controls.Add(this.lbl_Kisiler);
            this.tabPage3.Controls.Add(this.lbl_KisiBilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(992, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Raporlama";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(355, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(632, 436);
            this.listBox1.TabIndex = 4;
            // 
            // lbl_KisiBilgi
            // 
            this.lbl_KisiBilgi.AutoSize = true;
            this.lbl_KisiBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KisiBilgi.Location = new System.Drawing.Point(3, 22);
            this.lbl_KisiBilgi.Name = "lbl_KisiBilgi";
            this.lbl_KisiBilgi.Size = new System.Drawing.Size(310, 20);
            this.lbl_KisiBilgi.TabIndex = 0;
            this.lbl_KisiBilgi.Text = "Kişi veya Kişilerin Seyahat Bilgileri:";
            // 
            // lbl_Kisiler
            // 
            this.lbl_Kisiler.AutoSize = true;
            this.lbl_Kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kisiler.Location = new System.Drawing.Point(319, 23);
            this.lbl_Kisiler.Name = "lbl_Kisiler";
            this.lbl_Kisiler.Size = new System.Drawing.Size(53, 20);
            this.lbl_Kisiler.TabIndex = 1;
            this.lbl_Kisiler.Text = "label2";
            // 
            // lbl_GidisTar
            // 
            this.lbl_GidisTar.AutoSize = true;
            this.lbl_GidisTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_GidisTar.Location = new System.Drawing.Point(706, 22);
            this.lbl_GidisTar.Name = "lbl_GidisTar";
            this.lbl_GidisTar.Size = new System.Drawing.Size(99, 18);
            this.lbl_GidisTar.TabIndex = 2;
            this.lbl_GidisTar.Text = "Gidiş Tarihi:";
            // 
            // lbl_CikisTar
            // 
            this.lbl_CikisTar.AutoSize = true;
            this.lbl_CikisTar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_CikisTar.Location = new System.Drawing.Point(697, 58);
            this.lbl_CikisTar.Name = "lbl_CikisTar";
            this.lbl_CikisTar.Size = new System.Drawing.Size(109, 18);
            this.lbl_CikisTar.TabIndex = 3;
            this.lbl_CikisTar.Text = "Dönüş Tarihi:";
            // 
            // lbl_GirişTarihi
            // 
            this.lbl_GirişTarihi.AutoSize = true;
            this.lbl_GirişTarihi.Location = new System.Drawing.Point(816, 22);
            this.lbl_GirişTarihi.Name = "lbl_GirişTarihi";
            this.lbl_GirişTarihi.Size = new System.Drawing.Size(80, 17);
            this.lbl_GirişTarihi.TabIndex = 4;
            this.lbl_GirişTarihi.Text = "00/00/0000";
            // 
            // lbl_DonusTarihi
            // 
            this.lbl_DonusTarihi.AutoSize = true;
            this.lbl_DonusTarihi.Location = new System.Drawing.Point(816, 58);
            this.lbl_DonusTarihi.Name = "lbl_DonusTarihi";
            this.lbl_DonusTarihi.Size = new System.Drawing.Size(80, 17);
            this.lbl_DonusTarihi.TabIndex = 5;
            this.lbl_DonusTarihi.Text = "00/00/0000";
            // 
            // lbl_Arac
            // 
            this.lbl_Arac.AutoSize = true;
            this.lbl_Arac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Arac.Location = new System.Drawing.Point(45, 233);
            this.lbl_Arac.Name = "lbl_Arac";
            this.lbl_Arac.Size = new System.Drawing.Size(157, 29);
            this.lbl_Arac.TabIndex = 6;
            this.lbl_Arac.Text = "Ulaşım Aracı";
            // 
            // lbl_UlasimArac
            // 
            this.lbl_UlasimArac.AutoSize = true;
            this.lbl_UlasimArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_UlasimArac.Location = new System.Drawing.Point(78, 272);
            this.lbl_UlasimArac.Name = "lbl_UlasimArac";
            this.lbl_UlasimArac.Size = new System.Drawing.Size(64, 25);
            this.lbl_UlasimArac.TabIndex = 7;
            this.lbl_UlasimArac.Text = "label1";
            // 
            // lbl_KonaklamaYer
            // 
            this.lbl_KonaklamaYer.AutoSize = true;
            this.lbl_KonaklamaYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KonaklamaYer.Location = new System.Drawing.Point(357, 233);
            this.lbl_KonaklamaYer.Name = "lbl_KonaklamaYer";
            this.lbl_KonaklamaYer.Size = new System.Drawing.Size(192, 29);
            this.lbl_KonaklamaYer.TabIndex = 6;
            this.lbl_KonaklamaYer.Text = "Konaklama Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(389, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(201, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 80);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazdırma Formatı";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Json";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(127, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(53, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Xml";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(231, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 21);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Html";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // lbl_KalkisYeri
            // 
            this.lbl_KalkisYeri.AutoSize = true;
            this.lbl_KalkisYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KalkisYeri.Location = new System.Drawing.Point(9, 117);
            this.lbl_KalkisYeri.Name = "lbl_KalkisYeri";
            this.lbl_KalkisYeri.Size = new System.Drawing.Size(81, 29);
            this.lbl_KalkisYeri.TabIndex = 10;
            this.lbl_KalkisYeri.Text = "label1";
            // 
            // Varis_Yeri
            // 
            this.Varis_Yeri.AutoSize = true;
            this.Varis_Yeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Varis_Yeri.Location = new System.Drawing.Point(309, 117);
            this.Varis_Yeri.Name = "Varis_Yeri";
            this.Varis_Yeri.Size = new System.Drawing.Size(81, 29);
            this.Varis_Yeri.TabIndex = 11;
            this.Varis_Yeri.Text = "label3";
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.Location = new System.Drawing.Point(776, 378);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(100, 41);
            this.btn_Odeme.TabIndex = 12;
            this.btn_Odeme.Text = "Ödeme";
            this.btn_Odeme.UseVisualStyleBackColor = true;
            // 
            // btn_CiktiAl
            // 
            this.btn_CiktiAl.Location = new System.Drawing.Point(776, 425);
            this.btn_CiktiAl.Name = "btn_CiktiAl";
            this.btn_CiktiAl.Size = new System.Drawing.Size(100, 38);
            this.btn_CiktiAl.TabIndex = 13;
            this.btn_CiktiAl.Text = "Çıktı Al";
            this.btn_CiktiAl.UseVisualStyleBackColor = true;
            // 
            // SeyahatBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeyahatBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Kisisay)).EndInit();
            this.group_KimlikBilgileri.ResumeLayout(false);
            this.group_KimlikBilgileri.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Label lbl_Tutar;
        private System.Windows.Forms.TextBox txt_Tutar;
        private System.Windows.Forms.CheckBox check_TekYon;
        private System.Windows.Forms.Label lbl_Otobusler;
        private System.Windows.Forms.ComboBox cmb_Otobusler;
        private System.Windows.Forms.ComboBox cmb_Kamplar;
        private System.Windows.Forms.Label lbl_Kamp;
        private System.Windows.Forms.ComboBox cmb_Ucaklar;
        private System.Windows.Forms.Label lbl_Ucak;
        private System.Windows.Forms.ComboBox cmb_Oteller;
        private System.Windows.Forms.Label lbl_Otel;
        private System.Windows.Forms.ComboBox cmb_Sehirler;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numeric_Kisisay;
        private System.Windows.Forms.Label lbl_DonusTar;
        private System.Windows.Forms.Label lbl_GidişTar;
        private System.Windows.Forms.DateTimePicker dateTime_DonusTar;
        private System.Windows.Forms.DateTimePicker dateTime_GidisTar;
        private System.Windows.Forms.ComboBox cmb_Ulasim;
        private System.Windows.Forms.ComboBox cmb_Konaklama;
        private System.Windows.Forms.Label lbl_Kisisay;
        private System.Windows.Forms.Label lbl_Ulasim;
        private System.Windows.Forms.Label lbl_Konaklama;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.TextBox txt_KimlikNo;
        private System.Windows.Forms.Label lbl_KimlikNo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.GroupBox group_KimlikBilgileri;
        private System.Windows.Forms.RadioButton radio_Erkek;
        private System.Windows.Forms.RadioButton radio_Kadin;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_CiktiAl;
        private System.Windows.Forms.Button btn_Odeme;
        private System.Windows.Forms.Label Varis_Yeri;
        private System.Windows.Forms.Label lbl_KalkisYeri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_KonaklamaYer;
        private System.Windows.Forms.Label lbl_UlasimArac;
        private System.Windows.Forms.Label lbl_Arac;
        private System.Windows.Forms.Label lbl_DonusTarihi;
        private System.Windows.Forms.Label lbl_GirişTarihi;
        private System.Windows.Forms.Label lbl_CikisTar;
        private System.Windows.Forms.Label lbl_GidisTar;
        private System.Windows.Forms.Label lbl_Kisiler;
        private System.Windows.Forms.Label lbl_KisiBilgi;
    }
}

