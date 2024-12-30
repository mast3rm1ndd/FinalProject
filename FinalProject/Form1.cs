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
                        MessageBox.Show("S�n�f�n kontenjan� dolmu�. ��renci kaydedilemez.");
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

                        MessageBox.Show("��renci ba�ar�yla kaydedildi.");
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
                    MessageBox.Show("��renci bulunamad�.");
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
                    MessageBox.Show("��renci ba�ar�yla g�ncellendi.");
                }
                else
                {
                    MessageBox.Show("��renci bulunamad�.");
                }
            }
        }

        private void btnDersSecim_Click(object sender, EventArgs e) // butona t�kland��� an formu a�mak yerine bul i�in null kontrol� yapt�m. bu ba�lamda yaz�lan numaraya ait bir ��renci yoksa ders se�im ekran� a��lmayacak.
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
                    MessageBox.Show("��renci bulunamad�.");
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
