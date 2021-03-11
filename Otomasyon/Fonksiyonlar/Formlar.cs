﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    class Formlar
    {
        public int StokListesi(bool Secim=false)
        {
            Modul_Stok.FrmStokListesi frm = new Modul_Stok.FrmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
           return AnaForm.Aktarma;
        }
        public int StokGruplari(bool Secim = false)
        {
            Modul_Stok.FrmStokGruplari frm = new Modul_Stok.FrmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public void StokHareketleri(bool Ac = false)
        {

        }
        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.FrmStokKarti frm = new Modul_Stok.FrmStokKarti();
            frm.ShowDialog();
        }

        public int CariGruplari(bool Secim = false)
        {
            Modul_Cari.FrmCariGruplar frm = new Modul_Cari.FrmCariGruplar();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public int CariListesi(bool Secim = false)
        {
            Modul_Cari.FrmCariListeler frm = new Modul_Cari.FrmCariListeler();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void CariAcilisKarti(bool Ac = false, int CarId = -1)
        {
            Modul_Cari.FrmCariAcilisKarti frm = new Modul_Cari.FrmCariAcilisKarti();
            if (Ac) frm.Ac(CarId);
            frm.ShowDialog();
        }
    }
}
