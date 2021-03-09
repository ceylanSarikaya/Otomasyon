using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class FrmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        //GridControl run disnerdan colum eklemesi yapıldı devexpres özelliklerinden olan simplebutton,LableKontrol,GroupControl...gibi eklemeler yapılmıştır.
        Fonksiyonlar.DataBaseDataContext Db = new Fonksiyonlar.DataBaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;
        public FrmStokGruplari()
        {
            InitializeComponent();
        }

        private void FrmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_StokGruplaris
                      select s;
            Liste.DataSource = lst;
          
        }
        void Temizle()
        {
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            Edit = false;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_StokGruplari Grup = new Fonksiyonlar.Tbl_StokGruplari();
                Grup.GrupKodu = txtGrupKodu.Text;
                Grup.GurupAdi = txtGrupAdi.Text;
                Grup.GrupSaveDate = DateTime.Now;
                Grup.GrupSaveUser = AnaForm.UserId;
                Db.Tbl_StokGruplaris.InsertOnSubmit(Grup);
                Db.SubmitChanges();
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
                Fonksiyonlar.Tbl_StokGruplari Grup = Db.Tbl_StokGruplaris.First(s => s.Id == SecimID);
                Grup.GurupAdi = txtGrupAdi.Text;
                Grup.GrupKodu = txtGrupKodu.Text;
                Grup.GrupSaveDate = DateTime.Now;
                Grup.GrupSaveUser = AnaForm.UserId;
                Db.Tbl_StokGruplaris.InsertOnSubmit(Grup);
                Db.SubmitChanges();
                Temizle();
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
                Db.Tbl_StokGruplaris.DeleteOnSubmit(Db.Tbl_StokGruplaris.First(s => s.Id == SecimID));
                Db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
      
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();
        }
         void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GurupAdi").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GrupKodu").ToString();
            }
            catch (Exception )
            {
                Edit = false;
                SecimID = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}