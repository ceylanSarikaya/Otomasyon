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

namespace Otomasyon.Modul_Banka
{
    public partial class FrmParaTransferi : DevExpress.XtraEditors.XtraForm
    {
        string IslemTuru = "Banka Havalesi ";

        public FrmParaTransferi()
        {
            InitializeComponent();
        }

        private void txtTaransferTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTaransferTuru.SelectedIndex==0)
            {
                rbtGelen.Text = "Gelen Havale";
                rbtGiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if (txtTaransferTuru.SelectedIndex == 1)
            {
                rbtGelen.Text = "Gelen EFT";
                rbtGiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";
            }
        }

        private void FrmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
    }
}