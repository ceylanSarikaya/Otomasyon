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

namespace Otomasyon.Modul_Cari
{
    public partial class FrmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        public FrmCariAcilisKarti()
        {
            InitializeComponent();
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}