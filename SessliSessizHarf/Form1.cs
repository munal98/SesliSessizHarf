using System;
using System.Windows.Forms;

namespace _028_5_WindowsForms_SessliSessizHarf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHarf.SelectedIndex = 0;
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Text = "";
            cbHarf.SelectedIndex = 0;
            lSonuc.Text = "";
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            if (!ValideEt())
                return;

            //SesliSessizHarfBul1();
            SesliSessizHarfBul2();
        }

        void SesliSessizHarfBul1() // 1. algoritma
        {
            char[] sesliHarfler = new char[] {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            string sonuc = "";
            bool sesliKarakterMi;
            bool sessizKarakterMi;
            foreach (var kelimeKarakter in tbKelime.Text)
            {
                sesliKarakterMi = false;
                sessizKarakterMi = true;
                foreach (var sesliKarakter in sesliHarfler)
                {
                    if (cbHarf.SelectedIndex == 1) // 1: sesli harf
                    {
                        if (kelimeKarakter.ToString().ToLower() == sesliKarakter.ToString())
                        {
                            sesliKarakterMi = true;
                            break;
                        }
                    }
                    else // 2: sessiz harf
                    {
                        if (kelimeKarakter.ToString().ToLower() == sesliKarakter.ToString())
                        {
                            sessizKarakterMi = false;
                            break;
                        }
                    }
                }

                if ((cbHarf.SelectedIndex == 1 && sesliKarakterMi) || (cbHarf.SelectedIndex == 2 && sessizKarakterMi))
                {
                    if (!sonuc.Contains(kelimeKarakter.ToString()))
                    {
                        sonuc += kelimeKarakter;
                    }
                }
            }

            if (sonuc.Equals(""))
            {
                lSonuc.Text = cbHarf.Text + " Bulunamadı.";
            }
            else
            {
                lSonuc.Text = sonuc;
            }
        }

        void SesliSessizHarfBul2() // 2. algoritma
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            string sonuc = "";
            if (cbHarf.SelectedIndex == 1) // 1: sesli harf
            {
                foreach (char kelimeKarakter in tbKelime.Text.ToLower())
                {
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            if (!sonuc.Contains(kelimeKarakter.ToString()))
                                sonuc += kelimeKarakter;
                            break;
                        }
                    }
                }
            }
            else // 2: sessiz harf
            {
                foreach (char kelimeKarakter in tbKelime.Text.ToLower())
                {
                    bool sessizKarakterMi = true;
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            sessizKarakterMi = false;
                            break;
                        }
                    }
                    if (sessizKarakterMi && !sonuc.Contains(kelimeKarakter.ToString()))
                        sonuc += kelimeKarakter;
                }
            }
            if (sonuc.Equals(""))
            {
                lSonuc.Text = cbHarf.Text + " Bulunamadı.";
            }
            else
            {
                lSonuc.Text = sonuc;
            }
        }

        bool ValideEt()
        {
            if (String.IsNullOrWhiteSpace(tbKelime.Text))
            {
                MessageBox.Show("Lütfen kelime giriniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tbKelime.Text.Contains(" "))
            {
                MessageBox.Show("Lütfen boşluk kullanmayınız...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbHarf.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen sesli veya sessiz harf seçiniz...", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
