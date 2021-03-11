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

namespace Otomasyon.Modul_Cari
{
    public partial class FrmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        bool Edit = false;
        int CariId = -1;
        int GrupId = -1;
        public FrmCariAcilisKarti()
        {
            InitializeComponent();
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariGrupKodu.Text = numaralar.CariKodNumarasi();
        }

        void Temizle()
        {
            foreach (Control item in groupControl1.Controls)
                if (item is DevExpress.XtraEditors.TextEdit || item is DevExpress.XtraEditors.ButtonEdit) item.Text = "";
            foreach (Control item in groupControl2.Controls)
                if (item is DevExpress.XtraEditors.TextEdit || item is DevExpress.XtraEditors.ButtonEdit || item is DevExpress.XtraEditors.MemoEdit) item.Text = "";
            txtCariKodu.Text = numaralar.CariKodNumarasi();
            Edit = false;
            CariId = -1;
            GrupId = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_Cariler cariler = new Fonksiyonlar.TBL_Cariler();
                cariler.Adres = txtAdres.Text;
                cariler.CariAdi = txtCariAdi.Text;
                cariler.CariKodu = txtCariKodu.Text;
                cariler.Fax1 = txtFax1.Text;
                cariler.Fax2 = txtFax2.Text;
                cariler.GrupId = GrupId;
                cariler.Ilce = txtIlce.Text;
                cariler.MailInfo = txtMailInfo.Text;
                cariler.Sehir = txtSehir.Text;
                cariler.Telefon1 = txtTelefon1.Text;
                cariler.Telefon2 = txtTelefon2.Text;
                cariler.Ulke = txtUlke.Text;
                cariler.VergiDairesi = txtVergiDairesi.Text;
                cariler.VergiNo = txtVergiNo.Text;
                cariler.WebAdresi = txtWebAdresi.Text;
                cariler.Yetkili = txtYetkili1.Text;
                cariler.Yetkili1 = txtYetkili2.Text;
                cariler.YetkiliEmail = txtYetkiliEmail.Text;
                cariler.YetkiliMail = txtYetkiliMail.Text;
                cariler.SaveDate = DateTime.Now;
                cariler.SaveUser = AnaForm.UserId;
                dataContext.TBL_Carilers.InsertOnSubmit(cariler);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit("Yeni cari kaydı oluşturuldu");
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
                Fonksiyonlar.TBL_Cariler cariler = dataContext.TBL_Carilers.First(s => s.Id == CariId);
                cariler.Adres = txtAdres.Text;
                cariler.CariAdi = txtCariAdi.Text;
                cariler.CariKodu = txtCariKodu.Text;
                cariler.Fax1 = txtFax1.Text;
                cariler.Fax2 = txtFax2.Text;
                cariler.GrupId = GrupId;
                cariler.Ilce = txtIlce.Text;
                cariler.MailInfo = txtMailInfo.Text;
                cariler.Sehir = txtSehir.Text;
                cariler.Telefon1 = txtTelefon1.Text;
                cariler.Telefon2 = txtTelefon2.Text;
                cariler.Ulke = txtUlke.Text;
                cariler.VergiDairesi = txtVergiDairesi.Text;
                cariler.VergiNo = txtVergiNo.Text;
                cariler.WebAdresi = txtWebAdresi.Text;
                cariler.Yetkili = txtYetkili1.Text;
                cariler.Yetkili1 = txtYetkili2.Text;
                cariler.YetkiliEmail = txtYetkiliEmail.Text;
                cariler.YetkiliMail = txtYetkiliMail.Text;
                cariler.EditDate = DateTime.Now;
                cariler.EditUser = AnaForm.UserId;
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
                dataContext.TBL_Carilers.DeleteOnSubmit(dataContext.TBL_Carilers.First(s => s.Id == CariId));
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        public void Ac(int Id )
        {
            try
            {
                Edit = true;
                CariId = Id;
                Fonksiyonlar.TBL_Cariler cariler = dataContext.TBL_Carilers.First(s => s.Id == CariId);
                txtAdres.Text = cariler.Adres;
                txtCariAdi.Text = cariler.CariAdi;
                txtCariKodu.Text = cariler.CariKodu;
                txtFax1.Text = cariler.Fax1;
                txtFax2.Text = cariler.Fax2;
                txtIlce.Text = cariler.Ilce;
                txtMailInfo.Text = cariler.MailInfo;
                txtSehir.Text = cariler.Sehir;
                txtTelefon1.Text = cariler.Telefon1;
                txtTelefon2.Text = cariler.Telefon2;
                txtUlke.Text = cariler.Ulke;
                txtVergiDairesi.Text = cariler.VergiDairesi;
                txtVergiNo.Text = cariler.VergiNo;
                txtWebAdresi.Text = cariler.VergiNo;
                txtYetkili1.Text = cariler.Yetkili;
                txtYetkili2.Text = cariler.Yetkili1;
                txtYetkiliEmail.Text = cariler.YetkiliEmail;
                txtYetkiliMail.Text = cariler.YetkiliMail;
                GrupAc(cariler.GrupId.Value);

            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
       void GrupAc(int Id)
        {
            try
            {
                GrupId = Id;
                Fonksiyonlar.Tbl_CariGuruplari gruplar = dataContext.Tbl_CariGuruplaris.First(s => s.Id == GrupId);
                txtCariGrupAdi.Text = gruplar.GrupAdi;
                txtCariGrupKodu.Text = gruplar.GrupKodu;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariId > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariId > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtCariGrupAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.CariGruplari(true);
            if (Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.CariListesi(true);
            if (Id >0)
            {
                Ac(Id);
            }
            AnaForm.Aktarma = -1;
        }
    }
}