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
    public partial class FrmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        //xtraTabPage1.textedit,gridControl bunları Doct kısmında sayfaya sabitlendi
        //buradaki secim yanlış olarak dönderecek
        Fonksiyonlar.DataBaseDataContext Db = new Fonksiyonlar.DataBaseDataContext();
        public bool Secim = false;
        int SecimId = -1;
       
        public FrmStokListesi()
        {
            InitializeComponent();
        }

        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            Listele();
            //Metot oluşturup burda çağırdık
        }
        void Listele()
        {
            var lst = from s in Db.Tbl_Stoks
                      where s.StokAdi.Contains(txtStokAdi.Text) && s.StokBarkod.Contains(txtBarkod.Text)&&s.StokKodu.Contains(txtStokKodu.Text)
                      select s;
            gridControl1.DataSource = lst;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            txtBarkod.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
        }
        void Sec()
        {
            try
            {
                SecimId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimId = -1;
            }
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

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}