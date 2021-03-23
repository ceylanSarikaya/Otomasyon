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
    public partial class FrmKasaDevri : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();


        bool Edit = false;
        int KasaId = -1;
        int SecimId = -1;


        public FrmKasaDevri()
        {
            InitializeComponent();
        }

        private void FrmKasaDevri_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAcıklama.Text = "";
            txtMakbuzNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit = false;
            KasaId = -1;
            SecimId = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri hareketler = new Fonksiyonlar.Tbl_KasaHareketleri();
                hareketler.Aciklama = txtAcıklama.Text;
                hareketler.BelgeNo = txtMakbuzNo.Text;
                hareketler.EvrakTuru = "Kasa Devri karti";
              if(rbtCikisIslemi.Checked)  hareketler.GCKodu = "C";
                if (rbtGirisIslemi.Checked) hareketler.GCKodu = "G";
                hareketler.Tarih = DateTime.Parse(txtTarih.Text);
                hareketler.Tutar = decimal.Parse(txtTarih.Text);
                hareketler.SaveDate = DateTime.Now;
                hareketler.SaveUser = AnaForm.UserId;
                dataContext.Tbl_KasaHareketleris.InsertOnSubmit(hareketler);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit("Devir kayıt işlemi gercekleşmiştir");
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
                Fonksiyonlar.Tbl_KasaHareketleri hareketler = dataContext.Tbl_KasaHareketleris.First(s => s.Id == SecimId);
                hareketler.Aciklama = txtAcıklama.Text;
                hareketler.BelgeNo = txtMakbuzNo.Text;
                hareketler.EvrakTuru = "Kasa Devri karti";
                if (rbtCikisIslemi.Checked) hareketler.GCKodu = "C";
                if (rbtGirisIslemi.Checked) hareketler.GCKodu = "G";
                hareketler.Tarih = DateTime.Parse(txtTarih.Text);
                hareketler.Tutar = decimal.Parse(txtTarih.Text);
                hareketler.EditDate = DateTime.Now;
                hareketler.EditUser = AnaForm.UserId;
            
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
                dataContext.Tbl_KasaHareketleris.DeleteOnSubmit(dataContext.Tbl_KasaHareketleris.First(d => d.Id == SecimId));
                dataContext.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
        void KasaAc(int Id)
        {
            try
            {
                KasaId = Id;
                txtKasaAdi.Text = dataContext.TBL_Kasalars.First(s => s.Id == KasaId).KasaAdi;
                txtKasaKodu.Text = dataContext.TBL_Kasalars.First(s => s.Id == KasaId).KasaKodu;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Ac(int Id)
        {
            try
            {
                SecimId = Id;
                Edit = true;
                Fonksiyonlar.Tbl_KasaHareketleri hareketler = dataContext.Tbl_KasaHareketleris.First(s => s.Id == SecimId);
                txtAcıklama.Text = hareketler.Aciklama;
                txtMakbuzNo.Text = hareketler.BelgeNo;
                KasaAc(hareketler.KasaId.Value);
                txtTarih.Text = hareketler.Tarih.Value.ToShortDateString();
                txtTutar.Text = hareketler.Tutar.Value.ToString();
                if (hareketler.GCKodu == "C") rbtCikisIslemi.Checked = true;
                if (hareketler.GCKodu == "G") rbtGirisIslemi.Checked = true;
              
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimId > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimId > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.KasaListesi(true);
            if (Id>0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtMakbuzNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}