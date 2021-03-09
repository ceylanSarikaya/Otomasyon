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

namespace Otomasyon.Modul_Stok
{
    public partial class FrmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        //groupControl1,textEdit1,labelControl1,simpleButton1,pictureBox1

        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimler resimler = new Fonksiyonlar.Resimler();

        bool Edit = false;
        bool Resim = false;
        int GrupId = -1;
        int StokId = -1;
        OpenFileDialog Dosya = new OpenFileDialog();
        public FrmStokKarti()
        {
            InitializeComponent();
        }

        private void FrmStokKarti_Load(object sender, EventArgs e)
        {
         txtStokKodu.Text= numaralar.KodNumarasi();
        }

        void Temizle()
        {
            txtStokKodu.Text = numaralar.KodNumarasi();
            txtStokAdi.Text = "";
            txtSatisKDV.Text = "0";
            txtSatisFiyat.Text = "0";
            txtBarkod.Text = "";
            txtAlisFiyat.Text = "0";
            txtAlisKDV.Text = "0";
            txtGrupkod.Text = "";
            txtGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            pictureBox1.Image = null;
            Edit = false;
            Resim = false;
            GrupId = -1;
            StokId = -1;
            AnaForm.Aktarma = -1; //Burayı sureklı -1 tutmalıyız yoksa başka yerde çakısabılır.

        }
        void ResimSec()
        {
            Dosya.Filter = "Jpg(*.jpg)| *.jpg| Jpeg(*.jpeg)| *.jpeg";
            if (Dosya.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        void YeniKaydet()
        {
            try
            {

                Fonksiyonlar.Tbl_Stok stok = new Fonksiyonlar.Tbl_Stok();
                stok.StokAdi = txtStokAdi.Text;
                stok.StokAlisFiyati = decimal.Parse(txtAlisFiyat.Text);
                stok.StokAlisKdv = decimal.Parse(txtAlisKDV.Text);
                stok.StokSatiFiyati = decimal.Parse(txtSatisFiyat.Text);
                stok.StokSatisKdv = decimal.Parse(txtSatisKDV.Text);
                stok.StokKodu = txtStokKodu.Text;
                stok.StokBirim = txtBirim.Text;
                stok.StokResim = new System.Data.Linq.Binary(resimler.ResimYukleme(pictureBox1.Image)); //binary seklinde paketleyip dataya gönderir.
                stok.StokGrupId = GrupId;

                stok.StokSaveDate = DateTime.Now;
                stok.StokSaveUser = AnaForm.UserId;
                dataContext.Tbl_Stoks.InsertOnSubmit(stok);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit("Yeni Stok Kaydı Oluşturuldu");
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

                Fonksiyonlar.Tbl_Stok stok = dataContext.Tbl_Stoks.First(s => s.Id == StokId);
                stok.StokAdi = txtStokAdi.Text;
                stok.StokAlisFiyati = decimal.Parse(txtAlisFiyat.Text);
                stok.StokAlisKdv = decimal.Parse(txtAlisKDV.Text);
                stok.StokSatiFiyati = decimal.Parse(txtSatisFiyat.Text);
                stok.StokSatisKdv = decimal.Parse(txtSatisKDV.Text);
                stok.StokKodu = txtStokKodu.Text;
                stok.StokBirim = txtBirim.Text;
                if(Resim)stok.StokResim = new System.Data.Linq.Binary(resimler.ResimYukleme(pictureBox1.Image)); //binary seklinde paketleyip dataya gönderir.
                stok.StokGrupId = GrupId;

                stok.StokEditDate = DateTime.Now;
                stok.StokEditUser = AnaForm.UserId;
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
                dataContext.Tbl_Stoks.DeleteOnSubmit(dataContext.Tbl_Stoks.First(s => s.Id == StokId));
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void GrupAc(int Id)
        {
            GrupId = Id ;
            txtGrupAdi.Text = dataContext.Tbl_StokGruplaris.First(s => s.Id == GrupId).GurupAdi;
            txtGrupkod.Text = dataContext.Tbl_StokGruplaris.First(s => s.Id == GrupId).GrupKodu;
        }

        public void  Ac(int Id)
        {
            Edit = true;
            StokId = Id;
            Fonksiyonlar.Tbl_Stok stok = dataContext.Tbl_Stoks.First(s => s.Id == StokId);
            GrupAc(stok.StokGrupId.Value);
            pictureBox1.Image = resimler.ResimGetirme(stok.StokResim.ToArray());
            txtAlisFiyat.Text = stok.StokAlisFiyati.ToString();
            txtAlisKDV.Text = stok.StokAlisKdv.ToString();
            txtSatisFiyat.Text = stok.StokSatiFiyati.ToString();
            txtSatisKDV.Text = stok.StokSatisKdv.ToString();
            txtStokKodu.Text = stok.StokKodu;
            txtBirim.Text = stok.StokBirim;
            txtStokAdi.Text = stok.StokAdi;
            txtBarkod.Text = stok.StokBarkod;
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.StokListesi(true);
            if (Id>0)
            {
                Ac(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtGrupkod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.StokGruplari(true);
            if (Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokId > 0 && mesajlar.Sil() == DialogResult.Yes)
                Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokId > 0 && mesajlar.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }
    }
}