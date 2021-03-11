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
    public partial class FrmCariGruplar : DevExpress.XtraEditors.XtraForm
    {
        //try hata blogudur try icindeki dogru ise true yanlış ıse false donder catch bloguna gec orda true donerse hata mesajı ver false başka bir hata ver.
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        public bool Secim = false;
        bool Edit = false;
        int SecimId = -1;
        public FrmCariGruplar()
        {
            InitializeComponent();
       
        }
        void YeniKaydet()
        {
            try
            {

                Fonksiyonlar.Tbl_CariGuruplari guruplari = new Fonksiyonlar.Tbl_CariGuruplari();
                guruplari.GrupAdi = txtGrupAdi.Text;
                guruplari.GrupKodu = txtGrupKodu.Text;
                guruplari.SaveDate = DateTime.Now;
                guruplari.EditDate = DateTime.Now;
                guruplari.SaveUser = AnaForm.UserId;
                dataContext.Tbl_CariGuruplaris.InsertOnSubmit(guruplari);
                dataContext.SubmitChanges();
                mesajlar.YeniKayit("Yeni cari grup kaydı oluşturuldu");
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
               

                Fonksiyonlar.Tbl_CariGuruplari guruplari = dataContext.Tbl_CariGuruplaris.First(s => s.Id == SecimId);
                guruplari.GrupAdi = txtGrupAdi.Text;
                guruplari.GrupKodu = txtGrupKodu.Text;
                guruplari.EditDate = DateTime.Now;
                guruplari.EditUser = AnaForm.UserId;
                dataContext.SubmitChanges();
                mesajlar.Guncelle(true);
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
                SecimId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GrupAdi").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GrupKodu").ToString();

            }
            catch (Exception)
            {
                Edit = false;
                SecimId = -1;
            }
        }
        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimId = -1;
            Listele();
        }
        void Listele()
        {
            var lst = from s in dataContext.Tbl_CariGuruplaris
                      select s;
            Liste.DataSource = lst;
        }
        void Sil()
        {
            try
            {
                dataContext.Tbl_CariGuruplaris.DeleteOnSubmit(dataContext.Tbl_CariGuruplaris.First(s => s.Id == SecimId));
                dataContext.SubmitChanges();
                Temizle();
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
            if (Edit && SecimId > 0 && mesajlar.Sil() == DialogResult.Yes) Sil() ;
          
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariGruplar_Load(object sender, EventArgs e)
        {
            Listele(); 
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimId >0)
            {
                AnaForm.Aktarma = SecimId;
                this.Close();
            }
        }
    }
}