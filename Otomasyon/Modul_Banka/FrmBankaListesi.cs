﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Banka
{
    public partial class FrmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        int SecimId = -1;
        public FrmBankaListesi()
        {
            InitializeComponent();
        }

        private void FrmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {

        }
    }
}