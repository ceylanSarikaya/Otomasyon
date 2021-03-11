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
    public partial class FrmCariListeler : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DataBaseDataContext dataContext = new Fonksiyonlar.DataBaseDataContext();
        public bool Secim = false;
         int SecimId = -1;
        public FrmCariListeler()
        {
            InitializeComponent();
        }

        private void FrmCariListeler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var liste = from s in dataContext.TBL_Carilers
                        where s.CariAdi.Contains(txtCariAdi.Text) && s.CariKodu.Contains(txtCariKodu.Text)
                        select s;
            gridControl1.DataSource = liste;
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
    }
}