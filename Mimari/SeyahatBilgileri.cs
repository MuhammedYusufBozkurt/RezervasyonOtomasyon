using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mimari
{
    public partial class SeyahatBilgileri : Form
    {

        public SeyahatBilgileri()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Kamp.Visible = false;
            lbl_Otel.Visible = false;
            lbl_Otobusler.Visible = false;
            lbl_Ucak.Visible = false;
            cmb_Kamplar.Visible = false;
            cmb_Oteller.Visible = false;
            cmb_Otobusler.Visible = false;
            cmb_Ucaklar.Visible = false;
            otel_ucak.KisiSay = numeric_Kisisay.Value;
            SehirEkle();

        }

        public void SehirEkle()
        {

            List<string> satirlarList = new List<string>();

            StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Sehirler.txt");
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    satirlarList.Add(satir);
                }
                foreach (string x in satirlarList)
                {
                    cmb_Sehirler.Items.Add(x.Split('-')[0]);
                }

            }
        }
        public void OtelEkle()
        {
            List<string> satirlarList = new List<string>();
            if (cmb_Sehirler.Text == "Antalya")
            {
                if (cmb_Oteller.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Oteller.Items.RemoveAt(0);
                    }

                }

                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Oteller.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Oteller.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Muğla")
            {
                if (cmb_Oteller.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Oteller.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Oteller.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 3; i < 6; i++)
                    {
                        cmb_Oteller.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Çeşme")
            {
                if (cmb_Oteller.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Oteller.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Oteller.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 6; i < 9; i++)
                    {
                        cmb_Oteller.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }

        }
        public void KampEkle()
        {
            List<string> satirlarList = new List<string>();
            if (cmb_Sehirler.Text == "Antalya")
            {
                if (cmb_Kamplar.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Kamplar.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\KampAlanlari.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Kamplar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Muğla")
            {
                if (cmb_Kamplar.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Kamplar.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\KampAlanlari.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 3; i < 6; i++)
                    {
                        cmb_Kamplar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Çeşme")
            {
                if (cmb_Kamplar.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Kamplar.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\KampAlanlari.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 6; i < 9; i++)
                    {
                        cmb_Kamplar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }

        }
        public void OtobusEkle()
        {
            List<string> satirlarList = new List<string>();
            if (cmb_Sehirler.Text == "Antalya")
            {
                if (cmb_Otobusler.Items.Count > 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Otobusler.Items.RemoveAt(0);
                    }

                }
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Otobusler.txt");
                {
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Otobusler.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Muğla")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Otobusler.txt");
                {
                    if (cmb_Otobusler.Items.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            cmb_Otobusler.Items.RemoveAt(0);
                        }

                    }
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 3; i < 6; i++)
                    {
                        cmb_Otobusler.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Çeşme")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Otobusler.txt");
                {
                    if (cmb_Otobusler.Items.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            cmb_Otobusler.Items.RemoveAt(0);
                        }

                    }
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 6; i < 9; i++)
                    {
                        cmb_Otobusler.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
        }
        public void UcakEkle()
        {
            List<string> satirlarList = new List<string>();
            if (cmb_Sehirler.Text == "Antalya")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Ucaklar.txt");
                {
                    if (cmb_Ucaklar.Items.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            cmb_Ucaklar.Items.RemoveAt(0);
                        }

                    }
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        cmb_Ucaklar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Muğla")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Ucaklar.txt");
                {
                    if (cmb_Ucaklar.Items.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            cmb_Ucaklar.Items.RemoveAt(0);
                        }

                    }
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 3; i < 6; i++)
                    {
                        cmb_Ucaklar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
            else if (cmb_Sehirler.Text == "Çeşme")
            {
                StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Ucaklar.txt");
                {
                    if (cmb_Ucaklar.Items.Count > 0)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            cmb_Ucaklar.Items.RemoveAt(0);
                        }

                    }
                    string satir;
                    while ((satir = sr.ReadLine()) != null)
                    {
                        satirlarList.Add(satir);
                    }
                    for (int i = 6; i < 9; i++)
                    {
                        cmb_Ucaklar.Items.Add(satirlarList[i].Split('-')[1]);
                    }

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void check_TekYon_CheckedChanged(object sender, EventArgs e)
        {
            if (check_TekYon.Checked == true)
            {               
                otel_ucak.durum = true;
            }
            else
            {
                otel_ucak.durum = false;
            }
        }

        private void cmb_Konaklama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Konaklama.SelectedIndex == 0)
            {
                cmb_Oteller.Visible = true;
                lbl_Otel.Visible = true;
                cmb_Kamplar.Visible = false;
                lbl_Kamp.Visible = false;
            }
            if (cmb_Konaklama.SelectedIndex == 1)
            {
                cmb_Kamplar.Visible = true;
                lbl_Kamp.Visible = true;
                cmb_Oteller.Visible = false;
                lbl_Otel.Visible = false;
            }
        }

        private void cmb_Ulasim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Ulasim.SelectedIndex == 0)
            {
                cmb_Ucaklar.Visible = true;
                lbl_Ucak.Visible = true;
                cmb_Otobusler.Visible = false;
                lbl_Otobusler.Visible = false;
            }
            if (cmb_Ulasim.SelectedIndex == 1)
            {
                cmb_Otobusler.Visible = true;
                lbl_Otobusler.Visible = true;
                cmb_Ucaklar.Visible = false;
                lbl_Ucak.Visible = false;
            }
        }

        Otel_Ucak otel_ucak = new Otel_Ucak();

        private void cmb_Oteller_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> satirlarList = new List<string>();
            StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Oteller.txt");
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    satirlarList.Add(satir);
                }
                if (cmb_Oteller.SelectedIndex == 0)
                {
                    otel_ucak.GunlukOtelFiyat = Convert.ToInt32(satirlarList[0].Split('-')[2]);

                }
                else if (cmb_Oteller.SelectedIndex == 1)
                {
                    otel_ucak.GunlukOtelFiyat = int.Parse(satirlarList[1].Split('-')[2]);
                }
                if (cmb_Oteller.SelectedIndex == 2)
                {
                    otel_ucak.GunlukOtelFiyat = int.Parse(satirlarList[2].Split('-')[2]);
                }
            }
        }

        private void cmb_Sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {

            OtelEkle();
            KampEkle();
            UcakEkle();
            OtobusEkle();
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            txt_Tutar.Text = otel_ucak.Tutar().ToString();
        }

        private void cmb_Otobusler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Ucaklar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> satirlarList = new List<string>();
            StreamReader sr = new StreamReader(Application.StartupPath + @"\Seyahat\Ucaklar.txt");
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    satirlarList.Add(satir);
                }
                if (cmb_Ucaklar.SelectedIndex == 0)
                {
                    otel_ucak.UcakBiletFiyat = Convert.ToInt32(satirlarList[0].Split('-')[2]);
                }
                else if (cmb_Ucaklar.SelectedIndex == 1)
                {
                    otel_ucak.UcakBiletFiyat = Convert.ToInt32(satirlarList[1].Split('-')[2]);
                }
                else if (cmb_Ucaklar.SelectedIndex == 2)
                {
                    otel_ucak.UcakBiletFiyat = Convert.ToInt32(satirlarList[2].Split('-')[2]);
                }
            }
        }

        private void numeric_Kisisay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTime_GidişTar_ValueChanged(object sender, EventArgs e)
        {
            otel_ucak.GirisTar = dateTime_GidisTar.Value.Date;
        }

        private void dateTime_DonusTar_ValueChanged(object sender, EventArgs e)
        {
            otel_ucak.CikisTar = dateTime_DonusTar.Value.Date;
        }
    }
}
