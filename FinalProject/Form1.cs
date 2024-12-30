using System.Net.Http.Headers;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var ctx = new OdevContext())
            {
                int sinifID = Convert.ToInt32(sinifsecCombo.SelectedValue);

                var sinif = ctx.tblSiniflar.FirstOrDefault(s => s.SinifID == sinifID);

                if (sinif != null)
                {
                    int ogrenciSayisi = ctx.Ogrenciler.Count(o => o.SinifID == sinifID);

                    if (ogrenciSayisi >= sinif.Kontenjan)
                    {
                        MessageBox.Show("Sýnýfýn kontenjaný dolmuþ. Öðrenci kaydedilemez.");
                    }
                    else
                    {
                        var ogrenci = new Ogrenciler
                        {
                            Ad = txtAd.Text,
                            Soyad = txtSoyad.Text,
                            Numara = txtNumara.Text,
                            SinifID = sinifID
                        };

                        ctx.Ogrenciler.Add(ogrenci);
                        ctx.SaveChanges(); 

                        MessageBox.Show("Öðrenci baþarýyla kaydedildi.");
                    }
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string numara = txtNumara.Text;
            using (var ctx = new OdevContext())
            {
                var ogrenci = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == numara);

                if (ogrenci != null)
                {
                    txtAd.Text = ogrenci.Ad;
                    txtSoyad.Text = ogrenci.Soyad;
                    txtNumara.Text = ogrenci.Numara;
                }
                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string numara = txtNumara.Text;
            using (var ctx = new OdevContext())
            {
                var ogrenci = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == numara);

                if (ogrenci != null)
                {
                    ogrenci.Ad = txtAd.Text;
                    ogrenci.Soyad = txtSoyad.Text;

                    ctx.SaveChanges();
                    MessageBox.Show("Öðrenci baþarýyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
                }
            }
        }

        private void btnDersSecim_Click(object sender, EventArgs e) // butona týklandýðý an formu açmak yerine bul için null kontrolü yaptým. bu baðlamda yazýlan numaraya ait bir öðrenci yoksa ders seçim ekraný açýlmayacak.
        {
            string numara = txtNumara.Text;
            using (var ctx = new OdevContext())
            {
                var ogrenci = ctx.Ogrenciler.FirstOrDefault(o => o.Numara == numara);

                if (ogrenci != null)
                {
                    DersForm dersForm = new DersForm(ogrenci);
                    dersForm.Show();
                }
                else
                {
                    MessageBox.Show("Öðrenci bulunamadý.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var ctx = new OdevContext())
            {
                var siniflar = ctx.tblSiniflar.ToList();

                sinifsecCombo.DataSource = siniflar; 
                sinifsecCombo.DisplayMember = "SinifAd";  // SinifAd alanini combobox'ta gostermek istiyorum, alt satirda da value olarak secilen sinifin ID'sini veriyorum.
                sinifsecCombo.ValueMember = "SinifID";   
            }
        }
    }
}
