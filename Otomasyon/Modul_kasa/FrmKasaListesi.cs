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
    public partial class FrmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        int SecimId = -1;

        public bool Secim = false;
        public FrmKasaListesi()
        {
            InitializeComponent();
        }

        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in dataContext.TBL_Kasalars
                      where s.KasaKodu.Contains(txtKasaKodu.Text) && s.KasaAdi.Contains(txtKasaAdi.Text)
                      select s;
         
            gridControl1.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                SecimId = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                SecimId = -1;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimId >0)
            {
                AnaForm.Aktarma = SecimId;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

        }
    }
}