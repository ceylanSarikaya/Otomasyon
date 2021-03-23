using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_kasa
{
    public partial class FrmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        bool Edit = false;
        int SecimId = -1;
        public FrmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void txtHesapNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasakodu.Text = numaralar.KasaKodNumarasi();
            Listele();
        }
        void Temizle()
        {
            txtKasakodu.Text = numaralar.KasaKodNumarasi();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimId = -1;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Kasalar kasalar = new Fonksiyonlar.TBL_Kasalar();
                kasalar.Aciklama = txtAciklama.Text;
                kasalar.KasaAdi = txtKasaAdi.Text;
                kasalar.KasaKodu = txtKasakodu.Text;
                kasalar.SaveDate = DateTime.Now;
                kasalar.SaveUser = AnaForm.UserId;
                dataContext.TBL_Kasalars.InsertOnSubmit(kasalar);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit("YENİ KASA KAYDI OLUSTURULDU");
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_Kasalar kasalar = dataContext.TBL_Kasalars.First(s => s.Id == SecimId);
                kasalar.Aciklama = txtAciklama.Text;
                kasalar.KasaAdi = txtKasaAdi.Text;
                kasalar.KasaKodu = txtKasakodu.Text;
                kasalar.EditDate = DateTime.Now;
                kasalar.EditUser = AnaForm.UserId;
                dataContext.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                dataContext.TBL_Kasalars.DeleteOnSubmit(dataContext.TBL_Kasalars.First(s => s.Id == SecimId));
                dataContext.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimId= int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtKasakodu.Text = gridView1.GetFocusedRowCellValue("KasaKodu").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KasaAdi").ToString();
                txtAciklama.Text= gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Listele()
        {
            var listele = from s in dataContext.TBL_Kasalars
                          select s;
            gridControl1.DataSource = listele;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaAdi.Text != null && txtAciklama.Text != null)
            {
                if (Edit && SecimId > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                else YeniKaydet();
            }
            else MessageBox.Show("Kasa adı ve acıklama girilmesi gereklidir");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimId > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}