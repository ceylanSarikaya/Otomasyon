using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        public static int UserId = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barBtnStokKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokKarti();
        }

        private void barbtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokListesi();
        }

        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.StokHareketleri();
        }

        private void btnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariAcilisKarti();
        }

        private void btnCariGruplar_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariGruplari();
        }

        private void btnCariListeler_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.CariListesi();
        }

        private void btnCariHareketler_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaKarti();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasaListesi();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasAc();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            formlar.KasTahsilatOdemeKarti();
        }
    }
}