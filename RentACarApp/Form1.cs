using RentACarApp.Data;

namespace RentACarApp
{
    public partial class Form1 : Form
    {
        int id = 0;
        public Form1()
        {
            InitializeComponent();
            GunSayisi();
            AracListesi();
            ListViewSutunEkle();
        }
        public void AracListesi()
        {
            List<Araba> arabalar = new()
            {
                 new Araba{MusaitlikDurumu=true,Marka="Opel",Model="Astra",Yil=2020,Renk = "Mavi",AracTipi=AracTipi.Sedan,GunlukUcret=1100},
                new Araba{MusaitlikDurumu=true,Marka="Toyota", Model="Corolla", Yil=2021, Renk="Beyaz", AracTipi=AracTipi.Sedan, GunlukUcret=1500},
                new Araba{MusaitlikDurumu=true,Marka="BMW", Model="X5", Yil=2019, Renk="Siyah", AracTipi=AracTipi.Suv, GunlukUcret=1800},
                new Araba{MusaitlikDurumu=true,Marka="Hyundai", Model="i20", Yil=2023, Renk="Mavi", AracTipi=AracTipi.Hatchback, GunlukUcret=1100},
                new Araba{MusaitlikDurumu=true,Marka="Opel", Model="Astra", Yil=2020, Renk="Gri", AracTipi=AracTipi.Sedan, GunlukUcret=1200},
                new Araba{MusaitlikDurumu=true,Marka="Ford", Model="Focus", Yil=2022, Renk="Kýrmýzý", AracTipi=AracTipi.Hatchback, GunlukUcret=1150},
                new Araba{MusaitlikDurumu=true,Marka="Mercedes", Model="GLC", Yil=2023, Renk="Beyaz", AracTipi=AracTipi.Suv, GunlukUcret=2000},
                new Araba{MusaitlikDurumu=true,Marka="Renault", Model="Megane", Yil=2021, Renk="Siyah", AracTipi=AracTipi.Sedan, GunlukUcret=1300},
                new Araba{MusaitlikDurumu=true,Marka="Volkswagen", Model="Golf", Yil=2022, Renk="Mavi", AracTipi=AracTipi.Hatchback, GunlukUcret=1250},
                new Araba{MusaitlikDurumu=true,Marka="Peugeot", Model="3008", Yil=2020, Renk="Gri", AracTipi=AracTipi.Suv, GunlukUcret=1600},
                new Araba{MusaitlikDurumu=true,Marka="Audi", Model="A3", Yil=2023, Renk="Beyaz", AracTipi=AracTipi.Hatchback, GunlukUcret=1400},
                new Araba{MusaitlikDurumu=true,Marka="Toyota", Model="Camry", Yil=2019, Renk="Gri", AracTipi=AracTipi.Sedan, GunlukUcret=1450},
                new Araba{MusaitlikDurumu=true,Marka="BMW", Model="X3", Yil=2021, Renk="Siyah", AracTipi=AracTipi.Suv, GunlukUcret=1700},
                new Araba{MusaitlikDurumu=true,Marka="Hyundai", Model="Elantra", Yil=2023, Renk="Mavi", AracTipi=AracTipi.Sedan, GunlukUcret=1350},
                new Araba{MusaitlikDurumu=true,Marka="Opel", Model="Corsa", Yil=2022, Renk="Kýrmýzý", AracTipi=AracTipi.Hatchback, GunlukUcret=1100},
                new Araba{MusaitlikDurumu=true,Marka="Ford", Model="Kuga", Yil=2020, Renk="Gri", AracTipi=AracTipi.Suv, GunlukUcret=1550},
                new Araba{MusaitlikDurumu=true,Marka="Mercedes", Model="C180", Yil=2021, Renk="Beyaz", AracTipi=AracTipi.Sedan, GunlukUcret=1850},
                new Araba{MusaitlikDurumu=true,Marka="Renault", Model="Clio", Yil=2023, Renk="Siyah", AracTipi=AracTipi.Hatchback, GunlukUcret=1200},
                new Araba{MusaitlikDurumu=true,Marka="Volkswagen", Model="Passat", Yil=2019, Renk="Gri", AracTipi=AracTipi.Sedan, GunlukUcret=1400},
                new Araba{MusaitlikDurumu=true,Marka="Peugeot", Model="508", Yil=2020, Renk="Mavi", AracTipi=AracTipi.Sedan, GunlukUcret=1500},
                new Araba{MusaitlikDurumu=true,Marka="Audi", Model="Q5", Yil=2021, Renk="Kýrmýzý", AracTipi=AracTipi.Suv, GunlukUcret=1900},
                new Araba{MusaitlikDurumu=true,Marka="Toyota", Model="Yaris", Yil=2023, Renk="Beyaz", AracTipi=AracTipi.Hatchback, GunlukUcret=1150},
                new Araba{MusaitlikDurumu=true,Marka="BMW", Model="3 Serisi", Yil=2022, Renk="Siyah", AracTipi=AracTipi.Sedan, GunlukUcret=1750},
                new Araba{MusaitlikDurumu=true,Marka="Hyundai", Model="Tucson", Yil=2020, Renk="Mavi", AracTipi=AracTipi.Suv, GunlukUcret=1600},
                new Araba{MusaitlikDurumu=true,Marka="Opel", Model="Grandland", Yil=2019, Renk="Gri", AracTipi=AracTipi.Suv, GunlukUcret=1550},
                new Araba{MusaitlikDurumu=true,Marka="Ford", Model="Mondeo", Yil=2021, Renk="Beyaz", AracTipi=AracTipi.Sedan, GunlukUcret=1400},
                new Araba{MusaitlikDurumu=true,Marka="Mercedes", Model="A Serisi", Yil=2023, Renk="Kýrmýzý", AracTipi=AracTipi.Hatchback, GunlukUcret=1350},
                new Araba{MusaitlikDurumu=true,Marka="Renault", Model="Talisman", Yil=2020, Renk="Mavi", AracTipi=AracTipi.Sedan, GunlukUcret=1450},
                new Araba{MusaitlikDurumu=true,Marka="Volkswagen", Model="Tiguan", Yil=2022, Renk="Siyah", AracTipi=AracTipi.Suv, GunlukUcret=1700},
                new Araba{MusaitlikDurumu=true,Marka="Peugeot", Model="208", Yil=2021, Renk="Beyaz", AracTipi=AracTipi.Hatchback, GunlukUcret=1200},
                new Araba{MusaitlikDurumu=true,Marka="Audi", Model="A4", Yil=2019, Renk="Gri", AracTipi=AracTipi.Sedan, GunlukUcret=1550},
                new Araba{MusaitlikDurumu=true,Marka="Toyota", Model="RAV4", Yil=2023, Renk="Mavi", AracTipi=AracTipi.Suv, GunlukUcret=1850},
                new Araba{MusaitlikDurumu=true,Marka="BMW", Model="1 Serisi", Yil=2022, Renk="Siyah", AracTipi=AracTipi.Hatchback, GunlukUcret=1300},
                new Araba{MusaitlikDurumu=true,Marka="Hyundai", Model="i30", Yil=2021, Renk="Beyaz", AracTipi=AracTipi.Hatchback, GunlukUcret=1250},
                new Araba{MusaitlikDurumu=true,Marka="Opel", Model="Insignia", Yil=2020, Renk="Kýrmýzý", AracTipi=AracTipi.Sedan, GunlukUcret=1600},
                new Araba{MusaitlikDurumu=true,Marka="Ford", Model="Edge", Yil=2019, Renk="Mavi", AracTipi=AracTipi.Suv, GunlukUcret=1750},
                new Araba{MusaitlikDurumu=true,Marka="Mercedes", Model="GLB", Yil=2023, Renk="Gri", AracTipi=AracTipi.Suv, GunlukUcret=2000},
                new Araba{MusaitlikDurumu=true,Marka="Renault", Model="Kadjar", Yil=2022, Renk="Beyaz", AracTipi=AracTipi.Suv, GunlukUcret=1650},
                new Araba{MusaitlikDurumu=true,Marka="Volkswagen", Model="Arteon", Yil=2021, Renk="Siyah", AracTipi=AracTipi.Sedan, GunlukUcret=1700},
                new Araba{MusaitlikDurumu=true,Marka="Peugeot", Model="2008", Yil=2020, Renk="Kýrmýzý", AracTipi=AracTipi.Hatchback, GunlukUcret=1200},
            };

            foreach (Araba araba in arabalar)
            {
                cmbAraclar.Items.Add(araba);
            }

        }
        public void GunSayisi()
        {
            for (int i = 1; i <= 60; i++)
            {
                cmbGunSayisi.Items.Add(i);
            }
        }
        public void ListViewSutunEkle()
        {
            lvAracListesi.View = View.Details;
            lvAracListesi.GridLines = true;

            lvAracListesi.Columns.Add("ID", 30, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Marka", 70, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Model", 70, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Renk", 70, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Araç Tipi", 80, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Gün", 40, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Yýl", 40, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Günlük Ücret", 100, HorizontalAlignment.Center);
            lvAracListesi.Columns.Add("Toplam Ücret", 80, HorizontalAlignment.Center);
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if(cmbAraclar.Items==null)
            {
                MessageBox.Show("Lütfen Araç Seçiniz","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if(cmbGunSayisi.Items==null)
            {
                MessageBox.Show("Gün Sayýsýný Seçiniz","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int gunSayisi = Convert.ToInt32(cmbGunSayisi.SelectedItem);
            Araba arac = cmbAraclar.SelectedItem as Araba;
            KiralamaBilgisi kiralamaBilgisi = new KiralamaBilgisi()
            {
                Arac = arac,
                GunSayisi = gunSayisi
            };
            kiralamaBilgisi.UcretHesapla();
            
            if (arac.MusaitlikDurumu==true)
            {
                ListViewItem listViewItem = new ListViewItem();

                listViewItem.Text = (++id).ToString();
                listViewItem.SubItems.Add(arac.Marka.ToString());
                listViewItem.SubItems.Add(arac.Model.ToString());
                listViewItem.SubItems.Add(arac.Renk.ToString());
                listViewItem.SubItems.Add(arac.AracTipi.ToString());
                listViewItem.SubItems.Add(cmbGunSayisi.Text.ToString());
                listViewItem.SubItems.Add(arac.Yil.ToString());
                listViewItem.SubItems.Add(arac.GunlukUcret.ToString());
                listViewItem.SubItems.Add(kiralamaBilgisi.Arac.ToplamUcret.ToString());
                lvAracListesi.Items.Add(listViewItem);

                


                arac.MusaitlikDurumu = false;
                MessageBox.Show("Ýþlem Baþarýyla Tamamlanmýþtýr","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu Araç Kiralanmýþtýr","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
