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

        }
    }
}