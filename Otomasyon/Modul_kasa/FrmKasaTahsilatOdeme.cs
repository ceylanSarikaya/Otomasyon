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
    public partial class FrmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int IslemId = -1;
        int KasaId = -1;
        int CariId = -1;
        int CariHareketId = -1;
    
        public FrmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void FrmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            txtAcıklama.Text = "";
            txtMakbuzNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemId = -1;
            KasaId = -1;
            CariHareketId = -1;
            CariId = -1;
            AnaForm.Aktarma = -1;
        }
        public void Ac(int HareketId)
        {
            try
            {
                Edit = true;
                IslemId = HareketId;
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = dataContext.Tbl_KasaHareketleris.First(s => s.Id == IslemId);
                CariHareketId = dataContext.Tbl_CariHareketleris.First(s => s.EvrakTuru == kasaHareketleri.EvrakTuru && s.EvrakId == IslemId).Id;
                MessageBox.Show("Cari Hareket Id : " + CariHareketId.ToString());
                txtAcıklama.Text = kasaHareketleri.Aciklama;
                txtMakbuzNo.Text = kasaHareketleri.BelgeNo;
                if (kasaHareketleri.EvrakTuru == "Kasa Tahsilat") txtIslemTuru.SelectedIndex = 0;
                if (kasaHareketleri.EvrakTuru == "Kasa Odeme ") txtIslemTuru.SelectedIndex = 0;
                txtTarih.Text = kasaHareketleri.Tarih.Value.ToShortDateString();
                txtTutar.Text = kasaHareketleri.Tutar.Value.ToString();
                KasaAc(kasaHareketleri.KasaId.Value);
                CariAc(kasaHareketleri.CariId.Value);
            }
            catch (Exception e)
            {
                Temizle();
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
                KasaId = -1;
            }
        }

        void CariAc(int Id)
        {
            try
            {
                CariId = Id;
                txtCariAdi.Text = dataContext.TBL_Carilers.First(s => s.Id == KasaId).CariAdi;
                txtCariKodu.Text = dataContext.TBL_Carilers.First(s => s.Id == KasaId).CariKodu;
            }
            catch (Exception)
            {
               CariId= -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = new Fonksiyonlar.Tbl_KasaHareketleri();
                kasaHareketleri.Aciklama = txtAcıklama.Text;
                kasaHareketleri.BelgeNo = txtMakbuzNo.Text;
                kasaHareketleri.CariId = CariId;
                kasaHareketleri.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex==0) kasaHareketleri.GCKodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) kasaHareketleri.GCKodu = "C";
                kasaHareketleri.KasaId = KasaId;
                kasaHareketleri.SaveDate = DateTime.Now;
                kasaHareketleri.SaveUser = AnaForm.UserId;
                kasaHareketleri.Tarih = DateTime.Parse(txtTarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(txtTutar.Text);
                dataContext.Tbl_KasaHareketleris.InsertOnSubmit(kasaHareketleri);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit(txtIslemTuru.SelectedText + " Yeni kasa ıslem hareketi");
                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = new Fonksiyonlar.Tbl_CariHareketleri();
                cariHareketleri.Acıklama = txtMakbuzNo.Text + "belge numaralı " + txtIslemTuru.SelectedText.ToString()+"Islemi";
                if (txtIslemTuru.SelectedIndex == 0) cariHareketleri.Alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) cariHareketleri.Borc= decimal.Parse(txtTutar.Text);
                cariHareketleri.CariId = CariId;
                cariHareketleri.EvrakId = kasaHareketleri.Id;
                cariHareketleri.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) cariHareketleri.Tipi= "KT";
                if (txtIslemTuru.SelectedIndex == 1) cariHareketleri.Tipi = "Kö";
                cariHareketleri.SaveDate = DateTime.Now;
                cariHareketleri.SaveUser = AnaForm.UserId;
                dataContext.Tbl_CariHareketleris.InsertOnSubmit(cariHareketleri);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit(txtIslemTuru.SelectedText + " Yeni Cari ıslem hareketi");
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
                Fonksiyonlar.Tbl_KasaHareketleri kasaHareketleri = dataContext.Tbl_KasaHareketleris.First(s => s.Id == IslemId);
                //kasa hareketi olaraka aldıgımız işlem ıdmiz.
               
                kasaHareketleri.Aciklama = txtAcıklama.Text;
                kasaHareketleri.BelgeNo = txtMakbuzNo.Text;
                kasaHareketleri.CariId = CariId;
                kasaHareketleri.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) kasaHareketleri.GCKodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) kasaHareketleri.GCKodu = "C";
                kasaHareketleri.KasaId = KasaId;
                kasaHareketleri.EditDate = DateTime.Now;
                kasaHareketleri.EditUser = AnaForm.UserId;
                kasaHareketleri.Tarih = DateTime.Parse(txtTarih.Text);
                kasaHareketleri.Tutar = decimal.Parse(txtTutar.Text);
                dataContext.SubmitChanges();
                mesajlar.Guncelle(true);
                Fonksiyonlar.Tbl_CariHareketleri cariHareketleri = dataContext.Tbl_CariHareketleris.First(s => s.Id == CariHareketId);
                cariHareketleri.Acıklama = txtMakbuzNo.Text + "belge numaralı " + txtIslemTuru.SelectedText.ToString() + "Islemi";
                if (txtIslemTuru.SelectedIndex == 0) cariHareketleri.Alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) cariHareketleri.Borc = decimal.Parse(txtTutar.Text);
                cariHareketleri.CariId = CariId;
                cariHareketleri.EvrakId = kasaHareketleri.Id;
                cariHareketleri.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                cariHareketleri.Tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) cariHareketleri.Tipi = "KT";
                if (txtIslemTuru.SelectedIndex == 1) cariHareketleri.Tipi = "Kö";
                cariHareketleri.EditDate = DateTime.Now;
                cariHareketleri.EditUser = AnaForm.UserId;
                Temizle();
              
                dataContext.SubmitChanges();
                mesajlar.Guncelle(true);
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
                dataContext.Tbl_KasaHareketleris.DeleteOnSubmit(dataContext.Tbl_KasaHareketleris.First(s => s.Id == IslemId));
                dataContext.Tbl_CariHareketleris.DeleteOnSubmit(dataContext.Tbl_CariHareketleris.First(s => s.Id == CariHareketId));
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemId > 0 && CariHareketId > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemId > 0 && CariHareketId>0 && mesajlar.Sil() == DialogResult.Yes) Sil();
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

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.CariListesi(true);
            if (Id > 0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}