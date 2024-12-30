using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DersForm : Form
    {
        private Ogrenciler ogrenci; 
        public DersForm(Ogrenciler ogr)
        {
            InitializeComponent();
            ogrenci = ogr;
        }
        private void DersForm_Load(object sender, EventArgs e)
        {
            ogrBilgiLabel.Text = $"Ad: {ogrenci.Ad} Soyad: {ogrenci.Soyad} Numara: {ogrenci.Numara}";

            using (var ctx = new OdevContext())
            {
                var dersler = ctx.tblDersler.ToList(); 
                dataGridView1.DataSource = dersler; // dersleri datagrid'e baglama sekansi 
                dataGridView1.Columns["DersID"].Visible = false; 
                dataGridView1.Columns["tblOgrenciDers"].Visible = false;
                dataGridView1.Columns["DersAd"].HeaderText = "Dersin Adı";
                dataGridView1.Columns["DersKod"].HeaderText = "Dersin Kodu";
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.AllowUserToResizeRows = false;
                dataGridView1.AllowUserToResizeColumns = false;

                var ogrenciDersler = ctx.tblOgrenciDers
                                    .Where(od => od.OgrenciID == ogrenci.OgrenciID)
                                    .Include(od => od.Ders) 
                                    .ToList();

                if (ogrenciDersler.Any())
                {
                    var derslerMetni = "Aldığı dersler: ";
                    derslerMetni += string.Join(", ", ogrenciDersler.Select(od => $"{od.Ders.DersAd} ({od.Ders.DersKod})"));
                    aDersLabel.Text = derslerMetni;
                }
                else
                { 
                    aDersLabel.Text = "Bu öğrenci hiçbir ders almamıştır.";
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (var ctx = new OdevContext())
            {
                try
                {
                    var selectedRows = dataGridView1.SelectedRows; // secilen satirlarin id'sini aliyoruz

                    if (selectedRows.Count == 0)
                    {
                        MessageBox.Show("Lütfen en az bir ders seçin.");
                        return; 
                    }

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        int dersId = (int)row.Cells["DersID"].Value; 

                        // ogrenci ders relation'u icin
                        var ogrenciDers = new tblOgrenciDers
                        {
                            OgrenciID = ogrenci.OgrenciID,
                            DersID = dersId // secili dersin ID'si
                        };

                        ctx.tblOgrenciDers.Add(ogrenciDers);
                    }

                    ctx.SaveChanges();
                    MessageBox.Show("Seçilen dersler başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
