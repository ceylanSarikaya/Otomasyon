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
    public partial class FrmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        int IslemId = -1;
        string IslemTuru = "Kasa Tahsilat";
        public FrmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemTuru = txtIslemTuru.SelectedItem.ToString();
        }
    }
}